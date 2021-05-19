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

namespace lr15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog(); // создание диалогового окна
            dlg.FullOpen = true; // открытие полной версии диалога
            dlg.ShowHelp = true; // разрешить пользователю получать справку
            dlg.Color = panelChooseColor.BackColor; // установка цвета панели в качестве начального цвета диалога

            if (dlg.ShowDialog() == DialogResult.OK) // получение результата выполнения диалога
            {
                panelChooseColor.BackColor = dlg.Color; // установка цвета панели
            }
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            dlg.Font = txtChooseFont.Font;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFont.Font = dlg.Font;
                txtChooseFont.ForeColor = dlg.Color;
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Выберите папку";
            dlg.ShowNewFolderButton = true;
            dlg.SelectedPath = Application.StartupPath;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFolder.Text = dlg.SelectedPath;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Application.StartupPath;
            dlg.Filter = "txt files (*.txt)|*.txt |" +
                "Мои файлы |*.xxx|" +
                "Сборки (*.exe)|*.exe";
            dlg.FilterIndex = 3;
            dlg.Title = "Выбор моего файла";

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFile.Text = dlg.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x;
                int n;
                double U = 1;
                double N;

                x = Convert.ToInt32(textBox2.Text);
                n = Convert.ToInt32(textBox1.Text);


                if (n > 0)
                {
                    for (int i = n; i > 0; i--)
                    {
                        if (i % 2 == 0)
                        {
                            N = (-1) * (Math.Pow(Math.Sin(x), n) / n);
                            n -= 1;
                            U += N;
                        }
                        if (i % 2 == 1)
                        {
                            N = (Math.Pow(Math.Sin(x), n) / n);
                            n -= 1;
                            U += N;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите в поля целые положительные числа, отличные от нуля! Иначе программа работать не будет!");
                }
                txtChooseFont.Text = Convert.ToString(U);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Пожалуйста, введите в поля целые положительные числа, отличные от нуля! Иначе программа работать не будет!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Name = SaveFileDialog1.FileName;
                File.WriteAllText(Name, txtChooseFont.Text);
            }
        }
    }
}
