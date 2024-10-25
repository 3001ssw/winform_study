using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] food = { "소고기", "닭고기", "돼지고기", "우유", "술" };
            checkedListBox1.Items.AddRange(food);
        }

        private void checkbox1CheckedChanged(object sender, EventArgs e)
        {
            lbDisp.Text = "checked: " + checkBox1.Checked;
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
            {
                s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
            }
            lbDisp.Text = s;
        }
    }
}
