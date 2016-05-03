namespace BlindTest.userController
{
    partial class HighScore
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.appName = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(321, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(475, 329);
            this.listBox1.TabIndex = 0;
            // 
            // appName
            // 
            this.appName.BackColor = System.Drawing.Color.Transparent;
            this.appName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appName.Font = new System.Drawing.Font("Monotype Corsiva", 41.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.Cornsilk;
            this.appName.Location = new System.Drawing.Point(0, 0);
            this.appName.MaximumSize = new System.Drawing.Size(0, 60);
            this.appName.Name = "appName";
            this.appName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.appName.Size = new System.Drawing.Size(1112, 60);
            this.appName.TabIndex = 2;
            this.appName.Text = "Blind Test";
            this.appName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(210)))), ((int)(((byte)(17)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Verdana", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(11, 19);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(186, 44);
            this.back.TabIndex = 13;
            this.back.Text = "< Menu";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.back);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.listBox1);
            this.Name = "HighScore";
            this.Size = new System.Drawing.Size(1112, 621);
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Button back;
    }
}
