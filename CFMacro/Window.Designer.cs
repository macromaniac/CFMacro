namespace CFMacro
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GUITick = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.stockPrice = new System.Windows.Forms.Label();
            this.lastTradePriceText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GUITick
            // 
            this.GUITick.Enabled = true;
            this.GUITick.Tick += new System.EventHandler(this.GUITick_Tick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(11, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(507, 479);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // stockPrice
            // 
            this.stockPrice.AutoSize = true;
            this.stockPrice.Location = new System.Drawing.Point(134, 506);
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.Size = new System.Drawing.Size(119, 13);
            this.stockPrice.TabIndex = 2;
            this.stockPrice.Text = "YHOO LastTradePrice: ";
            // 
            // lastTradePriceText
            // 
            this.lastTradePriceText.AutoSize = true;
            this.lastTradePriceText.Location = new System.Drawing.Point(259, 506);
            this.lastTradePriceText.Name = "lastTradePriceText";
            this.lastTradePriceText.Size = new System.Drawing.Size(10, 13);
            this.lastTradePriceText.TabIndex = 3;
            this.lastTradePriceText.Text = "-";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 535);
            this.Controls.Add(this.lastTradePriceText);
            this.Controls.Add(this.stockPrice);
            this.Controls.Add(this.pictureBox);
            this.Name = "Window";
            this.ShowIcon = false;
            this.Text = "*";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GUITick;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label stockPrice;
        private System.Windows.Forms.Label lastTradePriceText;
    }
}

