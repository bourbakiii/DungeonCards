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
        public int points = 0;
        public Panel panel;
        public Label name_label;
        public Label health_label;
        public PictureBox picture_pictureBox;
        public PictureBox weapon_pictureBox;
        protected Card() { }
        public Card(string name, int health, Point point, string type)
        {
            this.name = name ?? "Enemy name";
            this.health = health;
            this.type = type;
            this.panel = new Panel
            {
                Location = point,
                Size = new Size(200, 200),
                Tag = new IndexStorage(point.Y / 200, point.X / 200),
                Text = this.type
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
                Text = this.name,
                ForeColor = Color.Black,
                Font = new Font(FontFamily.GenericMonospace, 20.0F, GraphicsUnit.Pixel),
                TextAlign = ContentAlignment.MiddleLeft
            };
            this.panel.Controls.Add(name_label);
            this.panel.Controls.Add(health_label);


            //var controls = this.panel.Controls;
            ////this.panel.BackColor = this.type == "enemy" ? Color.DarkRed : this.type == "trap" ? Color.Gray : this.panel.BackColor;

            //for (int a = 0; a < controls.Count; a++)
            //{
            //    //controls[a].Click += this.click;
            //    if (controls[a] is Label || controls[a] is PictureBox)
            //    {
            //        switch (Convert.ToString(controls[a].Tag))
            //        {
            //            case "name":
            //                {
            //                    this.name_label = (Label)controls[a];
            //                    break;
            //                }
            //            case "health":
            //                {
            //                    this.health_label = (Label)controls[a];
            //                    break;
            //                }
            //            case "picture":
            //                {
            //                    this.picture_pictureBox = (PictureBox)controls[a];
            //                    break;
            //                }
            //            case "weapon":
            //                {
            //                    this.weapon_pictureBox = (PictureBox)controls[a];
            //                    break;
            //                }
            //        }
            //    }
            //}
            //this.name_label.Text = this.name;
            //if (this.health_label != null) this.health_label.Text = Convert.ToString(this.health);


        }
    }
}
