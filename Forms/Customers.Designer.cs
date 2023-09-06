namespace librarymanagementsystem
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.newuserbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(513, 262);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(442, 38);
            this.usernametxt.TabIndex = 4;
            this.usernametxt.TextChanged += new System.EventHandler(this.usernametxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(513, 362);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(442, 42);
            this.passwordtxt.TabIndex = 6;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.Black;
            this.Loginbtn.Location = new System.Drawing.Point(603, 511);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(182, 71);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(1126, 722);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(177, 48);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // newuserbtn
            // 
            this.newuserbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.newuserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newuserbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newuserbtn.ForeColor = System.Drawing.Color.Black;
            this.newuserbtn.Location = new System.Drawing.Point(394, 606);
            this.newuserbtn.Name = "newuserbtn";
            this.newuserbtn.Size = new System.Drawing.Size(614, 63);
            this.newuserbtn.TabIndex = 17;
            this.newuserbtn.Text = "new costumer? sign here";
            this.newuserbtn.UseVisualStyleBackColor = false;
            this.newuserbtn.Click += new System.EventHandler(this.newuserbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(130, 738);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(162, 46);
            this.exitbtn.TabIndex = 18;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1388, 823);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.newuserbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button newuserbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}