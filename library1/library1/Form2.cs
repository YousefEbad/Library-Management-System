using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library1;
using System.IO;

namespace library1
{
    public partial class Form2 : Form
    {
        FileStream myfile;
        StreamWriter writer;
        StreamReader reader;
        
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            string title = Title.Text;
            string ispn = ISPN.Text;
            string author = Author.Text;
            string yearText = Year.Text.Trim();


            // Input validation
            
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
            string.IsNullOrEmpty(ispn) || string.IsNullOrEmpty(yearText))//check if there is no empty field
            {
                MessageBox.Show("Invalid! Please complete all fields","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
            else if (!(int.TryParse(ispn, out int ispn2)))//check if the ispn is a number
            {
                MessageBox.Show("Invalid ispn! Please enter a valid numeric value.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(yearText, out int year2) || int.Parse(yearText) > DateTime.Now.Year)//check if the year is a number and not in a future
            {
                MessageBox.Show("Invalid year! Please enter a valid year.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string filename = "data.txt";
                myfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
                reader = new StreamReader(myfile);
                string line;
                string[] split;
                bool Error = false;
                while ((line = reader.ReadLine())!=null)
                {
                    split = line.Split('|');
                    if (int.Parse(split[1]) == int.Parse(ispn))//check if the ispn is available 
                    {
                        MessageBox.Show("The ispn number is already in use. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Error = true;
                        break;
                    }
                }
                reader.Close();
                myfile.Close();
                
                myfile = new FileStream(filename, FileMode.Append, FileAccess.Write);

                if (!Error)
                {
                     writer = new StreamWriter(myfile);
                    int year = int.Parse(yearText);
                    string Line = $"available|{ispn}|{title}|{author}|{year}";
                    writer.WriteLine(Line);
                    MessageBox.Show("New Record Added to catalog successfuly");
                    writer.Flush();
                    writer.Close();
                }

                
                myfile.Close();
            }

            
        }

        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //the following will be shortcuts
        private void ISPN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Title.Select();
            }
        }

        private void Title_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                Author.Select();
        }

        private void Author_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Year.Select();
        }


        private void Year_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                insertBtn_Click(sender, e);
        }
    }
}
