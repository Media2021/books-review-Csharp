namespace BookReviews
{
    partial class ReviewsUser
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
            this.label26 = new System.Windows.Forms.Label();
            this.button_AddView = new System.Windows.Forms.Button();
            this.richTb_AddView = new System.Windows.Forms.RichTextBox();
            this.button_deleteReview = new System.Windows.Forms.Button();
            this.tb_reviewId = new System.Windows.Forms.RichTextBox();
            this.lbl_override = new System.Windows.Forms.Label();
            this.tb_bookName = new System.Windows.Forms.RichTextBox();
            this.tb_userName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(1140, 37);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(455, 86);
            this.label26.TabIndex = 31;
            this.label26.Text = "Read To Heal";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // button_AddView
            // 
            this.button_AddView.Location = new System.Drawing.Point(238, 973);
            this.button_AddView.Name = "button_AddView";
            this.button_AddView.Size = new System.Drawing.Size(279, 69);
            this.button_AddView.TabIndex = 26;
            this.button_AddView.Text = "Add review ";
            this.button_AddView.UseVisualStyleBackColor = true;
            this.button_AddView.Click += new System.EventHandler(this.button_AddView_Click);
            // 
            // richTb_AddView
            // 
            this.richTb_AddView.Location = new System.Drawing.Point(504, 452);
            this.richTb_AddView.Name = "richTb_AddView";
            this.richTb_AddView.Size = new System.Drawing.Size(475, 141);
            this.richTb_AddView.TabIndex = 32;
            this.richTb_AddView.Text = "";
            // 
            // button_deleteReview
            // 
            this.button_deleteReview.Location = new System.Drawing.Point(610, 973);
            this.button_deleteReview.Name = "button_deleteReview";
            this.button_deleteReview.Size = new System.Drawing.Size(279, 69);
            this.button_deleteReview.TabIndex = 33;
            this.button_deleteReview.Text = "Delete review ";
            this.button_deleteReview.UseVisualStyleBackColor = true;
            this.button_deleteReview.Click += new System.EventHandler(this.button_deleteReview_Click);
            // 
            // tb_reviewId
            // 
            this.tb_reviewId.Location = new System.Drawing.Point(504, 256);
            this.tb_reviewId.Name = "tb_reviewId";
            this.tb_reviewId.Size = new System.Drawing.Size(475, 56);
            this.tb_reviewId.TabIndex = 34;
            this.tb_reviewId.Text = "";
            this.tb_reviewId.TextChanged += new System.EventHandler(this.richTb_search_TextChanged);
            // 
            // lbl_override
            // 
            this.lbl_override.AutoSize = true;
            this.lbl_override.Location = new System.Drawing.Point(442, 1019);
            this.lbl_override.Name = "lbl_override";
            this.lbl_override.Size = new System.Drawing.Size(0, 48);
            this.lbl_override.TabIndex = 36;
            // 
            // tb_bookName
            // 
            this.tb_bookName.Location = new System.Drawing.Point(504, 350);
            this.tb_bookName.Name = "tb_bookName";
            this.tb_bookName.Size = new System.Drawing.Size(475, 56);
            this.tb_bookName.TabIndex = 37;
            this.tb_bookName.Text = "";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(504, 631);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(475, 56);
            this.tb_userName.TabIndex = 38;
            this.tb_userName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 48);
            this.label1.TabIndex = 39;
            this.label1.Text = "Review id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 48);
            this.label2.TabIndex = 40;
            this.label2.Text = "Book name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 48);
            this.label3.TabIndex = 41;
            this.label3.Text = "User name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 762);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(600, 55);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 767);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 48);
            this.label4.TabIndex = 43;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 48);
            this.label5.TabIndex = 44;
            this.label5.Text = "My review";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(1247, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(1553, 450);
            this.dataGridView1.TabIndex = 45;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "name";
            this.Column2.MinimumWidth = 15;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "review";
            this.Column3.MinimumWidth = 15;
            this.Column3.Name = "Column3";
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "myName";
            this.Column4.MinimumWidth = 15;
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "date";
            this.Column5.MinimumWidth = 15;
            this.Column5.Name = "Column5";
            this.Column5.Width = 300;
            // 
            // ReviewsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2886, 1267);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.tb_bookName);
            this.Controls.Add(this.lbl_override);
            this.Controls.Add(this.tb_reviewId);
            this.Controls.Add(this.button_deleteReview);
            this.Controls.Add(this.richTb_AddView);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.button_AddView);
            this.Name = "ReviewsUser";
            this.Text = "ReviewsUser";
            this.Load += new System.EventHandler(this.ReviewsUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label26;
        private Button button_AddView;
        private RichTextBox richTb_AddView;
        private Button button_deleteReview;
        private RichTextBox tb_reviewId;
        private Label lbl_override;
        private RichTextBox tb_bookName;
        private RichTextBox tb_userName;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}