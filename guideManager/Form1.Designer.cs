namespace guideManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.cbb_itemList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.cbb_showType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_showBatch = new System.Windows.Forms.Button();
            this.pl_help = new System.Windows.Forms.Panel();
            this.btn_closeHelp = new System.Windows.Forms.Button();
            this.txt_helpContent = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pl_help.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(53, 4);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(562, 21);
            this.txt_path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "路径：";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(620, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "载 入";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // cbb_itemList
            // 
            this.cbb_itemList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_itemList.FormattingEnabled = true;
            this.cbb_itemList.Location = new System.Drawing.Point(133, 29);
            this.cbb_itemList.Name = "cbb_itemList";
            this.cbb_itemList.Size = new System.Drawing.Size(481, 24);
            this.cbb_itemList.TabIndex = 3;
            this.cbb_itemList.SelectedIndexChanged += new System.EventHandler(this.cbb_itemList_SelectedIndexChanged);
            this.cbb_itemList.SelectionChangeCommitted += new System.EventHandler(this.cbb_itemList_SelectionChangeCommitted);
            this.cbb_itemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbb_itemList_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID：";
            // 
            // btn_showAll
            // 
            this.btn_showAll.Location = new System.Drawing.Point(620, 30);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(75, 23);
            this.btn_showAll.TabIndex = 5;
            this.btn_showAll.Text = "显示全部";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Visible = false;
            this.btn_showAll.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // txt_content
            // 
            this.txt_content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_content.Location = new System.Drawing.Point(9, 79);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_content.Size = new System.Drawing.Size(1165, 647);
            this.txt_content.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "内容：";
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.Location = new System.Drawing.Point(1128, 2);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(46, 23);
            this.btn_help.TabIndex = 9;
            this.btn_help.Text = "帮助";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.Location = new System.Drawing.Point(9, 733);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "保  存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_saveFile.Location = new System.Drawing.Point(91, 733);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(75, 23);
            this.btn_saveFile.TabIndex = 12;
            this.btn_saveFile.Text = "保存到文件";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Visible = false;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(54, 54);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 13;
            this.btn_next.Text = "下一步引导";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Visible = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // cbb_showType
            // 
            this.cbb_showType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_showType.FormattingEnabled = true;
            this.cbb_showType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cbb_showType.Items.AddRange(new object[] {
            "ID",
            "说明"});
            this.cbb_showType.Location = new System.Drawing.Point(53, 29);
            this.cbb_showType.Name = "cbb_showType";
            this.cbb_showType.Size = new System.Drawing.Size(75, 24);
            this.cbb_showType.TabIndex = 15;
            this.cbb_showType.Text = "ID";
            this.cbb_showType.SelectedIndexChanged += new System.EventHandler(this.cbb_showType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(136, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "注意：所有修改最后都必需点击保存到文件后才生效。";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(989, 743);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "技术支持：QQ412035160 by Phhui";
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_del.Location = new System.Drawing.Point(172, 733);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 18;
            this.btn_del.Text = "删  除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Visible = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_showBatch
            // 
            this.btn_showBatch.Location = new System.Drawing.Point(703, 29);
            this.btn_showBatch.Name = "btn_showBatch";
            this.btn_showBatch.Size = new System.Drawing.Size(75, 23);
            this.btn_showBatch.TabIndex = 19;
            this.btn_showBatch.Text = "批量管理";
            this.btn_showBatch.UseVisualStyleBackColor = true;
            this.btn_showBatch.Visible = false;
            this.btn_showBatch.Click += new System.EventHandler(this.btn_showBatch_Click);
            // 
            // pl_help
            // 
            this.pl_help.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pl_help.Controls.Add(this.btn_closeHelp);
            this.pl_help.Controls.Add(this.txt_helpContent);
            this.pl_help.Location = new System.Drawing.Point(2, 2);
            this.pl_help.Name = "pl_help";
            this.pl_help.Size = new System.Drawing.Size(1181, 759);
            this.pl_help.TabIndex = 21;
            this.pl_help.Visible = false;
            // 
            // btn_closeHelp
            // 
            this.btn_closeHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_closeHelp.Location = new System.Drawing.Point(1133, 3);
            this.btn_closeHelp.Name = "btn_closeHelp";
            this.btn_closeHelp.Size = new System.Drawing.Size(41, 23);
            this.btn_closeHelp.TabIndex = 1;
            this.btn_closeHelp.Text = "关闭";
            this.btn_closeHelp.UseVisualStyleBackColor = true;
            this.btn_closeHelp.Click += new System.EventHandler(this.btn_closeHelp_Click_1);
            // 
            // txt_helpContent
            // 
            this.txt_helpContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_helpContent.Location = new System.Drawing.Point(11, 28);
            this.txt_helpContent.Multiline = true;
            this.txt_helpContent.Name = "txt_helpContent";
            this.txt_helpContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_helpContent.Size = new System.Drawing.Size(1161, 720);
            this.txt_helpContent.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Location = new System.Drawing.Point(1129, 54);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 23);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(1026, 55);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 21);
            this.txt_search.TabIndex = 26;
            this.txt_search.Visible = false;
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.pl_help);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_showBatch);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_showType);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_saveFile);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_itemList);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新手引导管理器--by Phhui";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pl_help.ResumeLayout(false);
            this.pl_help.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ComboBox cbb_itemList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_saveFile;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ComboBox cbb_showType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_showBatch;
        private System.Windows.Forms.Panel pl_help;
        private System.Windows.Forms.Button btn_closeHelp;
        private System.Windows.Forms.TextBox txt_helpContent;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}

