namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void group1RadioChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(System.Windows.Forms.RadioButton))
            {
                System.Windows.Forms.RadioButton radio = (System.Windows.Forms.RadioButton)sender;

                label1.Text = "radio: " + radio.Text + ", Checked: " + radio.Checked;
            }
        }

        private void group2RadioChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(System.Windows.Forms.RadioButton))
            {
                System.Windows.Forms.RadioButton radio = (System.Windows.Forms.RadioButton)sender;

                label2.Text = "radio: " + radio.Text + ", Checked: " + radio.Checked;
            }
        }
    }
}
