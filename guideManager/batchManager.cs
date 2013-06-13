using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace guideManager
{
    public partial class batchManager : Form
    {
        private dataManager dm = dataManager.getThis();
        private int type = 0;
        public batchManager()
        {
            InitializeComponent();
        }

        private void rbt_all_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_all.Checked) type = 0;
            else if (rbt_tasktracking.Checked) type = 1;
            else if (rbt_npctalk.Checked) type = 2;
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            if (txt_str.Text.Length < 1)
            {
                MessageBox.Show("替换内容不能为空");
                return;
            }
            string str = "";
            if (type == 0) str = "确定对所有配置进行替换？";
            else if (type == 1) str = "确定对所有任务追踪配置进行替换？";
            else str = "确定对所有任务对话配置进行替换？";
            if (MessageBox.Show(str, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            int count = 0;
            Dictionary<string, string> gl = new Dictionary<string, string>();//临时字典
            foreach (KeyValuePair<string, string> l in dm.gList)
            {
                if (type == 0)
                {
                    gl[l.Key] = dm.gList[l.Key].Replace(txt_str.Text,txt_replace.Text);
                }
                else if (type == 1)
                {
                    if (l.Value.IndexOf("<windowName>taskTracking</windowName>") != -1)
                    {
                        gl[l.Key] = dm.gList[l.Key].Replace(txt_str.Text, txt_replace.Text);
                    }
                }
                else
                {
                    if (l.Value.IndexOf("<objValue>task</objValue>")!=-1&&l.Value.IndexOf("<windowName>taskTracking</windowName>") == -1)
                    {
                        gl[l.Key] = dm.gList[l.Key].Replace(txt_str.Text, txt_replace.Text);
                    }
                }
            }
            foreach (KeyValuePair<string, string> m in gl)
            {
                dm.gList[m.Key] = m.Value;
                count++;
            }
            MessageBox.Show("替换完毕，共替换 "+count.ToString()+" 项");
        }
    }
}
