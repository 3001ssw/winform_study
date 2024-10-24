namespace TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            lbDisp.Text = "button click: " + tbInput.Text;
        }

        private void tbInputTextChanged(object sender, EventArgs e)
        {
            lbDisp.Text = "text changed: " + tbInput.Text;
        }
    }
}
