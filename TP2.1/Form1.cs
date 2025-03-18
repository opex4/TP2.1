using System.Text.RegularExpressions;

namespace TP2._1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sentance = textBox1.Text;
            Logic logic = new Logic(sentance);
            String subStr = logic.LetterPercentage().ToString("#.##");
            
            label2.Text = subStr + " %";
        }
    }
}
