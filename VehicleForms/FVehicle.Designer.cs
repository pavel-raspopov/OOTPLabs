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
            this.textBName = new System.Windows.Forms.TextBox();
            this.textBYear = new System.Windows.Forms.TextBox();
            this.textBWeight = new System.Windows.Forms.TextBox();
            this.textBMaxSpeed = new System.Windows.Forms.TextBox();
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
            // textBName
            // 
            this.textBName.Location = new System.Drawing.Point(235, 52);
            this.textBName.Name = "textBName";
            this.textBName.Size = new System.Drawing.Size(160, 20);
            this.textBName.TabIndex = 4;
            // 
            // textBYear
            // 
            this.textBYear.Location = new System.Drawing.Point(235, 109);
            this.textBYear.Name = "textBYear";
            this.textBYear.Size = new System.Drawing.Size(160, 20);
            this.textBYear.TabIndex = 5;
            this.textBYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBYear_KeyPress);
            // 
            // textBWeight
            // 
            this.textBWeight.Location = new System.Drawing.Point(235, 166);
            this.textBWeight.Name = "textBWeight";
            this.textBWeight.Size = new System.Drawing.Size(160, 20);
            this.textBWeight.TabIndex = 6;
            this.textBWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBWeight_KeyPress);
            // 
            // textBMaxSpeed
            // 
            this.textBMaxSpeed.Location = new System.Drawing.Point(235, 229);
            this.textBMaxSpeed.Name = "textBMaxSpeed";
            this.textBMaxSpeed.Size = new System.Drawing.Size(160, 20);
            this.textBMaxSpeed.TabIndex = 7;
            this.textBMaxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBMaxSpeed_KeyPress);
            // 
            // FVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.textBMaxSpeed);
            this.Controls.Add(this.textBWeight);
            this.Controls.Add(this.textBYear);
            this.Controls.Add(this.textBName);
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
        private System.Windows.Forms.TextBox textBName;
        private System.Windows.Forms.TextBox textBYear;
        private System.Windows.Forms.TextBox textBWeight;
        private System.Windows.Forms.TextBox textBMaxSpeed;
    }
}