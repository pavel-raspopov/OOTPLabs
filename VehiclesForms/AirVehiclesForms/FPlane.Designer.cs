namespace OOTP.VehiclesForms.AirVehiclesForms
{
    partial class FPlane
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
            this.labTurbines = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.TextBTurbines = new System.Windows.Forms.TextBox();
            this.ComboBAircraftType = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTurbines
            // 
            this.labTurbines.AutoSize = true;
            this.labTurbines.Location = new System.Drawing.Point(400, 90);
            this.labTurbines.Name = "labTurbines";
            this.labTurbines.Size = new System.Drawing.Size(78, 13);
            this.labTurbines.TabIndex = 10;
            this.labTurbines.Text = "Кол-во турбин";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(400, 139);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(26, 13);
            this.labType.TabIndex = 11;
            this.labType.Text = "Тип";
            // 
            // TextBTurbines
            // 
            this.TextBTurbines.Location = new System.Drawing.Point(565, 87);
            this.TextBTurbines.Name = "TextBTurbines";
            this.TextBTurbines.Size = new System.Drawing.Size(100, 20);
            this.TextBTurbines.TabIndex = 12;
            // 
            // ComboBAircraftType
            // 
            this.ComboBAircraftType.FormattingEnabled = true;
            this.ComboBAircraftType.Items.AddRange(new object[] {
            "",
            "Пассажирский",
            "Транспортный",
            "Военный"});
            this.ComboBAircraftType.Location = new System.Drawing.Point(544, 136);
            this.ComboBAircraftType.Name = "ComboBAircraftType";
            this.ComboBAircraftType.Size = new System.Drawing.Size(121, 21);
            this.ComboBAircraftType.TabIndex = 13;
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(567, 196);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(98, 23);
            this.ButSave.TabIndex = 14;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 268);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBAircraftType);
            this.Controls.Add(this.TextBTurbines);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labTurbines);
            this.Name = "FPlane";
            this.Text = "Самолет";
            this.Load += new System.EventHandler(this.FPlane_Load);
            this.Controls.SetChildIndex(this.labTurbines, 0);
            this.Controls.SetChildIndex(this.labType, 0);
            this.Controls.SetChildIndex(this.TextBTurbines, 0);
            this.Controls.SetChildIndex(this.ComboBAircraftType, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTurbines;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.TextBox TextBTurbines;
        private System.Windows.Forms.ComboBox ComboBAircraftType;
        private System.Windows.Forms.Button ButSave;
    }
}