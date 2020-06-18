namespace OOTP.VehiclesForms
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
            this.labWheels = new System.Windows.Forms.Label();
            this.TextBWheels = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButViewEngine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labWheels
            // 
            this.labWheels.AutoSize = true;
            this.labWheels.Location = new System.Drawing.Point(51, 192);
            this.labWheels.Name = "labWheels";
            this.labWheels.Size = new System.Drawing.Size(83, 13);
            this.labWheels.TabIndex = 6;
            this.labWheels.Text = "Колеса ( штук )";
            // 
            // TextBWheels
            // 
            this.TextBWheels.Location = new System.Drawing.Point(176, 189);
            this.TextBWheels.Name = "TextBWheels";
            this.TextBWheels.Size = new System.Drawing.Size(142, 20);
            this.TextBWheels.TabIndex = 7;
            this.TextBWheels.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBWheels_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Двигатель";
            // 
            // ButViewEngine
            // 
            this.ButViewEngine.Location = new System.Drawing.Point(450, 84);
            this.ButViewEngine.Name = "ButViewEngine";
            this.ButViewEngine.Size = new System.Drawing.Size(88, 23);
            this.ButViewEngine.TabIndex = 9;
            this.ButViewEngine.Text = "Подробнее";
            this.ButViewEngine.UseVisualStyleBackColor = true;
            this.ButViewEngine.Click += new System.EventHandler(this.ButViewEngine_Click);
            // 
            // FLandVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 283);
            this.Controls.Add(this.ButViewEngine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBWheels);
            this.Controls.Add(this.labWheels);
            this.Name = "FLandVehicle";
            this.Text = "FLandVehicle";
            this.Load += new System.EventHandler(this.FLandVehicle_Load);
            this.Controls.SetChildIndex(this.labWheels, 0);
            this.Controls.SetChildIndex(this.TextBWheels, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ButViewEngine, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labWheels;
        private System.Windows.Forms.TextBox TextBWheels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButViewEngine;
    }
}