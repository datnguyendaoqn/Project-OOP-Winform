namespace WinFormsApp1
{
    partial class fSVedit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbHO = new TextBox();
            tbTEN = new TextBox();
            tbSDT = new TextBox();
            panel1 = new Panel();
            rbNAM = new RadioButton();
            rbNU = new RadioButton();
            btnOK = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 75);
            label1.Name = "label1";
            label1.Size = new Size(39, 22);
            label1.TabIndex = 0;
            label1.Text = "HO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 118);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 1;
            label2.Text = "TEN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 163);
            label3.Name = "label3";
            label3.Size = new Size(56, 22);
            label3.TabIndex = 2;
            label3.Text = "PHAI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 208);
            label4.Name = "label4";
            label4.Size = new Size(48, 22);
            label4.TabIndex = 3;
            label4.Text = "SDT";
            // 
            // tbHO
            // 
            tbHO.Location = new Point(147, 74);
            tbHO.Name = "tbHO";
            tbHO.Size = new Size(100, 23);
            tbHO.TabIndex = 4;
            // 
            // tbTEN
            // 
            tbTEN.Location = new Point(147, 120);
            tbTEN.Name = "tbTEN";
            tbTEN.Size = new Size(100, 23);
            tbTEN.TabIndex = 5;
            // 
            // tbSDT
            // 
            tbSDT.Location = new Point(147, 210);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(100, 23);
            tbSDT.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbNAM);
            panel1.Controls.Add(rbNU);
            panel1.Location = new Point(147, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 22);
            panel1.TabIndex = 7;
            // 
            // rbNAM
            // 
            rbNAM.AutoSize = true;
            rbNAM.Location = new Point(0, 0);
            rbNAM.Name = "rbNAM";
            rbNAM.Size = new Size(51, 19);
            rbNAM.TabIndex = 8;
            rbNAM.TabStop = true;
            rbNAM.Text = "Male";
            rbNAM.UseVisualStyleBackColor = true;
            // 
            // rbNU
            // 
            rbNU.AutoSize = true;
            rbNU.Location = new Point(57, 0);
            rbNU.Name = "rbNU";
            rbNU.Size = new Size(63, 19);
            rbNU.TabIndex = 9;
            rbNU.TabStop = true;
            rbNU.Text = "Female";
            rbNU.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ControlLightLight;
            btnOK.Location = new Point(272, 282);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // fSVedit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOK);
            Controls.Add(panel1);
            Controls.Add(tbSDT);
            Controls.Add(tbTEN);
            Controls.Add(tbHO);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fSVedit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fSVedit";
            Load += fSVedit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbHO;
        private TextBox tbTEN;
        private TextBox tbSDT;
        private Panel panel1;
        private RadioButton rbNAM;
        private RadioButton rbNU;
        private Button btnOK;
    }
}