using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class employeeConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeConsole));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mngstockbtn = new System.Windows.Forms.Button();
            this.manageusersbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.mngstockbtn);
            this.panel1.Controls.Add(this.manageusersbtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.orderbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 601);
            this.panel1.TabIndex = 0;
            // 
            // mngstockbtn
            // 
            this.mngstockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngstockbtn.Location = new System.Drawing.Point(58, 138);
            this.mngstockbtn.Name = "mngstockbtn";
            this.mngstockbtn.Size = new System.Drawing.Size(228, 41);
            this.mngstockbtn.TabIndex = 5;
            this.mngstockbtn.Text = "manage stock";
            this.mngstockbtn.UseVisualStyleBackColor = true;
            this.mngstockbtn.Click += new System.EventHandler(this.mngstockbtn_Click);
            // 
            // manageusersbtn
            // 
            this.manageusersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.manageusersbtn.Location = new System.Drawing.Point(58, 339);
            this.manageusersbtn.Margin = new System.Windows.Forms.Padding(2);
            this.manageusersbtn.Name = "manageusersbtn";
            this.manageusersbtn.Size = new System.Drawing.Size(228, 41);
            this.manageusersbtn.TabIndex = 4;
            this.manageusersbtn.Text = "manage users";
            this.manageusersbtn.UseVisualStyleBackColor = true;
            this.manageusersbtn.Click += new System.EventHandler(this.manageusersbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(82, 496);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(162, 43);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library Management";
            // 
            // orderbtn
            // 
            this.orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.orderbtn.Location = new System.Drawing.Point(58, 238);
            this.orderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(228, 43);
            this.orderbtn.TabIndex = 1;
            this.orderbtn.Text = "manage orders";
            this.orderbtn.UseVisualStyleBackColor = true;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click_1);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(846, 544);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(150, 33);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // employeeConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 601);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "employeeConsole";
            this.Text = "employeeConsole";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button orderbtn;
        private Label label1;
        private Button logoutbtn;
        private Button manageusersbtn;
        private Button backbtn;
        private Button mngstockbtn;
    }
}