namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Id";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "Librarion";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Reader";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "Book";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "Date";
            textBox5.Visible = true;
            label6.Visible = true;
            label6.Text = "Date return";
            textBox6.Visible = true;
            label7.Visible = true;
            label7.Text = "Status";
            textBox7.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Id";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "Heading";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Year";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "Author";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "Category";
            textBox5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Id";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "Name";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Email";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "Phone number";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "Date registration";
            textBox5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Id";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "Name";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Phone number";
            textBox3.Visible = true;
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Id";
            textBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "Name";
            textBox2.Visible = true;
            label3.Visible = true;
            label3.Text = "Date";
            textBox3.Visible = true;
            label4.Visible = true;
            label4.Text = "Description";
            textBox4.Visible = true;
            label5.Visible = true;
            label5.Text = "Librarion";
            textBox5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
        }
    }
}
