namespace OOTP.VehiclesForms.LandVehiclesForms
{
    partial class FTruck
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
            this.labHeavy = new System.Windows.Forms.Label();
            this.labOver = new System.Windows.Forms.Label();
            this.RBHeavy_Yes = new System.Windows.Forms.RadioButton();
            this.RBHeavy_No = new System.Windows.Forms.RadioButton();
            this.RBOver_Yes = new System.Windows.Forms.RadioButton();
            this.RBOver_No = new System.Windows.Forms.RadioButton();
            this.ButSave = new System.Windows.Forms.Button();
            this.panelHeavy = new System.Windows.Forms.Panel();
            this.panelOver = new System.Windows.Forms.Panel();
            this.panelHeavy.SuspendLayout();
            this.panelOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // FEngine
            // 
            this.FEngine.Location = new System.Drawing.Point(26, 26);
            // 
            // labHeavy
            // 
            this.labHeavy.AutoSize = true;
            this.labHeavy.Location = new System.Drawing.Point(378, 139);
            this.labHeavy.Name = "labHeavy";
            this.labHeavy.Size = new System.Drawing.Size(109, 13);
            this.labHeavy.TabIndex = 10;
            this.labHeavy.Text = "Тяжеловесный груз";
            // 
            // labOver
            // 
            this.labOver.AutoSize = true;
            this.labOver.Location = new System.Drawing.Point(378, 192);
            this.labOver.Name = "labOver";
            this.labOver.Size = new System.Drawing.Size(128, 13);
            this.labOver.TabIndex = 11;
            this.labOver.Text = "Крупногабаритный груз";
            // 
            // RBHeavy_Yes
            // 
            this.RBHeavy_Yes.AutoSize = true;
            this.RBHeavy_Yes.Location = new System.Drawing.Point(10, 10);
            this.RBHeavy_Yes.Name = "RBHeavy_Yes";
            this.RBHeavy_Yes.Size = new System.Drawing.Size(40, 17);
            this.RBHeavy_Yes.TabIndex = 12;
            this.RBHeavy_Yes.TabStop = true;
            this.RBHeavy_Yes.Text = "Да";
            this.RBHeavy_Yes.UseVisualStyleBackColor = true;
            // 
            // RBHeavy_No
            // 
            this.RBHeavy_No.AutoSize = true;
            this.RBHeavy_No.Location = new System.Drawing.Point(66, 10);
            this.RBHeavy_No.Name = "RBHeavy_No";
            this.RBHeavy_No.Size = new System.Drawing.Size(44, 17);
            this.RBHeavy_No.TabIndex = 13;
            this.RBHeavy_No.TabStop = true;
            this.RBHeavy_No.Text = "Нет";
            this.RBHeavy_No.UseVisualStyleBackColor = true;
            // 
            // RBOver_Yes
            // 
            this.RBOver_Yes.AutoSize = true;
            this.RBOver_Yes.Location = new System.Drawing.Point(13, 9);
            this.RBOver_Yes.Name = "RBOver_Yes";
            this.RBOver_Yes.Size = new System.Drawing.Size(40, 17);
            this.RBOver_Yes.TabIndex = 14;
            this.RBOver_Yes.TabStop = true;
            this.RBOver_Yes.Text = "Да";
            this.RBOver_Yes.UseVisualStyleBackColor = true;
            // 
            // RBOver_No
            // 
            this.RBOver_No.AutoSize = true;
            this.RBOver_No.Location = new System.Drawing.Point(68, 9);
            this.RBOver_No.Name = "RBOver_No";
            this.RBOver_No.Size = new System.Drawing.Size(44, 17);
            this.RBOver_No.TabIndex = 15;
            this.RBOver_No.TabStop = true;
            this.RBOver_No.Text = "Нет";
            this.RBOver_No.UseVisualStyleBackColor = true;
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(442, 231);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(101, 23);
            this.ButSave.TabIndex = 16;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // panelHeavy
            // 
            this.panelHeavy.Controls.Add(this.RBHeavy_Yes);
            this.panelHeavy.Controls.Add(this.RBHeavy_No);
            this.panelHeavy.Location = new System.Drawing.Point(493, 125);
            this.panelHeavy.Name = "panelHeavy";
            this.panelHeavy.Size = new System.Drawing.Size(123, 31);
            this.panelHeavy.TabIndex = 17;
            // 
            // panelOver
            // 
            this.panelOver.Controls.Add(this.RBOver_Yes);
            this.panelOver.Controls.Add(this.RBOver_No);
            this.panelOver.Location = new System.Drawing.Point(512, 180);
            this.panelOver.Name = "panelOver";
            this.panelOver.Size = new System.Drawing.Size(115, 29);
            this.panelOver.TabIndex = 18;
            // 
            // FTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 276);
            this.Controls.Add(this.panelOver);
            this.Controls.Add(this.panelHeavy);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.labOver);
            this.Controls.Add(this.labHeavy);
            this.Name = "FTruck";
            this.Text = "Грузовик";
            this.Load += new System.EventHandler(this.FTruck_Load);
            this.Controls.SetChildIndex(this.labHeavy, 0);
            this.Controls.SetChildIndex(this.labOver, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.Controls.SetChildIndex(this.panelHeavy, 0);
            this.Controls.SetChildIndex(this.panelOver, 0);
            this.panelHeavy.ResumeLayout(false);
            this.panelHeavy.PerformLayout();
            this.panelOver.ResumeLayout(false);
            this.panelOver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHeavy;
        private System.Windows.Forms.Label labOver;
        private System.Windows.Forms.RadioButton RBHeavy_Yes;
        private System.Windows.Forms.RadioButton RBHeavy_No;
        private System.Windows.Forms.RadioButton RBOver_Yes;
        private System.Windows.Forms.RadioButton RBOver_No;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Panel panelHeavy;
        private System.Windows.Forms.Panel panelOver;
    }
}