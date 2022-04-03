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
        Card[] cards = new Card[8];
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



            if(!change_positions((Panel)player.panel, (Panel)panel)) return



            Boolean change_positions(Panel first, Panel second)
            {
                IndexStorage first_tag = (IndexStorage)first.Tag;
                IndexStorage second_tag = (IndexStorage)second.Tag;
                debugger.Text = Convert.ToString(((IndexStorage)first.Tag).row + " | " + ((IndexStorage)first.Tag).column);
                if (Math.Abs((first_tag.row - second_tag.row) + (first_tag.column - second_tag.column)) == 1 &&
                Math.Abs(first_tag.row - second_tag.row) < 2 && Math.Abs(first_tag.column - second_tag.column) < 2)
                {
                    first.Tag = second_tag;
                    second.Tag = first_tag;
                    Point first_point = second.Location;
                    second.Location = first.Location;
                    first.Location = first_point;
                    return true;
                }
                return false;
            }

        }
        public void Game_Form_Load(object sender, EventArgs e)
        {
            var controls = this.Controls;
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                    if (row == 1 && column == 1)
                    {
                        player = new Player("Player", 20, new Point(200 * column, 200 * row), "player");
                        this.Controls.Add(player.panel);
                    }
                    else
                    {
                        Card card = new Card("Name", 1, new Point(200 * column, 200 * row), "player");
                        card.panel.Click += card_click;
                        card.name_label.Click += card_click;
                        card.health_label.Click += card_click;
                        //cards[index_of_card].picture_pictureBox.Click += card_click;
                        //cards[index_of_card].weapon_pictureBox.Click += card_click;
                        this.Controls.Add(card.panel);
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
