namespace MetotParametresi
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
            this.btnArcher = new System.Windows.Forms.Button();
            this.btnMage = new System.Windows.Forms.Button();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnAssasin = new System.Windows.Forms.Button();
            this.btnNpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArcher
            // 
            this.btnArcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArcher.Location = new System.Drawing.Point(85, 176);
            this.btnArcher.Name = "btnArcher";
            this.btnArcher.Size = new System.Drawing.Size(176, 51);
            this.btnArcher.TabIndex = 0;
            this.btnArcher.Text = "Archer";
            this.btnArcher.UseVisualStyleBackColor = true;
            this.btnArcher.Click += new System.EventHandler(this.btnArcher_Click);
            // 
            // btnMage
            // 
            this.btnMage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMage.Location = new System.Drawing.Point(309, 176);
            this.btnMage.Name = "btnMage";
            this.btnMage.Size = new System.Drawing.Size(176, 51);
            this.btnMage.TabIndex = 1;
            this.btnMage.Text = "Mage";
            this.btnMage.UseVisualStyleBackColor = true;
            this.btnMage.Click += new System.EventHandler(this.btnMage_Click);
            // 
            // btnWarrior
            // 
            this.btnWarrior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWarrior.Location = new System.Drawing.Point(537, 176);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(176, 51);
            this.btnWarrior.TabIndex = 2;
            this.btnWarrior.Text = "Warrior";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // btnAssasin
            // 
            this.btnAssasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAssasin.Location = new System.Drawing.Point(309, 311);
            this.btnAssasin.Name = "btnAssasin";
            this.btnAssasin.Size = new System.Drawing.Size(176, 42);
            this.btnAssasin.TabIndex = 3;
            this.btnAssasin.Text = "Assasin";
            this.btnAssasin.UseVisualStyleBackColor = true;
            this.btnAssasin.Click += new System.EventHandler(this.btnAssasin_Click);
            // 
            // btnNpc
            // 
            this.btnNpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNpc.Location = new System.Drawing.Point(537, 311);
            this.btnNpc.Name = "btnNpc";
            this.btnNpc.Size = new System.Drawing.Size(175, 41);
            this.btnNpc.TabIndex = 4;
            this.btnNpc.Text = "NPC";
            this.btnNpc.UseVisualStyleBackColor = true;
            this.btnNpc.Click += new System.EventHandler(this.btnNpc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNpc);
            this.Controls.Add(this.btnAssasin);
            this.Controls.Add(this.btnWarrior);
            this.Controls.Add(this.btnMage);
            this.Controls.Add(this.btnArcher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArcher;
        private System.Windows.Forms.Button btnMage;
        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnAssasin;
        private System.Windows.Forms.Button btnNpc;
    }
}

