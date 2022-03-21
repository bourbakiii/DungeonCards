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

        public Player(string name, int health, string type, Panel panel):base(name,health,type,panel)
        {
            var controls = this.panel.Controls;
            this.panel.Click += this.click;
            for (int a = 0; a < controls.Count; a++)
                controls[a].Click += this.click;

            
        }
        void click(object sender, EventArgs e)
        {
            this.panel.BackColor = Color.Red;
        }
    }
}
