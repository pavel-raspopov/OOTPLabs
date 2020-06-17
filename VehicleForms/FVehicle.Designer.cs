namespace OOTP.VehicleForms
{
    partial class FVehicle
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
            this.labName = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labWeight = new System.Windows.Forms.Label();
            this.labMaxSpeed = new System.Windows.Forms.Label();
            this.TextBName = new System.Windows.Forms.TextBox();
            this.TextBYear = new System.Windows.Forms.TextBox();
            this.TextBWeight = new System.Windows.Forms.TextBox();
            this.TextBMaxSpeed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labName.Location = new System.Drawing.Point(43, 50);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(83, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "Название";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labYear.Location = new System.Drawing.Point(43, 107);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(114, 20);
            this.labYear.TabIndex = 1;
            this.labYear.Text = "Год создания";
            // 
            // labWeight
            // 
            this.labWeight.AutoSize = true;
            this.labWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labWeight.Location = new System.Drawing.Point(43, 164);
            this.labWeight.Name = "labWeight";
            this.labWeight.Size = new System.Drawing.Size(74, 20);
            this.labWeight.TabIndex = 2;
            this.labWeight.Text = "Вес ( кг )";
            // 
            // labMaxSpeed
            // 
            this.labMaxSpeed.AutoSize = true;
            this.labMaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labMaxSpeed.Location = new System.Drawing.Point(43, 227);
            this.labMaxSpeed.Name = "labMaxSpeed";
            this.labMaxSpeed.Size = new System.Drawing.Size(178, 20);
            this.labMaxSpeed.TabIndex = 3;
            this.labMaxSpeed.Text = "Макс. скорость ( км/ч )";
            // 
            // TextBName
            // 
            this.TextBName.Location = new System.Drawing.Point(235, 52);
            this.TextBName.Name = "TextBName";
            this.TextBName.Size = new System.Drawing.Size(160, 20);
            this.TextBName.TabIndex = 4;
            // 
            // TextBYear
            // 
            this.TextBYear.Location = new System.Drawing.Point(235, 109);
            this.TextBYear.Name = "TextBYear";
            this.TextBYear.Size = new System.Drawing.Size(160, 20);
            this.TextBYear.TabIndex = 5;
            this.TextBYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBYear_KeyPress);
            // 
            // TextBWeight
            // 
            this.TextBWeight.Location = new System.Drawing.Point(235, 166);
            this.TextBWeight.Name = "TextBWeight";
            this.TextBWeight.Size = new System.Drawing.Size(160, 20);
            this.TextBWeight.TabIndex = 6;
            this.TextBWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBWeight_KeyPress);
            // 
            // TextBMaxSpeed
            // 
            this.TextBMaxSpeed.Location = new System.Drawing.Point(235, 229);
            this.TextBMaxSpeed.Name = "TextBMaxSpeed";
            this.TextBMaxSpeed.Size = new System.Drawing.Size(160, 20);
            this.TextBMaxSpeed.TabIndex = 7;
            this.TextBMaxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBMaxSpeed_KeyPress);
            // 
            // FVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.TextBMaxSpeed);
            this.Controls.Add(this.TextBWeight);
            this.Controls.Add(this.TextBYear);
            this.Controls.Add(this.TextBName);
            this.Controls.Add(this.labMaxSpeed);
            this.Controls.Add(this.labWeight);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labName);
            this.Name = "FVehicle";
            this.Text = "FVehicle";
            this.Load += new System.EventHandler(this.FVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labWeight;
        private System.Windows.Forms.Label labMaxSpeed;
        private System.Windows.Forms.TextBox TextBName;
        private System.Windows.Forms.TextBox TextBYear;
        private System.Windows.Forms.TextBox TextBWeight;
        private System.Windows.Forms.TextBox TextBMaxSpeed;
    }
}