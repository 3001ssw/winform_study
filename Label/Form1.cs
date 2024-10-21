using System.Diagnostics;

namespace Label
{
    public partial class Form1 : Form
    {
        protected int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lbHelloWorld.Text = "Hello world!(" + a + ")";
            a++;
        }

        private void HellowWorldTextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(lbHelloWorld.Text);
        }
    }
}
