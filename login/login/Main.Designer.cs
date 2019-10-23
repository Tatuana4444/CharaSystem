namespace login
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отсортироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыКлассовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listClass = new System.Windows.Forms.ListView();
            this.Forms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PipulsInfo = new System.Windows.Forms.ListView();
            this.Numb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChildName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Passport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaceNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Health = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.behavior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Shool = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Polic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MotherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FatherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broth_sistrer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FamilyNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MotherWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FatherWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.параметрыToolStripMenuItem,
            this.параметрыКлассовToolStripMenuItem,
            this.найтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1578, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.отправитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.закрытьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Файл";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // отправитьToolStripMenuItem
            // 
            this.отправитьToolStripMenuItem.Name = "отправитьToolStripMenuItem";
            this.отправитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.отправитьToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.отправитьToolStripMenuItem.Text = "Отправить";
            this.отправитьToolStripMenuItem.Click += new System.EventHandler(this.SendToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(206, 6);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.отсортироватьToolStripMenuItem1});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.параметрыToolStripMenuItem.Text = "Параметры учеников";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Insert)));
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.UpdataToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // отсортироватьToolStripMenuItem1
            // 
            this.отсортироватьToolStripMenuItem1.Name = "отсортироватьToolStripMenuItem1";
            this.отсортироватьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.отсортироватьToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.отсортироватьToolStripMenuItem1.Text = "Отсортировать";
            this.отсортироватьToolStripMenuItem1.Click += new System.EventHandler(this.SortToolStripMenuItem1_Click);
            // 
            // параметрыКлассовToolStripMenuItem
            // 
            this.параметрыКлассовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClass,
            this.редактироватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.параметрыКлассовToolStripMenuItem.Name = "параметрыКлассовToolStripMenuItem";
            this.параметрыКлассовToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.параметрыКлассовToolStripMenuItem.Text = "Параметры классов";
            // 
            // AddClass
            // 
            this.AddClass.Name = "AddClass";
            this.AddClass.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert)));
            this.AddClass.Size = new System.Drawing.Size(273, 26);
            this.AddClass.Text = "Добавить";
            this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
            // 
            // редактироватьToolStripMenuItem1
            // 
            this.редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            this.редактироватьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.редактироватьToolStripMenuItem1.Size = new System.Drawing.Size(273, 26);
            this.редактироватьToolStripMenuItem1.Text = "Редактировать";
            this.редактироватьToolStripMenuItem1.Click += new System.EventHandler(this.UpDataToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(273, 26);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.найтиToolStripMenuItem.Text = "Найти...";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 32);
            // 
            // listClass
            // 
            this.listClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Forms});
            this.listClass.FullRowSelect = true;
            this.listClass.GridLines = true;
            this.listClass.Location = new System.Drawing.Point(1334, 31);
            this.listClass.MultiSelect = false;
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(253, 597);
            this.listClass.TabIndex = 2;
            this.listClass.UseCompatibleStateImageBehavior = false;
            this.listClass.View = System.Windows.Forms.View.Details;
            this.listClass.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listClass_ItemSelectionChanged);
            // 
            // Forms
            // 
            this.Forms.Text = "Класс";
            this.Forms.Width = 177;
            // 
            // PipulsInfo
            // 
            this.PipulsInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numb,
            this.ChildName,
            this.Birthday,
            this.Passport,
            this.Place,
            this.PlaceNote,
            this.Health,
            this.behavior,
            this.Shool,
            this.Polic,
            this.MotherName,
            this.FatherName,
            this.Broth_sistrer,
            this.FamilyNote,
            this.MotherWork,
            this.FatherWork});
            this.PipulsInfo.FullRowSelect = true;
            this.PipulsInfo.GridLines = true;
            this.PipulsInfo.Location = new System.Drawing.Point(0, 31);
            this.PipulsInfo.MultiSelect = false;
            this.PipulsInfo.Name = "PipulsInfo";
            this.PipulsInfo.Size = new System.Drawing.Size(1335, 597);
            this.PipulsInfo.TabIndex = 3;
            this.PipulsInfo.UseCompatibleStateImageBehavior = false;
            this.PipulsInfo.View = System.Windows.Forms.View.Details;
            // 
            // Numb
            // 
            this.Numb.Text = "№";
            this.Numb.Width = 25;
            // 
            // ChildName
            // 
            this.ChildName.Text = "ФИО";
            this.ChildName.Width = 200;
            // 
            // Birthday
            // 
            this.Birthday.Text = "День рождения";
            this.Birthday.Width = 111;
            // 
            // Passport
            // 
            this.Passport.Text = "№паспорта";
            this.Passport.Width = 105;
            // 
            // Place
            // 
            this.Place.Text = "Адрес";
            this.Place.Width = 200;
            // 
            // PlaceNote
            // 
            this.PlaceNote.Text = "Условия";
            this.PlaceNote.Width = 130;
            // 
            // Health
            // 
            this.Health.Text = "Здоровье";
            this.Health.Width = 100;
            // 
            // behavior
            // 
            this.behavior.Text = "Поведение";
            this.behavior.Width = 100;
            // 
            // Shool
            // 
            this.Shool.Text = "Учет в школе";
            this.Shool.Width = 120;
            // 
            // Polic
            // 
            this.Polic.Text = "Учет в полиции";
            this.Polic.Width = 150;
            // 
            // MotherName
            // 
            this.MotherName.Text = "ФИО матери";
            this.MotherName.Width = 200;
            // 
            // FatherName
            // 
            this.FatherName.Text = "ФИО отца";
            this.FatherName.Width = 200;
            // 
            // Broth_sistrer
            // 
            this.Broth_sistrer.Text = "Сетра/братья";
            this.Broth_sistrer.Width = 100;
            // 
            // FamilyNote
            // 
            this.FamilyNote.Text = "Примечание";
            this.FamilyNote.Width = 100;
            // 
            // MotherWork
            // 
            this.MotherWork.Text = "Место работы матери";
            this.MotherWork.Width = 200;
            // 
            // FatherWork
            // 
            this.FatherWork.Text = "Место работы отца";
            this.FatherWork.Width = 200;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 628);
            this.Controls.Add(this.PipulsInfo);
            this.Controls.Add(this.listClass);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharaSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыКлассовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClass;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ListView listClass;
        private System.Windows.Forms.ColumnHeader Forms;
        private System.Windows.Forms.ListView PipulsInfo;
        private System.Windows.Forms.ColumnHeader ChildName;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.ColumnHeader Passport;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.ColumnHeader PlaceNote;
        private System.Windows.Forms.ColumnHeader Numb;
        private System.Windows.Forms.ToolStripMenuItem отправитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader Health;
        private System.Windows.Forms.ColumnHeader behavior;
        private System.Windows.Forms.ColumnHeader Shool;
        private System.Windows.Forms.ColumnHeader Polic;
        private System.Windows.Forms.ColumnHeader MotherName;
        private System.Windows.Forms.ColumnHeader FatherName;
        private System.Windows.Forms.ColumnHeader Broth_sistrer;
        private System.Windows.Forms.ColumnHeader FamilyNote;
        private System.Windows.Forms.ColumnHeader MotherWork;
        private System.Windows.Forms.ColumnHeader FatherWork;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьToolStripMenuItem1;
    }
}