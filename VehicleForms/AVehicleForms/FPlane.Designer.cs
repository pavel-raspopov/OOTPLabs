namespace OOTP.VehicleForms.AVehicleForms
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
            this.TextBNumTurbines = new System.Windows.Forms.TextBox();
            this.labType = new System.Windows.Forms.Label();
            this.ComboBType = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTurbines
            // 
            this.labTurbines.AutoSize = true;
            this.labTurbines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTurbines.Location = new System.Drawing.Point(456, 164);
            this.labTurbines.Name = "labTurbines";
            this.labTurbines.Size = new System.Drawing.Size(117, 20);
            this.labTurbines.TabIndex = 12;
            this.labTurbines.Text = "Кол-во турбин";
            // 
            // TextBNumTurbines
            // 
            this.TextBNumTurbines.Location = new System.Drawing.Point(634, 166);
            this.TextBNumTurbines.Name = "TextBNumTurbines";
            this.TextBNumTurbines.Size = new System.Drawing.Size(132, 20);
            this.TextBNumTurbines.TabIndex = 13;
            this.TextBNumTurbines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumTurbines_KeyPress);
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labType.Location = new System.Drawing.Point(456, 227);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(36, 20);
            this.labType.TabIndex = 14;
            this.labType.Text = "Тип";
            // 
            // ComboBType
            // 
            this.ComboBType.FormattingEnabled = true;
            this.ComboBType.Items.AddRange(new object[] {
            "",
            "Пассажирский",
            "Транспортный",
            "Военный"});
            this.ComboBType.Location = new System.Drawing.Point(634, 229);
            this.ComboBType.Name = "ComboBType";
            this.ComboBType.Size = new System.Drawing.Size(132, 21);
            this.ComboBType.TabIndex = 15;
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(670, 270);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(96, 38);
            this.ButSave.TabIndex = 16;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBType);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.TextBNumTurbines);
            this.Controls.Add(this.labTurbines);
            this.Name = "FPlane";
            this.Text = "Самолет";
            this.Load += new System.EventHandler(this.FPlane_Load);
            this.Controls.SetChildIndex(this.labTurbines, 0);
            this.Controls.SetChildIndex(this.TextBNumTurbines, 0);
            this.Controls.SetChildIndex(this.labType, 0);
            this.Controls.SetChildIndex(this.ComboBType, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTurbines;
        private System.Windows.Forms.TextBox TextBNumTurbines;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.ComboBox ComboBType;
        private System.Windows.Forms.Button ButSave;
    }
}