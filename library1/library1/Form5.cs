namespace library1;

public partial class Form5 : Form
{
    FileStream stream;
    StreamReader sr;
    string filename = "data.txt";
    private Form1 _form1;
    public Form5(Form1 form1)//reads the entire file in the constructor
    {
        InitializeComponent();
        _form1 = form1;
        stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
        sr = new StreamReader(stream);
        string line;
        string[] split;
        textBox2.Clear();
        while ((line = sr.ReadLine()) != null)
        {
            split = line.Split('|');
            textBox2.Text += $"{split[1]} - {split[2]} - {split[3]} - {split[4]}"+Environment.NewLine;
        }
        sr.Close();
        stream.Close();
    }
    private void button1_Click(object sender, EventArgs e)
    {
      _form1.Show();
      this.Hide();
    }

    private void Form5_FormClosing(object sender, FormClosingEventArgs e)
    {
        Environment.Exit(0);
    }

    private void button2_Click(object sender, EventArgs e) //search method
    {
        stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
        sr = new StreamReader(stream);
        string[] splitter;
        string line;
        bool isFound = false;
        if ((int.TryParse(textBox1.Text, out int text)))
        {
            while ((line = sr.ReadLine()) != null)
            {
                splitter = line.Split('|');
                if (textBox1.Text == splitter[1])
                {
                    textBox2.Clear();
                    textBox2.Text += $"{splitter[1]} - {splitter[2]} - {splitter[3]}"+Environment.NewLine;
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sr.Close();
            stream.Close();
        }
        else
        {
            MessageBox.Show("Invalid ispn! Please enter a valid numeric value.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            button2_Click(null, null);
        }
    }
}