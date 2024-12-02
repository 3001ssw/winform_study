namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //날짜 시간
            dateTimePicker1.Format = DateTimePickerFormat.Long;

            //날짜
            dateTimePicker2.Format = DateTimePickerFormat.Short;

            //시간
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.ShowUpDown = true;

            //커스텀
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "'Today is: 'yyyy/MMMM/dd(dddd) hh:mm:ss";

            displayDateTimeTimeToTextBox(dateTimePicker1);
            displayDateTimeTimeToTextBox(dateTimePicker2);
            displayDateTimeTimeToTextBox(dateTimePicker3);
            displayDateTimeTimeToTextBox(dateTimePicker4);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            displayDateTimeTimeToTextBox(sender);
        }

        private void displayDateTimeTimeToTextBox(object sender)
        {
            System.Windows.Forms.DateTimePicker? dtp = null;
            TextBox? textBox = null;
            if (sender.Equals(dateTimePicker1))
            {
                dtp = dateTimePicker1;
                textBox = textBox1;
            }
            else if (sender.Equals(dateTimePicker2))
            {
                dtp = dateTimePicker2;
                textBox  = textBox2;
            }
            else if (sender.Equals(dateTimePicker3))
            {
                dtp = dateTimePicker3;
                textBox = textBox3;
            }
            else if (sender.Equals(dateTimePicker4))
            {
                dtp = dateTimePicker4;
                textBox = textBox4;
            }
            else
            {
                dtp = null;
                textBox = null;
            }

            if (dtp != null && textBox != null)
            {
                DateTime dt = dtp.Value;
                string time = dt.ToString();
                time = string.Format("{0}년 {1}월 {2}일 {3}시 {4}분 {5}초", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
                textBox.Text = time;
            }

        }
    }
}
