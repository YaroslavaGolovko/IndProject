namespace _4_Головко_ИндПроектОАиП
{
    partial class FormAboutApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutApp));
            this.tbAboutApp = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAboutApp
            // 
            this.tbAboutApp.BackColor = System.Drawing.Color.PeachPuff;
            this.tbAboutApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAboutApp.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold);
            this.tbAboutApp.ForeColor = System.Drawing.Color.Sienna;
            this.tbAboutApp.Location = new System.Drawing.Point(45, 12);
            this.tbAboutApp.MinimumSize = new System.Drawing.Size(160, 80);
            this.tbAboutApp.Multiline = true;
            this.tbAboutApp.Name = "tbAboutApp";
            this.tbAboutApp.ReadOnly = true;
            this.tbAboutApp.Size = new System.Drawing.Size(299, 152);
            this.tbAboutApp.TabIndex = 1;
            this.tbAboutApp.TabStop = false;
            this.tbAboutApp.Text = resources.GetString("tbAboutApp.Text");
            this.tbAboutApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Sienna;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(265, 174);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormAboutApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(384, 221);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbAboutApp);
            this.Name = "FormAboutApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAboutApp;
        private System.Windows.Forms.Button btnClose;
    }
}