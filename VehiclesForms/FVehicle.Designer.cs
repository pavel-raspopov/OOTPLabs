namespace OOTP.VehiclesForms
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
            this.labPorp = new System.Windows.Forms.Label();
            this.labWeight = new System.Windows.Forms.Label();
            this.TextBName = new System.Windows.Forms.TextBox();
            this.TextBPorp = new System.Windows.Forms.TextBox();
            this.TextBWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(51, 48);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "Название";
            // 
            // labPorp
            // 
            this.labPorp.AutoSize = true;
            this.labPorp.Location = new System.Drawing.Point(51, 90);
            this.labPorp.Name = "labPorp";
            this.labPorp.Size = new System.Drawing.Size(68, 13);
            this.labPorp.TabIndex = 1;
            this.labPorp.Text = "Назначение";
            // 
            // labWeight
            // 
            this.labWeight.AutoSize = true;
            this.labWeight.Location = new System.Drawing.Point(51, 139);
            this.labWeight.Name = "labWeight";
            this.labWeight.Size = new System.Drawing.Size(52, 13);
            this.labWeight.TabIndex = 2;
            this.labWeight.Text = "Вес ( кг )";
            // 
            // TextBName
            // 
            this.TextBName.Location = new System.Drawing.Point(176, 45);
            this.TextBName.Name = "TextBName";
            this.TextBName.Size = new System.Drawing.Size(142, 20);
            this.TextBName.TabIndex = 3;
            // 
            // TextBPorp
            // 
            this.TextBPorp.Location = new System.Drawing.Point(176, 87);
            this.TextBPorp.Name = "TextBPorp";
            this.TextBPorp.Size = new System.Drawing.Size(142, 20);
            this.TextBPorp.TabIndex = 4;
            // 
            // TextBWeight
            // 
            this.TextBWeight.Location = new System.Drawing.Point(176, 136);
            this.TextBWeight.Name = "TextBWeight";
            this.TextBWeight.Size = new System.Drawing.Size(142, 20);
            this.TextBWeight.TabIndex = 5;
            this.TextBWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBWeight_KeyPress);
            // 
            // FVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 277);
            this.Controls.Add(this.TextBWeight);
            this.Controls.Add(this.TextBPorp);
            this.Controls.Add(this.TextBName);
            this.Controls.Add(this.labWeight);
            this.Controls.Add(this.labPorp);
            this.Controls.Add(this.labName);
            this.Name = "FVehicle";
            this.Text = "FVehicle";
            this.Load += new System.EventHandler(this.FVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPorp;
        private System.Windows.Forms.Label labWeight;
        private System.Windows.Forms.TextBox TextBName;
        private System.Windows.Forms.TextBox TextBPorp;
        private System.Windows.Forms.TextBox TextBWeight;
    }
}