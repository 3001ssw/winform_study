using System.Xml.Linq;

namespace ToolTip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(maskedTextBox1, "�����ȣ�� �Է����ּ���.");
            toolTip1.SetToolTip(maskedTextBox2, "��ȭ��ȣ�� �Է����ּ���.");
        }

        private void Object_MouseHover(object sender, EventArgs e)
        {
            if (sender.Equals(maskedTextBox1))
            {
                toolTip1.SetToolTip(maskedTextBox1, "�����ȣ�� �Է����ּ���.");
            }
            else if (sender.Equals(maskedTextBox2))
            {
                toolTip1.SetToolTip(maskedTextBox2, "��ȭ��ȣ�� �Է����ּ���.");
            }
            else if (sender.Equals(button1))
            {
                toolTip1.SetToolTip(button1, "Ŭ���� �Է� �˴ϴ�.");
            }
        }
    }
}
