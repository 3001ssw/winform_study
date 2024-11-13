using System.Diagnostics;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "Column1");
            dataGridView1.Columns.Add("Column2", "Column2");
            dataGridView1.Columns.Add("Column3", "Column3");
            dataGridView1.Columns.Add("Column4", "Column4");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            DataGridViewRow row = new DataGridViewRow();
            dataGridView1.Rows.Add(row);
            row.Cells[0].Value = textBox1.Text;
            row.Cells[1].Value = textBox2.Text;
            row.Cells[2].Value = textBox3.Text;
            row.Cells[3].Value = textBox4.Text;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridView grid = (System.Windows.Forms.DataGridView)sender;
            Debug.WriteLine("selected count: " + grid.SelectedRows.Count);

            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    Debug.WriteLine("cell: " + cell.Value);
                }
            }
        }
    }
}
