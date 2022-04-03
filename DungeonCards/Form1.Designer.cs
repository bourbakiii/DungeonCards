
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2996, 1737);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox debugger;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

