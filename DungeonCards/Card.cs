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
using static DungeonCards.IndexStorage;

namespace DungeonCards
{
    class Card
    {
        public string name = "Enemy name";
        public int health = 1;
        public string type = "Enemy";
        public string text;
        public int points = 0;
        public Panel panel;
        public Label name_label;
        public Label health_label;
        public PictureBox picture_pictureBox;
        public PictureBox weapon_pictureBox;
        public Card() { }
        public Card(string name, int health, Point point, string type, string text)
        {
            this.name = name ?? "Enemy name";
            this.health = health;
            this.type = type;
            this.text = text;
            this.panel = new Panel
            {
                Location = point,
                Size = new Size(200, 200),
                Tag = new IndexStorage(point.Y / 200, point.X / 200),
                Text = this.text,
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        };
            this.health_label = new Label
            {
                Location = new Point(0, 0),
                Size = new Size(200, 20),
                Text = this.health.ToString(),
                ForeColor = Color.Maroon,
                Font = new Font(FontFamily.GenericMonospace, 20.0F, GraphicsUnit.Pixel),
                TextAlign = ContentAlignment.MiddleRight
            };
            this.name_label = new Label
            {
                Location = new Point(0, 200 - 20),
                Size = new Size(200, 20),
                Text = Convert.ToString(((IndexStorage)this.panel.Tag).row + "|" + ((IndexStorage)this.panel.Tag).column),
                ForeColor = Color.Black,
                Font = new Font(FontFamily.GenericMonospace, 20.0F, GraphicsUnit.Pixel),
                TextAlign = ContentAlignment.MiddleLeft
            };
            this.panel.Controls.Add(name_label);
            this.panel.Controls.Add(health_label);
            


        }
        public void writeTag()
        {
            this.name_label.Text = Convert.ToString(((IndexStorage)this.panel.Tag).row + "|" + ((IndexStorage)this.panel.Tag).column);
        }
        public void changeHealth(int value)
        {
            this.health = value;
            this.health_label.Text = value.ToString();
        }
    }
}
