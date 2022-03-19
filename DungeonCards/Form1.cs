using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DungeonCards.Card;

namespace DungeonCards
{
    public partial class Game_Form : Form
    {
        int rows_count = 3;
        int columns_count = 3;
        Card[] cards = new Card[8];
        public Game_Form()
        {
            InitializeComponent();
        }

        private void Game_Form_Load(object sender, EventArgs e)
        {

            player.BackColor = Color.Green;

            var controls = this.Controls;
            int index_of_card = 0;
            for (int a = 0; a < controls.Count; a++)
                if (controls[a] is Panel)
                {
                    cards[index_of_card] = new Card(Convert.ToString(index_of_card++), (Panel)controls[a]);
                    (Panel)controls[a].Click += cards[index_of_card].сolorize;
                }
        }

        private void Card_click(object sender, EventArgs e)
        {
            PictureBox card = (PictureBox)sender;
            card.BackColor = Color.Red;
            debugger.Text = Convert.ToString(card.Location.X) + " /" + Convert.ToString(card.Location.Y);
            int card_x = card.Location.X;
            int card_y = card.Location.Y;

            card.Location = new Point(player.Location.X, player.Location.Y);
            player.Location = new Point(card_x, card_y);
        }

        private void colorize(object sender, EventArgs e)
        {

        }
    }

}
