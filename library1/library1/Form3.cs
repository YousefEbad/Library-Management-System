using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace library1
{
    public partial class Form3 : Form
    {
        FileStream myfile;
        StreamReader reader;
        StreamWriter writer;
        private Form1 _form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            string ispn = check_in.Text;

            string filename = "data.txt";
            myfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            reader = new StreamReader(myfile);
            writer = new StreamWriter(myfile);
            string line;
            string[] split;
            int pos = 0;
            bool isSuccess = false;
            while ((line = reader.ReadLine())!=null)
            {
                split = line.Split('|');
                if (int.Parse(split[1]) == int.Parse(ispn))//if condition to check if the book is available or not
                {
                    
                    if (split[0] == "available")
                    {
                        myfile.Seek(pos, SeekOrigin.Begin);
                        writer.Write("*");//makes the book not available 
                        MessageBox.Show($"You Got The \"{split[2]}\" Book Hope You Enjoy Reading it",$"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        isSuccess = true;
                        break;
                    }else if (split[0] == "*vailable")//condition to check if the book is in the file but not available
                    {
                        MessageBox.Show("Sorry the book is currently not available, try again later.","Not available",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        isSuccess = true;
                        break;
                    }
                }
                pos += line.Length+1;
            }

            if (!isSuccess)//if the book is not in the file
            {
                MessageBox.Show("We are sorry to inform you that the book is not found","Not found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            writer.Flush();
            writer.Close();
            reader.Close();
            myfile.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form1.Show();
            this.Hide();
        }//return to main menu

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
