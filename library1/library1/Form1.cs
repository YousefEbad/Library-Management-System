namespace library1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //every button Hides the current form and open another form
        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2(this); 
            form2.Show();
            this.Hide();

        }//insert form

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }//exit button

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }//borrow form

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            this.Hide();
        }//return form

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            this.Hide();
        }//check list form

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);//close the entire project in case of closing by "X" button in navigation bar
        }
    }
}
