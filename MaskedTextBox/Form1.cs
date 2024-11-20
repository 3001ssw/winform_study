using System.Windows.Forms;

namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            // ��Ŀ�� �Ű����� ȣ�� ��
            if (!e.IsValidInput)
            {
                MessageBox.Show("�ùٸ� ������ �Է����ּ���!");
                maskedTextBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = maskedTextBox1.Text;
            MessageBox.Show("input text: " + txt);
        }
    }
}
