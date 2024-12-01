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
            toolTip1.SetToolTip(maskedTextBox1, "우편번호를 입력해주세요.");
            toolTip1.SetToolTip(maskedTextBox2, "전화번호를 입력해주세요");
        }
    }
}
