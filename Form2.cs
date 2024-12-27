using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zorara;

namespace Inject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/KINGHUB01/BlackKing-obf/main/Doors%20Blackking%20And%20BobHub\"))()";
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/3345-c-a-t-s-u-s/Kncrypt/refs/heads/main/Loader.lua\"))()";
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/3345-c-a-t-s-u-s/Kncrypt/refs/heads/main/Loader.lua\"))()";
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()";
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet(\"https://pastefy.app/wa3v2Vgm/raw\"))()";
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/NukeVsCity/Scripts2024/main/ybaredguiforpc\"))()";
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet(\"https://github.com/ltseverydayyou/uuuuuuu/blob/main/UNC%20test?raw=true\"))()";
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/AhmadV99/Speed-Hub-X/main/Speed%20Hub%20X.lua\", true))()";
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fom = new Form1();
            fom.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
