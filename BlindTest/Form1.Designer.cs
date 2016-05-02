namespace BlindTest
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.appName = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.scores = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.appName.Size = new System.Drawing.Size(1096, 60);
            this.appName.TabIndex = 0;
            this.appName.Text = "Blind Test";
            this.appName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.appName.Click += new System.EventHandler(this.label1_Click);
            // 
            // play
            // 
            this.play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.Snow;
            this.play.Location = new System.Drawing.Point(443, 162);
            this.play.MaximumSize = new System.Drawing.Size(200, 50);
            this.play.MinimumSize = new System.Drawing.Size(200, 50);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(200, 50);
            this.play.TabIndex = 1;
            this.play.Text = "Jouer";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // scores
            // 
            this.scores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.scores.FlatAppearance.BorderSize = 0;
            this.scores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scores.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores.ForeColor = System.Drawing.Color.Snow;
            this.scores.Location = new System.Drawing.Point(443, 275);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(200, 49);
            this.scores.TabIndex = 2;
            this.scores.Text = "Scores";
            this.scores.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(129)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 618);
            this.Controls.Add(this.scores);
            this.Controls.Add(this.play);
            this.Controls.Add(this.appName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button scores;
    }
}

