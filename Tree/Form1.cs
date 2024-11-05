namespace Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;

            // ù��° TreeView ������ - ����
            TreeNode svrNode = new TreeNode("����", 0, 1);
            svrNode.Nodes.Add("SE", "���� ����", 0, 1);
            svrNode.Nodes.Add("DJ", "���� ����", 0, 1);
            svrNode.Nodes.Add("BS", "�λ� ����", 0, 1);

            // �ι�° TreeView ������ - Ŭ���̾�Ʈ
            TreeNode netNode = new TreeNode("Ŭ���̾�Ʈ", 2, 3);
            netNode.Nodes.Add("SE", "���� ������", 2, 3);
            netNode.Nodes.Add("DJ", "���� ������", 2, 3);
            netNode.Nodes.Add("BS", "�λ� ������", 2, 3);

            svrNode.Nodes.Add(netNode);

            // 2���� ��带 TreeView�� �߰�
            treeView1.Nodes.Add(svrNode);
            //treeView1.Nodes.Add(netNode);

            // ��� Ʈ�� ��带 �����ش�
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeKey = e.Node.Name;
            string nodeText = e.Node.Text;
            if (!string.IsNullOrEmpty(nodeKey))
            {
                MessageBox.Show("���õ� ��� Ű : " + nodeKey + ", �ؽ�Ʈ: " + nodeText);
            }
        }
    }
}
