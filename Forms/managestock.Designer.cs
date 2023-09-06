namespace LibraryManagementSystem
{
    partial class managestock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(managestock));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemscmbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemtextbox = new System.Windows.Forms.TextBox();
            this.stockgridview = new System.Windows.Forms.DataGridView();
            this.updatebtn = new System.Windows.Forms.Button();
            this.refrshbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(348, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(196, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 20;
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
            this.itemscmbox.Location = new System.Drawing.Point(310, 110);
            this.itemscmbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemscmbox.Name = "itemscmbox";
            this.itemscmbox.Size = new System.Drawing.Size(189, 34);
            this.itemscmbox.TabIndex = 21;
            this.itemscmbox.Text = "choose";
            this.itemscmbox.SelectedIndexChanged += new System.EventHandler(this.itemscmbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(577, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "text";
            // 
            // itemtextbox
            // 
            this.itemtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtextbox.Location = new System.Drawing.Point(642, 113);
            this.itemtextbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemtextbox.Name = "itemtextbox";
            this.itemtextbox.Size = new System.Drawing.Size(285, 35);
            this.itemtextbox.TabIndex = 23;
            this.itemtextbox.TextChanged += new System.EventHandler(this.itemtextbox_TextChanged);
            // 
            // stockgridview
            // 
            this.stockgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockgridview.Location = new System.Drawing.Point(16, 217);
            this.stockgridview.Name = "stockgridview";
            this.stockgridview.RowHeadersWidth = 62;
            this.stockgridview.Size = new System.Drawing.Size(1061, 326);
            this.stockgridview.TabIndex = 24;
            this.stockgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockgridview_CellContentClick);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(345, 563);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(154, 33);
            this.updatebtn.TabIndex = 25;
            this.updatebtn.Text = "update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // refrshbtn
            // 
            this.refrshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refrshbtn.Location = new System.Drawing.Point(730, 563);
            this.refrshbtn.Name = "refrshbtn";
            this.refrshbtn.Size = new System.Drawing.Size(117, 34);
            this.refrshbtn.TabIndex = 26;
            this.refrshbtn.Text = "refresh";
            this.refrshbtn.UseVisualStyleBackColor = true;
            this.refrshbtn.Click += new System.EventHandler(this.refrshbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(528, 563);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(154, 33);
            this.deletebtn.TabIndex = 27;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(914, 617);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(153, 40);
            this.backbtn.TabIndex = 28;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(454, 167);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(154, 33);
            this.searchbtn.TabIndex = 31;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // managestock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1117, 676);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.refrshbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.stockgridview);
            this.Controls.Add(this.itemtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemscmbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "managestock";
            this.Text = "managestock";
            ((System.ComponentModel.ISupportInitialize)(this.stockgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox itemscmbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemtextbox;
        private System.Windows.Forms.DataGridView stockgridview;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button refrshbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button searchbtn;
    }
}