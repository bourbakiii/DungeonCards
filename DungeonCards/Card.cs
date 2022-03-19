﻿using System;
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
        public string type = "Enemy";
        public int points = 0;
        public int index_row = 0;
        public int index_column = 0;
        public Panel panel;
        public Card(string name, Panel panel)
        {
            this.name = name ?? "Enemy name";
            this.panel = panel;

            var controls = this.panel.Controls;
            this.panel.Click += this.click;
            for (int a = 0; a < controls.Count; a++)
            {
                controls[a].Click += this.click;
                if (controls[a] is Label)
                {
                    ((Label)controls[a]).Text = this.name;
                }
            }
            
        }
        void click(object sender, EventArgs e)
        {
            this.panel.BackColor = Color.Black;
        }
    }
}
