namespace WFA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClickArtir = new System.Windows.Forms.Button();
            this.btnClickAzalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickArtir
            // 
            this.btnClickArtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClickArtir.Location = new System.Drawing.Point(120, 163);
            this.btnClickArtir.Name = "btnClickArtir";
            this.btnClickArtir.Size = new System.Drawing.Size(225, 60);
            this.btnClickArtir.TabIndex = 0;
            this.btnClickArtir.Text = "Arttır";
            this.btnClickArtir.UseVisualStyleBackColor = true;
            this.btnClickArtir.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnClickAzalt
            // 
            this.btnClickAzalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClickAzalt.Location = new System.Drawing.Point(417, 163);
            this.btnClickAzalt.Name = "btnClickAzalt";
            this.btnClickAzalt.Size = new System.Drawing.Size(248, 59);
            this.btnClickAzalt.TabIndex = 1;
            this.btnClickAzalt.Text = "Azalt";
            this.btnClickAzalt.UseVisualStyleBackColor = true;
            this.btnClickAzalt.Click += new System.EventHandler(this.btnClickAzalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClickAzalt);
            this.Controls.Add(this.btnClickArtir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickArtir;
        private System.Windows.Forms.Button btnClickAzalt;
    }
}

