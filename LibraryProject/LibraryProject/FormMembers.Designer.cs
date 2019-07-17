namespace LibraryProject
{
    partial class FormMembers
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
            this.dataGridMember = new System.Windows.Forms.DataGridView();
            this.btnChooseMember = new System.Windows.Forms.Button();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.btnChooseBook = new System.Windows.Forms.Button();
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).BeginInit();
            this.gbMember.SuspendLayout();
            this.gbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMember
            // 
            this.dataGridMember.AllowUserToAddRows = false;
            this.dataGridMember.AllowUserToDeleteRows = false;
            this.dataGridMember.AllowUserToOrderColumns = true;
            this.dataGridMember.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMember.Location = new System.Drawing.Point(24, 31);
            this.dataGridMember.Name = "dataGridMember";
            this.dataGridMember.ReadOnly = true;
            this.dataGridMember.Size = new System.Drawing.Size(273, 150);
            this.dataGridMember.TabIndex = 0;
            this.dataGridMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMember_CellClick);
            this.dataGridMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMember_CellContentClick);
            // 
            // btnChooseMember
            // 
            this.btnChooseMember.Location = new System.Drawing.Point(216, 187);
            this.btnChooseMember.Name = "btnChooseMember";
            this.btnChooseMember.Size = new System.Drawing.Size(81, 23);
            this.btnChooseMember.TabIndex = 1;
            this.btnChooseMember.Text = "Seç";
            this.btnChooseMember.UseVisualStyleBackColor = true;
            this.btnChooseMember.Click += new System.EventHandler(this.btnChooseMember_Click);
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.dataGridMember);
            this.gbMember.Controls.Add(this.btnChooseMember);
            this.gbMember.Location = new System.Drawing.Point(25, 26);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(324, 223);
            this.gbMember.TabIndex = 2;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Üye Seçim Alanı";
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.btnChooseBook);
            this.gbBook.Controls.Add(this.dataGridBook);
            this.gbBook.Location = new System.Drawing.Point(373, 26);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(300, 223);
            this.gbBook.TabIndex = 3;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "Kitap Seçim Alanı";
            // 
            // btnChooseBook
            // 
            this.btnChooseBook.Location = new System.Drawing.Point(201, 187);
            this.btnChooseBook.Name = "btnChooseBook";
            this.btnChooseBook.Size = new System.Drawing.Size(75, 23);
            this.btnChooseBook.TabIndex = 1;
            this.btnChooseBook.Text = "Seç";
            this.btnChooseBook.UseVisualStyleBackColor = true;
            this.btnChooseBook.Click += new System.EventHandler(this.btnChooseBook_Click);
            // 
            // dataGridBook
            // 
            this.dataGridBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBook.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridBook.Location = new System.Drawing.Point(22, 31);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.Size = new System.Drawing.Size(254, 150);
            this.dataGridBook.TabIndex = 0;
            this.dataGridBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBook_CellClick);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(142, 274);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(64, 13);
            this.lblMember.TabIndex = 4;
            this.lblMember.Text = "Seçilen Üye";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(463, 274);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(69, 13);
            this.lblBook.TabIndex = 5;
            this.lblBook.Text = "Seçilen Kitap";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÖDÜNÇ VER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.gbMember);
            this.Name = "FormMembers";
            this.Text = "Kitap Ödünç Verme İşlemi";
            this.Load += new System.EventHandler(this.FormMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMember)).EndInit();
            this.gbMember.ResumeLayout(false);
            this.gbBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMember;
        private System.Windows.Forms.Button btnChooseMember;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.DataGridView dataGridBook;
        private System.Windows.Forms.Button btnChooseBook;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button button1;
    }
}