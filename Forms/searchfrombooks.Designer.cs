using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class searchfrombooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchfrombooks));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texttxt = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.bookdataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksstockBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new LibraryManagementSystem.libraryManagementDataSet();
            this.booksstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backbtn = new System.Windows.Forms.Button();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksstockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_stockTableAdapter = new LibraryManagementSystem.libraryManagementDataSetTableAdapters.books_stockTableAdapter();
            this.searchbtnn = new System.Windows.Forms.Button();
            this.refbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksstockBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksstockBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(345, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(59, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            // 
            // texttxt
            // 
            this.texttxt.AutoSize = true;
            this.texttxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.texttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttxt.Location = new System.Drawing.Point(188, 83);
            this.texttxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texttxt.Name = "texttxt";
            this.texttxt.Size = new System.Drawing.Size(47, 25);
            this.texttxt.TabIndex = 4;
            this.texttxt.Text = "text";
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchtxt.Location = new System.Drawing.Point(258, 80);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(296, 30);
            this.searchtxt.TabIndex = 5;
            // 
            // bookdataGridView1
            // 
            this.bookdataGridView1.AllowUserToAddRows = false;
            this.bookdataGridView1.AllowUserToDeleteRows = false;
            this.bookdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.bookdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookdataGridView1.Location = new System.Drawing.Point(26, 131);
            this.bookdataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.bookdataGridView1.Name = "bookdataGridView1";
            this.bookdataGridView1.ReadOnly = true;
            this.bookdataGridView1.RowHeadersWidth = 62;
            this.bookdataGridView1.RowTemplate.Height = 28;
            this.bookdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookdataGridView1.Size = new System.Drawing.Size(850, 282);
            this.bookdataGridView1.TabIndex = 6;
            this.bookdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookdataGridView1_CellContentClick_1);
            // 
            // booksstockBindingSource2
            // 
            this.booksstockBindingSource2.DataMember = "books_stock";
            this.booksstockBindingSource2.DataSource = this.libraryManagementDataSet;
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "libraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksstockBindingSource
            // 
            this.booksstockBindingSource.DataMember = "books_stock";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(808, 442);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(97, 32);
            this.backbtn.TabIndex = 8;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 149;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "title";
            this.title.MinimumWidth = 8;
            this.title.Name = "title";
            this.title.Width = 150;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "isbn";
            this.isbn.MinimumWidth = 8;
            this.isbn.Name = "isbn";
            this.isbn.Width = 150;
            // 
            // booksstockBindingSource1
            // 
            this.booksstockBindingSource1.DataMember = "books_stock";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "title";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "isbn";
            this.dataGridViewTextBoxColumn1.HeaderText = "isbn";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "isbn";
            this.dataGridViewTextBoxColumn2.HeaderText = "isbn";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // books_stockTableAdapter
            // 
            this.books_stockTableAdapter.ClearBeforeFill = true;
            // 
            // searchbtnn
            // 
            this.searchbtnn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchbtnn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtnn.Location = new System.Drawing.Point(572, 77);
            this.searchbtnn.Name = "searchbtnn";
            this.searchbtnn.Size = new System.Drawing.Size(95, 33);
            this.searchbtnn.TabIndex = 11;
            this.searchbtnn.Text = "search";
            this.searchbtnn.UseVisualStyleBackColor = false;
            this.searchbtnn.Click += new System.EventHandler(this.searchbtnn_Click);
            // 
            // refbtn
            // 
            this.refbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refbtn.Location = new System.Drawing.Point(673, 77);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(122, 29);
            this.refbtn.TabIndex = 12;
            this.refbtn.Text = "refresh";
            this.refbtn.UseVisualStyleBackColor = false;
            this.refbtn.Click += new System.EventHandler(this.refbtn_Click);
            // 
            // searchfrombooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(938, 494);
            this.Controls.Add(this.refbtn);
            this.Controls.Add(this.searchbtnn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.bookdataGridView1);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.texttxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchfrombooks";
            this.Text = "searchfrombooks";
            this.Load += new System.EventHandler(this.searchfrombooks_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bookdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksstockBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksstockBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label texttxt;
        private TextBox searchtxt;
        private DataGridView bookdataGridView1;
        private BindingSource libraryManagementDataSetBindingSource;
        private BindingSource booksstockBindingSource;
        private Button backbtn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn isbn;
        private BindingSource booksstockBindingSource1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publicationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private LibraryManagementSystem.libraryManagementDataSet libraryManagementDataSet;
        private BindingSource booksstockBindingSource2;
        private LibraryManagementSystem.libraryManagementDataSetTableAdapters.books_stockTableAdapter books_stockTableAdapter;
        private Button searchbtnn;
        private Button refbtn;
    }
}