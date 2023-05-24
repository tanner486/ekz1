
namespace _16
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Создать = new System.Windows.Forms.ToolStripMenuItem();
            this.Открыть = new System.Windows.Forms.ToolStripMenuItem();
            this.Сохранить = new System.Windows.Forms.ToolStripMenuItem();
            this.Выход = new System.Windows.Forms.ToolStripMenuItem();
            this.Редактирование = new System.Windows.Forms.ToolStripMenuItem();
            this.Вырезать = new System.Windows.Forms.ToolStripMenuItem();
            this.Копировать = new System.Windows.Forms.ToolStripMenuItem();
            this.Вставить = new System.Windows.Forms.ToolStripMenuItem();
            this.Вид = new System.Windows.Forms.ToolStripMenuItem();
            this.Шрифт = new System.Windows.Forms.ToolStripMenuItem();
            this.Очистка = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.Редактирование,
            this.Вид,
            this.Очистка});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Создать,
            this.Открыть,
            this.Сохранить,
            this.Выход});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Создать
            // 
            this.Создать.Name = "Создать";
            this.Создать.Size = new System.Drawing.Size(180, 22);
            this.Создать.Text = "Создать";
            this.Создать.Click += new System.EventHandler(this.Создать_Click);
            // 
            // Открыть
            // 
            this.Открыть.Name = "Открыть";
            this.Открыть.Size = new System.Drawing.Size(180, 22);
            this.Открыть.Text = "Открыть";
            this.Открыть.Click += new System.EventHandler(this.Открыть_Click);
            // 
            // Сохранить
            // 
            this.Сохранить.Enabled = false;
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(180, 22);
            this.Сохранить.Text = "Сохранить";
            this.Сохранить.Click += new System.EventHandler(this.Сохранить_Click);
            // 
            // Выход
            // 
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(180, 22);
            this.Выход.Text = "Выход";
            this.Выход.Click += new System.EventHandler(this.Выход_Click);
            // 
            // Редактирование
            // 
            this.Редактирование.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Копировать,
            this.Вырезать,
            this.Вставить});
            this.Редактирование.Enabled = false;
            this.Редактирование.Name = "Редактирование";
            this.Редактирование.Size = new System.Drawing.Size(108, 20);
            this.Редактирование.Text = "Редактирование";
            // 
            // Вырезать
            // 
            this.Вырезать.Name = "Вырезать";
            this.Вырезать.Size = new System.Drawing.Size(180, 22);
            this.Вырезать.Text = "Вырезать";
            this.Вырезать.Click += new System.EventHandler(this.Вырезать_Click);
            // 
            // Копировать
            // 
            this.Копировать.Name = "Копировать";
            this.Копировать.Size = new System.Drawing.Size(180, 22);
            this.Копировать.Text = "Копировать";
            this.Копировать.Click += new System.EventHandler(this.Копировать_Click);
            // 
            // Вставить
            // 
            this.Вставить.Name = "Вставить";
            this.Вставить.Size = new System.Drawing.Size(180, 22);
            this.Вставить.Text = "Вставить";
            this.Вставить.Click += new System.EventHandler(this.Вставить_Click);
            // 
            // Вид
            // 
            this.Вид.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Шрифт});
            this.Вид.Enabled = false;
            this.Вид.Name = "Вид";
            this.Вид.Size = new System.Drawing.Size(39, 20);
            this.Вид.Text = "Вид";
            // 
            // Шрифт
            // 
            this.Шрифт.Name = "Шрифт";
            this.Шрифт.Size = new System.Drawing.Size(180, 22);
            this.Шрифт.Text = "Шрифт";
            this.Шрифт.Click += new System.EventHandler(this.Шрифт_Click);
            // 
            // Очистка
            // 
            this.Очистка.Enabled = false;
            this.Очистка.Name = "Очистка";
            this.Очистка.Size = new System.Drawing.Size(65, 20);
            this.Очистка.Text = "Очистка";
            this.Очистка.Click += new System.EventHandler(this.Очистка_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Текстовый редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Создать;
        private System.Windows.Forms.ToolStripMenuItem Открыть;
        private System.Windows.Forms.ToolStripMenuItem Сохранить;
        private System.Windows.Forms.ToolStripMenuItem Выход;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem Редактирование;
        private System.Windows.Forms.ToolStripMenuItem Вырезать;
        private System.Windows.Forms.ToolStripMenuItem Копировать;
        private System.Windows.Forms.ToolStripMenuItem Вставить;
        private System.Windows.Forms.ToolStripMenuItem Вид;
        private System.Windows.Forms.ToolStripMenuItem Шрифт;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem Очистка;
    }
}

