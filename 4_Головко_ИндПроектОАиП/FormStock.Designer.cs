namespace _4_Головко_ИндПроектОАиП
{
    partial class FormStock
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
            this.tbReview = new System.Windows.Forms.TextBox();
            this.lStock = new System.Windows.Forms.Label();
            this.btnPromoCode = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbReview
            // 
            this.tbReview.Location = new System.Drawing.Point(32, 82);
            this.tbReview.MinimumSize = new System.Drawing.Size(160, 90);
            this.tbReview.Multiline = true;
            this.tbReview.Name = "tbReview";
            this.tbReview.Size = new System.Drawing.Size(240, 96);
            this.tbReview.TabIndex = 3;
            // 
            // lStock
            // 
            this.lStock.AutoSize = true;
            this.lStock.BackColor = System.Drawing.Color.PeachPuff;
            this.lStock.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStock.ForeColor = System.Drawing.Color.Sienna;
            this.lStock.Image = global::_4_Головко_ИндПроектОАиП.Properties.Resources.dostavka_piccy___2_;
            this.lStock.Location = new System.Drawing.Point(53, 19);
            this.lStock.MaximumSize = new System.Drawing.Size(250, 100);
            this.lStock.MinimumSize = new System.Drawing.Size(150, 60);
            this.lStock.Name = "lStock";
            this.lStock.Size = new System.Drawing.Size(197, 60);
            this.lStock.TabIndex = 4;
            this.lStock.Text = "Специальное предложение: оставьте отзыв и получите уникальный промокод!";
            this.lStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPromoCode
            // 
            this.btnPromoCode.BackColor = System.Drawing.Color.Sienna;
            this.btnPromoCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromoCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPromoCode.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPromoCode.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPromoCode.Location = new System.Drawing.Point(70, 188);
            this.btnPromoCode.Name = "btnPromoCode";
            this.btnPromoCode.Size = new System.Drawing.Size(160, 35);
            this.btnPromoCode.TabIndex = 5;
            this.btnPromoCode.Text = "Получить промокод";
            this.btnPromoCode.UseVisualStyleBackColor = false;
            this.btnPromoCode.Click += new System.EventHandler(this.btnPromoCode_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Sienna;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMenu.Location = new System.Drawing.Point(70, 229);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(160, 35);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Выход";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::_4_Головко_ИндПроектОАиП.Properties.Resources.dostavka_piccy___2_;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnPromoCode);
            this.Controls.Add(this.tbReview);
            this.Controls.Add(this.lStock);
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Акция!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbReview;
        private System.Windows.Forms.Label lStock;
        private System.Windows.Forms.Button btnPromoCode;
        private System.Windows.Forms.Button btnMenu;
    }
}