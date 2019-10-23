namespace login
{
    partial class classchoose
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
            this.EditClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditClass
            // 
            this.EditClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditClass.Location = new System.Drawing.Point(537, 94);
            this.EditClass.Name = "EditClass";
            this.EditClass.Size = new System.Drawing.Size(92, 55);
            this.EditClass.TabIndex = 0;
            this.EditClass.TextChanged += new System.EventHandler(this.EditClass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите класс";
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonContinue.Location = new System.Drawing.Point(292, 205);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(268, 55);
            this.ButtonContinue.TabIndex = 4;
            this.ButtonContinue.Text = "Продолжить";
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // classchoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(812, 310);
            this.Controls.Add(this.ButtonContinue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "classchoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharaSystem";
            this.Load += new System.EventHandler(this.classchoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonContinue;
    }
}