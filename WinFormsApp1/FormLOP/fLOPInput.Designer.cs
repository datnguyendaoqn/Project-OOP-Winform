namespace WinFormsApp1
{
    partial class fLOPInput
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
            lbID = new Label();
            lbNameclass = new Label();
            lbyear = new Label();
            tbName = new TextBox();
            tbID = new TextBox();
            tbYear = new TextBox();
            btnNhap = new Button();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.BackColor = SystemColors.Control;
            lbID.Location = new Point(68, 73);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // lbNameclass
            // 
            lbNameclass.AutoSize = true;
            lbNameclass.Location = new Point(68, 139);
            lbNameclass.Name = "lbNameclass";
            lbNameclass.Size = new Size(39, 15);
            lbNameclass.TabIndex = 2;
            lbNameclass.Text = "Name";
            // 
            // lbyear
            // 
            lbyear.AutoSize = true;
            lbyear.Location = new Point(68, 205);
            lbyear.Name = "lbyear";
            lbyear.Size = new Size(59, 15);
            lbyear.TabIndex = 3;
            lbyear.Text = "NienKhoa";
            // 
            // tbName
            // 
            tbName.Location = new Point(213, 131);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 4;
            // 
            // tbID
            // 
            tbID.Location = new Point(213, 73);
            tbID.Name = "tbID";
            tbID.Size = new Size(100, 23);
            tbID.TabIndex = 5;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(213, 205);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(100, 23);
            tbYear.TabIndex = 6;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(238, 302);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhap";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // fInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNhap);
            Controls.Add(tbYear);
            Controls.Add(tbID);
            Controls.Add(tbName);
            Controls.Add(lbyear);
            Controls.Add(lbNameclass);
            Controls.Add(lbID);
            IsMdiContainer = true;
            Name = "fInput";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private Label lbNameclass;
        private Label lbyear;
        private TextBox tbName;
        private TextBox tbID;
        private TextBox tbYear;
        private Button btnNhap;
    }
}