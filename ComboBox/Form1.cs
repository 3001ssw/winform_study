namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] fruits = { "사과", "배", "토마토", "수박" };
            cbFruit.Items.AddRange(fruits);
            cbFruit.SelectedIndex = 0;

            string[] Country = { "미국", "중국", "한국", "일본" };
            cbCountry.Items.AddRange(Country);
            cbCountry.SelectedIndex = 0;

            string[] Company = { "애플", "테무", "삼성", "니콘" };
            cbCompany.Items.AddRange(Company);
            cbCompany.SelectedIndex = 0;
        }

        private void ComboFruit_SelectedIndexChnaged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox combo = (System.Windows.Forms.ComboBox)sender;
            if (0 <= combo.SelectedIndex)
            {
                label1.Text = "index: " + combo.SelectedIndex + ", text: " + combo.Text;
            }
        }
    }
}
