namespace OOTP.VehiclesForms.WaterVehiclesForms
{
    partial class FYacht
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
            this.labType = new System.Windows.Forms.Label();
            this.labDrive = new System.Windows.Forms.Label();
            this.ComboBYachtType = new System.Windows.Forms.ComboBox();
            this.ComboBDrive = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(369, 90);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(47, 13);
            this.labType.TabIndex = 10;
            this.labType.Text = "По виду";
            // 
            // labDrive
            // 
            this.labDrive.AutoSize = true;
            this.labDrive.Location = new System.Drawing.Point(369, 139);
            this.labDrive.Name = "labDrive";
            this.labDrive.Size = new System.Drawing.Size(65, 13);
            this.labDrive.TabIndex = 11;
            this.labDrive.Text = "По приводу";
            // 
            // ComboBYachtType
            // 
            this.ComboBYachtType.FormattingEnabled = true;
            this.ComboBYachtType.Items.AddRange(new object[] {
            "",
            "Круизная",
            "Спортивная"});
            this.ComboBYachtType.Location = new System.Drawing.Point(492, 87);
            this.ComboBYachtType.Name = "ComboBYachtType";
            this.ComboBYachtType.Size = new System.Drawing.Size(142, 21);
            this.ComboBYachtType.TabIndex = 12;
            // 
            // ComboBDrive
            // 
            this.ComboBDrive.FormattingEnabled = true;
            this.ComboBDrive.Items.AddRange(new object[] {
            "",
            "Парусная",
            "Парусно-моторная",
            "Моторная"});
            this.ComboBDrive.Location = new System.Drawing.Point(492, 136);
            this.ComboBDrive.Name = "ComboBDrive";
            this.ComboBDrive.Size = new System.Drawing.Size(142, 21);
            this.ComboBDrive.TabIndex = 13;
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(533, 196);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(101, 23);
            this.ButSave.TabIndex = 14;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FYacht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 268);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBDrive);
            this.Controls.Add(this.ComboBYachtType);
            this.Controls.Add(this.labDrive);
            this.Controls.Add(this.labType);
            this.Name = "FYacht";
            this.Text = "Яхта";
            this.Load += new System.EventHandler(this.FYacht_Load);
            this.Controls.SetChildIndex(this.labType, 0);
            this.Controls.SetChildIndex(this.labDrive, 0);
            this.Controls.SetChildIndex(this.ComboBYachtType, 0);
            this.Controls.SetChildIndex(this.ComboBDrive, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labDrive;
        private System.Windows.Forms.ComboBox ComboBYachtType;
        private System.Windows.Forms.ComboBox ComboBDrive;
        private System.Windows.Forms.Button ButSave;
    }
}