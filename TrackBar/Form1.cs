namespace TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 100;
            trackBar1.TickFrequency = 5;
            trackBar1.LargeChange = 3;
            trackBar1.SmallChange = 3;
            trackBar1.TickStyle = TickStyle.Both;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int trackVal = trackBar1.Value;
            label1.Text = trackVal.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Int32.Parse(numericUpDown1.Value.ToString());
        }
    }
}
