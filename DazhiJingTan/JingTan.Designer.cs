namespace DazhiJingTan
{
    partial class JingTan
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
            this.stDataGridView = new System.Windows.Forms.DataGridView();
            this.settingGroupbox = new System.Windows.Forms.GroupBox();
            this.fileGroupbox = new System.Windows.Forms.GroupBox();
            this.importFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.projectNumberText = new System.Windows.Forms.TextBox();
            this.holeNumberText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.probeNumberText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.testDateText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.coneSquareText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCoffiText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stDataGridView)).BeginInit();
            this.settingGroupbox.SuspendLayout();
            this.fileGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stDataGridView
            // 
            this.stDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stDataGridView.Location = new System.Drawing.Point(12, 20);
            this.stDataGridView.Name = "stDataGridView";
            this.stDataGridView.RowTemplate.Height = 27;
            this.stDataGridView.Size = new System.Drawing.Size(570, 723);
            this.stDataGridView.TabIndex = 0;
            this.stDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.stDataGridView_CellValueChanged);
            // 
            // settingGroupbox
            // 
            this.settingGroupbox.Controls.Add(this.label8);
            this.settingGroupbox.Controls.Add(this.label7);
            this.settingGroupbox.Controls.Add(this.labelCoffiText);
            this.settingGroupbox.Controls.Add(this.label6);
            this.settingGroupbox.Controls.Add(this.coneSquareText);
            this.settingGroupbox.Controls.Add(this.label5);
            this.settingGroupbox.Controls.Add(this.testDateText);
            this.settingGroupbox.Controls.Add(this.label4);
            this.settingGroupbox.Controls.Add(this.probeNumberText);
            this.settingGroupbox.Controls.Add(this.label3);
            this.settingGroupbox.Controls.Add(this.holeNumberText);
            this.settingGroupbox.Controls.Add(this.label2);
            this.settingGroupbox.Controls.Add(this.projectNumberText);
            this.settingGroupbox.Controls.Add(this.label1);
            this.settingGroupbox.Location = new System.Drawing.Point(606, 467);
            this.settingGroupbox.Name = "settingGroupbox";
            this.settingGroupbox.Size = new System.Drawing.Size(248, 259);
            this.settingGroupbox.TabIndex = 1;
            this.settingGroupbox.TabStop = false;
            this.settingGroupbox.Text = "设置项";
            // 
            // fileGroupbox
            // 
            this.fileGroupbox.Controls.Add(this.saveFileBtn);
            this.fileGroupbox.Controls.Add(this.importFileBtn);
            this.fileGroupbox.Location = new System.Drawing.Point(606, 238);
            this.fileGroupbox.Name = "fileGroupbox";
            this.fileGroupbox.Size = new System.Drawing.Size(241, 214);
            this.fileGroupbox.TabIndex = 2;
            this.fileGroupbox.TabStop = false;
            this.fileGroupbox.Text = "文件操作项";
            // 
            // importFileBtn
            // 
            this.importFileBtn.Location = new System.Drawing.Point(36, 24);
            this.importFileBtn.Name = "importFileBtn";
            this.importFileBtn.Size = new System.Drawing.Size(167, 41);
            this.importFileBtn.TabIndex = 0;
            this.importFileBtn.Text = "导入文件";
            this.importFileBtn.UseVisualStyleBackColor = true;
            this.importFileBtn.Click += new System.EventHandler(this.importFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目编号：";
            // 
            // projectNumberText
            // 
            this.projectNumberText.Location = new System.Drawing.Point(108, 25);
            this.projectNumberText.Name = "projectNumberText";
            this.projectNumberText.Size = new System.Drawing.Size(100, 25);
            this.projectNumberText.TabIndex = 1;
            this.projectNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // holeNumberText
            // 
            this.holeNumberText.Location = new System.Drawing.Point(108, 63);
            this.holeNumberText.Name = "holeNumberText";
            this.holeNumberText.Size = new System.Drawing.Size(100, 25);
            this.holeNumberText.TabIndex = 3;
            this.holeNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "孔号：";
            // 
            // probeNumberText
            // 
            this.probeNumberText.Location = new System.Drawing.Point(108, 102);
            this.probeNumberText.Name = "probeNumberText";
            this.probeNumberText.Size = new System.Drawing.Size(100, 25);
            this.probeNumberText.TabIndex = 5;
            this.probeNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "探头编号：";
            // 
            // testDateText
            // 
            this.testDateText.Location = new System.Drawing.Point(108, 140);
            this.testDateText.Name = "testDateText";
            this.testDateText.Size = new System.Drawing.Size(100, 25);
            this.testDateText.TabIndex = 7;
            this.testDateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "测试日期：";
            // 
            // coneSquareText
            // 
            this.coneSquareText.Location = new System.Drawing.Point(108, 180);
            this.coneSquareText.Name = "coneSquareText";
            this.coneSquareText.Size = new System.Drawing.Size(100, 25);
            this.coneSquareText.TabIndex = 9;
            this.coneSquareText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "锥头面积：";
            // 
            // labelCoffiText
            // 
            this.labelCoffiText.Location = new System.Drawing.Point(108, 219);
            this.labelCoffiText.Name = "labelCoffiText";
            this.labelCoffiText.Size = new System.Drawing.Size(100, 25);
            this.labelCoffiText.TabIndex = 11;
            this.labelCoffiText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "标定系数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "cm2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "kpa";
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(37, 83);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(167, 41);
            this.saveFileBtn.TabIndex = 1;
            this.saveFileBtn.Text = "保存文件";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // JingTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 770);
            this.Controls.Add(this.fileGroupbox);
            this.Controls.Add(this.settingGroupbox);
            this.Controls.Add(this.stDataGridView);
            this.Name = "JingTan";
            this.Text = "大智静探";
            ((System.ComponentModel.ISupportInitialize)(this.stDataGridView)).EndInit();
            this.settingGroupbox.ResumeLayout(false);
            this.settingGroupbox.PerformLayout();
            this.fileGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stDataGridView;
        private System.Windows.Forms.GroupBox settingGroupbox;
        private System.Windows.Forms.GroupBox fileGroupbox;
        private System.Windows.Forms.Button importFileBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox labelCoffiText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coneSquareText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox testDateText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox probeNumberText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox holeNumberText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox projectNumberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveFileBtn;
    }
}

