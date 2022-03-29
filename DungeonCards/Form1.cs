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
using static DungeonCards.Player;

namespace DungeonCards
{
    public partial class Game_Form : Form
    {
        int rows_count = 3;
        int columns_count = 3;
        Card[] cards = new Card[8];
        Player player;
        public Game_Form()
        {
            InitializeComponent();
        }
        public delegate void CardDelegate();
        public void card_click(object sender, EventArgs e)
        {
            player.panel.BackColor = Color.Green;

            Control panel;
            if (sender is Label) { panel = (Label)sender; panel = panel.Parent; }
            else if (sender is PictureBox) { panel = (PictureBox)sender ; panel = panel.Parent; }
            else panel = (Panel)sender;
            panel.BackColor = Color.Lavender;
            debugger.Text = Math.Abs((player.panel.Location.X + panel.Location.X) - (player.panel.Location.Y + panel.Location.Y)).ToString();

            if (Math.Abs((player.panel.Location.X - panel.Location.X) + (player.panel.Location.Y - panel.Location.Y)) == 200)
            {
                //debugger.Text = "Алло";
                Point buffer_location = player.panel.Location;
                player.panel.Location = new Point(panel.Location.X, panel.Location.Y);
                panel.Location = buffer_location;
            }
        }
        public void Game_Form_Load(object sender, EventArgs e)
        {
            var controls = this.Controls;
            int index_of_card = 0;
            for (int a = 0; a < controls.Count; a++)
            {
                if (controls[a] is Panel)
                {
                    if (Convert.ToString(controls[a].Tag) == "player") { player = new Player("Русико", 20, "player", (Panel)controls[a]); continue; }
                    cards[index_of_card] = new Card("Анатолий", 10, "enemy", (Panel)controls[a]);
                    cards[index_of_card].panel.Click += card_click;
                    cards[index_of_card].name_label.Click += card_click;
                    cards[index_of_card].health_label.Click += card_click;
                    cards[index_of_card].picture_pictureBox.Click += card_click;
                    cards[index_of_card].weapon_pictureBox.Click += card_click;
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
