namespace Constructor
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
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.createProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(255, 179);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(249, 39);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "Yeni Ürün Ekle";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(255, 136);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(249, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // createProduct
            // 
            this.createProduct.Location = new System.Drawing.Point(565, 180);
            this.createProduct.Name = "createProduct";
            this.createProduct.Size = new System.Drawing.Size(163, 37);
            this.createProduct.TabIndex = 2;
            this.createProduct.Text = "Yeni Ürünü Kolay Oluşturma";
            this.createProduct.UseVisualStyleBackColor = true;
            this.createProduct.Click += new System.EventHandler(this.createProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnNewProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button createProduct;
    }
}

