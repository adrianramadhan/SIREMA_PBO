namespace SIREMA.antarmuka
{
    partial class LoginForm
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
            this.userId_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.userId_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.login_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userId_lbl
            // 
            this.userId_lbl.AutoSize = true;
            this.userId_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId_lbl.Location = new System.Drawing.Point(183, 122);
            this.userId_lbl.Name = "userId_lbl";
            this.userId_lbl.Size = new System.Drawing.Size(68, 16);
            this.userId_lbl.TabIndex = 0;
            this.userId_lbl.Text = "USER ID";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(183, 154);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(94, 16);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "PASSWORD";
            // 
            // userId_txt
            // 
            this.userId_txt.Location = new System.Drawing.Point(291, 119);
            this.userId_txt.Name = "userId_txt";
            this.userId_txt.Size = new System.Drawing.Size(255, 22);
            this.userId_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(291, 151);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(255, 22);
            this.password_txt.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(186, 198);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(164, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(372, 198);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(174, 23);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.Location = new System.Drawing.Point(309, 49);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(117, 37);
            this.login_lbl.TabIndex = 6;
            this.login_lbl.Text = "LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 327);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.userId_txt);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.userId_lbl);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userId_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox userId_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label login_lbl;
    }
}