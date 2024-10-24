namespace TextBox
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
            tbInput = new System.Windows.Forms.TextBox();
            lbDisp = new Label();
            btnInput = new Button();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Location = new Point(164, 15);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(100, 23);
            tbInput.TabIndex = 0;
            tbInput.TextChanged += tbInputTextChanged;
            // 
            // lbDisp
            // 
            lbDisp.BorderStyle = BorderStyle.Fixed3D;
            lbDisp.Location = new Point(13, 15);
            lbDisp.Name = "lbDisp";
            lbDisp.Size = new Size(145, 23);
            lbDisp.TabIndex = 1;
            // 
            // btnInput
            // 
            btnInput.Location = new Point(270, 15);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(75, 23);
            btnInput.TabIndex = 2;
            btnInput.Text = "Input";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 225);
            Controls.Add(btnInput);
            Controls.Add(lbDisp);
            Controls.Add(tbInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private Label lbDisp;
        private Button btnInput;
    }
}
