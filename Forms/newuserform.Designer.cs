using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class newuserform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newuserform));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.useridtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phonenumbertxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.savechangesbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(220, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "New User Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(245, 115);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(303, 29);
            this.usernametxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(245, 168);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(303, 30);
            this.passwordtxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "user ID";
            // 
            // useridtxt
            // 
            this.useridtxt.Location = new System.Drawing.Point(245, 215);
            this.useridtxt.Margin = new System.Windows.Forms.Padding(2);
            this.useridtxt.Multiline = true;
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(303, 33);
            this.useridtxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "phone number";
            // 
            // phonenumbertxt
            // 
            this.phonenumbertxt.Location = new System.Drawing.Point(245, 275);
            this.phonenumbertxt.Margin = new System.Windows.Forms.Padding(2);
            this.phonenumbertxt.Multiline = true;
            this.phonenumbertxt.Name = "phonenumbertxt";
            this.phonenumbertxt.Size = new System.Drawing.Size(303, 29);
            this.phonenumbertxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "address";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(245, 333);
            this.addresstxt.Margin = new System.Windows.Forms.Padding(2);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(303, 29);
            this.addresstxt.TabIndex = 14;
            // 
            // savechangesbtn
            // 
            this.savechangesbtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.savechangesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.savechangesbtn.Location = new System.Drawing.Point(307, 388);
            this.savechangesbtn.Margin = new System.Windows.Forms.Padding(2);
            this.savechangesbtn.Name = "savechangesbtn";
            this.savechangesbtn.Size = new System.Drawing.Size(137, 33);
            this.savechangesbtn.TabIndex = 15;
            this.savechangesbtn.Text = "save changes";
            this.savechangesbtn.UseVisualStyleBackColor = false;
            this.savechangesbtn.Click += new System.EventHandler(this.savechangesbtn_Click_1);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(701, 454);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(107, 39);
            this.backbtn.TabIndex = 17;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // newuserform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 504);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.savechangesbtn);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phonenumbertxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.useridtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "newuserform";
            this.Text = "newuserform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox usernametxt;
        private Label label3;
        private TextBox passwordtxt;
        private Label label4;
        private TextBox useridtxt;
        private Label label5;
        private TextBox phonenumbertxt;
        private Label label6;
        private TextBox addresstxt;
        private Button savechangesbtn;
        private Button backbtn;
    }
}