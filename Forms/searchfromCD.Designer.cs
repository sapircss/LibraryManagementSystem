using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class searchfromCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchfromCD));
            this.texttxt = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Label();
            this.refreshbtb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CDgrdview = new System.Windows.Forms.DataGridView();
            this.cDstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CDgrdview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDstockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // texttxt
            // 
            this.texttxt.AutoSize = true;
            this.texttxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.texttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttxt.Location = new System.Drawing.Point(188, 75);
            this.texttxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texttxt.Name = "texttxt";
            this.texttxt.Size = new System.Drawing.Size(47, 25);
            this.texttxt.TabIndex = 5;
            this.texttxt.Text = "text";
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchtxt.Location = new System.Drawing.Point(239, 70);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(2);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(296, 30);
            this.searchtxt.TabIndex = 6;
            // 
            // searchbtn
            // 
            this.searchbtn.AutoSize = true;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.searchbtn.Location = new System.Drawing.Point(560, 73);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(77, 25);
            this.searchbtn.TabIndex = 11;
            this.searchbtn.Text = "search";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click_1);
            // 
            // refreshbtb
            // 
            this.refreshbtb.AutoSize = true;
            this.refreshbtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.refreshbtb.Location = new System.Drawing.Point(641, 73);
            this.refreshbtb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.refreshbtb.Name = "refreshbtb";
            this.refreshbtb.Size = new System.Drawing.Size(79, 25);
            this.refreshbtb.TabIndex = 12;
            this.refreshbtb.Text = "refresh";
            this.refreshbtb.Click += new System.EventHandler(this.refreshbtb_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(354, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search CD";
            // 
            // CDgrdview
            // 
            this.CDgrdview.AllowUserToAddRows = false;
            this.CDgrdview.AllowUserToDeleteRows = false;
            this.CDgrdview.AutoGenerateColumns = false;
            this.CDgrdview.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.CDgrdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CDgrdview.DataSource = this.cDstockBindingSource;
            this.CDgrdview.Location = new System.Drawing.Point(30, 127);
            this.CDgrdview.Margin = new System.Windows.Forms.Padding(2);
            this.CDgrdview.Name = "CDgrdview";
            this.CDgrdview.ReadOnly = true;
            this.CDgrdview.RowHeadersWidth = 62;
            this.CDgrdview.RowTemplate.Height = 28;
            this.CDgrdview.Size = new System.Drawing.Size(837, 325);
            this.CDgrdview.TabIndex = 14;
            // 
            // cDstockBindingSource
            // 
            this.cDstockBindingSource.DataMember = "CD_stock";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(788, 477);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(97, 39);
            this.backbtn.TabIndex = 15;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // searchfromCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 537);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.CDgrdview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshbtb);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.texttxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchfromCD";
            this.Text = "searchfromCD";
            ((System.ComponentModel.ISupportInitialize)(this.CDgrdview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDstockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label texttxt;
        private TextBox searchtxt;
        private Label searchbtn;
        private Label refreshbtb;
        private Label label2;
        private DataGridView CDgrdview;
        private Button backbtn;
        private BindingSource cDstockBindingSource;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shelfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}