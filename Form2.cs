using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void trollFaceCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\raf_c\OneDrive\Imagens\projetos\trollface.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void mogCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\raf_c\OneDrive\Imagens\projetos\meme2.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void noCharacter_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\raf_c\OneDrive\Imagens\projetos\meme3.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void foreverAlone_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Image.FromFile(@"C:\Users\raf_c\OneDrive\Imagens\projetos\meme4.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }
    }
}
