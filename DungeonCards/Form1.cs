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
using static DungeonCards.IndexStorage;

namespace DungeonCards
{
    public partial class Game_Form : Form
    {
        int rows_count = 3;
        int columns_count = 3;
        Card[,] cards = new Card[3,3];
        Player player;
        public Game_Form()
        {
            InitializeComponent();
        }
        public delegate void CardDelegate();
        public void card_click(object sender, EventArgs e)
        {
            Control panel;
            if (sender is Label) { panel = (Label)sender; panel = panel.Parent; }
            else if (sender is PictureBox) { panel = (PictureBox)sender; panel = panel.Parent; }
            else panel = (Panel)sender;

            debugger.Text = Convert.ToString(panel.Location.Y / 200 + " | " + panel.Location.X / 200);
            var card = findByTag(cards, ((IndexStorage)panel.Tag).row, ((IndexStorage)panel.Tag).column);
            if (!change_positions(player, card)) return;

            player.changeHealth(Math.Max(0, player.health - card.health));
            card.changeHealth(Math.Max(0, card.health - player.health));

            bool change_positions(Card first, Card second)
            {
                debugger.Text = Convert.ToString(Math.Abs((first.panel.Location.Y / 200 - second.panel.Location.Y / 200) + (first.panel.Location.X / 200 - second.panel.Location.X / 200)));
                if (Math.Abs((first.panel.Location.Y/200 - second.panel.Location.Y / 200) + (first.panel.Location.X / 200 - second.panel.Location.X / 200)) == 1 
                    &&
                Math.Abs(first.panel.Location.Y / 200 - second.panel.Location.Y / 200) < 2 && Math.Abs(first.panel.Location.X / 200 - second.panel.Location.X / 200) < 2
                )
                {
                    IndexStorage bugger_tag = (IndexStorage)first.panel.Tag;
                    first.panel.Tag = (IndexStorage)second.panel.Tag;
                    second.panel.Tag = bugger_tag;
                    Point first_point = second.panel.Location;
                    second.panel.Location = first.panel.Location;
                    first.panel.Location = first_point;
                    first.writeTag();
                    second.writeTag();
                    return true;
                }
                return false;
            }
            Card findByTag(Card[,] cards, int row, int column)
            {
                Card card_return = cards[0, 0];
                for(int i =0;i<3; i++)
                    for(int j =0;j<3;j++)
                    {
                        if(((IndexStorage)cards[i,j].panel.Tag).row == row && ((IndexStorage)cards[i, j].panel.Tag).column == column)
                        {
                            return cards[i, j];
                        }
                    }
                return card_return;
            }
        }
        public void Game_Form_Load(object sender, EventArgs e)
        {
            var controls = this.Controls;
            int card_index = 0;
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                    if (row == 1 && column == 1)
                    {
                        player = new Player("Player", 20, new Point(200 * column, 200 * row), "player", "-1");
                        cards[row, column] = player;
                        this.Controls.Add(player.panel);
                    }
                    else
                    {
                        cards[row, column] = new Card("Name", 1, new Point(200 * column, 200 * row), "player", Convert.ToString(card_index++));
                        cards[row, column].panel.Click += card_click;
                        for (int a = 0; a < cards[row, column].panel.Controls.Count; a++)
                        {
                            cards[row, column].panel.Controls[a].Click += card_click;
                        }
                        //cards[index_of_card].picture_pictureBox.Click += card_click;
                        //cards[index_of_card].weapon_pictureBox.Click += card_click;
                        this.Controls.Add(cards[row, column].panel);
                    }
            //for (int a = 0; a < controls.Count; a++)
            //{
            //    if (controls[a] is Panel)
            //    {
            //        if (Convert.ToString(controls[a].Tag) == "player") {  }
            //        cards[index_of_card] = new Card("Анатолий", 10, (Panel)controls[a]);
            //        cards[index_of_card].panel.Click += card_click;
            //        //cards[index_of_card].name_label.Click += card_click;
            //        cards[index_of_card].health_label.Click += card_click;
            //        //cards[index_of_card].picture_pictureBox.Click += card_click;
            //        //cards[index_of_card].weapon_pictureBox.Click += card_click;
            //    }
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
