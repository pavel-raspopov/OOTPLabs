namespace OOTP.VehicleForms.WVehicleForms
{
    partial class FSubmarine
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
            this.labMaxDepth = new System.Windows.Forms.Label();
            this.TextBMaxDepth = new System.Windows.Forms.TextBox();
            this.labTurbines = new System.Windows.Forms.Label();
            this.TextBNumTurbines = new System.Windows.Forms.TextBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labMaxDepth
            // 
            this.labMaxDepth.AutoSize = true;
            this.labMaxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labMaxDepth.Location = new System.Drawing.Point(437, 164);
            this.labMaxDepth.Name = "labMaxDepth";
            this.labMaxDepth.Size = new System.Drawing.Size(115, 20);
            this.labMaxDepth.TabIndex = 14;
            this.labMaxDepth.Text = "Макс. глубина";
            // 
            // TextBMaxDepth
            // 
            this.TextBMaxDepth.Location = new System.Drawing.Point(628, 166);
            this.TextBMaxDepth.Name = "TextBMaxDepth";
            this.TextBMaxDepth.Size = new System.Drawing.Size(126, 20);
            this.TextBMaxDepth.TabIndex = 15;
            this.TextBMaxDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBMaxDepth_KeyPress);
            // 
            // labTurbines
            // 
            this.labTurbines.AutoSize = true;
            this.labTurbines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTurbines.Location = new System.Drawing.Point(437, 227);
            this.labTurbines.Name = "labTurbines";
            this.labTurbines.Size = new System.Drawing.Size(117, 20);
            this.labTurbines.TabIndex = 16;
            this.labTurbines.Text = "Кол-во турбин";
            // 
            // TextBNumTurbines
            // 
            this.TextBNumTurbines.Location = new System.Drawing.Point(628, 229);
            this.TextBNumTurbines.Name = "TextBNumTurbines";
            this.TextBNumTurbines.Size = new System.Drawing.Size(126, 20);
            this.TextBNumTurbines.TabIndex = 17;
            this.TextBNumTurbines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumTurbines_KeyPress);
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(650, 281);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(104, 43);
            this.ButSave.TabIndex = 18;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FSubmarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.TextBNumTurbines);
            this.Controls.Add(this.labTurbines);
            this.Controls.Add(this.TextBMaxDepth);
            this.Controls.Add(this.labMaxDepth);
            this.Name = "FSubmarine";
            this.Text = "Подлодка";
            this.Load += new System.EventHandler(this.FSubmarine_Load);
            this.Controls.SetChildIndex(this.labMaxDepth, 0);
            this.Controls.SetChildIndex(this.TextBMaxDepth, 0);
            this.Controls.SetChildIndex(this.labTurbines, 0);
            this.Controls.SetChildIndex(this.TextBNumTurbines, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMaxDepth;
        private System.Windows.Forms.TextBox TextBMaxDepth;
        private System.Windows.Forms.Label labTurbines;
        private System.Windows.Forms.TextBox TextBNumTurbines;
        private System.Windows.Forms.Button ButSave;
    }
}