namespace OOTP.VehicleForms
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
            this.TextBMaxHeight = new System.Windows.Forms.TextBox();
            this.labTakeoffWeight = new System.Windows.Forms.Label();
            this.TextBTakeoffWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labMaxHeight
            // 
            this.labMaxHeight.AutoSize = true;
            this.labMaxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labMaxHeight.Location = new System.Drawing.Point(456, 50);
            this.labMaxHeight.Name = "labMaxHeight";
            this.labMaxHeight.Size = new System.Drawing.Size(155, 20);
            this.labMaxHeight.TabIndex = 8;
            this.labMaxHeight.Text = "Макс. высота ( км. )";
            // 
            // TextBMaxHeight
            // 
            this.TextBMaxHeight.Location = new System.Drawing.Point(634, 52);
            this.TextBMaxHeight.Name = "TextBMaxHeight";
            this.TextBMaxHeight.Size = new System.Drawing.Size(132, 20);
            this.TextBMaxHeight.TabIndex = 9;
            this.TextBMaxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBMaxHeight_KeyPress);
            // 
            // labTakeoffWeight
            // 
            this.labTakeoffWeight.AutoSize = true;
            this.labTakeoffWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTakeoffWeight.Location = new System.Drawing.Point(456, 107);
            this.labTakeoffWeight.Name = "labTakeoffWeight";
            this.labTakeoffWeight.Size = new System.Drawing.Size(156, 20);
            this.labTakeoffWeight.TabIndex = 10;
            this.labTakeoffWeight.Text = "Взлетный вес ( кг. )";
            // 
            // TextBTakeoffWeight
            // 
            this.TextBTakeoffWeight.Location = new System.Drawing.Point(634, 109);
            this.TextBTakeoffWeight.Name = "TextBTakeoffWeight";
            this.TextBTakeoffWeight.Size = new System.Drawing.Size(132, 20);
            this.TextBTakeoffWeight.TabIndex = 11;
            this.TextBTakeoffWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBTakeoffWeight_KeyPress);
            // 
            // FAirVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.TextBTakeoffWeight);
            this.Controls.Add(this.labTakeoffWeight);
            this.Controls.Add(this.TextBMaxHeight);
            this.Controls.Add(this.labMaxHeight);
            this.Name = "FAirVehicle";
            this.Text = "FAirVehicle";
            this.Load += new System.EventHandler(this.FAirVehicle_Load);
            this.Controls.SetChildIndex(this.labMaxHeight, 0);
            this.Controls.SetChildIndex(this.TextBMaxHeight, 0);
            this.Controls.SetChildIndex(this.labTakeoffWeight, 0);
            this.Controls.SetChildIndex(this.TextBTakeoffWeight, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMaxHeight;
        private System.Windows.Forms.TextBox TextBMaxHeight;
        private System.Windows.Forms.Label labTakeoffWeight;
        private System.Windows.Forms.TextBox TextBTakeoffWeight;
    }
}