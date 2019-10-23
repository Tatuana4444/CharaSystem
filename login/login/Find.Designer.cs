namespace login
{
    partial class Find
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
            this.LabelLogin = new System.Windows.Forms.Label();
            this.EditFind = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(83, 65);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(124, 39);
            this.LabelLogin.TabIndex = 6;
            this.LabelLogin.Text = "Найти:";
            // 
            // EditFind
            // 
            this.EditFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditFind.Location = new System.Drawing.Point(90, 107);
            this.EditFind.Name = "EditFind";
            this.EditFind.Size = new System.Drawing.Size(480, 45);
            this.EditFind.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ФИО ученика",
            "Дата рождения",
            "Номер свидетельства о рождении/паспорта",
            "Адрес",
            "Жилищные условия",
            "Состояние здаровья",
            "Поведение",
            "Состоит на учете в школе",
            "Состоит на учете в полиции",
            "ФИО матери",
            "ФИО отца",
            "Количество братьев/сестер",
            "Примечание",
            "Место работы матери",
            "Место работы отца",
            "Все"});
            this.comboBox1.Location = new System.Drawing.Point(90, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(480, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Все";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Критерий:";
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEnter.Location = new System.Drawing.Point(180, 340);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(313, 55);
            this.ButtonEnter.TabIndex = 9;
            this.ButtonEnter.Text = "Найти";
            this.ButtonEnter.UseVisualStyleBackColor = false;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(651, 472);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.EditFind);
            this.Name = "Find";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox EditFind;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEnter;
    }
}