namespace Bazinga_
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
            this.BtPaper = new System.Windows.Forms.Button();
            this.BtRock = new System.Windows.Forms.Button();
            this.BtScissors = new System.Windows.Forms.Button();
            this.BtLizard = new System.Windows.Forms.Button();
            this.BtProsperity = new System.Windows.Forms.Button();
            this.PicPlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbDescriptionPlayer = new System.Windows.Forms.Label();
            this.LbScorePlayer = new System.Windows.Forms.Label();
            this.LbScoreSheldon = new System.Windows.Forms.Label();
            this.LbDescriptionSheldon = new System.Windows.Forms.Label();
            this.PicSheldon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSheldon)).BeginInit();
            this.SuspendLayout();
            // 
            // BtPaper
            // 
            this.BtPaper.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtPaper.BackgroundImage = global::Bazinga_.Properties.Resources.paper;
            this.BtPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPaper.Location = new System.Drawing.Point(158, 278);
            this.BtPaper.Name = "BtPaper";
            this.BtPaper.Size = new System.Drawing.Size(140, 160);
            this.BtPaper.TabIndex = 0;
            this.BtPaper.Tag = "1";
            this.BtPaper.UseVisualStyleBackColor = false;
            this.BtPaper.Click += new System.EventHandler(this.ClickPlay);
            // 
            // BtRock
            // 
            this.BtRock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtRock.BackgroundImage = global::Bazinga_.Properties.Resources.rock;
            this.BtRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtRock.Location = new System.Drawing.Point(12, 278);
            this.BtRock.Name = "BtRock";
            this.BtRock.Size = new System.Drawing.Size(140, 160);
            this.BtRock.TabIndex = 1;
            this.BtRock.Tag = "0";
            this.BtRock.UseVisualStyleBackColor = false;
            this.BtRock.Click += new System.EventHandler(this.ClickPlay);
            // 
            // BtScissors
            // 
            this.BtScissors.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtScissors.BackgroundImage = global::Bazinga_.Properties.Resources.scissors;
            this.BtScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtScissors.Location = new System.Drawing.Point(304, 278);
            this.BtScissors.Name = "BtScissors";
            this.BtScissors.Size = new System.Drawing.Size(140, 160);
            this.BtScissors.TabIndex = 2;
            this.BtScissors.Tag = "2";
            this.BtScissors.UseVisualStyleBackColor = false;
            this.BtScissors.Click += new System.EventHandler(this.ClickPlay);
            // 
            // BtLizard
            // 
            this.BtLizard.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtLizard.BackgroundImage = global::Bazinga_.Properties.Resources.lizard;
            this.BtLizard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtLizard.Location = new System.Drawing.Point(450, 278);
            this.BtLizard.Name = "BtLizard";
            this.BtLizard.Size = new System.Drawing.Size(140, 160);
            this.BtLizard.TabIndex = 3;
            this.BtLizard.Tag = "3";
            this.BtLizard.UseVisualStyleBackColor = false;
            this.BtLizard.Click += new System.EventHandler(this.ClickPlay);
            // 
            // BtProsperity
            // 
            this.BtProsperity.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtProsperity.BackgroundImage = global::Bazinga_.Properties.Resources.prosperity;
            this.BtProsperity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtProsperity.Location = new System.Drawing.Point(596, 278);
            this.BtProsperity.Name = "BtProsperity";
            this.BtProsperity.Size = new System.Drawing.Size(140, 160);
            this.BtProsperity.TabIndex = 4;
            this.BtProsperity.Tag = "4";
            this.BtProsperity.UseVisualStyleBackColor = false;
            this.BtProsperity.Click += new System.EventHandler(this.ClickPlay);
            // 
            // PicPlayer
            // 
            this.PicPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PicPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicPlayer.Location = new System.Drawing.Point(57, 29);
            this.PicPlayer.Name = "PicPlayer";
            this.PicPlayer.Size = new System.Drawing.Size(200, 200);
            this.PicPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayer.TabIndex = 5;
            this.PicPlayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // LbDescriptionPlayer
            // 
            this.LbDescriptionPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDescriptionPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbDescriptionPlayer.Location = new System.Drawing.Point(263, 29);
            this.LbDescriptionPlayer.Name = "LbDescriptionPlayer";
            this.LbDescriptionPlayer.Size = new System.Drawing.Size(68, 26);
            this.LbDescriptionPlayer.TabIndex = 8;
            this.LbDescriptionPlayer.Text = "Player";
            this.LbDescriptionPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbDescriptionPlayer.Click += new System.EventHandler(this.LbDescriptionPlayer_Click);
            // 
            // LbScorePlayer
            // 
            this.LbScorePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScorePlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbScorePlayer.Location = new System.Drawing.Point(275, 55);
            this.LbScorePlayer.Name = "LbScorePlayer";
            this.LbScorePlayer.Size = new System.Drawing.Size(41, 26);
            this.LbScorePlayer.TabIndex = 9;
            this.LbScorePlayer.Text = "0";
            this.LbScorePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbScoreSheldon
            // 
            this.LbScoreSheldon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbScoreSheldon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbScoreSheldon.Location = new System.Drawing.Point(427, 55);
            this.LbScoreSheldon.Name = "LbScoreSheldon";
            this.LbScoreSheldon.Size = new System.Drawing.Size(41, 26);
            this.LbScoreSheldon.TabIndex = 12;
            this.LbScoreSheldon.Text = "0";
            this.LbScoreSheldon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbDescriptionSheldon
            // 
            this.LbDescriptionSheldon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDescriptionSheldon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbDescriptionSheldon.Location = new System.Drawing.Point(413, 29);
            this.LbDescriptionSheldon.Name = "LbDescriptionSheldon";
            this.LbDescriptionSheldon.Size = new System.Drawing.Size(68, 26);
            this.LbDescriptionSheldon.TabIndex = 11;
            this.LbDescriptionSheldon.Text = "Sheldon";
            this.LbDescriptionSheldon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicSheldon
            // 
            this.PicSheldon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PicSheldon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicSheldon.Location = new System.Drawing.Point(493, 29);
            this.PicSheldon.Name = "PicSheldon";
            this.PicSheldon.Size = new System.Drawing.Size(200, 200);
            this.PicSheldon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSheldon.TabIndex = 10;
            this.PicSheldon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(750, 465);
            this.Controls.Add(this.LbScoreSheldon);
            this.Controls.Add(this.LbDescriptionSheldon);
            this.Controls.Add(this.PicSheldon);
            this.Controls.Add(this.LbScorePlayer);
            this.Controls.Add(this.LbDescriptionPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicPlayer);
            this.Controls.Add(this.BtProsperity);
            this.Controls.Add(this.BtLizard);
            this.Controls.Add(this.BtScissors);
            this.Controls.Add(this.BtRock);
            this.Controls.Add(this.BtPaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bazinga!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSheldon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtPaper;
        private System.Windows.Forms.Button BtRock;
        private System.Windows.Forms.Button BtScissors;
        private System.Windows.Forms.Button BtLizard;
        private System.Windows.Forms.Button BtProsperity;
        private System.Windows.Forms.PictureBox PicPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbDescriptionPlayer;
        private System.Windows.Forms.Label LbScorePlayer;
        private System.Windows.Forms.Label LbScoreSheldon;
        private System.Windows.Forms.Label LbDescriptionSheldon;
        private System.Windows.Forms.PictureBox PicSheldon;
    }
}

