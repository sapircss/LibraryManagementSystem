using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class UsersConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersConsole));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.orderbtn);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 487);
            this.panel1.TabIndex = 1;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(58, 398);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(154, 37);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // orderbtn
            // 
            this.orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orderbtn.Location = new System.Drawing.Point(44, 226);
            this.orderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(191, 42);
            this.orderbtn.TabIndex = 1;
            this.orderbtn.Text = "my account";
            this.orderbtn.UseVisualStyleBackColor = true;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click_1);
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(44, 124);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(191, 41);
            this.searchbtn.TabIndex = 0;
            this.searchbtn.Text = "search book";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click_1);
            // 
            // UsersConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsersConsole";
            this.Text = "UsersConsole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button logoutbtn;
        private Label label1;
        private Button orderbtn;
        private Button searchbtn;
    }
}