namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] fruits = { "���", "��", "�丶��", "����" };
            cbFruit.Items.AddRange(fruits);
            cbFruit.SelectedIndex = 0;

            string[] Country = { "�̱�", "�߱�", "�ѱ�", "�Ϻ�" };
            cbCountry.Items.AddRange(Country);
            cbCountry.SelectedIndex = 0;

            string[] Company = { "����", "�׹�", "�Ｚ", "����" };
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
