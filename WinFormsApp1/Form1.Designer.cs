namespace WinFormsApp1
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
            lvDSLOP = new ListView();
            Malop = new ColumnHeader();
            TenLop = new ColumnHeader();
            Namhoc = new ColumnHeader();
            btnNhaplop = new Button();
            btnEditlop = new Button();
            btnXoalop = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            tbYear = new TextBox();
            btnPrint = new Button();
            groupBox2 = new GroupBox();
            btnXoasv = new Button();
            btnAddsv = new Button();
            btnEditsv = new Button();
            lvDSSV = new ListView();
            MaSV = new ColumnHeader();
            Ho = new ColumnHeader();
            Ten = new ColumnHeader();
            Phai = new ColumnHeader();
            SDT = new ColumnHeader();
            groupBox3 = new GroupBox();
            btnEditMH = new Button();
            btnDeleteMH = new Button();
            btnAddMH = new Button();
            lvDSMH = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lvDSLOP
            // 
            lvDSLOP.Columns.AddRange(new ColumnHeader[] { Malop, TenLop, Namhoc });
            lvDSLOP.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lvDSLOP.FullRowSelect = true;
            lvDSLOP.GridLines = true;
            lvDSLOP.Location = new Point(2, 34);
            lvDSLOP.Name = "lvDSLOP";
            lvDSLOP.Size = new Size(374, 292);
            lvDSLOP.TabIndex = 0;
            lvDSLOP.UseCompatibleStateImageBehavior = false;
            lvDSLOP.View = View.Details;
            // 
            // Malop
            // 
            Malop.Text = "ID Class";
            Malop.Width = 110;
            // 
            // TenLop
            // 
            TenLop.Text = "Name";
            TenLop.TextAlign = HorizontalAlignment.Center;
            TenLop.Width = 200;
            // 
            // Namhoc
            // 
            Namhoc.Text = "Year";
            Namhoc.TextAlign = HorizontalAlignment.Center;
            // 
            // btnNhaplop
            // 
            btnNhaplop.Location = new Point(0, 324);
            btnNhaplop.Name = "btnNhaplop";
            btnNhaplop.Size = new Size(92, 38);
            btnNhaplop.TabIndex = 1;
            btnNhaplop.Text = "Add";
            btnNhaplop.UseVisualStyleBackColor = true;
            btnNhaplop.Click += btnLoad_Click;
            // 
            // btnEditlop
            // 
            btnEditlop.Location = new Point(301, 324);
            btnEditlop.Name = "btnEditlop";
            btnEditlop.Size = new Size(75, 39);
            btnEditlop.TabIndex = 2;
            btnEditlop.Text = "Edit";
            btnEditlop.UseVisualStyleBackColor = true;
            btnEditlop.Click += btnEdit_Click;
            // 
            // btnXoalop
            // 
            btnXoalop.Location = new Point(141, 323);
            btnXoalop.Name = "btnXoalop";
            btnXoalop.Size = new Size(97, 39);
            btnXoalop.TabIndex = 3;
            btnXoalop.Text = "Delete";
            btnXoalop.UseVisualStyleBackColor = true;
            btnXoalop.Click += btnXoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(lvDSLOP);
            groupBox1.Controls.Add(btnNhaplop);
            groupBox1.Controls.Add(btnEditlop);
            groupBox1.Controls.Add(btnXoalop);
            groupBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.GhostWhite;
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 362);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "DSLOP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 433);
            label1.Name = "label1";
            label1.Size = new Size(60, 26);
            label1.TabIndex = 7;
            label1.Text = "Year";
            // 
            // tbYear
            // 
            tbYear.Location = new Point(120, 433);
            tbYear.Multiline = true;
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(100, 26);
            tbYear.TabIndex = 8;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.Window;
            btnPrint.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.Location = new Point(12, 465);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(208, 31);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "In Lop theo Nien khoa";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoasv);
            groupBox2.Controls.Add(btnAddsv);
            groupBox2.Controls.Add(btnEditsv);
            groupBox2.Controls.Add(lvDSSV);
            groupBox2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(406, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 360);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "DSSV";
            // 
            // btnXoasv
            // 
            btnXoasv.Location = new Point(221, 322);
            btnXoasv.Name = "btnXoasv";
            btnXoasv.Size = new Size(93, 38);
            btnXoasv.TabIndex = 3;
            btnXoasv.Text = "Delete";
            btnXoasv.UseVisualStyleBackColor = true;
            btnXoasv.Click += btnXoasv_Click;
            // 
            // btnAddsv
            // 
            btnAddsv.Location = new Point(0, 323);
            btnAddsv.Name = "btnAddsv";
            btnAddsv.Size = new Size(75, 38);
            btnAddsv.TabIndex = 2;
            btnAddsv.Text = "Add";
            btnAddsv.UseVisualStyleBackColor = true;
            btnAddsv.Click += btnAddsv_Click;
            // 
            // btnEditsv
            // 
            btnEditsv.Location = new Point(459, 323);
            btnEditsv.Name = "btnEditsv";
            btnEditsv.Size = new Size(75, 39);
            btnEditsv.TabIndex = 1;
            btnEditsv.Text = "Edit";
            btnEditsv.UseVisualStyleBackColor = true;
            btnEditsv.Click += btnEditsv_Click;
            // 
            // lvDSSV
            // 
            lvDSSV.Columns.AddRange(new ColumnHeader[] { MaSV, Ho, Ten, Phai, SDT });
            lvDSSV.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lvDSSV.FullRowSelect = true;
            lvDSSV.GridLines = true;
            lvDSSV.Location = new Point(0, 32);
            lvDSSV.Name = "lvDSSV";
            lvDSSV.Size = new Size(555, 292);
            lvDSSV.TabIndex = 0;
            lvDSSV.UseCompatibleStateImageBehavior = false;
            lvDSSV.View = View.Details;
            // 
            // MaSV
            // 
            MaSV.Text = "MaSV";
            MaSV.Width = 110;
            // 
            // Ho
            // 
            Ho.Text = "Ho";
            Ho.TextAlign = HorizontalAlignment.Center;
            Ho.Width = 150;
            // 
            // Ten
            // 
            Ten.Text = "Ten";
            Ten.TextAlign = HorizontalAlignment.Center;
            Ten.Width = 80;
            // 
            // Phai
            // 
            Phai.Text = "Phai";
            Phai.TextAlign = HorizontalAlignment.Center;
            // 
            // SDT
            // 
            SDT.Text = "SDT";
            SDT.TextAlign = HorizontalAlignment.Center;
            SDT.Width = 130;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEditMH);
            groupBox3.Controls.Add(btnDeleteMH);
            groupBox3.Controls.Add(btnAddMH);
            groupBox3.Controls.Add(lvDSMH);
            groupBox3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(967, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(452, 362);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "DSMH";
            // 
            // btnEditMH
            // 
            btnEditMH.Location = new Point(377, 325);
            btnEditMH.Name = "btnEditMH";
            btnEditMH.Size = new Size(75, 36);
            btnEditMH.TabIndex = 3;
            btnEditMH.Text = "Edit";
            btnEditMH.UseVisualStyleBackColor = true;
            btnEditMH.Click += btnEditMH_Click;
            // 
            // btnDeleteMH
            // 
            btnDeleteMH.Location = new Point(185, 325);
            btnDeleteMH.Name = "btnDeleteMH";
            btnDeleteMH.Size = new Size(89, 37);
            btnDeleteMH.TabIndex = 2;
            btnDeleteMH.Text = "Delete";
            btnDeleteMH.UseVisualStyleBackColor = true;
            btnDeleteMH.Click += btnDeleteMH_Click;
            // 
            // btnAddMH
            // 
            btnAddMH.Location = new Point(0, 325);
            btnAddMH.Name = "btnAddMH";
            btnAddMH.Size = new Size(75, 36);
            btnAddMH.TabIndex = 1;
            btnAddMH.Text = "Add";
            btnAddMH.UseVisualStyleBackColor = true;
            btnAddMH.Click += btnAddMH_Click;
            // 
            // lvDSMH
            // 
            lvDSMH.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvDSMH.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lvDSMH.FullRowSelect = true;
            lvDSMH.GridLines = true;
            lvDSMH.Location = new Point(0, 36);
            lvDSMH.MultiSelect = false;
            lvDSMH.Name = "lvDSMH";
            lvDSMH.Size = new Size(452, 290);
            lvDSMH.TabIndex = 0;
            lvDSMH.UseCompatibleStateImageBehavior = false;
            lvDSMH.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "MaMH";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TenMH";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "STCLT";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "STCTH";
            columnHeader4.Width = 77;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1538, 642);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnPrint);
            Controls.Add(tbYear);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            IsMdiContainer = true;
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListView lvDSLOP;
        private ColumnHeader Malop;
        private ColumnHeader TenLop;
        private ColumnHeader Namhoc;
        private Button btnNhaplop;
        private Button btnEditlop;
        private Button btnXoalop;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbYear;
        private Button btnPrint;
        private GroupBox groupBox2;
        public ListView lvDSSV;
        private ColumnHeader MaSV;
        private ColumnHeader Ho;
        private ColumnHeader Ten;
        private ColumnHeader Phai;
        private ColumnHeader SDT;
        private Button btnXoasv;
        private Button btnAddsv;
        private Button btnEditsv;
        private GroupBox groupBox3;
        public ListView lvDSMH;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnEditMH;
        private Button btnDeleteMH;
        private Button btnAddMH;
    }
}