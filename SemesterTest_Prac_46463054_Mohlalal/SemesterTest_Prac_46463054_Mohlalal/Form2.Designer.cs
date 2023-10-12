namespace SemesterTest_Prac_46463054_Mohlalal
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEmploymentType = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.gbPreviousFunding = new System.Windows.Forms.GroupBox();
            this.radPreviouslyFundedNo = new System.Windows.Forms.RadioButton();
            this.radPreviouslyFundedYes = new System.Windows.Forms.RadioButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnNewApplication = new System.Windows.Forms.Button();
            this.chkConfirmation = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lstOutput2 = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbPreviousFunding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name and surname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // lstEmploymentType
            // 
            this.lstEmploymentType.FormattingEnabled = true;
            this.lstEmploymentType.Items.AddRange(new object[] {
            "Employed-Full time",
            "Employed-Part time",
            "Unemployed",
            "Self-employed",
            "Entreprenuer",
            "Tenderpreneur"});
            this.lstEmploymentType.Location = new System.Drawing.Point(265, 25);
            this.lstEmploymentType.Margin = new System.Windows.Forms.Padding(2);
            this.lstEmploymentType.Name = "lstEmploymentType";
            this.lstEmploymentType.Size = new System.Drawing.Size(196, 108);
            this.lstEmploymentType.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 25);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(111, 80);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(110, 20);
            this.txtAge.TabIndex = 4;
            // 
            // gbPreviousFunding
            // 
            this.gbPreviousFunding.Controls.Add(this.radPreviouslyFundedNo);
            this.gbPreviousFunding.Controls.Add(this.radPreviouslyFundedYes);
            this.gbPreviousFunding.Location = new System.Drawing.Point(472, 25);
            this.gbPreviousFunding.Margin = new System.Windows.Forms.Padding(2);
            this.gbPreviousFunding.Name = "gbPreviousFunding";
            this.gbPreviousFunding.Padding = new System.Windows.Forms.Padding(2);
            this.gbPreviousFunding.Size = new System.Drawing.Size(202, 93);
            this.gbPreviousFunding.TabIndex = 5;
            this.gbPreviousFunding.TabStop = false;
            this.gbPreviousFunding.Text = "Previous Funding";
            // 
            // radPreviouslyFundedNo
            // 
            this.radPreviouslyFundedNo.AutoSize = true;
            this.radPreviouslyFundedNo.Location = new System.Drawing.Point(10, 55);
            this.radPreviouslyFundedNo.Margin = new System.Windows.Forms.Padding(2);
            this.radPreviouslyFundedNo.Name = "radPreviouslyFundedNo";
            this.radPreviouslyFundedNo.Size = new System.Drawing.Size(188, 17);
            this.radPreviouslyFundedNo.TabIndex = 1;
            this.radPreviouslyFundedNo.TabStop = true;
            this.radPreviouslyFundedNo.Text = "I have not received funding before";
            this.radPreviouslyFundedNo.UseVisualStyleBackColor = true;
            this.radPreviouslyFundedNo.CheckedChanged += new System.EventHandler(this.radPreviouslyFundedNo_CheckedChanged);
            // 
            // radPreviouslyFundedYes
            // 
            this.radPreviouslyFundedYes.AutoSize = true;
            this.radPreviouslyFundedYes.Location = new System.Drawing.Point(10, 24);
            this.radPreviouslyFundedYes.Margin = new System.Windows.Forms.Padding(2);
            this.radPreviouslyFundedYes.Name = "radPreviouslyFundedYes";
            this.radPreviouslyFundedYes.Size = new System.Drawing.Size(170, 17);
            this.radPreviouslyFundedYes.TabIndex = 0;
            this.radPreviouslyFundedYes.TabStop = true;
            this.radPreviouslyFundedYes.Text = "I have received funding before";
            this.radPreviouslyFundedYes.UseVisualStyleBackColor = true;
            this.radPreviouslyFundedYes.CheckedChanged += new System.EventHandler(this.radPreviouslyFundedNo_CheckedChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(10, 164);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(223, 44);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Submit Application";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.Location = new System.Drawing.Point(265, 164);
            this.btnNewApplication.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(195, 44);
            this.btnNewApplication.TabIndex = 7;
            this.btnNewApplication.Text = "New Application";
            this.btnNewApplication.UseVisualStyleBackColor = true;
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // chkConfirmation
            // 
            this.chkConfirmation.AutoSize = true;
            this.chkConfirmation.Location = new System.Drawing.Point(8, 134);
            this.chkConfirmation.Margin = new System.Windows.Forms.Padding(2);
            this.chkConfirmation.Name = "chkConfirmation";
            this.chkConfirmation.Size = new System.Drawing.Size(245, 17);
            this.chkConfirmation.TabIndex = 8;
            this.chkConfirmation.Text = "I declare that all information provided is correct";
            this.chkConfirmation.UseVisualStyleBackColor = true;
            this.chkConfirmation.CheckedChanged += new System.EventHandler(this.chkConfirmation_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(24, 253);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(2);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(272, 212);
            this.lstOutput.TabIndex = 10;
            // 
            // lstOutput2
            // 
            this.lstOutput2.FormattingEnabled = true;
            this.lstOutput2.Location = new System.Drawing.Point(372, 253);
            this.lstOutput2.Margin = new System.Windows.Forms.Padding(2);
            this.lstOutput2.Name = "lstOutput2";
            this.lstOutput2.Size = new System.Drawing.Size(284, 212);
            this.lstOutput2.TabIndex = 11;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(311, 294);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(56, 19);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(311, 351);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(56, 19);
            this.openFileButton.TabIndex = 13;
            this.openFileButton.Text = "Open";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 480);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lstOutput2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.chkConfirmation);
            this.Controls.Add(this.btnNewApplication);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.gbPreviousFunding);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstEmploymentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPreviousFunding.ResumeLayout(false);
            this.gbPreviousFunding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEmploymentType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.GroupBox gbPreviousFunding;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.CheckBox chkConfirmation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.RadioButton radPreviouslyFundedNo;
        private System.Windows.Forms.RadioButton radPreviouslyFundedYes;
        private System.Windows.Forms.ListBox lstOutput2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

