namespace DateTimePicker
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
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            textBox1 = new TextBox();
            button1 = new Button();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            textBox2 = new TextBox();
            button2 = new Button();
            dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            textBox3 = new TextBox();
            button3 = new Button();
            dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            textBox4 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(350, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(302, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(668, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Checked = false;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(350, 41);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(302, 23);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 23);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(668, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Checked = false;
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(350, 70);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(302, 23);
            dateTimePicker3.TabIndex = 7;
            dateTimePicker3.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(324, 23);
            textBox3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(668, 70);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Checked = false;
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.Location = new Point(350, 99);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(302, 23);
            dateTimePicker4.TabIndex = 10;
            dateTimePicker4.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(20, 99);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(324, 23);
            textBox4.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(668, 99);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 324);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker4);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private TextBox textBox2;
        private Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private TextBox textBox3;
        private Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private TextBox textBox4;
        private Button button4;
    }
}
