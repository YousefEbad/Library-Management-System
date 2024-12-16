using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library1
{


    public partial class Form4 : Form
    {
        FileStream myfile;
        StreamReader reader;
        StreamWriter writer;
        private Form1 _form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void check_out_Click(object sender, EventArgs e)
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
                if (int.Parse(split[1]) == int.Parse(ispn))//finding the book row
                {
                    
                    if (split[0] == "*vailable")//if the book is borrowed
                    {
                        myfile.Seek(pos, SeekOrigin.Begin);//goes to the beginning of the row
                        writer.Write("a");//making the book available
                        MessageBox.Show($"Thank You For Returning \"{split[2]}\" Book Hope You Enjoied Reading it",$"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        isSuccess = true;
                        break;
                    }else if (split[0] == "available")
                    {
                        MessageBox.Show("This Book is already in the library.","Found",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        isSuccess = true;
                        break;
                    }
                }
                pos += line.Length+1;//count the number of letters "+1" for new lines
            }

            if (!isSuccess)//if the book is not found in the file
            {
                MessageBox.Show("The library doesn't have this book","Not found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
