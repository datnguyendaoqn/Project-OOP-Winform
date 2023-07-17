namespace WinFormsApp1
{
    partial class fSVinput
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
            label5 = new Label();
            tbSDT = new TextBox();
            tbTEN = new TextBox();
            tbHO = new TextBox();
            tbMSSV = new TextBox();
            panel1 = new Panel();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 87);
            label2.Name = "label2";
            label2.Size = new Size(39, 22);
            label2.TabIndex = 1;
            label2.Text = "HO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 144);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(50, 22);
            label3.TabIndex = 2;
            label3.Text = "TEN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 198);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 3;
            label4.Text = "PHAI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 261);
            label5.Name = "label5";
            label5.Size = new Size(48, 22);
            label5.TabIndex = 4;
            label5.Text = "SDT";
            // 
            // tbSDT
            // 
            tbSDT.Location = new Point(114, 263);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(100, 23);
            tbSDT.TabIndex = 5;
            // 
            // tbTEN
            // 
            tbTEN.Location = new Point(114, 146);
            tbTEN.Name = "tbTEN";
            tbTEN.Size = new Size(100, 23);
            tbTEN.TabIndex = 6;
            // 
            // tbHO
            // 
            tbHO.Location = new Point(114, 89);
            tbHO.Name = "tbHO";
            tbHO.Size = new Size(100, 23);
            tbHO.TabIndex = 7;
            // 
            // tbMSSV
            // 
            tbMSSV.Location = new Point(114, 36);
            tbMSSV.Name = "tbMSSV";
            tbMSSV.Size = new Size(100, 23);
            tbMSSV.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbNam);
            panel1.Controls.Add(rbNu);
            panel1.Location = new Point(114, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 38);
            panel1.TabIndex = 9;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(3, 16);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(51, 19);
            rbNam.TabIndex = 10;
            rbNam.TabStop = true;
            rbNam.Text = "Male";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(106, 16);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(63, 19);
            rbNu.TabIndex = 11;
            rbNu.TabStop = true;
            rbNu.Text = "Female";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Location = new Point(239, 347);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // fSVinput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(tbMSSV);
            Controls.Add(tbHO);
            Controls.Add(tbTEN);
            Controls.Add(tbSDT);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fSVinput";
            Text = "fSVinput";
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
        private Label label5;
        private TextBox tbSDT;
        private TextBox tbTEN;
        private TextBox tbHO;
        private TextBox tbMSSV;
        private Panel panel1;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private Button button1;
    }
}