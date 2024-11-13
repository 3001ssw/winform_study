using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            listView1.View = View.Details;
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

        //https://freeprog.tistory.com/232
        private void btnListViewAdd_Click(object sender, EventArgs e)
        {
            string str1 = tbListView1.Text;
            string str2 = tbListView2.Text;
            string str3 = tbListView3.Text;

            listView1.BeginUpdate();

            //ListViewItem listViewItem = new ListViewItem(new string[] { str1, str2, str3 });
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = str1;
            listViewItem.SubItems.Add(str2);
            listViewItem.SubItems.Add(str3);
            listView1.Items.Add(listViewItem);

            listView1.EndUpdate();

            tbListView1.Clear();
            tbListView2.Clear();
            tbListView3.Clear();

            tbListView1.Focus();
        }

        private void btnListViewClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("row: {0}", listView1.Items.Count);
            Debug.WriteLine("col: {0}", listView1.Columns.Count);

            for (int row = 0; row < listView1.Items.Count; row++)
            {
                for (int col = 0; col < listView1.Columns.Count; col++)
                {
                    string str = string.Format("item: {0}", listView1.Items[row].SubItems[col].Text.ToString());
                    Debug.WriteLine(str);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView listView = (System.Windows.Forms.ListView)sender;
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                Debug.WriteLine(item.Text);
                Debug.WriteLine("count: " + item.SubItems.Count);
                foreach (ListViewSubItem subItem in item.SubItems)
                {
                    Debug.WriteLine("SubItem: " + subItem.Text);
                }
            }
        }
    }
}
