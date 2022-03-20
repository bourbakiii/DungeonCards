using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DungeonCards.Game_Form;

namespace DungeonCards
{
    class Card
    {
        public string name = "Enemy name";
        public int health = 1;
        public string type = "Enemy";
        public int points = 0;
        public int index_row = 0;
        public int index_column = 0;
        public Panel panel;
        public Label name_label;
        public Label health_label;
        public Card(string name, int health, string type, Panel panel)
        {
            this.name = name ?? "Enemy name";
            this.health = health;
            this.type = type;
            this.panel = panel;

            var controls = this.panel.Controls;
            this.panel.Click += this.click;
            //this.panel.BackColor = this.type == "enemy" ? Color.DarkRed : this.type == "trap" ? Color.Gray : this.panel.BackColor;

            for (int a = 0; a < controls.Count; a++)
            {
                controls[a].Click += this.click;
                if (controls[a] is Label)
                {
                    switch (Convert.ToString(controls[a].Tag))
                    {
                        case "name":
                            {
                                this.name_label = (Label)controls[a];
                                break;
                            }
                        case "health":
                            {
                                this.health_label = (Label)controls[a];
                                break;
                            }
                    }
                }
            }
            this.name_label.Text = this.name;
            if (this.health_label != null) this.health_label.Text = Convert.ToString(this.health);
        }
        void click(object sender, EventArgs e)
        {
            this.panel.BackColor = Color.Black;
        }
    }
}
