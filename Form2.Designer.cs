
namespace Pong
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.TittleLable = new System.Windows.Forms.Label();
            this.trollFaceCharacter = new System.Windows.Forms.PictureBox();
            this.mogCharacter = new System.Windows.Forms.PictureBox();
            this.noCharacter = new System.Windows.Forms.PictureBox();
            this.foreverAlone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trollFaceCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreverAlone)).BeginInit();
            this.SuspendLayout();
            // 
            // TittleLable
            // 
            this.TittleLable.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLable.Location = new System.Drawing.Point(74, 38);
            this.TittleLable.Name = "TittleLable";
            this.TittleLable.Size = new System.Drawing.Size(657, 84);
            this.TittleLable.TabIndex = 0;
            this.TittleLable.Text = "Click A Character";
            this.TittleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trollFaceCharacter
            // 
            this.trollFaceCharacter.BackColor = System.Drawing.Color.Transparent;
            this.trollFaceCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trollFaceCharacter.BackgroundImage")));
            this.trollFaceCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trollFaceCharacter.Location = new System.Drawing.Point(53, 157);
            this.trollFaceCharacter.Name = "trollFaceCharacter";
            this.trollFaceCharacter.Size = new System.Drawing.Size(160, 160);
            this.trollFaceCharacter.TabIndex = 1;
            this.trollFaceCharacter.TabStop = false;
            this.trollFaceCharacter.Click += new System.EventHandler(this.trollFaceCharacter_Click);
            // 
            // mogCharacter
            // 
            this.mogCharacter.BackColor = System.Drawing.Color.Transparent;
            this.mogCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mogCharacter.BackgroundImage")));
            this.mogCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mogCharacter.Location = new System.Drawing.Point(240, 157);
            this.mogCharacter.Name = "mogCharacter";
            this.mogCharacter.Size = new System.Drawing.Size(160, 160);
            this.mogCharacter.TabIndex = 2;
            this.mogCharacter.TabStop = false;
            this.mogCharacter.Click += new System.EventHandler(this.mogCharacter_Click);
            // 
            // noCharacter
            // 
            this.noCharacter.BackColor = System.Drawing.Color.Transparent;
            this.noCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noCharacter.BackgroundImage")));
            this.noCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.noCharacter.Location = new System.Drawing.Point(420, 157);
            this.noCharacter.Name = "noCharacter";
            this.noCharacter.Size = new System.Drawing.Size(160, 160);
            this.noCharacter.TabIndex = 3;
            this.noCharacter.TabStop = false;
            this.noCharacter.Click += new System.EventHandler(this.noCharacter_Click);
            // 
            // foreverAlone
            // 
            this.foreverAlone.BackColor = System.Drawing.Color.Transparent;
            this.foreverAlone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("foreverAlone.BackgroundImage")));
            this.foreverAlone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foreverAlone.Location = new System.Drawing.Point(601, 157);
            this.foreverAlone.Name = "foreverAlone";
            this.foreverAlone.Size = new System.Drawing.Size(160, 160);
            this.foreverAlone.TabIndex = 4;
            this.foreverAlone.TabStop = false;
            this.foreverAlone.Click += new System.EventHandler(this.foreverAlone_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foreverAlone);
            this.Controls.Add(this.noCharacter);
            this.Controls.Add(this.mogCharacter);
            this.Controls.Add(this.trollFaceCharacter);
            this.Controls.Add(this.TittleLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "CharacterForm";
            this.Text = "Choose a character";
            ((System.ComponentModel.ISupportInitialize)(this.trollFaceCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mogCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreverAlone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TittleLable;
        private System.Windows.Forms.PictureBox trollFaceCharacter;
        private System.Windows.Forms.PictureBox mogCharacter;
        private System.Windows.Forms.PictureBox noCharacter;
        private System.Windows.Forms.PictureBox foreverAlone;
    }
}