namespace Diziler
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
            varisNoktasi = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cmbFrom = new System.Windows.Forms.ComboBox();
            cmbTo = new System.Windows.Forms.ComboBox();
            satinAl = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // varisNoktasi
            // 
            varisNoktasi.AutoSize = true;
            varisNoktasi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            varisNoktasi.Location = new System.Drawing.Point(413, 176);
            varisNoktasi.Name = "varisNoktasi";
            varisNoktasi.Size = new System.Drawing.Size(121, 25);
            varisNoktasi.TabIndex = 1;
            varisNoktasi.Text = "Varış Noktası";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(94, 176);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 25);
            label1.TabIndex = 2;
            label1.Text = "Kalkış Noktası";
            // 
            // cmbFrom
            // 
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new System.Drawing.Point(228, 178);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new System.Drawing.Size(121, 23);
            cmbFrom.TabIndex = 3;
            cmbFrom.SelectedValueChanged += cmbFrom_SelectedValueChanged;
            // 
            // cmbTo
            // 
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new System.Drawing.Point(540, 176);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new System.Drawing.Size(121, 23);
            cmbTo.TabIndex = 4;
            // 
            // satinAl
            // 
            satinAl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            satinAl.Location = new System.Drawing.Point(317, 270);
            satinAl.Name = "satinAl";
            satinAl.Size = new System.Drawing.Size(146, 41);
            satinAl.TabIndex = 5;
            satinAl.Text = "Satın Al";
            satinAl.UseVisualStyleBackColor = true;
            satinAl.Click += satinAl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(satinAl);
            Controls.Add(cmbTo);
            Controls.Add(cmbFrom);
            Controls.Add(label1);
            Controls.Add(varisNoktasi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label varisNoktasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button satinAl;
    }
}
