namespace OOTP.VehicleForms
{
    partial class FWaterVehicle
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
            this.labNumDecks = new System.Windows.Forms.Label();
            this.TextBNumDecks = new System.Windows.Forms.TextBox();
            this.labDisplacement = new System.Windows.Forms.Label();
            this.TextBDisplacement = new System.Windows.Forms.TextBox();
            this.labCrew = new System.Windows.Forms.Label();
            this.TextBCrew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labNumDecks
            // 
            this.labNumDecks.AutoSize = true;
            this.labNumDecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNumDecks.Location = new System.Drawing.Point(43, 291);
            this.labNumDecks.Name = "labNumDecks";
            this.labNumDecks.Size = new System.Drawing.Size(109, 20);
            this.labNumDecks.TabIndex = 8;
            this.labNumDecks.Text = "Кол-во палуб";
            // 
            // TextBNumDecks
            // 
            this.TextBNumDecks.Location = new System.Drawing.Point(235, 293);
            this.TextBNumDecks.Name = "TextBNumDecks";
            this.TextBNumDecks.Size = new System.Drawing.Size(160, 20);
            this.TextBNumDecks.TabIndex = 9;
            this.TextBNumDecks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumDecks_KeyPress);
            // 
            // labDisplacement
            // 
            this.labDisplacement.AutoSize = true;
            this.labDisplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDisplacement.Location = new System.Drawing.Point(437, 50);
            this.labDisplacement.Name = "labDisplacement";
            this.labDisplacement.Size = new System.Drawing.Size(177, 20);
            this.labDisplacement.TabIndex = 10;
            this.labDisplacement.Text = "Водоизмещение ( м3 )";
            // 
            // TextBDisplacement
            // 
            this.TextBDisplacement.Location = new System.Drawing.Point(628, 52);
            this.TextBDisplacement.Name = "TextBDisplacement";
            this.TextBDisplacement.Size = new System.Drawing.Size(126, 20);
            this.TextBDisplacement.TabIndex = 11;
            this.TextBDisplacement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBDisplacement_KeyPress);
            // 
            // labCrew
            // 
            this.labCrew.AutoSize = true;
            this.labCrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCrew.Location = new System.Drawing.Point(437, 107);
            this.labCrew.Name = "labCrew";
            this.labCrew.Size = new System.Drawing.Size(67, 20);
            this.labCrew.TabIndex = 12;
            this.labCrew.Text = "Экипаж";
            // 
            // TextBCrew
            // 
            this.TextBCrew.Location = new System.Drawing.Point(628, 109);
            this.TextBCrew.Name = "TextBCrew";
            this.TextBCrew.Size = new System.Drawing.Size(126, 20);
            this.TextBCrew.TabIndex = 13;
            this.TextBCrew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBCrew_KeyPress);
            // 
            // FWaterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 340);
            this.Controls.Add(this.TextBCrew);
            this.Controls.Add(this.labCrew);
            this.Controls.Add(this.TextBDisplacement);
            this.Controls.Add(this.labDisplacement);
            this.Controls.Add(this.TextBNumDecks);
            this.Controls.Add(this.labNumDecks);
            this.Name = "FWaterVehicle";
            this.Text = "FWaterVehicle";
            this.Load += new System.EventHandler(this.FWaterVehicle_Load);
            this.Controls.SetChildIndex(this.labNumDecks, 0);
            this.Controls.SetChildIndex(this.TextBNumDecks, 0);
            this.Controls.SetChildIndex(this.labDisplacement, 0);
            this.Controls.SetChildIndex(this.TextBDisplacement, 0);
            this.Controls.SetChildIndex(this.labCrew, 0);
            this.Controls.SetChildIndex(this.TextBCrew, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumDecks;
        private System.Windows.Forms.TextBox TextBNumDecks;
        private System.Windows.Forms.Label labDisplacement;
        private System.Windows.Forms.TextBox TextBDisplacement;
        private System.Windows.Forms.Label labCrew;
        private System.Windows.Forms.TextBox TextBCrew;
    }
}