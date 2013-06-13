namespace guideManager
{
    partial class batchManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(batchManager));
            this.rbt_tasktracking = new System.Windows.Forms.RadioButton();
            this.rbt_npctalk = new System.Windows.Forms.RadioButton();
            this.rbt_all = new System.Windows.Forms.RadioButton();
            this.txt_str = new System.Windows.Forms.TextBox();
            this.txt_replace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_replace = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbt_tasktracking
            // 
            this.rbt_tasktracking.AutoSize = true;
            this.rbt_tasktracking.Location = new System.Drawing.Point(66, 11);
            this.rbt_tasktracking.Name = "rbt_tasktracking";
            this.rbt_tasktracking.Size = new System.Drawing.Size(71, 16);
            this.rbt_tasktracking.TabIndex = 1;
            this.rbt_tasktracking.Text = "任务追踪";
            this.rbt_tasktracking.UseVisualStyleBackColor = true;
            this.rbt_tasktracking.CheckedChanged += new System.EventHandler(this.rbt_all_CheckedChanged);
            // 
            // rbt_npctalk
            // 
            this.rbt_npctalk.AutoSize = true;
            this.rbt_npctalk.Location = new System.Drawing.Point(143, 11);
            this.rbt_npctalk.Name = "rbt_npctalk";
            this.rbt_npctalk.Size = new System.Drawing.Size(65, 16);
            this.rbt_npctalk.TabIndex = 2;
            this.rbt_npctalk.Text = "NPC对话";
            this.rbt_npctalk.UseVisualStyleBackColor = true;
            this.rbt_npctalk.CheckedChanged += new System.EventHandler(this.rbt_all_CheckedChanged);
            // 
            // rbt_all
            // 
            this.rbt_all.AutoSize = true;
            this.rbt_all.Checked = true;
            this.rbt_all.Location = new System.Drawing.Point(13, 11);
            this.rbt_all.Name = "rbt_all";
            this.rbt_all.Size = new System.Drawing.Size(47, 16);
            this.rbt_all.TabIndex = 0;
            this.rbt_all.TabStop = true;
            this.rbt_all.Text = "全部";
            this.rbt_all.UseVisualStyleBackColor = true;
            this.rbt_all.CheckedChanged += new System.EventHandler(this.rbt_all_CheckedChanged);
            // 
            // txt_str
            // 
            this.txt_str.Location = new System.Drawing.Point(13, 34);
            this.txt_str.Multiline = true;
            this.txt_str.Name = "txt_str";
            this.txt_str.Size = new System.Drawing.Size(200, 50);
            this.txt_str.TabIndex = 3;
            // 
            // txt_replace
            // 
            this.txt_replace.Location = new System.Drawing.Point(267, 34);
            this.txt_replace.Multiline = true;
            this.txt_replace.Name = "txt_replace";
            this.txt_replace.Size = new System.Drawing.Size(200, 50);
            this.txt_replace.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "替换为";
            // 
            // btn_replace
            // 
            this.btn_replace.Location = new System.Drawing.Point(473, 47);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(59, 23);
            this.btn_replace.TabIndex = 6;
            this.btn_replace.Text = "替  换";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(217, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "注意：批量替换很容易出错，替换后请到主界面核对正确后再保存到文件中才生效。";
            // 
            // batchManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_replace);
            this.Controls.Add(this.txt_str);
            this.Controls.Add(this.rbt_all);
            this.Controls.Add(this.rbt_npctalk);
            this.Controls.Add(this.rbt_tasktracking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "batchManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "批量管理--by Phhui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_tasktracking;
        private System.Windows.Forms.RadioButton rbt_npctalk;
        private System.Windows.Forms.TextBox txt_str;
        private System.Windows.Forms.TextBox txt_replace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_replace;
        public System.Windows.Forms.RadioButton rbt_all;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label2;
    }
}