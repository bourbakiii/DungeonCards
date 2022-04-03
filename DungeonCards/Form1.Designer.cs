
namespace DungeonCards
{
    partial class Game_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.debugger = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.player_panel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.player_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.SuspendLayout();
            // 
            // debugger
            // 
            this.debugger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debugger.Location = new System.Drawing.Point(1230, 0);
            this.debugger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debugger.Multiline = true;
            this.debugger.Name = "debugger";
            this.debugger.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugger.Size = new System.Drawing.Size(646, 1150);
            this.debugger.TabIndex = 9;
            this.debugger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(332, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 37);
            this.label9.TabIndex = 3;
            this.label9.Tag = "health";
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(29, 69);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(76, 276);
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(62, 69);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(302, 276);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // player_panel
            // 
            this.player_panel.BackColor = System.Drawing.SystemColors.Control;
            this.player_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_panel.Controls.Add(this.label10);
            this.player_panel.Controls.Add(this.pictureBox19);
            this.player_panel.Controls.Add(this.pictureBox20);
            this.player_panel.Controls.Add(this.label19);
            this.player_panel.Location = new System.Drawing.Point(1335, 376);
            this.player_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player_panel.Name = "player_panel";
            this.player_panel.Size = new System.Drawing.Size(398, 383);
            this.player_panel.TabIndex = 14;
            this.player_panel.Tag = "player";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoEllipsis = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(332, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 37);
            this.label10.TabIndex = 3;
            this.label10.Tag = "health";
            this.label10.Text = "0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(28, 69);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(76, 277);
            this.pictureBox19.TabIndex = 2;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "weapon";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(62, 69);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(302, 277);
            this.pictureBox20.TabIndex = 1;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "picture";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoEllipsis = true;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(32, 348);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 37);
            this.label19.TabIndex = 0;
            this.label19.Tag = "name";
            this.label19.Text = "Имя";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2996, 1737);
            this.Controls.Add(this.player_panel);
            this.Controls.Add(this.debugger);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.player_panel.ResumeLayout(false);
            this.player_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox debugger;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel player_panel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Label label19;
    }
}

