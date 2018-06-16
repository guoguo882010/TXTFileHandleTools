namespace TXTFileHandleTools
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectMergeSourceFilesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectMergeTargetFileButton = new System.Windows.Forms.Button();
            this.MergeTargetFileTextBox = new System.Windows.Forms.TextBox();
            this.MergeLabel = new System.Windows.Forms.Label();
            this.MergeFileButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DupTargetFileButton = new System.Windows.Forms.Button();
            this.DupSourceFileButton = new System.Windows.Forms.Button();
            this.DupButton = new System.Windows.Forms.Button();
            this.DupTargetFileTextBox = new System.Windows.Forms.TextBox();
            this.DupSourceFileTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitAppButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DomainTargetButton = new System.Windows.Forms.Button();
            this.DomainSourceTextBox = new System.Windows.Forms.TextBox();
            this.DomainSourceButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DomainButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DomainTargetTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectMergeSourceFilesButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectMergeTargetFileButton);
            this.groupBox1.Controls.Add(this.MergeTargetFileTextBox);
            this.groupBox1.Controls.Add(this.MergeLabel);
            this.groupBox1.Controls.Add(this.MergeFileButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "　合并文件　";
            // 
            // SelectMergeSourceFilesButton
            // 
            this.SelectMergeSourceFilesButton.Location = new System.Drawing.Point(111, 60);
            this.SelectMergeSourceFilesButton.Name = "SelectMergeSourceFilesButton";
            this.SelectMergeSourceFilesButton.Size = new System.Drawing.Size(141, 23);
            this.SelectMergeSourceFilesButton.TabIndex = 6;
            this.SelectMergeSourceFilesButton.Text = "选择需要合并的文件";
            this.SelectMergeSourceFilesButton.UseVisualStyleBackColor = true;
            this.SelectMergeSourceFilesButton.Click += new System.EventHandler(this.SelectMergeSourceFilesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择目标文件：";
            // 
            // SelectMergeTargetFileButton
            // 
            this.SelectMergeTargetFileButton.Location = new System.Drawing.Point(515, 28);
            this.SelectMergeTargetFileButton.Name = "SelectMergeTargetFileButton";
            this.SelectMergeTargetFileButton.Size = new System.Drawing.Size(30, 23);
            this.SelectMergeTargetFileButton.TabIndex = 5;
            this.SelectMergeTargetFileButton.Text = ">>";
            this.SelectMergeTargetFileButton.UseVisualStyleBackColor = true;
            this.SelectMergeTargetFileButton.Click += new System.EventHandler(this.SelectMergeTargetFileButton_Click);
            // 
            // MergeTargetFileTextBox
            // 
            this.MergeTargetFileTextBox.Location = new System.Drawing.Point(111, 28);
            this.MergeTargetFileTextBox.Name = "MergeTargetFileTextBox";
            this.MergeTargetFileTextBox.Size = new System.Drawing.Size(398, 21);
            this.MergeTargetFileTextBox.TabIndex = 4;
            this.MergeTargetFileTextBox.TextChanged += new System.EventHandler(this.MergeTargetFileTextBox_TextChanged);
            // 
            // MergeLabel
            // 
            this.MergeLabel.AutoSize = true;
            this.MergeLabel.Location = new System.Drawing.Point(312, 65);
            this.MergeLabel.Name = "MergeLabel";
            this.MergeLabel.Size = new System.Drawing.Size(89, 12);
            this.MergeLabel.TabIndex = 3;
            this.MergeLabel.Text = "0 个文件被选择";
            // 
            // MergeFileButton
            // 
            this.MergeFileButton.Location = new System.Drawing.Point(470, 60);
            this.MergeFileButton.Name = "MergeFileButton";
            this.MergeFileButton.Size = new System.Drawing.Size(75, 23);
            this.MergeFileButton.TabIndex = 2;
            this.MergeFileButton.Text = "合并文件";
            this.MergeFileButton.UseVisualStyleBackColor = true;
            this.MergeFileButton.Click += new System.EventHandler(this.MergeFileButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DupTargetFileButton);
            this.groupBox2.Controls.Add(this.DupSourceFileButton);
            this.groupBox2.Controls.Add(this.DupButton);
            this.groupBox2.Controls.Add(this.DupTargetFileTextBox);
            this.groupBox2.Controls.Add(this.DupSourceFileTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "　移除重复　";
            // 
            // DupTargetFileButton
            // 
            this.DupTargetFileButton.Location = new System.Drawing.Point(515, 43);
            this.DupTargetFileButton.Name = "DupTargetFileButton";
            this.DupTargetFileButton.Size = new System.Drawing.Size(30, 23);
            this.DupTargetFileButton.TabIndex = 9;
            this.DupTargetFileButton.Text = ">>";
            this.DupTargetFileButton.UseVisualStyleBackColor = true;
            this.DupTargetFileButton.Click += new System.EventHandler(this.DupTargetFileButton_Click);
            // 
            // DupSourceFileButton
            // 
            this.DupSourceFileButton.Location = new System.Drawing.Point(515, 18);
            this.DupSourceFileButton.Name = "DupSourceFileButton";
            this.DupSourceFileButton.Size = new System.Drawing.Size(30, 23);
            this.DupSourceFileButton.TabIndex = 6;
            this.DupSourceFileButton.Text = ">>";
            this.DupSourceFileButton.UseVisualStyleBackColor = true;
            this.DupSourceFileButton.Click += new System.EventHandler(this.DupSourceFileButton_Click);
            // 
            // DupButton
            // 
            this.DupButton.Location = new System.Drawing.Point(470, 72);
            this.DupButton.Name = "DupButton";
            this.DupButton.Size = new System.Drawing.Size(75, 23);
            this.DupButton.TabIndex = 8;
            this.DupButton.Text = "移除重复";
            this.DupButton.UseVisualStyleBackColor = true;
            this.DupButton.Click += new System.EventHandler(this.DupButton_Click);
            // 
            // DupTargetFileTextBox
            // 
            this.DupTargetFileTextBox.Location = new System.Drawing.Point(111, 45);
            this.DupTargetFileTextBox.Name = "DupTargetFileTextBox";
            this.DupTargetFileTextBox.Size = new System.Drawing.Size(398, 21);
            this.DupTargetFileTextBox.TabIndex = 7;
            this.DupTargetFileTextBox.TextChanged += new System.EventHandler(this.DupTargetFileTextBox_TextChanged);
            // 
            // DupSourceFileTextBox
            // 
            this.DupSourceFileTextBox.Location = new System.Drawing.Point(111, 18);
            this.DupSourceFileTextBox.Name = "DupSourceFileTextBox";
            this.DupSourceFileTextBox.Size = new System.Drawing.Size(398, 21);
            this.DupSourceFileTextBox.TabIndex = 6;
            this.DupSourceFileTextBox.TextChanged += new System.EventHandler(this.DupSourceFileTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "选择目标文件：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "选择源文件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "作者：guoguo882010@hotmail.com";
            // 
            // ExitAppButton
            // 
            this.ExitAppButton.Location = new System.Drawing.Point(497, 338);
            this.ExitAppButton.Name = "ExitAppButton";
            this.ExitAppButton.Size = new System.Drawing.Size(75, 23);
            this.ExitAppButton.TabIndex = 3;
            this.ExitAppButton.Text = "退出程序";
            this.ExitAppButton.UseVisualStyleBackColor = true;
            this.ExitAppButton.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DomainTargetButton);
            this.groupBox3.Controls.Add(this.DomainSourceTextBox);
            this.groupBox3.Controls.Add(this.DomainSourceButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.DomainButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DomainTargetTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "　提取网址中的域名　";
            // 
            // DomainTargetButton
            // 
            this.DomainTargetButton.Location = new System.Drawing.Point(515, 43);
            this.DomainTargetButton.Name = "DomainTargetButton";
            this.DomainTargetButton.Size = new System.Drawing.Size(30, 23);
            this.DomainTargetButton.TabIndex = 16;
            this.DomainTargetButton.Text = ">>";
            this.DomainTargetButton.UseVisualStyleBackColor = true;
            this.DomainTargetButton.Click += new System.EventHandler(this.DomainTargetButton_Click);
            // 
            // DomainSourceTextBox
            // 
            this.DomainSourceTextBox.Location = new System.Drawing.Point(111, 18);
            this.DomainSourceTextBox.Name = "DomainSourceTextBox";
            this.DomainSourceTextBox.Size = new System.Drawing.Size(398, 21);
            this.DomainSourceTextBox.TabIndex = 13;
            this.DomainSourceTextBox.TextChanged += new System.EventHandler(this.DomainSourceTextBox_TextChanged);
            // 
            // DomainSourceButton
            // 
            this.DomainSourceButton.Location = new System.Drawing.Point(515, 18);
            this.DomainSourceButton.Name = "DomainSourceButton";
            this.DomainSourceButton.Size = new System.Drawing.Size(30, 23);
            this.DomainSourceButton.TabIndex = 12;
            this.DomainSourceButton.Text = ">>";
            this.DomainSourceButton.UseVisualStyleBackColor = true;
            this.DomainSourceButton.Click += new System.EventHandler(this.DomainSourceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "选择源文件：";
            // 
            // DomainButton
            // 
            this.DomainButton.Location = new System.Drawing.Point(470, 72);
            this.DomainButton.Name = "DomainButton";
            this.DomainButton.Size = new System.Drawing.Size(75, 23);
            this.DomainButton.TabIndex = 15;
            this.DomainButton.Text = "提取域名";
            this.DomainButton.UseVisualStyleBackColor = true;
            this.DomainButton.Click += new System.EventHandler(this.DomainButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "选择目标文件：";
            // 
            // DomainTargetTextBox
            // 
            this.DomainTargetTextBox.Location = new System.Drawing.Point(111, 45);
            this.DomainTargetTextBox.Name = "DomainTargetTextBox";
            this.DomainTargetTextBox.Size = new System.Drawing.Size(398, 21);
            this.DomainTargetTextBox.TabIndex = 14;
            this.DomainTargetTextBox.TextChanged += new System.EventHandler(this.DomainTargetTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ExitAppButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TXT文件处理程序";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MergeFileButton;
        private System.Windows.Forms.Label MergeLabel;
        private System.Windows.Forms.Button SelectMergeTargetFileButton;
        private System.Windows.Forms.TextBox MergeTargetFileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitAppButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DupTargetFileTextBox;
        private System.Windows.Forms.TextBox DupSourceFileTextBox;
        private System.Windows.Forms.Button DupButton;
        private System.Windows.Forms.Button DupTargetFileButton;
        private System.Windows.Forms.Button DupSourceFileButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DomainTargetButton;
        private System.Windows.Forms.TextBox DomainSourceTextBox;
        private System.Windows.Forms.Button DomainSourceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DomainButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DomainTargetTextBox;
        private System.Windows.Forms.Button SelectMergeSourceFilesButton;
    }
}

