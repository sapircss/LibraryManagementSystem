using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class searchitems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchitems));
            this.label2 = new System.Windows.Forms.Label();
            this.itemcombobox = new System.Windows.Forms.ComboBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(321, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Bar";
            // 
            // itemcombobox
            // 
            this.itemcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemcombobox.FormattingEnabled = true;
            this.itemcombobox.Location = new System.Drawing.Point(308, 183);
            this.itemcombobox.Margin = new System.Windows.Forms.Padding(2);
            this.itemcombobox.Name = "itemcombobox";
            this.itemcombobox.Size = new System.Drawing.Size(231, 37);
            this.itemcombobox.TabIndex = 2;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchbtn.Location = new System.Drawing.Point(346, 238);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(140, 38);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(341, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "choose item";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.backbtn.Location = new System.Drawing.Point(658, 346);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(128, 43);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // searchitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 400);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.itemcombobox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "searchitems";
            this.Text = "searchitems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private ComboBox itemcombobox;
        private Button searchbtn;
        private Label label3;
        private Button backbtn;
    }
}