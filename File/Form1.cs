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

namespace File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\杨俊艺\\Desktop\\file.txt", FileMode.OpenOrCreate, FileAccess.Write);
            byte[] b = new byte[40];
            char[] ch = new char[40];
            ch = this.txtName.Text.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                b[i] = (byte)ch[i];
            }
            fs.Write(b,0,ch.Length);

            ch = this.txtSex.Text.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                b[i]= (byte)ch[i];
            }
            fs.Write(b, 0, ch.Length);
            ch = this.txtH.Text.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                b[i] = (byte)ch[i];
            }
            fs.Write(b, 0, ch.Length);
            fs.Flush();
            fs.Close();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Users\\杨俊艺\\Desktop\\file.txt", FileMode.OpenOrCreate, FileAccess.Read);
            int a = 0;
            string str = "";
            string ch;
            a = fs.ReadByte();
            while (a > -1)
            {
                ch = ((char)a).ToString();
                str += ch;
                a = fs.ReadByte();
            }
            textBox1.Text = str;
            fs.Close();
        }
    }
}
