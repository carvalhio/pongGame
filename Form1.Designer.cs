
namespace Pong
{
    partial class Pong
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cpuPlayerBox = new System.Windows.Forms.PictureBox();
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cpuPlayerBox
            // 
            this.cpuPlayerBox.BackColor = System.Drawing.Color.Lime;
            this.cpuPlayerBox.Location = new System.Drawing.Point(1026, 249);
            this.cpuPlayerBox.Name = "cpuPlayerBox";
            this.cpuPlayerBox.Size = new System.Drawing.Size(15, 118);
            this.cpuPlayerBox.TabIndex = 1;
            this.cpuPlayerBox.TabStop = false;
            // 
            // pongBall
            // 
            this.pongBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pongBall.BackgroundImage")));
            this.pongBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pongBall.Location = new System.Drawing.Point(542, 285);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(18, 17);
            this.pongBall.TabIndex = 2;
            this.pongBall.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(473, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // playerScore
            // 
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Cascadia Mono", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.playerScore.Location = new System.Drawing.Point(400, 74);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(55, 55);
            this.playerScore.TabIndex = 4;
            this.playerScore.Text = "0";
            this.playerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuScore
            // 
            this.cpuScore.BackColor = System.Drawing.Color.Transparent;
            this.cpuScore.Font = new System.Drawing.Font("Cascadia Mono", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuScore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cpuScore.Location = new System.Drawing.Point(638, 74);
            this.cpuScore.Name = "cpuScore";
            this.cpuScore.Size = new System.Drawing.Size(55, 55);
            this.cpuScore.TabIndex = 5;
            this.cpuScore.Text = "0";
            this.cpuScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 648);
            this.Controls.Add(this.cpuScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.cpuPlayerBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1069, 687);
            this.MinimumSize = new System.Drawing.Size(1069, 687);
            this.Name = "Pong";
            this.Text = "Pong";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPlayerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cpuPlayerBox;
        private System.Windows.Forms.PictureBox pongBall;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuScore;
    }
}

