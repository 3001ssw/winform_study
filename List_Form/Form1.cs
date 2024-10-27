using System.Windows.Forms;

namespace List_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            string str = tbListBox.Text;
            if (str == "")
                return;

            listBox1.BeginUpdate();

            listBox1.Items.Add(str);

            listBox1.EndUpdate();

            tbListBox.Clear();
            tbListBox.Focus();
        }

        private void btnListBoxClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            object obj = listBox1.Items[i];
            string str = listBox1.Items[i].ToString();

            lbListBox.Text = "selected index: " + i + ", text: " + str;
        }

        private void btnListViewAdd_Click(object sender, EventArgs e)
        {
            string str = tbListView.Text;
            if (str == "")
                return;

            listView1.BeginUpdate();

            listView1.Items.Add(str);

            listView1.EndUpdate();

            tbListView.Clear();

            tbListView.Focus();
        }

        private void btnListViewClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            //object obj = listView1.Items[i];
            //string str = listView1.Items[i].ToString();
            //
            //lbListView.Text = "selected index: " + i + ", text: " + str;
        }
    }
}
