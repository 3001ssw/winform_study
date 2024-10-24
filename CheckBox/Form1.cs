namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkbox1CheckedChanged(object sender, EventArgs e)
        {
            lbDisp.Text = "checked: " + checkBox1.Checked;
        }
    }
}
