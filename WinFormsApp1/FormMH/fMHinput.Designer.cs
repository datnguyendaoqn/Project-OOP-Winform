namespace WinFormsApp1
{
    partial class fMHinput
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
            tbMaMH = new TextBox();
            tbTenMH = new TextBox();
            tbSTCLT = new TextBox();
            tbSTCTH = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 65);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 0;
            label1.Text = "MaMH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 121);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 1;
            label2.Text = "TenMH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(79, 175);
            label3.Name = "label3";
            label3.Size = new Size(75, 24);
            label3.TabIndex = 2;
            label3.Text = "STCLT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(79, 228);
            label4.Name = "label4";
            label4.Size = new Size(79, 24);
            label4.TabIndex = 3;
            label4.Text = "STCTH";
            // 
            // tbMaMH
            // 
            tbMaMH.Location = new Point(235, 66);
            tbMaMH.Name = "tbMaMH";
            tbMaMH.Size = new Size(100, 23);
            tbMaMH.TabIndex = 4;
            // 
            // tbTenMH
            // 
            tbTenMH.Location = new Point(235, 121);
            tbTenMH.Name = "tbTenMH";
            tbTenMH.Size = new Size(100, 23);
            tbTenMH.TabIndex = 5;
            // 
            // tbSTCLT
            // 
            tbSTCLT.Location = new Point(235, 176);
            tbSTCLT.Name = "tbSTCLT";
            tbSTCLT.Size = new Size(100, 23);
            tbSTCLT.TabIndex = 6;
            // 
            // tbSTCTH
            // 
            tbSTCTH.Location = new Point(235, 228);
            tbSTCTH.Name = "tbSTCTH";
            tbSTCTH.Size = new Size(100, 23);
            tbSTCTH.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(260, 300);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // fMHinput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tbSTCTH);
            Controls.Add(tbSTCLT);
            Controls.Add(tbTenMH);
            Controls.Add(tbMaMH);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fMHinput";
            Text = "fInputMH";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbMaMH;
        private TextBox tbTenMH;
        private TextBox tbSTCLT;
        private TextBox tbSTCTH;
        private Button button1;
    }
}