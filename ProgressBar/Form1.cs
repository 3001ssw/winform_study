namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PercentValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = Convert.ToInt32(numericPercent.Value);
        }
    }
}
