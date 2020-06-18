namespace OOTP.VehiclesForms.WaterVehiclesForms
{
    partial class FJetski
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
            this.labPlaces = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.TextBSeats = new System.Windows.Forms.TextBox();
            this.ComboBJetskiType = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labPlaces
            // 
            this.labPlaces.AutoSize = true;
            this.labPlaces.Location = new System.Drawing.Point(369, 90);
            this.labPlaces.Name = "labPlaces";
            this.labPlaces.Size = new System.Drawing.Size(69, 13);
            this.labPlaces.TabIndex = 10;
            this.labPlaces.Text = "Кол-во мест";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(369, 139);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(26, 13);
            this.labType.TabIndex = 11;
            this.labType.Text = "Тип";
            // 
            // TextBSeats
            // 
            this.TextBSeats.Location = new System.Drawing.Point(492, 87);
            this.TextBSeats.Name = "TextBSeats";
            this.TextBSeats.Size = new System.Drawing.Size(142, 20);
            this.TextBSeats.TabIndex = 12;
            this.TextBSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBSeats_KeyPress);
            // 
            // ComboBJetskiType
            // 
            this.ComboBJetskiType.FormattingEnabled = true;
            this.ComboBJetskiType.Items.AddRange(new object[] {
            "",
            "Туристический",
            "Спортивный"});
            this.ComboBJetskiType.Location = new System.Drawing.Point(492, 136);
            this.ComboBJetskiType.Name = "ComboBJetskiType";
            this.ComboBJetskiType.Size = new System.Drawing.Size(142, 21);
            this.ComboBJetskiType.TabIndex = 13;
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(545, 193);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(89, 23);
            this.ButSave.TabIndex = 14;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FJetski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 266);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBJetskiType);
            this.Controls.Add(this.TextBSeats);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labPlaces);
            this.Name = "FJetski";
            this.Text = "Гидроцикл";
            this.Load += new System.EventHandler(this.FJetski_Load);
            this.Controls.SetChildIndex(this.labPlaces, 0);
            this.Controls.SetChildIndex(this.labType, 0);
            this.Controls.SetChildIndex(this.TextBSeats, 0);
            this.Controls.SetChildIndex(this.ComboBJetskiType, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPlaces;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.TextBox TextBSeats;
        private System.Windows.Forms.ComboBox ComboBJetskiType;
        private System.Windows.Forms.Button ButSave;
    }
}