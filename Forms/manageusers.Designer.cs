using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class manageusers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageusers));
            this.label2 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.usersgridviews = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet2 = new LibraryManagementSystem.libraryManagementDataSet2();
            this.data_CustomersTableAdapter = new LibraryManagementSystem.libraryManagementDataSet2TableAdapters.Data_CustomersTableAdapter();
            this.updatebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.useridtxt = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.refrshbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersgridviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(333, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Users Management";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(905, 525);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(130, 40);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // usersgridviews
            // 
            this.usersgridviews.AutoGenerateColumns = false;
            this.usersgridviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersgridviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password,
            this.userID,
            this.address,
            this.phone,
            this.borrows});
            this.usersgridviews.DataSource = this.dataCustomersBindingSource;
            this.usersgridviews.Location = new System.Drawing.Point(65, 165);
            this.usersgridviews.Name = "usersgridviews";
            this.usersgridviews.RowHeadersWidth = 62;
            this.usersgridviews.Size = new System.Drawing.Size(987, 280);
            this.usersgridviews.TabIndex = 17;
            this.usersgridviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersgridviews_CellContentClick);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            dataGridViewCellStyle1.Format = "\"(###) ###-####\"";
            dataGridViewCellStyle1.NullValue = null;
            this.username.DefaultCellStyle = dataGridViewCellStyle1;
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.Width = 150;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            dataGridViewCellStyle2.Format = "\"(###) ###-####\"";
            dataGridViewCellStyle2.NullValue = null;
            this.password.DefaultCellStyle = dataGridViewCellStyle2;
            this.password.HeaderText = "password";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            this.password.Width = 150;
            // 
            // userID
            // 
            this.userID.DataPropertyName = "userID";
            this.userID.HeaderText = "userID";
            this.userID.MinimumWidth = 8;
            this.userID.Name = "userID";
            this.userID.Width = 150;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.Width = 150;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "phone";
            this.phone.MinimumWidth = 8;
            this.phone.Name = "phone";
            this.phone.Width = 150;
            // 
            // borrows
            // 
            this.borrows.DataPropertyName = "borrows";
            this.borrows.HeaderText = "borrows";
            this.borrows.MinimumWidth = 8;
            this.borrows.Name = "borrows";
            this.borrows.Width = 150;
            // 
            // dataCustomersBindingSource
            // 
            this.dataCustomersBindingSource.DataMember = "Data_Customers";
            this.dataCustomersBindingSource.DataSource = this.libraryManagementDataSet2;
            // 
            // libraryManagementDataSet2
            // 
            this.libraryManagementDataSet2.DataSetName = "libraryManagementDataSet2";
            this.libraryManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_CustomersTableAdapter
            // 
            this.data_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(76, 461);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(154, 33);
            this.updatebtn.TabIndex = 18;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "user ID";
            // 
            // useridtxt
            // 
            this.useridtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridtxt.Location = new System.Drawing.Point(340, 107);
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(272, 30);
            this.useridtxt.TabIndex = 22;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(643, 103);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(127, 34);
            this.search.TabIndex = 23;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // refrshbtn
            // 
            this.refrshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refrshbtn.Location = new System.Drawing.Point(259, 461);
            this.refrshbtn.Name = "refrshbtn";
            this.refrshbtn.Size = new System.Drawing.Size(117, 34);
            this.refrshbtn.TabIndex = 24;
            this.refrshbtn.Text = "refresh";
            this.refrshbtn.UseVisualStyleBackColor = true;
            this.refrshbtn.Click += new System.EventHandler(this.refrshbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(404, 462);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(154, 33);
            this.deletebtn.TabIndex = 25;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // manageusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1076, 582);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.refrshbtn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.useridtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.usersgridviews);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "manageusers";
            this.Text = "manageusers";
            this.Load += new System.EventHandler(this.manageusers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersgridviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button backbtn;
        private DataGridView usersgridviews;
        private LibraryManagementSystem.libraryManagementDataSet2 libraryManagementDataSet2;
        private BindingSource dataCustomersBindingSource;
        private LibraryManagementSystem.libraryManagementDataSet2TableAdapters.Data_CustomersTableAdapter data_CustomersTableAdapter;
        private Button updatebtn;
        private Label label3;
        private TextBox useridtxt;
        private Button search;
        private Button refrshbtn;
        private Button deletebtn;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn userID;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn borrows;
    }
}