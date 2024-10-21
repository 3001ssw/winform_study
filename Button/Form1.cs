using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("클릭!", "버튼1");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("마우스 클릭!", "버튼1");
        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("마우스 캡쳐 체인지!", "버튼1");
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("키 다운!: " + e.KeyData, "버튼1");
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("키 업!: " + e.KeyData, "버튼1");
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            Debug.WriteLine("엔터!", "버튼1");
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            Debug.WriteLine("리브!", "버튼1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("클릭!", "버튼2");

        }
    }
}
