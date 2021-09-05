namespace _4_Головко_ИндПроектОАиП
{
    partial class FormBase
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
            this.lName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.BackColor = System.Drawing.Color.SeaShell;
            this.lName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lName.Location = new System.Drawing.Point(49, 9);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(443, 25);
            this.lName.TabIndex = 0;
            this.lName.Text = "Оформите заказ в пиццерии \"Винсент\" за 5 минут!";
            this.lName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Sienna;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(384, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Выход";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Sienna;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStock.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStock.Location = new System.Drawing.Point(49, 125);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(130, 40);
            this.btnStock.TabIndex = 14;
            this.btnStock.Text = " Акции!";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Sienna;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOrder.Location = new System.Drawing.Point(384, 167);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(130, 40);
            this.btnOrder.TabIndex = 15;
            this.btnOrder.Text = "Заказать";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Sienna;
            this.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAboutUs.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAboutUs.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAboutUs.Location = new System.Drawing.Point(49, 70);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(130, 40);
            this.btnAboutUs.TabIndex = 17;
            this.btnAboutUs.Text = "О приложении";
            this.btnAboutUs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = global::_4_Головко_ИндПроектОАиП.Properties.Resources.dostavka_piccy_;
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.Location = new System.Drawing.Point(-7, -2);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(564, 380);
            this.pictureBoxBackground.TabIndex = 16;
            this.pictureBoxBackground.TabStop = false;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(556, 360);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBoxBackground);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пиццерия \"Винсент\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Button btnAboutUs;
    }
}

