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

            // 첫번째 TreeView 아이템 - 서버
            TreeNode svrNode = new TreeNode("서버", 0, 1);
            svrNode.Nodes.Add("SE", "서울 서버", 0, 1);
            svrNode.Nodes.Add("DJ", "대전 서버", 0, 1);
            svrNode.Nodes.Add("BS", "부산 서버", 0, 1);

            // 두번째 TreeView 아이템 - 클라이언트
            TreeNode netNode = new TreeNode("클라이언트", 2, 3);
            netNode.Nodes.Add("SE", "서울 접속자", 2, 3);
            netNode.Nodes.Add("DJ", "대전 접속자", 2, 3);
            netNode.Nodes.Add("BS", "부산 접속자", 2, 3);

            svrNode.Nodes.Add(netNode);

            // 2개의 노드를 TreeView에 추가
            treeView1.Nodes.Add(svrNode);
            //treeView1.Nodes.Add(netNode);

            // 모든 트리 노드를 보여준다
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nodeKey = e.Node.Name;
            string nodeText = e.Node.Text;
            if (!string.IsNullOrEmpty(nodeKey))
            {
                MessageBox.Show("선택된 노드 키 : " + nodeKey + ", 텍스트: " + nodeText);
            }
        }
    }
}
