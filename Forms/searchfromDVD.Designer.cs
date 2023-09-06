using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class searchfromDVD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchfromDVD));
            this.label2 = new System.Windows.Forms.Label();
            this.texttxt = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Label();
            this.refreshbtb = new System.Windows.Forms.Label();
            this.DVDgrdview = new System.Windows.Forms.DataGridView();
            this.dVDstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DVDgrdview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDstockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(307, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search DVD";
            // 
            // texttxt
            // 
            this.texttxt.AutoSize = true;
            this.texttxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.texttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttxt.Location = new System.Drawing.Point(135, 76);
            this.texttxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texttxt.Name = "texttxt";
            this.texttxt.Size = new System.Drawing.Size(51, 26);
            this.texttxt.TabIndex = 17;
            this.texttxt.Text = "text";
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchtxt.Location = new System.Drawing.Point(190, 75);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(311, 30);
            this.searchtxt.TabIndex = 18;
            // 
            // searchbtn
            // 
            this.searchbtn.AutoSize = true;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.searchbtn.Location = new System.Drawing.Point(505, 77);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(77, 25);
            this.searchbtn.TabIndex = 19;
            this.searchbtn.Text = "search";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click_1);
            // 
            // refreshbtb
            // 
            this.refreshbtb.AutoSize = true;
            this.refreshbtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.refreshbtb.Location = new System.Drawing.Point(586, 75);
            this.refreshbtb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.refreshbtb.Name = "refreshbtb";
            this.refreshbtb.Size = new System.Drawing.Size(79, 25);
            this.refreshbtb.TabIndex = 20;
            this.refreshbtb.Text = "refresh";
            this.refreshbtb.Click += new System.EventHandler(this.refreshbtb_Click_1);
            // 
            // DVDgrdview
            // 
            this.DVDgrdview.AllowUserToAddRows = false;
            this.DVDgrdview.AllowUserToDeleteRows = false;
            this.DVDgrdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVDgrdview.Location = new System.Drawing.Point(25, 121);
            this.DVDgrdview.Margin = new System.Windows.Forms.Padding(2);
            this.DVDgrdview.Name = "DVDgrdview";
            this.DVDgrdview.ReadOnly = true;
            this.DVDgrdview.RowHeadersWidth = 62;
            this.DVDgrdview.RowTemplate.Height = 28;
            this.DVDgrdview.Size = new System.Drawing.Size(814, 330);
            this.DVDgrdview.TabIndex = 21;
            // 
            // dVDstockBindingSource
            // 
            this.dVDstockBindingSource.DataMember = "DVD_stock";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(739, 474);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(114, 36);
            this.backbtn.TabIndex = 22;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // searchfromDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 536);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.DVDgrdview);
            this.Controls.Add(this.refreshbtb);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.texttxt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchfromDVD";
            this.Text = "searchfromDVD";
            ((System.ComponentModel.ISupportInitialize)(this.DVDgrdview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVDstockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label texttxt;
        private TextBox searchtxt;
        private Label searchbtn;
        private Label refreshbtb;
        private DataGridView DVDgrdview;
        private Button backbtn;
        private BindingSource dVDstockBindingSource;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn actorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}