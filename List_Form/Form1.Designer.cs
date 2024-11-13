namespace List_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            lbListBox = new Label();
            btnListBox = new Button();
            tbListBox = new TextBox();
            btnListBoxClear = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lbListView = new Label();
            btnListViewAdd = new Button();
            btnListViewClear = new Button();
            tbListView1 = new TextBox();
            tbListView2 = new TextBox();
            tbListView3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(329, 139);
            listBox1.TabIndex = 1;
            listBox1.SelectedValueChanged += listBox1_SelectedValueChanged;
            // 
            // lbListBox
            // 
            lbListBox.BorderStyle = BorderStyle.FixedSingle;
            lbListBox.Location = new Point(12, 9);
            lbListBox.Name = "lbListBox";
            lbListBox.Size = new Size(329, 23);
            lbListBox.TabIndex = 0;
            lbListBox.Text = "label1";
            // 
            // btnListBox
            // 
            btnListBox.Location = new Point(191, 193);
            btnListBox.Name = "btnListBox";
            btnListBox.Size = new Size(75, 23);
            btnListBox.TabIndex = 3;
            btnListBox.Text = "button1";
            btnListBox.UseVisualStyleBackColor = true;
            btnListBox.Click += btnListBox_Click;
            // 
            // tbListBox
            // 
            tbListBox.Location = new Point(12, 193);
            tbListBox.Name = "tbListBox";
            tbListBox.Size = new Size(173, 23);
            tbListBox.TabIndex = 2;
            // 
            // btnListBoxClear
            // 
            btnListBoxClear.Location = new Point(272, 192);
            btnListBoxClear.Name = "btnListBoxClear";
            btnListBoxClear.Size = new Size(75, 23);
            btnListBoxClear.TabIndex = 4;
            btnListBoxClear.Text = "button1";
            btnListBoxClear.UseVisualStyleBackColor = true;
            btnListBoxClear.Click += btnListBoxClear_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(360, 47);
            listView1.Name = "listView1";
            listView1.Size = new Size(339, 139);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lbListView
            // 
            lbListView.BorderStyle = BorderStyle.FixedSingle;
            lbListView.Location = new Point(360, 9);
            lbListView.Name = "lbListView";
            lbListView.Size = new Size(329, 23);
            lbListView.TabIndex = 5;
            lbListView.Text = "label1";
            // 
            // btnListViewAdd
            // 
            btnListViewAdd.Location = new Point(539, 192);
            btnListViewAdd.Name = "btnListViewAdd";
            btnListViewAdd.Size = new Size(75, 23);
            btnListViewAdd.TabIndex = 10;
            btnListViewAdd.Text = "button1";
            btnListViewAdd.UseVisualStyleBackColor = true;
            btnListViewAdd.Click += btnListViewAdd_Click;
            // 
            // btnListViewClear
            // 
            btnListViewClear.Location = new Point(620, 191);
            btnListViewClear.Name = "btnListViewClear";
            btnListViewClear.Size = new Size(75, 23);
            btnListViewClear.TabIndex = 11;
            btnListViewClear.Text = "button1";
            btnListViewClear.UseVisualStyleBackColor = true;
            btnListViewClear.Click += btnListViewClear_Click;
            // 
            // tbListView1
            // 
            tbListView1.Location = new Point(360, 194);
            tbListView1.Name = "tbListView1";
            tbListView1.Size = new Size(49, 23);
            tbListView1.TabIndex = 7;
            // 
            // tbListView2
            // 
            tbListView2.Location = new Point(415, 194);
            tbListView2.Name = "tbListView2";
            tbListView2.Size = new Size(49, 23);
            tbListView2.TabIndex = 8;
            // 
            // tbListView3
            // 
            tbListView3.Location = new Point(470, 194);
            tbListView3.Name = "tbListView3";
            tbListView3.Size = new Size(49, 23);
            tbListView3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(620, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 322);
            Controls.Add(listView1);
            Controls.Add(tbListView3);
            Controls.Add(tbListView2);
            Controls.Add(tbListView1);
            Controls.Add(button1);
            Controls.Add(btnListViewClear);
            Controls.Add(tbListBox);
            Controls.Add(btnListViewAdd);
            Controls.Add(btnListBoxClear);
            Controls.Add(btnListBox);
            Controls.Add(lbListView);
            Controls.Add(lbListBox);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lbListBox;
        private Button btnListBox;
        private TextBox tbListBox;
        private Button btnListBoxClear;
        private ListView listView1;
        private Label lbListView;
        private Button btnListViewAdd;
        private Button btnListViewClear;
        private TextBox tbListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox tbListView2;
        private TextBox tbListView3;
        private Button button1;
    }
}
