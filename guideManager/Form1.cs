using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Collections;

namespace guideManager
{
    public partial class Form1 : Form
    {
        private Boolean isEdit = false;
        private batchManager bm = new batchManager();
        private txtEdit te = new txtEdit();
        private dataManager dm = dataManager.getThis();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(txt_path.Text);
            }
            catch (Exception err)
            {
                txt_content.Text = err.Message.ToString();
                MessageBox.Show("XML格式错误：" + err.Message.ToString());
                return;
            }
            dm.resetData();
            XmlNode xn = xmlDoc.SelectSingleNode("RECORDS");
            XmlNodeList xnl = xn.ChildNodes;
            int l=1;
            foreach (XmlNode xnf in xnl)
            {
                if (xnf.NodeType == XmlNodeType.Element)
                {
                    XmlElement xe = (XmlElement)xnf;
                    string id = xe.SelectSingleNode("id").InnerText.ToString();
                    dm.idList.Add(id);
                    string val = xe.OuterXml;
                    //val = val.Replace("<info>","<info>"+id.ToString()+"-引导"+l.ToString()+"-");
                    string info = xe.SelectSingleNode("info").InnerText.ToString();
                    dm.infoList.Add(info);
                    if (dm.gList.ContainsKey(id)) dm.gList[id] = val;
                    else dm.gList.Add(id, val);
                    if (dm.xmlList.ContainsKey(id)) dm.xmlList[id] = xe;
                    else dm.xmlList.Add(id, xe);
                    if (dm.iList.ContainsKey(info)) dm.iList[info] = xe;
                    else dm.iList.Add(info, xe);
                    l++;
                }
            }
            cbb_itemList.DataSource = dm.idList;
            txt_content.Text = "加载完毕，共" + dm.gList.Count.ToString() + "个引导";
            File.WriteAllText("url.txt", txt_path.Text);
            dm.path = txt_path.Text;
            btn_showBatch.Visible = true;
            btn_save.Visible = true;
            btn_saveFile.Visible = true;
            btn_del.Visible = true;
            btn_showAll.Visible = true;
            btn_search.Visible = true;
            txt_search.Visible = true;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (checkContent())
            {
                if (MessageBox.Show("当前配置内容有修改，但未保存，确定不保存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }
            }
            if (te.IsDisposed) te = new txtEdit();
            te.Show();
            bm.Close();
            this.Hide();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            if (File.Exists("help.txt"))
            {
                txt_helpContent.Text = File.ReadAllText("help.txt");
            }
            else
            {
                txt_helpContent.Text = "help.txt不存在";
            }
            pl_help.Visible = true;
        }

        private void btn_closeHelp_Click(object sender, EventArgs e)
        {
            pl_help.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dm.gList[dm.currentId] = txt_content.Text.Replace("\r\n", "");
            isEdit = true;
            MessageBox.Show("保存成功~~");
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("该操作会将原有文件内容替换，确定替换？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            string s = "<?xml version='1.0' encoding='utf-8' ?>\r\n<RECORDS>\r\n";
            foreach (KeyValuePair<string, string> l in dm.gList)
            {
                s += l.Value;
            }
            s = s.Replace("<id", "\r\n    <id");
            s = s.Replace("<type", "\r\n    <type");
            s = s.Replace("<info", "\r\n    <info");
            s = s.Replace("<value", "\r\n    <value");
            s = s.Replace("<objType", "\r\n    <objType");
            s = s.Replace("<objValue", "\r\n    <objValue");
            s = s.Replace("<windowName", "\r\n    <windowName");
            s = s.Replace("<needWindow", "\r\n    <needWindow");
            s = s.Replace("<align", "\r\n    <align");
            s = s.Replace("<instant", "\r\n    <instant");
            s = s.Replace("<closeObj", "\r\n    <closeObj");
            s = s.Replace("<content", "\r\n    <content");
            s = s.Replace("<mask", "\r\n        <mask");
            s = s.Replace("<resources", "\r\n        <resources");
            s = s.Replace("<layer", "\r\n        <layer");
            s = s.Replace("<simpleButton", "\r\n        <simpleButton");
            s = s.Replace("<loading", "\r\n    <loading");
            s = s.Replace("<nextId", "\r\n    <nextId");
            s = s.Replace("</RECORD><RECORD>", "</RECORD>\r\n\r\n<RECORD>");
            s = s.Replace("</RECORD>", "\r\n</RECORD>");
            s = s.Replace("</layer>", "\r\n        </layer>");
            s = s.Replace("</content>", "\r\n    </content>");
            s = s.Replace("<textArea", "\r\n        <textArea");
            s += "</RECORDS>";
            File.WriteAllText(txt_path.Text,s);
            isEdit = false;
        }

        private void cbb_showType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_showType.SelectedItem.ToString() == "ID")
            {
                cbb_itemList.DataSource = dm.idList;
            }
            else
            {
                cbb_itemList.DataSource = dm.infoList;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEdit)
            {
                if(MessageBox.Show("有数据修改后未保存到文件中，确定要关闭窗口？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)!=DialogResult.OK){
                    e.Cancel= true;
                }
            }
        }
        private Boolean checkContent()
        {
            if (txt_content.Text.Length < 20) return false;
            if (dm.currentId.Length < 1) return false;
            if (dm.gList.ContainsKey(dm.currentId))
            {
                if (txt_content.Text.Replace("><", ">\r\n<") != dm.gList[dm.currentId].Replace("><", ">\r\n<"))
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (dm.xmlList[dm.currentId].SelectSingleNode("nextId") == null) return;
            if (dm.xmlList[dm.currentId].SelectSingleNode("nextId").InnerText != null)
            {
                if (checkContent())
                {
                    if (MessageBox.Show("当前配置内容有修改，但未保存，确定不保存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    {
                        return;
                    }
                }
                string key = dm.xmlList[dm.currentId].SelectSingleNode("nextId").InnerText;
                if (dm.gList.ContainsKey(key))
                {
                    dm.currentId = key;
                    txt_content.Text = dm.gList[key].Replace("><", ">\r\n<");
                    cbb_itemList.Text = key;
                }
                else
                {
                    txt_content.Text = "没有找到该引导:" + key;
                }
                showNext();
            }
        }
        private void showItem()
        {
            if (cbb_itemList.Text.Length < 1) return;
            if (dm.idList.Count < 1)
            {
                MessageBox.Show("数据未导入");
                return;
            }
            if (checkContent())
            {
                if (MessageBox.Show("当前配置内容有修改，但未保存，确定不保存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }
            }
            string key = cbb_itemList.Text;
            if (dm.gList.ContainsKey(key))
            {
                dm.currentId = key;
                txt_content.Text = dm.gList[key].Replace("><", ">\r\n<");
            }
            else if (dm.iList.ContainsKey(key))
            {
                dm.currentId = dm.iList[key].SelectSingleNode("id").InnerText;
                txt_content.Text = dm.iList[key].OuterXml.Replace("><", ">\r\n<");
            }
            else
            {
                txt_content.Text = "没有找到该引导";
            }
            showNext();
        }
        private void showNext()
        {
            if (txt_content.Text.IndexOf("<nextId>") != -1)
            {
                btn_next.Visible = true;
            }
            else
            {
                btn_next.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("url.txt"))
            {
                txt_path.Text = File.ReadAllText("url.txt");
                dm.path = txt_path.Text;
            }
            dm.fm = this;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除该条引导配置？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            dm.gList.Remove(dm.currentId);
            MessageBox.Show("删除成功");
        }

        private void btn_showBatch_Click(object sender, EventArgs e)
        {
            if (bm.IsDisposed) bm = new batchManager();
            bm.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            txt_content.Width = this.Width-40;
            txt_content.Height = this.Height - 150;
            pl_help.Width = this.Width - 20;
            pl_help.Height = this.Height - 40;
            txt_helpContent.Width = pl_help.Width - 20;
            txt_helpContent.Height = pl_help.Height - 50;
        }

        private void btn_closeHelp_Click_1(object sender, EventArgs e)
        {
            pl_help.Visible = false;
        }

        private void cbb_itemList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //showItem();
        }
        //下拉框输入后回车
        private void cbb_itemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                showItem();
            }
        }

        private void cbb_itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            showItem();
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            searchItem();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            searchItem();
        }
        private void searchItem()
        {
            if (txt_search.Text.Length < 1) return;
            int n = 0;
            string val = "";
            foreach (KeyValuePair<string, string> l in dm.gList)
            {
                if (l.Value.IndexOf(txt_search.Text) != -1)
                {

                    if (n == 0)
                    {
                        cbb_itemList.Text = l.Key;
                        showItem();
                    }
                    val += l.Key + ",";
                    n++;
                }
            }
            if (n == 0)
            {
                MessageBox.Show("没有搜索到包含 " + txt_search.Text + " 的配置");
                return;
            }
            MessageBox.Show("搜索完毕，共搜索到 " + n.ToString() + " 项,当前显示第1项。包含该值的配置有" + val);
        }
    }
}
