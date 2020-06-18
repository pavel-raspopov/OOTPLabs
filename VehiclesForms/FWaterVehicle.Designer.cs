namespace OOTP.VehiclesForms
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
            this.labWLine = new System.Windows.Forms.Label();
            this.labCons = new System.Windows.Forms.Label();
            this.TextBWLine = new System.Windows.Forms.TextBox();
            this.TextBCons = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labWLine
            // 
            this.labWLine.AutoSize = true;
            this.labWLine.Location = new System.Drawing.Point(51, 196);
            this.labWLine.Name = "labWLine";
            this.labWLine.Size = new System.Drawing.Size(96, 13);
            this.labWLine.TabIndex = 6;
            this.labWLine.Text = "Ватерлиния ( см )";
            // 
            // labCons
            // 
            this.labCons.AutoSize = true;
            this.labCons.Location = new System.Drawing.Point(369, 48);
            this.labCons.Name = "labCons";
            this.labCons.Size = new System.Drawing.Size(104, 13);
            this.labCons.TabIndex = 7;
            this.labCons.Text = "Расход ( л/100 км )";
            // 
            // TextBWLine
            // 
            this.TextBWLine.Location = new System.Drawing.Point(176, 193);
            this.TextBWLine.Name = "TextBWLine";
            this.TextBWLine.Size = new System.Drawing.Size(142, 20);
            this.TextBWLine.TabIndex = 8;
            this.TextBWLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBWLine_KeyPress);
            // 
            // TextBCons
            // 
            this.TextBCons.Location = new System.Drawing.Point(492, 45);
            this.TextBCons.Name = "TextBCons";
            this.TextBCons.Size = new System.Drawing.Size(142, 20);
            this.TextBCons.TabIndex = 9;
            this.TextBCons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBCons_KeyPress);
            // 
            // FWaterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 238);
            this.Controls.Add(this.TextBCons);
            this.Controls.Add(this.TextBWLine);
            this.Controls.Add(this.labCons);
            this.Controls.Add(this.labWLine);
            this.Name = "FWaterVehicle";
            this.Text = "FWaterVehicle";
            this.Load += new System.EventHandler(this.FWaterVehicle_Load);
            this.Controls.SetChildIndex(this.labWLine, 0);
            this.Controls.SetChildIndex(this.labCons, 0);
            this.Controls.SetChildIndex(this.TextBWLine, 0);
            this.Controls.SetChildIndex(this.TextBCons, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labWLine;
        private System.Windows.Forms.Label labCons;
        private System.Windows.Forms.TextBox TextBWLine;
        private System.Windows.Forms.TextBox TextBCons;
    }
}