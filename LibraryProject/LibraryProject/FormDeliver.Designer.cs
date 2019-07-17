namespace LibraryProject
{
    partial class FormDeliver
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgMemberDelete = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridLoan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridLoan);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(91, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 237);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödünç Alınan Kitapların Listesi";
            // 
            // dgMemberDelete
            // 
            this.dgMemberDelete.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgMemberDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMemberDelete.Location = new System.Drawing.Point(39, 32);
            this.dgMemberDelete.Name = "dgMemberDelete";
            this.dgMemberDelete.Size = new System.Drawing.Size(512, 63);
            this.dgMemberDelete.TabIndex = 6;
            this.dgMemberDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMemberDelete_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SEÇ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridLoan
            // 
            this.dataGridLoan.AllowUserToAddRows = false;
            this.dataGridLoan.AllowUserToDeleteRows = false;
            this.dataGridLoan.AllowUserToOrderColumns = true;
            this.dataGridLoan.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLoan.Location = new System.Drawing.Point(39, 31);
            this.dataGridLoan.Name = "dataGridLoan";
            this.dataGridLoan.ReadOnly = true;
            this.dataGridLoan.Size = new System.Drawing.Size(512, 150);
            this.dataGridLoan.TabIndex = 1;
            this.dataGridLoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLoan_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgMemberDelete);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(91, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 154);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitabı Alan Üye ve Borç Bilgisi";
            // 
            // FormDeliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDeliver";
            this.Text = "Kitap Teslim Etme Ve Borç Ödeme";
            this.Load += new System.EventHandler(this.FormDeliver_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemberDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgMemberDelete;
        private System.Windows.Forms.DataGridView dataGridLoan;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}