namespace OOTP.VehicleForms
{
    partial class FLandVehicle
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
            this.labNumWheels = new System.Windows.Forms.Label();
            this.TextBNumWheels = new System.Windows.Forms.TextBox();
            this.labEngine = new System.Windows.Forms.Label();
            this.ButViewEngine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNumWheels
            // 
            this.labNumWheels.AutoSize = true;
            this.labNumWheels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNumWheels.Location = new System.Drawing.Point(43, 290);
            this.labNumWheels.Name = "labNumWheels";
            this.labNumWheels.Size = new System.Drawing.Size(109, 20);
            this.labNumWheels.TabIndex = 8;
            this.labNumWheels.Text = "Кол-во колес";
            // 
            // TextBNumWheels
            // 
            this.TextBNumWheels.Location = new System.Drawing.Point(235, 292);
            this.TextBNumWheels.Name = "TextBNumWheels";
            this.TextBNumWheels.Size = new System.Drawing.Size(160, 20);
            this.TextBNumWheels.TabIndex = 9;
            this.TextBNumWheels.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumWheels_KeyPress);
            // 
            // labEngine
            // 
            this.labEngine.AutoSize = true;
            this.labEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labEngine.Location = new System.Drawing.Point(525, 52);
            this.labEngine.Name = "labEngine";
            this.labEngine.Size = new System.Drawing.Size(183, 20);
            this.labEngine.TabIndex = 10;
            this.labEngine.Text = "Параметры двигателя";
            // 
            // ButViewEngine
            // 
            this.ButViewEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButViewEngine.Location = new System.Drawing.Point(568, 99);
            this.ButViewEngine.Name = "ButViewEngine";
            this.ButViewEngine.Size = new System.Drawing.Size(99, 38);
            this.ButViewEngine.TabIndex = 11;
            this.ButViewEngine.Text = "Просмотр";
            this.ButViewEngine.UseVisualStyleBackColor = true;
            this.ButViewEngine.Click += new System.EventHandler(this.ButViewEngine_Click);
            // 
            // FLandVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.ButViewEngine);
            this.Controls.Add(this.labEngine);
            this.Controls.Add(this.TextBNumWheels);
            this.Controls.Add(this.labNumWheels);
            this.Name = "FLandVehicle";
            this.Text = "FLandVehicle";
            this.Load += new System.EventHandler(this.FLandVehicle_Load);
            this.Controls.SetChildIndex(this.labNumWheels, 0);
            this.Controls.SetChildIndex(this.TextBNumWheels, 0);
            this.Controls.SetChildIndex(this.labEngine, 0);
            this.Controls.SetChildIndex(this.ButViewEngine, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumWheels;
        private System.Windows.Forms.TextBox TextBNumWheels;
        private System.Windows.Forms.Label labEngine;
        private System.Windows.Forms.Button ButViewEngine;
    }
}