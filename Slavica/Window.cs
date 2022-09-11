using System.Text.RegularExpressions;

namespace Slavica
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }


        // checks if the text entry is correct
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // turns off the 'proceed' button if the entry is incorrect
            if (textBox1.Text == "")
                button1.Enabled = false;

            else if (Regex.IsMatch(textBox1.Text, "^[a-zA-Z0-9]*$"))
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }


        // starts a translation process
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> contents = Scrapper.GetContent(textBox1.Text);
            var words = Parser.ParseInfo(contents);

            
            // East Slavic
            label5.Text = "Russian: " + words[0];
            label6.Text = "Ukrainian: " + words[1];
            label7.Text = "Belarusian: " + words[2];
            label8.Text = "Rusyn: " + words[3];
            label9.Text = "Old Russian: " + words[4];

        }
    }
}