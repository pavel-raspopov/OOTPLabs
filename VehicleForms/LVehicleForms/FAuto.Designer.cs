namespace OOTP.VehicleForms.LVehicleForms
{
    partial class FAuto
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
            this.labDoors = new System.Windows.Forms.Label();
            this.TextBNumDoors = new System.Windows.Forms.TextBox();
            this.labBody = new System.Windows.Forms.Label();
            this.labDriveUnit = new System.Windows.Forms.Label();
            this.ComboBTypeBody = new System.Windows.Forms.ComboBox();
            this.ComboBDriveUnit = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FEngine
            // 
            this.FEngine.Location = new System.Drawing.Point(182, 182);
            // 
            // labDoors
            // 
            this.labDoors.AutoSize = true;
            this.labDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDoors.Location = new System.Drawing.Point(454, 164);
            this.labDoors.Name = "labDoors";
            this.labDoors.Size = new System.Drawing.Size(121, 20);
            this.labDoors.TabIndex = 12;
            this.labDoors.Text = "Кол-во дверей";
            // 
            // TextBNumDoors
            // 
            this.TextBNumDoors.Location = new System.Drawing.Point(615, 166);
            this.TextBNumDoors.Name = "TextBNumDoors";
            this.TextBNumDoors.Size = new System.Drawing.Size(144, 20);
            this.TextBNumDoors.TabIndex = 13;
            this.TextBNumDoors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumDoors_KeyPress);
            // 
            // labBody
            // 
            this.labBody.AutoSize = true;
            this.labBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labBody.Location = new System.Drawing.Point(454, 227);
            this.labBody.Name = "labBody";
            this.labBody.Size = new System.Drawing.Size(52, 20);
            this.labBody.TabIndex = 14;
            this.labBody.Text = "Кузов";
            // 
            // labDriveUnit
            // 
            this.labDriveUnit.AutoSize = true;
            this.labDriveUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDriveUnit.Location = new System.Drawing.Point(454, 290);
            this.labDriveUnit.Name = "labDriveUnit";
            this.labDriveUnit.Size = new System.Drawing.Size(68, 20);
            this.labDriveUnit.TabIndex = 15;
            this.labDriveUnit.Text = "Привод";
            // 
            // ComboBTypeBody
            // 
            this.ComboBTypeBody.FormattingEnabled = true;
            this.ComboBTypeBody.Items.AddRange(new object[] {
            "",
            "Седан",
            "Хэтчбэк",
            "Грузовик",
            "Купе",
            "Суперкар",
            "Внедорожник",
            "Кроссовер",
            "Кабриолет",
            "Родстер",
            "Пикап",
            "Фургон"});
            this.ComboBTypeBody.Location = new System.Drawing.Point(615, 229);
            this.ComboBTypeBody.Name = "ComboBTypeBody";
            this.ComboBTypeBody.Size = new System.Drawing.Size(144, 21);
            this.ComboBTypeBody.TabIndex = 16;
            // 
            // ComboBDriveUnit
            // 
            this.ComboBDriveUnit.FormattingEnabled = true;
            this.ComboBDriveUnit.Items.AddRange(new object[] {
            "",
            "Передний",
            "Задний",
            "Полный"});
            this.ComboBDriveUnit.Location = new System.Drawing.Point(615, 292);
            this.ComboBDriveUnit.Name = "ComboBDriveUnit";
            this.ComboBDriveUnit.Size = new System.Drawing.Size(144, 21);
            this.ComboBDriveUnit.TabIndex = 17;
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(664, 329);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(95, 39);
            this.ButSave.TabIndex = 18;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBDriveUnit);
            this.Controls.Add(this.ComboBTypeBody);
            this.Controls.Add(this.labDriveUnit);
            this.Controls.Add(this.labBody);
            this.Controls.Add(this.TextBNumDoors);
            this.Controls.Add(this.labDoors);
            this.Name = "FAuto";
            this.Text = "Автомобиль";
            this.Load += new System.EventHandler(this.FAuto_Load);
            this.Controls.SetChildIndex(this.labDoors, 0);
            this.Controls.SetChildIndex(this.TextBNumDoors, 0);
            this.Controls.SetChildIndex(this.labBody, 0);
            this.Controls.SetChildIndex(this.labDriveUnit, 0);
            this.Controls.SetChildIndex(this.ComboBTypeBody, 0);
            this.Controls.SetChildIndex(this.ComboBDriveUnit, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDoors;
        private System.Windows.Forms.TextBox TextBNumDoors;
        private System.Windows.Forms.Label labBody;
        private System.Windows.Forms.Label labDriveUnit;
        private System.Windows.Forms.ComboBox ComboBTypeBody;
        private System.Windows.Forms.ComboBox ComboBDriveUnit;
        private System.Windows.Forms.Button ButSave;
    }
}