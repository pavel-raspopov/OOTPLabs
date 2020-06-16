namespace OOTP.VehicleForms.LVehicleForms
{
    partial class FMotobike
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
            this.labSideCar = new System.Windows.Forms.Label();
            this.RButSideCarYes = new System.Windows.Forms.RadioButton();
            this.RButSideCarNo = new System.Windows.Forms.RadioButton();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FEngine
            // 
            this.FEngine.Location = new System.Drawing.Point(52, 52);
            // 
            // labSideCar
            // 
            this.labSideCar.AutoSize = true;
            this.labSideCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSideCar.Location = new System.Drawing.Point(469, 164);
            this.labSideCar.Name = "labSideCar";
            this.labSideCar.Size = new System.Drawing.Size(141, 20);
            this.labSideCar.TabIndex = 12;
            this.labSideCar.Text = "Наличие коляски";
            // 
            // RButSideCarYes
            // 
            this.RButSideCarYes.AutoSize = true;
            this.RButSideCarYes.Location = new System.Drawing.Point(651, 167);
            this.RButSideCarYes.Name = "RButSideCarYes";
            this.RButSideCarYes.Size = new System.Drawing.Size(40, 17);
            this.RButSideCarYes.TabIndex = 13;
            this.RButSideCarYes.TabStop = true;
            this.RButSideCarYes.Text = "Да";
            this.RButSideCarYes.UseVisualStyleBackColor = true;
            // 
            // RButSideCarNo
            // 
            this.RButSideCarNo.AutoSize = true;
            this.RButSideCarNo.Location = new System.Drawing.Point(710, 167);
            this.RButSideCarNo.Name = "RButSideCarNo";
            this.RButSideCarNo.Size = new System.Drawing.Size(44, 17);
            this.RButSideCarNo.TabIndex = 14;
            this.RButSideCarNo.TabStop = true;
            this.RButSideCarNo.Text = "Нет";
            this.RButSideCarNo.UseVisualStyleBackColor = true;
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(651, 272);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(96, 38);
            this.ButSave.TabIndex = 15;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FMotobike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.RButSideCarNo);
            this.Controls.Add(this.RButSideCarYes);
            this.Controls.Add(this.labSideCar);
            this.Name = "FMotobike";
            this.Text = "Мотоцикл";
            this.Load += new System.EventHandler(this.FMotobike_Load);
            this.Controls.SetChildIndex(this.labSideCar, 0);
            this.Controls.SetChildIndex(this.RButSideCarYes, 0);
            this.Controls.SetChildIndex(this.RButSideCarNo, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSideCar;
        private System.Windows.Forms.RadioButton RButSideCarYes;
        private System.Windows.Forms.RadioButton RButSideCarNo;
        private System.Windows.Forms.Button ButSave;
    }
}