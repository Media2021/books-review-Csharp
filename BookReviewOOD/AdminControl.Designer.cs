namespace BookReviews
{
    partial class AdminControl
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
            this.lbl_empId = new System.Windows.Forms.Label();
            this.tb_EMPId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dtEMP = new System.Windows.Forms.Button();
            this.lblBookType = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.tb_empPassword = new System.Windows.Forms.TextBox();
            this.tb_empName = new System.Windows.Forms.TextBox();
            this.btn_addEMP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_bsn = new System.Windows.Forms.TextBox();
            this.btn_logout1 = new System.Windows.Forms.Button();
            this.comboB_role = new System.Windows.Forms.ComboBox();
            this.lbl_override = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_empId
            // 
            this.lbl_empId.AutoSize = true;
            this.lbl_empId.Location = new System.Drawing.Point(128, 273);
            this.lbl_empId.Name = "lbl_empId";
            this.lbl_empId.Size = new System.Drawing.Size(216, 48);
            this.lbl_empId.TabIndex = 66;
            this.lbl_empId.Text = "employee id";
            // 
            // tb_EMPId
            // 
            this.tb_EMPId.Location = new System.Drawing.Point(450, 266);
            this.tb_EMPId.Name = "tb_EMPId";
            this.tb_EMPId.Size = new System.Drawing.Size(300, 55);
            this.tb_EMPId.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1017, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 86);
            this.label1.TabIndex = 64;
            this.label1.Text = "Read To Heal";
            // 
            // btn_dtEMP
            // 
            this.btn_dtEMP.Location = new System.Drawing.Point(450, 920);
            this.btn_dtEMP.Name = "btn_dtEMP";
            this.btn_dtEMP.Size = new System.Drawing.Size(300, 69);
            this.btn_dtEMP.TabIndex = 62;
            this.btn_dtEMP.Text = "Delete employee";
            this.btn_dtEMP.UseVisualStyleBackColor = true;
            this.btn_dtEMP.Click += new System.EventHandler(this.btn_dtEMP_Click);
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(128, 611);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(87, 48);
            this.lblBookType.TabIndex = 60;
            this.lblBookType.Text = "BSN";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(128, 495);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(170, 48);
            this.lblBookAuthor.TabIndex = 59;
            this.lblBookAuthor.Text = "password";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(128, 392);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(108, 48);
            this.lblBookName.TabIndex = 58;
            this.lblBookName.Text = "name";
            // 
            // tb_empPassword
            // 
            this.tb_empPassword.Location = new System.Drawing.Point(450, 495);
            this.tb_empPassword.Name = "tb_empPassword";
            this.tb_empPassword.Size = new System.Drawing.Size(300, 55);
            this.tb_empPassword.TabIndex = 55;
            // 
            // tb_empName
            // 
            this.tb_empName.Location = new System.Drawing.Point(450, 385);
            this.tb_empName.Name = "tb_empName";
            this.tb_empName.Size = new System.Drawing.Size(300, 55);
            this.tb_empName.TabIndex = 54;
            // 
            // btn_addEMP
            // 
            this.btn_addEMP.Location = new System.Drawing.Point(128, 920);
            this.btn_addEMP.Name = "btn_addEMP";
            this.btn_addEMP.Size = new System.Drawing.Size(269, 69);
            this.btn_addEMP.TabIndex = 53;
            this.btn_addEMP.Text = "Add employee";
            this.btn_addEMP.UseVisualStyleBackColor = true;
            this.btn_addEMP.Click += new System.EventHandler(this.btn_addEMP_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(946, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 57;
            this.dataGridView1.Size = new System.Drawing.Size(1620, 450);
            this.dataGridView1.TabIndex = 52;
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
            this.Column7.HeaderText = "Password";
            this.Column7.MinimumWidth = 15;
            this.Column7.Name = "Column7";
            this.Column7.Width = 300;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "bsn";
            this.Column8.MinimumWidth = 15;
            this.Column8.Name = "Column8";
            this.Column8.Width = 300;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Role";
            this.Column1.MinimumWidth = 15;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // tb_bsn
            // 
            this.tb_bsn.Location = new System.Drawing.Point(450, 620);
            this.tb_bsn.Name = "tb_bsn";
            this.tb_bsn.Size = new System.Drawing.Size(300, 55);
            this.tb_bsn.TabIndex = 67;
            // 
            // btn_logout1
            // 
            this.btn_logout1.Location = new System.Drawing.Point(2295, 1016);
            this.btn_logout1.Name = "btn_logout1";
            this.btn_logout1.Size = new System.Drawing.Size(300, 69);
            this.btn_logout1.TabIndex = 68;
            this.btn_logout1.Text = "log out";
            this.btn_logout1.UseVisualStyleBackColor = true;
            this.btn_logout1.Click += new System.EventHandler(this.btn_logout1_Click);
            // 
            // comboB_role
            // 
            this.comboB_role.FormattingEnabled = true;
            this.comboB_role.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.comboB_role.Location = new System.Drawing.Point(387, 750);
            this.comboB_role.Name = "comboB_role";
            this.comboB_role.Size = new System.Drawing.Size(363, 56);
            this.comboB_role.TabIndex = 69;
            // 
            // lbl_override
            // 
            this.lbl_override.AutoSize = true;
            this.lbl_override.Location = new System.Drawing.Point(1058, 1002);
            this.lbl_override.Name = "lbl_override";
            this.lbl_override.Size = new System.Drawing.Size(0, 48);
            this.lbl_override.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 750);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 48);
            this.label2.TabIndex = 71;
            this.label2.Text = "Role";
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2663, 1121);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_override);
            this.Controls.Add(this.comboB_role);
            this.Controls.Add(this.btn_logout1);
            this.Controls.Add(this.tb_bsn);
            this.Controls.Add(this.lbl_empId);
            this.Controls.Add(this.tb_EMPId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dtEMP);
            this.Controls.Add(this.lblBookType);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.tb_empPassword);
            this.Controls.Add(this.tb_empName);
            this.Controls.Add(this.btn_addEMP);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminControl";
            this.Text = "AdminControl";
            this.Load += new System.EventHandler(this.AdminControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_empId;
        private TextBox tb_EMPId;
        private Label label1;
        private Button btn_dtEMP;
        private Label lblBookType;
        private Label lblBookAuthor;
        private Label lblBookName;
        private TextBox tb_empPassword;
        private TextBox tb_empName;
        private Button btn_addEMP;
        private DataGridView dataGridView1;
        private TextBox tb_bsn;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button btn_logout1;
        private ComboBox comboB_role;
        private DataGridViewTextBoxColumn Column1;
        private Label lbl_override;
        private Label label2;
    }
}