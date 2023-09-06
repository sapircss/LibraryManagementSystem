
using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class manageorders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manageorders));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.useridtxt = new System.Windows.Forms.TextBox();
            this.verifybtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.dataCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refreshbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemscmbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemtextbox = new System.Windows.Forms.TextBox();
            this.searchitembtn = new System.Windows.Forms.Button();
            this.refreshitembtn = new System.Windows.Forms.Button();
            this.itemsgridview = new System.Windows.Forms.DataGridView();
            this.borrow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.returnitem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.libraryManagementDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(337, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "order management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(139, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "user ID";
            // 
            // useridtxt
            // 
            this.useridtxt.Location = new System.Drawing.Point(240, 84);
            this.useridtxt.Margin = new System.Windows.Forms.Padding(2);
            this.useridtxt.Multiline = true;
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(285, 26);
            this.useridtxt.TabIndex = 10;
            // 
            // verifybtn
            // 
            this.verifybtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.verifybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifybtn.Location = new System.Drawing.Point(529, 81);
            this.verifybtn.Margin = new System.Windows.Forms.Padding(2);
            this.verifybtn.Name = "verifybtn";
            this.verifybtn.Size = new System.Drawing.Size(103, 30);
            this.verifybtn.TabIndex = 13;
            this.verifybtn.Text = "verify";
            this.verifybtn.UseVisualStyleBackColor = false;
            this.verifybtn.Click += new System.EventHandler(this.verifybtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(909, 536);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(94, 36);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // dataCustomersBindingSource
            // 
            this.dataCustomersBindingSource.DataMember = "Data_Customers";
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(636, 79);
            this.refreshbtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(90, 32);
            this.refreshbtn.TabIndex = 18;
            this.refreshbtn.Text = "refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(118, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "item type";
            // 
            // itemscmbox
            // 
            this.itemscmbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemscmbox.FormattingEnabled = true;
            this.itemscmbox.Items.AddRange(new object[] {
            "book",
            "CD",
            "DVD"});
            this.itemscmbox.Location = new System.Drawing.Point(249, 145);
            this.itemscmbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemscmbox.Name = "itemscmbox";
            this.itemscmbox.Size = new System.Drawing.Size(219, 34);
            this.itemscmbox.TabIndex = 20;
            this.itemscmbox.Text = "choose";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(503, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "text";
            // 
            // itemtextbox
            // 
            this.itemtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtextbox.Location = new System.Drawing.Point(568, 145);
            this.itemtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemtextbox.Name = "itemtextbox";
            this.itemtextbox.Size = new System.Drawing.Size(257, 35);
            this.itemtextbox.TabIndex = 22;
            // 
            // searchitembtn
            // 
            this.searchitembtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchitembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchitembtn.Location = new System.Drawing.Point(344, 204);
            this.searchitembtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchitembtn.Name = "searchitembtn";
            this.searchitembtn.Size = new System.Drawing.Size(93, 32);
            this.searchitembtn.TabIndex = 23;
            this.searchitembtn.Text = "search";
            this.searchitembtn.UseVisualStyleBackColor = false;
            this.searchitembtn.Click += new System.EventHandler(this.searchitembtn_Click_1);
            // 
            // refreshitembtn
            // 
            this.refreshitembtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.refreshitembtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshitembtn.Location = new System.Drawing.Point(574, 204);
            this.refreshitembtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshitembtn.Name = "refreshitembtn";
            this.refreshitembtn.Size = new System.Drawing.Size(122, 32);
            this.refreshitembtn.TabIndex = 24;
            this.refreshitembtn.Text = "refresh";
            this.refreshitembtn.UseVisualStyleBackColor = false;
            this.refreshitembtn.Click += new System.EventHandler(this.refreshitembtn_Click);
            // 
            // itemsgridview
            // 
            this.itemsgridview.AllowUserToDeleteRows = false;
            this.itemsgridview.AllowUserToOrderColumns = true;
            this.itemsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrow,
            this.returnitem});
            this.itemsgridview.Location = new System.Drawing.Point(109, 249);
            this.itemsgridview.Margin = new System.Windows.Forms.Padding(2);
            this.itemsgridview.Name = "itemsgridview";
            this.itemsgridview.ReadOnly = true;
            this.itemsgridview.RowHeadersWidth = 62;
            this.itemsgridview.RowTemplate.Height = 28;
            this.itemsgridview.Size = new System.Drawing.Size(876, 248);
            this.itemsgridview.TabIndex = 25;
            this.itemsgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsgridview_CellContentClick);
            // 
            // borrow
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.borrow.DefaultCellStyle = dataGridViewCellStyle1;
            this.borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrow.HeaderText = "borrow";
            this.borrow.MinimumWidth = 8;
            this.borrow.Name = "borrow";
            this.borrow.ReadOnly = true;
            this.borrow.Text = "borrow";
            this.borrow.UseColumnTextForButtonValue = true;
            this.borrow.Width = 150;
            // 
            // returnitem
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.returnitem.DefaultCellStyle = dataGridViewCellStyle2;
            this.returnitem.HeaderText = "return";
            this.returnitem.MinimumWidth = 8;
            this.returnitem.Name = "returnitem";
            this.returnitem.ReadOnly = true;
            this.returnitem.Text = "return";
            this.returnitem.UseColumnTextForButtonValue = true;
            this.returnitem.Width = 150;
            // 
            // manageorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1068, 610);
            this.Controls.Add(this.itemsgridview);
            this.Controls.Add(this.refreshitembtn);
            this.Controls.Add(this.searchitembtn);
            this.Controls.Add(this.itemtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemscmbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.verifybtn);
            this.Controls.Add(this.useridtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "manageorders";
            this.Text = "manageorders";
            this.Load += new System.EventHandler(this.manageorders_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox useridtxt;
        private Button verifybtn;
        private Button backbtn;
        private BindingSource dataCustomersBindingSource;
        private Button refreshbtn;
        private Label label1;
        private ComboBox itemscmbox;
        private Label label4;
        private TextBox itemtextbox;
        private Button searchitembtn;
        private Button refreshitembtn;
        private DataGridView itemsgridview;
        private BindingSource libraryManagementDataSet6BindingSource;
        private DataGridViewButtonColumn borrow;
        private DataGridViewButtonColumn returnitem;
    }
}