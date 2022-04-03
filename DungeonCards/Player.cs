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
    class Player : Card
    {

        public Player(string name, int health, Point point, string type, string text):base(name,health,point, type, text )
        {
            var controls = this.panel.Controls;
            this.panel.Click += this.click;
            for (int a = 0; a < controls.Count; a++)
                controls[a].Click += this.click;
            this.panel.BackColor = Color.DarkGray;
        }
        void click(object sender, EventArgs e)
        {
        }
    }
}
