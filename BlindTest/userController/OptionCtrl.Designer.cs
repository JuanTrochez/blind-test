namespace BlindTest.userController
{
    partial class OptionCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionCtrl));
            this.back = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.appName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(210)))), ((int)(((byte)(17)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Verdana", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(15, 20);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(186, 44);
            this.back.TabIndex = 12;
            this.back.Text = "< Menu";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(210)))), ((int)(((byte)(17)))));
            this.browse.FlatAppearance.BorderSize = 0;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(655, 273);
            this.browse.Margin = new System.Windows.Forms.Padding(1);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(151, 29);
            this.browse.TabIndex = 13;
            this.browse.Text = "Parcourir";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 20);
            this.textBox1.TabIndex = 14;
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
            this.appName.TabIndex = 15;
            this.appName.Text = "Blind Test";
            this.appName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OptionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.back);
            this.Controls.Add(this.appName);
            this.Name = "OptionCtrl";
            this.Size = new System.Drawing.Size(1112, 621);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label appName;
    }
}
