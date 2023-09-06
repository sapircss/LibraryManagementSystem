using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class userordersdetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userordersdetails));
            this.label1 = new System.Windows.Forms.Label();
            this.userordersgridview = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAccountSet = new LibraryManagementSystem.userAccountSet();
            this.backbtn = new System.Windows.Forms.Button();
            this.data_CustomersTableAdapter = new LibraryManagementSystem.userAccountSetTableAdapters.Data_CustomersTableAdapter();
            this.showbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userordersgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Account";
            // 
            // userordersgridview
            // 
            this.userordersgridview.AllowUserToAddRows = false;
            this.userordersgridview.AllowUserToDeleteRows = false;
            this.userordersgridview.AutoGenerateColumns = false;
            this.userordersgridview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.userordersgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userordersgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.borrowsDataGridViewTextBoxColumn});
            this.userordersgridview.DataSource = this.dataCustomersBindingSource;
            this.userordersgridview.Location = new System.Drawing.Point(35, 139);
            this.userordersgridview.Margin = new System.Windows.Forms.Padding(2);
            this.userordersgridview.Name = "userordersgridview";
            this.userordersgridview.ReadOnly = true;
            this.userordersgridview.RowHeadersWidth = 62;
            this.userordersgridview.RowTemplate.Height = 28;
            this.userordersgridview.Size = new System.Drawing.Size(760, 202);
            this.userordersgridview.TabIndex = 5;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // borrowsDataGridViewTextBoxColumn
            // 
            this.borrowsDataGridViewTextBoxColumn.DataPropertyName = "borrows";
            this.borrowsDataGridViewTextBoxColumn.HeaderText = "borrows";
            this.borrowsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.borrowsDataGridViewTextBoxColumn.Name = "borrowsDataGridViewTextBoxColumn";
            this.borrowsDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowsDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataCustomersBindingSource
            // 
            this.dataCustomersBindingSource.DataMember = "Data_Customers";
            this.dataCustomersBindingSource.DataSource = this.userAccountSet;
            // 
            // userAccountSet
            // 
            this.userAccountSet.DataSetName = "userAccountSet";
            this.userAccountSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(679, 407);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(142, 37);
            this.backbtn.TabIndex = 15;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // data_CustomersTableAdapter
            // 
            this.data_CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // showbtn
            // 
            this.showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.Location = new System.Drawing.Point(340, 106);
            this.showbtn.Margin = new System.Windows.Forms.Padding(2);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(133, 29);
            this.showbtn.TabIndex = 16;
            this.showbtn.Text = "show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // userordersdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 481);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.userordersgridview);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "userordersdetails";
            this.Text = "userordersdetails";
            this.Load += new System.EventHandler(this.userordersdetails_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.userordersgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView userordersgridview;
        private Button backbtn;
        private LibraryManagementSystem.userAccountSet userAccountSet;
        private BindingSource dataCustomersBindingSource;
        private LibraryManagementSystem.userAccountSetTableAdapters.Data_CustomersTableAdapter data_CustomersTableAdapter;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowsDataGridViewTextBoxColumn;
        private Button showbtn;
    }
}