namespace login
{
    partial class Authorized
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Label();
            this.EditLogin = new System.Windows.Forms.TextBox();
            this.EditPassword = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.regbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header.Location = new System.Drawing.Point(187, 68);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(992, 67);
            this.header.TabIndex = 0;
            this.header.Text = "Добро пожаловать в CharaSystem!";
            // 
            // EditLogin
            // 
            this.EditLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditLogin.Location = new System.Drawing.Point(448, 237);
            this.EditLogin.Name = "EditLogin";
            this.EditLogin.Size = new System.Drawing.Size(480, 45);
            this.EditLogin.TabIndex = 1;
            this.EditLogin.TextChanged += new System.EventHandler(this.EditLogin_TextChanged);
            // 
            // EditPassword
            // 
            this.EditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPassword.Location = new System.Drawing.Point(448, 361);
            this.EditPassword.Name = "EditPassword";
            this.EditPassword.PasswordChar = '*';
            this.EditPassword.Size = new System.Drawing.Size(480, 45);
            this.EditPassword.TabIndex = 2;
            this.EditPassword.TextChanged += new System.EventHandler(this.EditLogin_TextChanged);
            this.EditPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditPassword_KeyPress);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEnter.Enabled = false;
            this.ButtonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEnter.Location = new System.Drawing.Point(718, 506);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(313, 55);
            this.ButtonEnter.TabIndex = 3;
            this.ButtonEnter.Text = "Войти";
            this.ButtonEnter.UseVisualStyleBackColor = false;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(441, 195);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(433, 39);
            this.LabelLogin.TabIndex = 4;
            this.LabelLogin.Text = "Введите название школы:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Transparent;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.ForeColor = System.Drawing.Color.White;
            this.LabelPassword.Location = new System.Drawing.Point(441, 319);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(282, 39);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Введите пароль:";
            // 
            // regbutton
            // 
            this.regbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.regbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regbutton.Location = new System.Drawing.Point(357, 506);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(313, 55);
            this.regbutton.TabIndex = 6;
            this.regbutton.Text = "Регистрация";
            this.regbutton.UseVisualStyleBackColor = false;
            this.regbutton.Click += new System.EventHandler(this.regbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Authorized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::login.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1333, 628);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.EditPassword);
            this.Controls.Add(this.EditLogin);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorized";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharaSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox EditLogin;
        private System.Windows.Forms.TextBox EditPassword;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

