namespace ComboBox
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
            cbFruit = new System.Windows.Forms.ComboBox();
            label1 = new Label();
            cbCountry = new System.Windows.Forms.ComboBox();
            cbCompany = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // cbFruit
            // 
            cbFruit.DropDownStyle = ComboBoxStyle.Simple;
            cbFruit.FormattingEnabled = true;
            cbFruit.Location = new Point(342, 9);
            cbFruit.Name = "cbFruit";
            cbFruit.Size = new Size(121, 150);
            cbFruit.TabIndex = 0;
            cbFruit.SelectedIndexChanged += ComboFruit_SelectedIndexChnaged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 23);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(476, 12);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(121, 23);
            cbCountry.TabIndex = 2;
            cbCountry.SelectedIndexChanged += ComboFruit_SelectedIndexChnaged;
            // 
            // cbCompany
            // 
            cbCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCompany.FormattingEnabled = true;
            cbCompany.Location = new Point(617, 12);
            cbCompany.Name = "cbCompany";
            cbCompany.Size = new Size(121, 23);
            cbCompany.TabIndex = 3;
            cbCompany.SelectedIndexChanged += ComboFruit_SelectedIndexChnaged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 104);
            Controls.Add(cbCompany);
            Controls.Add(cbCountry);
            Controls.Add(label1);
            Controls.Add(cbFruit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cbFruit;
        private Label label1;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbCompany;
    }
}
