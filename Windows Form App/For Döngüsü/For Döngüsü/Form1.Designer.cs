namespace For_Döngüsü
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
            lstNumbers = new System.Windows.Forms.ListBox();
            lstDoubleNumbers = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // lstNumbers
            // 
            lstNumbers.FormattingEnabled = true;
            lstNumbers.ItemHeight = 15;
            lstNumbers.Location = new System.Drawing.Point(52, 59);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new System.Drawing.Size(271, 319);
            lstNumbers.TabIndex = 0;
            // 
            // lstDoubleNumbers
            // 
            lstDoubleNumbers.FormattingEnabled = true;
            lstDoubleNumbers.ItemHeight = 15;
            lstDoubleNumbers.Location = new System.Drawing.Point(450, 108);
            lstDoubleNumbers.Name = "lstDoubleNumbers";
            lstDoubleNumbers.Size = new System.Drawing.Size(241, 199);
            lstDoubleNumbers.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lstDoubleNumbers);
            Controls.Add(lstNumbers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstDoubleNumbers;
    }
}
