namespace Label
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
            lbHelloWorld = new System.Windows.Forms.Label();
            btnShow = new Button();
            SuspendLayout();
            // 
            // lbHelloWorld
            // 
            lbHelloWorld.BorderStyle = BorderStyle.FixedSingle;
            lbHelloWorld.FlatStyle = FlatStyle.Popup;
            lbHelloWorld.Location = new Point(12, 9);
            lbHelloWorld.Name = "lbHelloWorld";
            lbHelloWorld.Size = new Size(446, 23);
            lbHelloWorld.TabIndex = 0;
            lbHelloWorld.TextChanged += HellowWorldTextChanged;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(473, 9);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(195, 23);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show Hello World";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(lbHelloWorld);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lbHelloWorld;
        private Button btnShow;
    }
}
