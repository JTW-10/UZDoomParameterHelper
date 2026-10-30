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
            lblLevel = new Label();
            cmbFile = new ComboBox();
            lblFile = new Label();
            cmbSkill = new ComboBox();
            lblSkill = new Label();
            chkFast = new CheckBox();
            txtParameters = new TextBox();
            btnGenerate = new Button();
            txtLevel = new TextBox();
            SuspendLayout();
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(140, 62);
            lblLevel.Margin = new Padding(5, 0, 5, 0);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(65, 30);
            lblLevel.TabIndex = 0;
            lblLevel.Text = "Level:";
            // 
            // cmbFile
            // 
            cmbFile.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFile.FormattingEnabled = true;
            cmbFile.Items.AddRange(new object[] { "", "Brutal Doom (brutalv21.pk3)", "Final Doomer (FinalDoomer_v3.4.pk3)", "Doom Deluxe (DoomDeluxe.pk3)" });
            cmbFile.Location = new Point(219, 168);
            cmbFile.Margin = new Padding(5, 6, 5, 6);
            cmbFile.Name = "cmbFile";
            cmbFile.Size = new Size(205, 38);
            cmbFile.TabIndex = 3;
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(140, 174);
            lblFile.Margin = new Padding(5, 0, 5, 0);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(49, 30);
            lblFile.TabIndex = 2;
            lblFile.Text = "File:";
            // 
            // cmbSkill
            // 
            cmbSkill.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSkill.FormattingEnabled = true;
            cmbSkill.Items.AddRange(new object[] { "", "I'm Too Young To Die", "Hey, Not Too Rough", "Hurt Me Plenty", "Ultra-Violence", "Nightmare!" });
            cmbSkill.Location = new Point(665, 56);
            cmbSkill.Margin = new Padding(5, 6, 5, 6);
            cmbSkill.Name = "cmbSkill";
            cmbSkill.Size = new Size(205, 38);
            cmbSkill.TabIndex = 5;
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Location = new Point(555, 62);
            lblSkill.Margin = new Padding(5, 0, 5, 0);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(101, 30);
            lblSkill.TabIndex = 4;
            lblSkill.Text = "Difficulty:";
            // 
            // chkFast
            // 
            chkFast.AutoSize = true;
            chkFast.CheckAlign = ContentAlignment.TopRight;
            chkFast.Location = new Point(555, 166);
            chkFast.Margin = new Padding(5, 6, 5, 6);
            chkFast.Name = "chkFast";
            chkFast.Size = new Size(176, 34);
            chkFast.TabIndex = 6;
            chkFast.Text = "Fast Monsters?";
            chkFast.UseVisualStyleBackColor = true;
            // 
            // txtParameters
            // 
            txtParameters.Location = new Point(147, 286);
            txtParameters.Margin = new Padding(5, 6, 5, 6);
            txtParameters.Name = "txtParameters";
            txtParameters.Size = new Size(722, 35);
            txtParameters.TabIndex = 7;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(418, 356);
            btnGenerate.Margin = new Padding(5, 6, 5, 6);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(166, 110);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(219, 62);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(107, 35);
            txtLevel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 506);
            Controls.Add(txtLevel);
            Controls.Add(btnGenerate);
            Controls.Add(txtParameters);
            Controls.Add(chkFast);
            Controls.Add(cmbSkill);
            Controls.Add(lblSkill);
            Controls.Add(cmbFile);
            Controls.Add(lblFile);
            Controls.Add(lblLevel);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLevel;
        private ComboBox cmbFile;
        private Label lblFile;
        private ComboBox cmbSkill;
        private Label lblSkill;
        private CheckBox chkFast;
        private TextBox txtParameters;
        private Button btnGenerate;
        private TextBox txtLevel;
    }
}
