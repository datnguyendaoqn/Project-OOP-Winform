namespace WinFormsApp1
{
    partial class fLOPEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLOPEdit));
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            tbYear = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // tbName
            // 
            resources.ApplyResources(tbName, "tbName");
            tbName.Name = "tbName";
            // 
            // tbYear
            // 
            resources.ApplyResources(tbYear, "tbYear");
            tbYear.Name = "tbYear";
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.Name = "btnOK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // fEdit
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnOK);
            Controls.Add(tbYear);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox tbName;
        public TextBox tbYear;
        private Button btnOK;
    }
}