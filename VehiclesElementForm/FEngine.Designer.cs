namespace OOTP.VehiclesElementForm
{
    partial class FEngine
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
            this.labPower = new System.Windows.Forms.Label();
            this.labVolume = new System.Windows.Forms.Label();
            this.labFuel = new System.Windows.Forms.Label();
            this.TextBPower = new System.Windows.Forms.TextBox();
            this.TextBVolume = new System.Windows.Forms.TextBox();
            this.ComboBFuel = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labPower
            // 
            this.labPower.AutoSize = true;
            this.labPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPower.Location = new System.Drawing.Point(49, 49);
            this.labPower.Name = "labPower";
            this.labPower.Size = new System.Drawing.Size(136, 20);
            this.labPower.TabIndex = 0;
            this.labPower.Text = "Мощность ( л.с. )";
            // 
            // labVolume
            // 
            this.labVolume.AutoSize = true;
            this.labVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labVolume.Location = new System.Drawing.Point(49, 103);
            this.labVolume.Name = "labVolume";
            this.labVolume.Size = new System.Drawing.Size(97, 20);
            this.labVolume.TabIndex = 1;
            this.labVolume.Text = "Объем ( л. )";
            // 
            // labFuel
            // 
            this.labFuel.AutoSize = true;
            this.labFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labFuel.Location = new System.Drawing.Point(49, 161);
            this.labFuel.Name = "labFuel";
            this.labFuel.Size = new System.Drawing.Size(108, 20);
            this.labFuel.TabIndex = 2;
            this.labFuel.Text = "Вид топлива";
            // 
            // TextBPower
            // 
            this.TextBPower.Location = new System.Drawing.Point(276, 51);
            this.TextBPower.Name = "TextBPower";
            this.TextBPower.Size = new System.Drawing.Size(156, 20);
            this.TextBPower.TabIndex = 3;
            this.TextBPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBPower_KeyPress);
            // 
            // TextBVolume
            // 
            this.TextBVolume.Location = new System.Drawing.Point(276, 105);
            this.TextBVolume.Name = "TextBVolume";
            this.TextBVolume.Size = new System.Drawing.Size(156, 20);
            this.TextBVolume.TabIndex = 4;
            this.TextBVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBVolume_KeyPress);
            // 
            // ComboBFuel
            // 
            this.ComboBFuel.FormattingEnabled = true;
            this.ComboBFuel.Items.AddRange(new object[] {
            "",
            "Бензин",
            "Дизель",
            "Газ"});
            this.ComboBFuel.Location = new System.Drawing.Point(276, 163);
            this.ComboBFuel.Name = "ComboBFuel";
            this.ComboBFuel.Size = new System.Drawing.Size(156, 21);
            this.ComboBFuel.TabIndex = 5;
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(166, 206);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(147, 32);
            this.ButSave.TabIndex = 6;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 254);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBFuel);
            this.Controls.Add(this.TextBVolume);
            this.Controls.Add(this.TextBPower);
            this.Controls.Add(this.labFuel);
            this.Controls.Add(this.labVolume);
            this.Controls.Add(this.labPower);
            this.Name = "FEngine";
            this.Text = "Параметры двигателя";
            this.Load += new System.EventHandler(this.FEngine_Load);
            this.Shown += new System.EventHandler(this.FEngine_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPower;
        private System.Windows.Forms.Label labVolume;
        private System.Windows.Forms.Label labFuel;
        private System.Windows.Forms.TextBox TextBPower;
        private System.Windows.Forms.TextBox TextBVolume;
        private System.Windows.Forms.ComboBox ComboBFuel;
        private System.Windows.Forms.Button ButSave;
    }
}