using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Текстовые документы(Документ.txt)|Документ.txt|Все файлы(Документ.Документ)|Документ.Документ";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Вы хотите сохранить Документ?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (save == DialogResult.Yes)
            {
                Form activeChild = this;
                RichTextBox editBox = (RichTextBox)activeChild.ActiveControl;
                string str = editBox.Text;
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, str);
            }
        }
    }
}
