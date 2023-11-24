namespace Yemek_Tarifi
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
            btnAddStage = new System.Windows.Forms.Button();
            lstStages = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // btnAddStage
            // 
            btnAddStage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddStage.Location = new System.Drawing.Point(416, 140);
            btnAddStage.Name = "btnAddStage";
            btnAddStage.Size = new System.Drawing.Size(252, 77);
            btnAddStage.TabIndex = 0;
            btnAddStage.Text = "Stage Add";
            btnAddStage.UseVisualStyleBackColor = true;
            btnAddStage.Click += btnAddStage_Click;
            // 
            // lstStages
            // 
            lstStages.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lstStages.FormattingEnabled = true;
            lstStages.ItemHeight = 25;
            lstStages.Location = new System.Drawing.Point(91, 58);
            lstStages.Name = "lstStages";
            lstStages.Size = new System.Drawing.Size(260, 304);
            lstStages.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lstStages);
            Controls.Add(btnAddStage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddStage;
        private System.Windows.Forms.ListBox lstStages;
    }
}
