namespace OOTP.VehiclesForms
{
    partial class FAirVehicle
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
            this.labMaxHeight = new System.Windows.Forms.Label();
            this.labTakeoffWeight = new System.Windows.Forms.Label();
            this.TextBMaxHeight = new System.Windows.Forms.TextBox();
            this.TextBTakeoffWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labMaxHeight
            // 
            this.labMaxHeight.AutoSize = true;
            this.labMaxHeight.Location = new System.Drawing.Point(51, 196);
            this.labMaxHeight.Name = "labMaxHeight";
            this.labMaxHeight.Size = new System.Drawing.Size(106, 13);
            this.labMaxHeight.TabIndex = 6;
            this.labMaxHeight.Text = "Макс. высота ( км )";
            // 
            // labTakeoffWeight
            // 
            this.labTakeoffWeight.AutoSize = true;
            this.labTakeoffWeight.Location = new System.Drawing.Point(400, 48);
            this.labTakeoffWeight.Name = "labTakeoffWeight";
            this.labTakeoffWeight.Size = new System.Drawing.Size(104, 13);
            this.labTakeoffWeight.TabIndex = 7;
            this.labTakeoffWeight.Text = "Взлетный вес ( кг )";
            // 
            // TextBMaxHeight
            // 
            this.TextBMaxHeight.Location = new System.Drawing.Point(176, 193);
            this.TextBMaxHeight.Name = "TextBMaxHeight";
            this.TextBMaxHeight.Size = new System.Drawing.Size(140, 20);
            this.TextBMaxHeight.TabIndex = 8;
            this.TextBMaxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBMaxHeight_KeyPress);
            // 
            // TextBTakeoffWeight
            // 
            this.TextBTakeoffWeight.Location = new System.Drawing.Point(565, 45);
            this.TextBTakeoffWeight.Name = "TextBTakeoffWeight";
            this.TextBTakeoffWeight.Size = new System.Drawing.Size(100, 20);
            this.TextBTakeoffWeight.TabIndex = 9;
            this.TextBTakeoffWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBTakeoffWeight_KeyPress);
            // 
            // FAirVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 250);
            this.Controls.Add(this.TextBTakeoffWeight);
            this.Controls.Add(this.TextBMaxHeight);
            this.Controls.Add(this.labTakeoffWeight);
            this.Controls.Add(this.labMaxHeight);
            this.Name = "FAirVehicle";
            this.Text = "FAirVehicle";
            this.Load += new System.EventHandler(this.FAirVehicle_Load);
            this.Controls.SetChildIndex(this.labMaxHeight, 0);
            this.Controls.SetChildIndex(this.labTakeoffWeight, 0);
            this.Controls.SetChildIndex(this.TextBMaxHeight, 0);
            this.Controls.SetChildIndex(this.TextBTakeoffWeight, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMaxHeight;
        private System.Windows.Forms.Label labTakeoffWeight;
        private System.Windows.Forms.TextBox TextBMaxHeight;
        private System.Windows.Forms.TextBox TextBTakeoffWeight;
    }
}