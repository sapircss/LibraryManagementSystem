using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeloginbtn = new System.Windows.Forms.Button();
            this.Customerloginbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(297, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 172);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // employeeloginbtn
            // 
            this.employeeloginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employeeloginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.employeeloginbtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.employeeloginbtn.Location = new System.Drawing.Point(67, 389);
            this.employeeloginbtn.Margin = new System.Windows.Forms.Padding(2);
            this.employeeloginbtn.Name = "employeeloginbtn";
            this.employeeloginbtn.Size = new System.Drawing.Size(208, 36);
            this.employeeloginbtn.TabIndex = 5;
            this.employeeloginbtn.Text = "Employee";
            this.employeeloginbtn.UseVisualStyleBackColor = false;
            this.employeeloginbtn.Click += new System.EventHandler(this.employeeloginbtn_Click_1);
            // 
            // Customerloginbtn
            // 
            this.Customerloginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Customerloginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Customerloginbtn.Location = new System.Drawing.Point(706, 401);
            this.Customerloginbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Customerloginbtn.Name = "Customerloginbtn";
            this.Customerloginbtn.Size = new System.Drawing.Size(179, 36);
            this.Customerloginbtn.TabIndex = 6;
            this.Customerloginbtn.Text = "Customer";
            this.Customerloginbtn.UseVisualStyleBackColor = false;
            this.Customerloginbtn.Click += new System.EventHandler(this.Customerloginbtn_Click_1);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.exitbtn.Location = new System.Drawing.Point(407, 506);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(152, 36);
            this.exitbtn.TabIndex = 18;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click_1);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(954, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.Customerloginbtn);
            this.Controls.Add(this.employeeloginbtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "homepage";
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Button employeeloginbtn;
        private Button Customerloginbtn;
        private Button exitbtn;
    }
}

