namespace UZDoomParameterHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIWAD = new Label();
            cmbIWAD = new ComboBox();
            cmbFile = new ComboBox();
            lblFile = new Label();
            cmbSkill = new ComboBox();
            lblSkill = new Label();
            checkBox1 = new CheckBox();
            txtParameters = new TextBox();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // lblIWAD
            // 
            lblIWAD.AutoSize = true;
            lblIWAD.Location = new Point(84, 81);
            lblIWAD.Name = "lblIWAD";
            lblIWAD.Size = new Size(40, 15);
            lblIWAD.TabIndex = 0;
            lblIWAD.Text = "IWAD:";
            // 
            // cmbIWAD
            // 
            cmbIWAD.FormattingEnabled = true;
            cmbIWAD.Location = new Point(130, 78);
            cmbIWAD.Name = "cmbIWAD";
            cmbIWAD.Size = new Size(121, 23);
            cmbIWAD.TabIndex = 1;
            // 
            // cmbFile
            // 
            cmbFile.FormattingEnabled = true;
            cmbFile.Location = new Point(130, 134);
            cmbFile.Name = "cmbFile";
            cmbFile.Size = new Size(121, 23);
            cmbFile.TabIndex = 3;
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(84, 137);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(28, 15);
            lblFile.TabIndex = 2;
            lblFile.Text = "File:";
            // 
            // cmbSkill
            // 
            cmbSkill.FormattingEnabled = true;
            cmbSkill.Location = new Point(390, 78);
            cmbSkill.Name = "cmbSkill";
            cmbSkill.Size = new Size(121, 23);
            cmbSkill.TabIndex = 5;
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Location = new Point(326, 81);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(58, 15);
            lblSkill.TabIndex = 4;
            lblSkill.Text = "Difficulty:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.TopRight;
            checkBox1.Location = new Point(326, 133);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Fast Monsters?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtParameters
            // 
            txtParameters.Location = new Point(88, 193);
            txtParameters.Name = "txtParameters";
            txtParameters.Size = new Size(423, 23);
            txtParameters.TabIndex = 7;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(247, 259);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(97, 55);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 347);
            Controls.Add(btnGenerate);
            Controls.Add(txtParameters);
            Controls.Add(checkBox1);
            Controls.Add(cmbSkill);
            Controls.Add(lblSkill);
            Controls.Add(cmbFile);
            Controls.Add(lblFile);
            Controls.Add(cmbIWAD);
            Controls.Add(lblIWAD);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIWAD;
        private ComboBox cmbIWAD;
        private ComboBox cmbFile;
        private Label lblFile;
        private ComboBox cmbSkill;
        private Label lblSkill;
        private CheckBox checkBox1;
        private TextBox txtParameters;
        private Button btnGenerate;
    }
}
