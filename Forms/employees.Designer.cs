using System.Drawing;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    partial class employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(434, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(387, 211);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(394, 42);
            this.usernametxt.TabIndex = 3;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(387, 311);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(394, 42);
            this.passwordtxt.TabIndex = 4;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.Black;
            this.Loginbtn.Location = new System.Drawing.Point(474, 398);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(201, 54);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click_1);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.backbtn.Location = new System.Drawing.Point(909, 565);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(176, 49);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click_1);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.exitbtn.Location = new System.Drawing.Point(84, 583);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(176, 49);
            this.exitbtn.TabIndex = 17;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click_1);
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1198, 697);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "employees";
            this.Text = "employees";
            this.Load += new System.EventHandler(this.employees_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Button Loginbtn;
        private Button backbtn;
        private Button exitbtn;
    }
}