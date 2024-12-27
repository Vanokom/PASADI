using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zorara;
using System.Windows;
using static System.Net.WebRequestMethods;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Microsoft.Win32;


namespace Inject
{
    public partial class Form1 : Form
    {
        private ImageBrush Background;

        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;

            Timer time = new Timer();
            time.Tick += timertick;
            time.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoreFunctions.Inject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = System.IO.File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int irandom = random.Next(1);

            if (irandom == 0)
            {
                CoreFunctions.KillRoblox();
            }
            else if (irandom == 1)
            {
                button5.Visible = false;
                label2.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Создаем диалог для выбора файла
            OpenFileDialog openFileDialog2 = new OpenFileDialog
            {
                Title = "Select Background Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*"
            };

            // Показываем диалог и проверяем, был ли выбран файл
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Меняем фоновое изображение на выбранное
                this.BackgroundImage = Image.FromFile(openFileDialog2.FileName);
                this.BackgroundImageLayout = ImageLayout.Stretch; // Растягиваем изображение по размеру формы
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void timertick(object sender, EventArgs e)
        {
            if (CoreFunctions.IsRobloxOpen())
            {
                label3.Text = "Нашел вроде роблокс";
                label3.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                label3.ForeColor= System.Drawing.Color.Gray;
            }
            if (CoreFunctions.IsInjected())
            {
                label3.Text = "Все окей";
                label3.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label3.Text = "Не получилась";
                label3.ForeColor = System.Drawing.Color.Blue;
            }
        }
    }
}
