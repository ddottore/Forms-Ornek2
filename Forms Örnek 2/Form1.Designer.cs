namespace Forms_Örnek_2
{
    partial class form
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
            this.lblStudentRegisterName = new System.Windows.Forms.Label();
            this.lbxStudentList = new System.Windows.Forms.ListBox();
            this.tbxStudentNameText = new System.Windows.Forms.TextBox();
            this.lblStudentNameText = new System.Windows.Forms.Label();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.btnStudentRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentRegisterName
            // 
            this.lblStudentRegisterName.AutoSize = true;
            this.lblStudentRegisterName.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentRegisterName.Location = new System.Drawing.Point(149, 9);
            this.lblStudentRegisterName.Name = "lblStudentRegisterName";
            this.lblStudentRegisterName.Size = new System.Drawing.Size(510, 28);
            this.lblStudentRegisterName.TabIndex = 0;
            this.lblStudentRegisterName.Text = "Ögrenci Kayıt Sistemi";
            // 
            // lbxStudentList
            // 
            this.lbxStudentList.FormattingEnabled = true;
            this.lbxStudentList.ItemHeight = 15;
            this.lbxStudentList.Location = new System.Drawing.Point(86, 209);
            this.lbxStudentList.Name = "lbxStudentList";
            this.lbxStudentList.Size = new System.Drawing.Size(609, 214);
            this.lbxStudentList.TabIndex = 1;
            this.lbxStudentList.SelectedIndexChanged += new System.EventHandler(this.lbxStudentList_SelectedIndexChanged);
            // 
            // tbxStudentNameText
            // 
            this.tbxStudentNameText.Location = new System.Drawing.Point(212, 87);
            this.tbxStudentNameText.Name = "tbxStudentNameText";
            this.tbxStudentNameText.Size = new System.Drawing.Size(416, 23);
            this.tbxStudentNameText.TabIndex = 2;
            this.tbxStudentNameText.TextChanged += new System.EventHandler(this.tbxStudentNameText_TextChanged);
            // 
            // lblStudentNameText
            // 
            this.lblStudentNameText.AutoSize = true;
            this.lblStudentNameText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentNameText.Location = new System.Drawing.Point(86, 90);
            this.lblStudentNameText.Name = "lblStudentNameText";
            this.lblStudentNameText.Size = new System.Drawing.Size(118, 15);
            this.lblStudentNameText.TabIndex = 3;
            this.lblStudentNameText.Text = "Girilecek Öğrenci Adı";
            this.lblStudentNameText.Click += new System.EventHandler(this.lblStudentNameText_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(634, 86);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(61, 24);
            this.btnStudentAdd.TabIndex = 4;
            this.btnStudentAdd.Text = "Ekle";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // btnStudentRemove
            // 
            this.btnStudentRemove.Location = new System.Drawing.Point(713, 400);
            this.btnStudentRemove.Name = "btnStudentRemove";
            this.btnStudentRemove.Size = new System.Drawing.Size(75, 23);
            this.btnStudentRemove.TabIndex = 5;
            this.btnStudentRemove.Text = "Sil";
            this.btnStudentRemove.UseVisualStyleBackColor = true;
            this.btnStudentRemove.Click += new System.EventHandler(this.btnStudentRemove_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStudentRemove);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.lblStudentNameText);
            this.Controls.Add(this.tbxStudentNameText);
            this.Controls.Add(this.lbxStudentList);
            this.Controls.Add(this.lblStudentRegisterName);
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnStudentNameAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStudentRegisterName;
        private ListBox lbxStudentList;
        private TextBox tbxStudentNameText;
        private Label lblStudentNameText;
        private Button btnStudentAdd;
        private Button btnStudentRemove;
    }
}