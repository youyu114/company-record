namespace CompanyQuery
{
    partial class DetailedView
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
            this.components = new System.ComponentModel.Container();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemarksTextBox = new System.Windows.Forms.RichTextBox();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InterviewLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompanyNameLabel.Location = new System.Drawing.Point(288, 57);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(69, 26);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "公司名";
            this.CompanyNameLabel.Click += new System.EventHandler(this.CompanyNameLabel_Click);
            this.CompanyNameLabel.MouseEnter += new System.EventHandler(this.CompanyNameLabel_MouseEnter_1);
            this.CompanyNameLabel.MouseLeave += new System.EventHandler(this.CompanyNameLabel_MouseLeave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(76, 199);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "注释：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "详细地址：";
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Location = new System.Drawing.Point(126, 196);
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.ReadOnly = true;
            this.RemarksTextBox.Size = new System.Drawing.Size(599, 174);
            this.RemarksTextBox.TabIndex = 5;
            this.RemarksTextBox.Text = "";
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegionLabel.Location = new System.Drawing.Point(149, 121);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(0, 20);
            this.RegionLabel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "是否面试过：";
            // 
            // InterviewLabel
            // 
            this.InterviewLabel.AutoSize = true;
            this.InterviewLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InterviewLabel.Location = new System.Drawing.Point(162, 158);
            this.InterviewLabel.Name = "InterviewLabel";
            this.InterviewLabel.Size = new System.Drawing.Size(0, 20);
            this.InterviewLabel.TabIndex = 8;
            // 
            // DetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InterviewLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegionLabel);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.CompanyNameLabel);
            this.Name = "DetailedView";
            this.Text = "详细信息";
            this.Load += new System.EventHandler(this.DetailedView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CompanyNameLabel;
        private Label Label1;
        private Label label2;
        private RichTextBox RemarksTextBox;
        private Label RegionLabel;
        private Label label3;
        private Label InterviewLabel;
        private ToolTip toolTip1;
    }
}