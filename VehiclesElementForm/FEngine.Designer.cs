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
            this.textBPower = new System.Windows.Forms.TextBox();
            this.textBVolume = new System.Windows.Forms.TextBox();
            this.comboBFuel = new System.Windows.Forms.ComboBox();
            this.butSave = new System.Windows.Forms.Button();
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
            // textBPower
            // 
            this.textBPower.Location = new System.Drawing.Point(276, 51);
            this.textBPower.Name = "textBPower";
            this.textBPower.Size = new System.Drawing.Size(156, 20);
            this.textBPower.TabIndex = 3;
            this.textBPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBPower_KeyPress);
            // 
            // textBVolume
            // 
            this.textBVolume.Location = new System.Drawing.Point(276, 105);
            this.textBVolume.Name = "textBVolume";
            this.textBVolume.Size = new System.Drawing.Size(156, 20);
            this.textBVolume.TabIndex = 4;
            this.textBVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBVolume_KeyPress);
            // 
            // comboBFuel
            // 
            this.comboBFuel.FormattingEnabled = true;
            this.comboBFuel.Items.AddRange(new object[] {
            "",
            "Бензин",
            "Дизель",
            "Газ"});
            this.comboBFuel.Location = new System.Drawing.Point(276, 163);
            this.comboBFuel.Name = "comboBFuel";
            this.comboBFuel.Size = new System.Drawing.Size(156, 21);
            this.comboBFuel.TabIndex = 5;
            // 
            // butSave
            // 
            this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(166, 206);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(147, 32);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // FEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 254);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.comboBFuel);
            this.Controls.Add(this.textBVolume);
            this.Controls.Add(this.textBPower);
            this.Controls.Add(this.labFuel);
            this.Controls.Add(this.labVolume);
            this.Controls.Add(this.labPower);
            this.Name = "FEngine";
            this.Text = "Параметры двигателя";
            this.Shown += new System.EventHandler(this.FEngine_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPower;
        private System.Windows.Forms.Label labVolume;
        private System.Windows.Forms.Label labFuel;
        private System.Windows.Forms.TextBox textBPower;
        private System.Windows.Forms.TextBox textBVolume;
        private System.Windows.Forms.ComboBox comboBFuel;
        private System.Windows.Forms.Button butSave;
    }
}