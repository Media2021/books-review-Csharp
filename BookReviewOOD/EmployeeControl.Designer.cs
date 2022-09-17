namespace BookReviews
{
    partial class EmployeeControl
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
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBookType = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.richTbDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxBookType = new System.Windows.Forms.ComboBox();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.btn_loguot = new System.Windows.Forms.Button();
            this.lbl_override = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(433, 1130);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(225, 69);
            this.btnDeleteBook.TabIndex = 47;
            this.btnDeleteBook.Text = "Delete book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(373, 636);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(201, 48);
            this.lblDescription.TabIndex = 46;
            this.lblDescription.Text = "Description";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(181, 528);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(185, 48);
            this.lblBookType.TabIndex = 45;
            this.lblBookType.Text = "Book Type";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(181, 412);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(215, 48);
            this.lblBookAuthor.TabIndex = 44;
            this.lblBookAuthor.Text = "Book author";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(181, 309);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(199, 48);
            this.lblBookName.TabIndex = 43;
            this.lblBookName.Text = "Book name";
            // 
            // richTbDescription
            // 
            this.richTbDescription.Location = new System.Drawing.Point(181, 709);
            this.richTbDescription.Name = "richTbDescription";
            this.richTbDescription.Size = new System.Drawing.Size(709, 288);
            this.richTbDescription.TabIndex = 42;
            this.richTbDescription.Text = "";
            // 
            // comboBoxBookType
            // 
            this.comboBoxBookType.FormattingEnabled = true;
            this.comboBoxBookType.Items.AddRange(new object[] {
            "Novels",
            "Stories",
            "Aducational"});
            this.comboBoxBookType.Location = new System.Drawing.Point(503, 520);
            this.comboBoxBookType.Name = "comboBoxBookType";
            this.comboBoxBookType.Size = new System.Drawing.Size(363, 56);
            this.comboBoxBookType.TabIndex = 41;
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Location = new System.Drawing.Point(503, 412);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(300, 55);
            this.tbBookAuthor.TabIndex = 40;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(503, 302);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(300, 55);
            this.tbBookName.TabIndex = 39;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(155, 1130);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(225, 69);
            this.btnAddBook.TabIndex = 38;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(1041, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(1624, 450);
            this.dataGridView1.TabIndex = 37;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id";
            this.Column5.MinimumWidth = 15;
            this.Column5.Name = "Column5";
            this.Column5.Width = 300;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "name";
            this.Column6.MinimumWidth = 15;
            this.Column6.Name = "Column6";
            this.Column6.Width = 300;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "author";
            this.Column7.MinimumWidth = 15;
            this.Column7.Name = "Column7";
            this.Column7.Width = 300;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "type";
            this.Column8.MinimumWidth = 15;
            this.Column8.Name = "Column8";
            this.Column8.Width = 300;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "description";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1096, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 86);
            this.label1.TabIndex = 49;
            this.label1.Text = "Read To Heal";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Location = new System.Drawing.Point(181, 190);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(141, 48);
            this.lblBookId.TabIndex = 51;
            this.lblBookId.Text = "Book id";
            // 
            // tbBookId
            // 
            this.tbBookId.Location = new System.Drawing.Point(503, 183);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.Size = new System.Drawing.Size(300, 55);
            this.tbBookId.TabIndex = 50;
            // 
            // btn_loguot
            // 
            this.btn_loguot.Location = new System.Drawing.Point(723, 1130);
            this.btn_loguot.Name = "btn_loguot";
            this.btn_loguot.Size = new System.Drawing.Size(225, 69);
            this.btn_loguot.TabIndex = 52;
            this.btn_loguot.Text = "Log out";
            this.btn_loguot.UseVisualStyleBackColor = true;
            this.btn_loguot.Click += new System.EventHandler(this.btn_loguot_Click);
            // 
            // lbl_override
            // 
            this.lbl_override.AutoSize = true;
            this.lbl_override.Location = new System.Drawing.Point(1351, 1065);
            this.lbl_override.Name = "lbl_override";
            this.lbl_override.Size = new System.Drawing.Size(0, 48);
            this.lbl_override.TabIndex = 53;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2722, 1249);
            this.Controls.Add(this.lbl_override);
            this.Controls.Add(this.btn_loguot);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.tbBookId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblBookType);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.richTbDescription);
            this.Controls.Add(this.comboBoxBookType);
            this.Controls.Add(this.tbBookAuthor);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeControl";
            this.Text = "BooksAdmin";
            this.Load += new System.EventHandler(this.BooksAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnDeleteBook;
        private Label lblDescription;
        private Label lblBookType;
        private Label lblBookAuthor;
        private Label lblBookName;
        private RichTextBox richTbDescription;
        private ComboBox comboBoxBookType;
        private TextBox tbBookAuthor;
        private TextBox tbBookName;
        private Button btnAddBook;
        private DataGridView dataGridView1;
        private Label label1;
        private Label lblBookId;
        private TextBox tbBookId;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private Button btn_loguot;
        private Label lbl_override;
    }
}