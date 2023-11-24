using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        string secretKey;

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] secretKeys = { "dolap", "bilgisayar", "fare", "kalem" };
            secretKey = secretKeys[random.Next(0, secretKeys.Length)];
            txtGuess.Enabled = true;
            btnCheck.Enabled = true;
            txtGuess.Text = "";


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;
            if (guess == secretKey)
            {
                MessageBox.Show("Kazandınız...");
            }
            else
            {
                char[] letters = guess.ToCharArray();
                string matchedLetters = "";
                foreach (char letter in letters)
                {
                    if(secretKey.Contains(letter) && matchedLetters.Contains(letter))
                    {
                        matchedLetters += $"{letter},";
                    }
                }
                if (matchedLetters != "")
                {
                    matchedLetters = matchedLetters.TrimEnd(',');
                    listBox1.Items.Add(matchedLetters);
                }
            }
            txtGuess.Text = "";
        }
    }
}
