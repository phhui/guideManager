using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace guideManager
{
    public partial class txtEdit : Form
    {
        private dataManager dm = dataManager.getThis();
        private string ct = "";
        public txtEdit()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(dm.path, txt_content.Text);
            MessageBox.Show("保存成功~");
        }

        private void txtEdit_Load(object sender, EventArgs e)
        {
            txt_content.Text = File.ReadAllText(dm.path);
            ct = txt_content.Text;
        }

        private void txtEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ct != txt_content.Text)
            {
                if (MessageBox.Show("数据有修改，且未保存，确定要关闭窗口？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dm.fm.IsDisposed) dm.fm = new Form1();
            dm.fm.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (ct != txt_content.Text)
            {
                if (MessageBox.Show("数据有修改，且未保存，确定要关闭窗口？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                {
                    return;
                }
            }
            if (dm.fm.IsDisposed) dm.fm = new Form1();
            dm.fm.Show();
            this.Close();
        }

        private void txtEdit_Resize(object sender, EventArgs e)
        {
            txt_content.Width = this.Width - 20;
            txt_content.Height = this.Height - 70;
        }
    }
}
