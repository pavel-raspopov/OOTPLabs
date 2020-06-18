namespace OOTP.VehiclesForms.LandVehiclesForms
{
    partial class FAuto
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
            this.labSeats = new System.Windows.Forms.Label();
            this.labBody = new System.Windows.Forms.Label();
            this.TextBSeats = new System.Windows.Forms.TextBox();
            this.ComboBBody = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FEngine
            // 
            this.FEngine.Location = new System.Drawing.Point(26, 26);
            // 
            // labSeats
            // 
            this.labSeats.AutoSize = true;
            this.labSeats.Location = new System.Drawing.Point(367, 139);
            this.labSeats.Name = "labSeats";
            this.labSeats.Size = new System.Drawing.Size(99, 13);
            this.labSeats.TabIndex = 10;
            this.labSeats.Text = "Кол-во пасс. мест";
            // 
            // labBody
            // 
            this.labBody.AutoSize = true;
            this.labBody.Location = new System.Drawing.Point(367, 192);
            this.labBody.Name = "labBody";
            this.labBody.Size = new System.Drawing.Size(37, 13);
            this.labBody.TabIndex = 11;
            this.labBody.Text = "Кузов";
            // 
            // TextBSeats
            // 
            this.TextBSeats.Location = new System.Drawing.Point(515, 136);
            this.TextBSeats.Name = "TextBSeats";
            this.TextBSeats.Size = new System.Drawing.Size(100, 20);
            this.TextBSeats.TabIndex = 12;
            this.TextBSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBSeats_KeyPress);
            // 
            // ComboBBody
            // 
            this.ComboBBody.FormattingEnabled = true;
            this.ComboBBody.Items.AddRange(new object[] {
            "",
            "Седан",
            "Хэтчбэк",
            "Грузовик",
            "Купе",
            "Суперкар",
            "Внедорожник",
            "Кроссовер",
            "Кабриолет",
            "Родстер",
            "Пикап",
            "Фургон"});
            this.ComboBBody.Location = new System.Drawing.Point(494, 189);
            this.ComboBBody.Name = "ComboBBody";
            this.ComboBBody.Size = new System.Drawing.Size(121, 21);
            this.ComboBBody.TabIndex = 13;
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(515, 230);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(100, 23);
            this.ButSave.TabIndex = 14;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 280);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBBody);
            this.Controls.Add(this.TextBSeats);
            this.Controls.Add(this.labBody);
            this.Controls.Add(this.labSeats);
            this.Name = "FAuto";
            this.Text = "Автомобиль";
            this.Load += new System.EventHandler(this.FAuto_Load);
            this.Controls.SetChildIndex(this.labSeats, 0);
            this.Controls.SetChildIndex(this.labBody, 0);
            this.Controls.SetChildIndex(this.TextBSeats, 0);
            this.Controls.SetChildIndex(this.ComboBBody, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSeats;
        private System.Windows.Forms.Label labBody;
        private System.Windows.Forms.TextBox TextBSeats;
        private System.Windows.Forms.ComboBox ComboBBody;
        private System.Windows.Forms.Button ButSave;
    }
}