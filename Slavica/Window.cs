using System.Text.RegularExpressions;

namespace Slavica
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }


        // initializing objects for classes
        Scrapper scrapper = new Scrapper();
        Parser parser = new Parser();


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
            scrapper.GetInfo(textBox1.Text);
            parser.ParseInfo(Scrapper.responses);
        }
    }
}