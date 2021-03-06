﻿namespace BlindTest.userController
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.appName = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musiqueChoice1 = new System.Windows.Forms.RadioButton();
            this.musiqueChoice2 = new System.Windows.Forms.RadioButton();
            this.musiqueChoice4 = new System.Windows.Forms.RadioButton();
            this.musiqueChoice3 = new System.Windows.Forms.RadioButton();
            this.goodResponse = new System.Windows.Forms.TextBox();
            this.wrongAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.appName.Size = new System.Drawing.Size(1112, 60);
            this.appName.TabIndex = 1;
            this.appName.Text = "Blind Test";
            this.appName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressTimer
            // 
            this.progressTimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressTimer.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.progressTimer.Location = new System.Drawing.Point(292, 357);
            this.progressTimer.Margin = new System.Windows.Forms.Padding(4);
            this.progressTimer.Name = "progressTimer";
            this.progressTimer.Size = new System.Drawing.Size(500, 13);
            this.progressTimer.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 277);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // musiqueChoice1
            // 
            this.musiqueChoice1.Appearance = System.Windows.Forms.Appearance.Button;
            this.musiqueChoice1.AutoSize = true;
            this.musiqueChoice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.musiqueChoice1.CausesValidation = false;
            this.musiqueChoice1.FlatAppearance.BorderSize = 0;
            this.musiqueChoice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musiqueChoice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musiqueChoice1.ForeColor = System.Drawing.Color.White;
            this.musiqueChoice1.Location = new System.Drawing.Point(292, 394);
            this.musiqueChoice1.Margin = new System.Windows.Forms.Padding(4);
            this.musiqueChoice1.MaximumSize = new System.Drawing.Size(200, 0);
            this.musiqueChoice1.MinimumSize = new System.Drawing.Size(200, 0);
            this.musiqueChoice1.Name = "musiqueChoice1";
            this.musiqueChoice1.Size = new System.Drawing.Size(200, 32);
            this.musiqueChoice1.TabIndex = 5;
            this.musiqueChoice1.TabStop = true;
            this.musiqueChoice1.Text = "Musique 1";
            this.musiqueChoice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musiqueChoice1.UseVisualStyleBackColor = false;
            this.musiqueChoice1.CheckedChanged += new System.EventHandler(this.musiqueChoice1_CheckedChanged);
            // 
            // musiqueChoice2
            // 
            this.musiqueChoice2.Appearance = System.Windows.Forms.Appearance.Button;
            this.musiqueChoice2.AutoSize = true;
            this.musiqueChoice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.musiqueChoice2.CausesValidation = false;
            this.musiqueChoice2.FlatAppearance.BorderSize = 0;
            this.musiqueChoice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musiqueChoice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musiqueChoice2.ForeColor = System.Drawing.Color.White;
            this.musiqueChoice2.Location = new System.Drawing.Point(592, 394);
            this.musiqueChoice2.Margin = new System.Windows.Forms.Padding(4);
            this.musiqueChoice2.MaximumSize = new System.Drawing.Size(200, 0);
            this.musiqueChoice2.MinimumSize = new System.Drawing.Size(200, 0);
            this.musiqueChoice2.Name = "musiqueChoice2";
            this.musiqueChoice2.Size = new System.Drawing.Size(200, 32);
            this.musiqueChoice2.TabIndex = 6;
            this.musiqueChoice2.TabStop = true;
            this.musiqueChoice2.Text = "Musique 2";
            this.musiqueChoice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musiqueChoice2.UseVisualStyleBackColor = false;
            this.musiqueChoice2.CheckedChanged += new System.EventHandler(this.musiqueChoice2_CheckedChanged);
            // 
            // musiqueChoice4
            // 
            this.musiqueChoice4.Appearance = System.Windows.Forms.Appearance.Button;
            this.musiqueChoice4.AutoSize = true;
            this.musiqueChoice4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.musiqueChoice4.CausesValidation = false;
            this.musiqueChoice4.FlatAppearance.BorderSize = 0;
            this.musiqueChoice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musiqueChoice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musiqueChoice4.ForeColor = System.Drawing.Color.White;
            this.musiqueChoice4.Location = new System.Drawing.Point(592, 462);
            this.musiqueChoice4.Margin = new System.Windows.Forms.Padding(4);
            this.musiqueChoice4.MaximumSize = new System.Drawing.Size(200, 0);
            this.musiqueChoice4.MinimumSize = new System.Drawing.Size(200, 0);
            this.musiqueChoice4.Name = "musiqueChoice4";
            this.musiqueChoice4.Size = new System.Drawing.Size(200, 32);
            this.musiqueChoice4.TabIndex = 7;
            this.musiqueChoice4.TabStop = true;
            this.musiqueChoice4.Text = "Musique 4";
            this.musiqueChoice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musiqueChoice4.UseVisualStyleBackColor = false;
            this.musiqueChoice4.CheckedChanged += new System.EventHandler(this.musiqueChoice4_CheckedChanged);
            // 
            // musiqueChoice3
            // 
            this.musiqueChoice3.Appearance = System.Windows.Forms.Appearance.Button;
            this.musiqueChoice3.AutoSize = true;
            this.musiqueChoice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.musiqueChoice3.CausesValidation = false;
            this.musiqueChoice3.FlatAppearance.BorderSize = 0;
            this.musiqueChoice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musiqueChoice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musiqueChoice3.ForeColor = System.Drawing.Color.White;
            this.musiqueChoice3.Location = new System.Drawing.Point(292, 462);
            this.musiqueChoice3.Margin = new System.Windows.Forms.Padding(4);
            this.musiqueChoice3.MaximumSize = new System.Drawing.Size(200, 0);
            this.musiqueChoice3.MinimumSize = new System.Drawing.Size(200, 0);
            this.musiqueChoice3.Name = "musiqueChoice3";
            this.musiqueChoice3.Size = new System.Drawing.Size(200, 32);
            this.musiqueChoice3.TabIndex = 8;
            this.musiqueChoice3.TabStop = true;
            this.musiqueChoice3.Text = "Musique 3";
            this.musiqueChoice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musiqueChoice3.UseVisualStyleBackColor = false;
            this.musiqueChoice3.CheckedChanged += new System.EventHandler(this.musiqueChoice3_CheckedChanged);
            // 
            // goodResponse
            // 
            this.goodResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(141)))), ((int)(((byte)(129)))));
            this.goodResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goodResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodResponse.ForeColor = System.Drawing.Color.White;
            this.goodResponse.Location = new System.Drawing.Point(292, 512);
            this.goodResponse.Margin = new System.Windows.Forms.Padding(4);
            this.goodResponse.Name = "goodResponse";
            this.goodResponse.Size = new System.Drawing.Size(500, 19);
            this.goodResponse.TabIndex = 9;
            this.goodResponse.Text = "Bonne réponse !";
            this.goodResponse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.goodResponse.Visible = false;
            // 
            // wrongAnswer
            // 
            this.wrongAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.wrongAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongAnswer.ForeColor = System.Drawing.Color.White;
            this.wrongAnswer.Location = new System.Drawing.Point(292, 512);
            this.wrongAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.wrongAnswer.Name = "wrongAnswer";
            this.wrongAnswer.Size = new System.Drawing.Size(500, 19);
            this.wrongAnswer.TabIndex = 10;
            this.wrongAnswer.Text = "Mauvaise réponse !";
            this.wrongAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wrongAnswer.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(210)))), ((int)(((byte)(17)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(459, 554);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Suivant";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(920, 554);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(172, 19);
            this.txtScore.TabIndex = 13;
            this.txtScore.Text = "Score : 0";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(210)))), ((int)(((byte)(17)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(459, 554);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.back.TabIndex = 15;
            this.back.Text = "< Menu";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.back);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wrongAnswer);
            this.Controls.Add(this.goodResponse);
            this.Controls.Add(this.musiqueChoice3);
            this.Controls.Add(this.musiqueChoice4);
            this.Controls.Add(this.musiqueChoice2);
            this.Controls.Add(this.musiqueChoice1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressTimer);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(1112, 621);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.ProgressBar progressTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton musiqueChoice1;
        private System.Windows.Forms.RadioButton musiqueChoice2;
        private System.Windows.Forms.RadioButton musiqueChoice4;
        private System.Windows.Forms.RadioButton musiqueChoice3;
        private System.Windows.Forms.TextBox goodResponse;
        private System.Windows.Forms.TextBox wrongAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back;
    }
}
