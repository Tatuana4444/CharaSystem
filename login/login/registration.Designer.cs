namespace login
{
    partial class registration
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
            this.EditLogin = new System.Windows.Forms.TextBox();
            this.EditPass = new System.Windows.Forms.TextBox();
            this.regbutton = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditPass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditLogin
            // 
            this.EditLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditLogin.Location = new System.Drawing.Point(89, 114);
            this.EditLogin.Name = "EditLogin";
            this.EditLogin.Size = new System.Drawing.Size(480, 45);
            this.EditLogin.TabIndex = 2;
            this.EditLogin.TextChanged += new System.EventHandler(this.EditLogin_TextChanged);
            // 
            // EditPass
            // 
            this.EditPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPass.Location = new System.Drawing.Point(89, 252);
            this.EditPass.Name = "EditPass";
            this.EditPass.PasswordChar = '*';
            this.EditPass.Size = new System.Drawing.Size(480, 45);
            this.EditPass.TabIndex = 3;
            this.EditPass.TextChanged += new System.EventHandler(this.EditLogin_TextChanged);
            // 
            // regbutton
            // 
            this.regbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regbutton.Enabled = false;
            this.regbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regbutton.Location = new System.Drawing.Point(173, 498);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(313, 55);
            this.regbutton.TabIndex = 7;
            this.regbutton.Text = "Зарегистрироваться";
            this.regbutton.UseVisualStyleBackColor = false;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(82, 72);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(433, 39);
            this.LabelLogin.TabIndex = 8;
            this.LabelLogin.Text = "Введите название школы:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.ForeColor = System.Drawing.Color.White;
            this.LabelPassword.Location = new System.Drawing.Point(92, 210);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(282, 39);
            this.LabelPassword.TabIndex = 9;
            this.LabelPassword.Text = "Введите пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Повторите пароль:";
            // 
            // EditPass2
            // 
            this.EditPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPass2.Location = new System.Drawing.Point(89, 392);
            this.EditPass2.Name = "EditPass2";
            this.EditPass2.PasswordChar = '*';
            this.EditPass2.Size = new System.Drawing.Size(480, 45);
            this.EditPass2.TabIndex = 10;
            this.EditPass2.TextChanged += new System.EventHandler(this.EditLogin_TextChanged);
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::login.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(644, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditPass2);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.EditPass);
            this.Controls.Add(this.EditLogin);
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharaSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditLogin;
        private System.Windows.Forms.TextBox EditPass;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditPass2;
    }
}