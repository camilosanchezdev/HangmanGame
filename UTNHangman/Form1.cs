using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTNHangman
{
    public partial class Hangout : Form
    {
        public Hangout()
        {
            InitializeComponent();

            RandomWord();
            UploadLetters();
            UploadImages();
        }
        int cont = 1;
        int contWin = 0;
        string[] wordHide = { "HOME", "FIVE", "DOOR", "BLUE", "SOAP" };
        public void RandomWord()
        {
            Random rnd = new Random();
            string word = wordHide[rnd.Next(0, 4)];
            letra1.Text = word[0].ToString();
            letra2.Text = word[1].ToString();
            letra3.Text = word[2].ToString();
            letra4.Text = word[3].ToString();
        }
        
        List<Label> letters = new List<Label>();
        public void UploadLetters()
        {
            letters.Add(letra1);
            letters.Add(letra2);
            letters.Add(letra3);
            letters.Add(letra4);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only letters
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        // Images hangout

        List<Bitmap> hangoutParts = new List<Bitmap>();
        public void UploadImages()
        {
            var bmp0 = new Bitmap(UTNHangman.Properties.Resources.img1);
            var bmp1 = new Bitmap(UTNHangman.Properties.Resources.img2);
            var bmp2 = new Bitmap(UTNHangman.Properties.Resources.img3);
            var bmp3 = new Bitmap(UTNHangman.Properties.Resources.img4);
            var bmp4 = new Bitmap(UTNHangman.Properties.Resources.img5);
            var bmp5 = new Bitmap(UTNHangman.Properties.Resources.img6);
            var bmp6 = new Bitmap(UTNHangman.Properties.Resources.img7);
            hangoutParts.Add(bmp0);
            hangoutParts.Add(bmp1);
            hangoutParts.Add(bmp2);
            hangoutParts.Add(bmp3);
            hangoutParts.Add(bmp4);
            hangoutParts.Add(bmp5);
            hangoutParts.Add(bmp6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check each space
            bool horcaCheck = false;
            foreach (var item in letters)
            {
               
                if (testLetter.Text ==  item.Text)
                {
                    item.Visible = true;
                    // flag positve
                    horcaCheck = true;
                    contWin++;
                }
            }
            // Clean textbox
            testLetter.Text = "";

            if (!horcaCheck)
            {
                // flag negative
                // add element to hangout
                Horca.Image = hangoutParts[cont];
                cont++;
            }
            if (cont == 7)
            {
                btnTry.Enabled = false;
                testLetter.ReadOnly = true;
                gameOver.Text = "GAME OVER";
                // Show secret word
                foreach (var item in letters)
                {
                    item.Visible = true;
                }
                // Btn Play again
                btnPlayAgain.Visible = true;
                btnPlayAgain.Enabled = true;
                
                
            }
            if (contWin == 4)
            {
                btnTry.Enabled = false;
                testLetter.ReadOnly = true;
                gameOver.Text = "GANASTE";
                // Btn Play again
                btnPlayAgain.Visible = true;
                btnPlayAgain.Enabled = true;
            }


        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Restart game
            testLetter.ReadOnly = false;
            gameOver.Text = "";
            btnTry.Enabled = true;
            Horca.Image = hangoutParts[0];
            cont = 1;
            contWin = 0;
            foreach (var item in letters)
            {
                item.Visible = false;
            }
            btnPlayAgain.Enabled = false;
            btnPlayAgain.Visible = false;
            RandomWord();
        }
    }
}
