namespace ProgressBar
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
            progressBar1 = new System.Windows.Forms.ProgressBar();
            numericPercent = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPercent).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(39, 26);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(395, 23);
            progressBar1.TabIndex = 0;
            // 
            // numericPercent
            // 
            numericPercent.Location = new Point(457, 30);
            numericPercent.Name = "numericPercent";
            numericPercent.Size = new Size(120, 23);
            numericPercent.TabIndex = 1;
            numericPercent.ValueChanged += PercentValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(39, 65);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(numericPercent);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericPercent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private NumericUpDown numericPercent;
        private Button button1;
    }
}
