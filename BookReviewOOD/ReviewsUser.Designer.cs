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
            this.tb_refresh = new System.Windows.Forms.TextBox();
            this.button_AddView = new System.Windows.Forms.Button();
            this.richTb_AddView = new System.Windows.Forms.RichTextBox();
            this.button_deleteReview = new System.Windows.Forms.Button();
            this.richTb_search = new System.Windows.Forms.RichTextBox();
            this.listB_findBook = new System.Windows.Forms.ListBox();
            this.lbl_override = new System.Windows.Forms.Label();
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
            // tb_refresh
            // 
            this.tb_refresh.Location = new System.Drawing.Point(541, 403);
            this.tb_refresh.Name = "tb_refresh";
            this.tb_refresh.Size = new System.Drawing.Size(202, 55);
            this.tb_refresh.TabIndex = 27;
            this.tb_refresh.Text = "Refresh";
            this.tb_refresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_refresh.TextChanged += new System.EventHandler(this.tb_refresh_TextChanged);
            // 
            // button_AddView
            // 
            this.button_AddView.Location = new System.Drawing.Point(541, 969);
            this.button_AddView.Name = "button_AddView";
            this.button_AddView.Size = new System.Drawing.Size(279, 69);
            this.button_AddView.TabIndex = 26;
            this.button_AddView.Text = "Add review ";
            this.button_AddView.UseVisualStyleBackColor = true;
            this.button_AddView.Click += new System.EventHandler(this.button_AddView_Click);
            // 
            // richTb_AddView
            // 
            this.richTb_AddView.Location = new System.Drawing.Point(1045, 938);
            this.richTb_AddView.Name = "richTb_AddView";
            this.richTb_AddView.Size = new System.Drawing.Size(739, 100);
            this.richTb_AddView.TabIndex = 32;
            this.richTb_AddView.Text = "";
            // 
            // button_deleteReview
            // 
            this.button_deleteReview.Location = new System.Drawing.Point(541, 1077);
            this.button_deleteReview.Name = "button_deleteReview";
            this.button_deleteReview.Size = new System.Drawing.Size(279, 69);
            this.button_deleteReview.TabIndex = 33;
            this.button_deleteReview.Text = "Delete review ";
            this.button_deleteReview.UseVisualStyleBackColor = true;
            this.button_deleteReview.Click += new System.EventHandler(this.button_deleteReview_Click);
            // 
            // richTb_search
            // 
            this.richTb_search.Location = new System.Drawing.Point(1120, 386);
            this.richTb_search.Name = "richTb_search";
            this.richTb_search.Size = new System.Drawing.Size(475, 56);
            this.richTb_search.TabIndex = 34;
            this.richTb_search.Text = "";
            this.richTb_search.TextChanged += new System.EventHandler(this.richTb_search_TextChanged);
            // 
            // listB_findBook
            // 
            this.listB_findBook.FormattingEnabled = true;
            this.listB_findBook.ItemHeight = 48;
            this.listB_findBook.Location = new System.Drawing.Point(985, 562);
            this.listB_findBook.Name = "listB_findBook";
            this.listB_findBook.Size = new System.Drawing.Size(839, 244);
            this.listB_findBook.TabIndex = 35;
            this.listB_findBook.SelectedIndexChanged += new System.EventHandler(this.listB_findBook_SelectedIndexChanged);
            // 
            // lbl_override
            // 
            this.lbl_override.AutoSize = true;
            this.lbl_override.Location = new System.Drawing.Point(1058, 1149);
            this.lbl_override.Name = "lbl_override";
            this.lbl_override.Size = new System.Drawing.Size(0, 48);
            this.lbl_override.TabIndex = 36;
            // 
            // ReviewsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2378, 1267);
            this.Controls.Add(this.lbl_override);
            this.Controls.Add(this.listB_findBook);
            this.Controls.Add(this.richTb_search);
            this.Controls.Add(this.button_deleteReview);
            this.Controls.Add(this.richTb_AddView);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.tb_refresh);
            this.Controls.Add(this.button_AddView);
            this.Name = "ReviewsUser";
            this.Text = "ReviewsUser";
            this.Load += new System.EventHandler(this.ReviewsUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label26;
        private TextBox tb_refresh;
        private Button button_AddView;
        private RichTextBox richTb_AddView;
        private Button button_deleteReview;
        private RichTextBox richTb_search;
        private ListBox listB_findBook;
        private Label lbl_override;
    }
}