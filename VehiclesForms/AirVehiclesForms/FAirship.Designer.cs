namespace OOTP.VehiclesForms.AirVehiclesForms
{
    partial class FAirship
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
            this.labScrews = new System.Windows.Forms.Label();
            this.labShell = new System.Windows.Forms.Label();
            this.TextBScrews = new System.Windows.Forms.TextBox();
            this.ComboBShell = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labScrews
            // 
            this.labScrews.AutoSize = true;
            this.labScrews.Location = new System.Drawing.Point(400, 90);
            this.labScrews.Name = "labScrews";
            this.labScrews.Size = new System.Drawing.Size(79, 13);
            this.labScrews.TabIndex = 10;
            this.labScrews.Text = "Кол-во винтов";
            // 
            // labShell
            // 
            this.labShell.AutoSize = true;
            this.labShell.Location = new System.Drawing.Point(400, 139);
            this.labShell.Name = "labShell";
            this.labShell.Size = new System.Drawing.Size(56, 13);
            this.labShell.TabIndex = 11;
            this.labShell.Text = "Оболочка";
            // 
            // TextBScrews
            // 
            this.TextBScrews.Location = new System.Drawing.Point(565, 87);
            this.TextBScrews.Name = "TextBScrews";
            this.TextBScrews.Size = new System.Drawing.Size(100, 20);
            this.TextBScrews.TabIndex = 12;
            this.TextBScrews.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBScrews_KeyPress);
            // 
            // ComboBShell
            // 
            this.ComboBShell.FormattingEnabled = true;
            this.ComboBShell.Items.AddRange(new object[] {
            "",
            "Мягкая",
            "Полужесткая",
            "Жесткая"});
            this.ComboBShell.Location = new System.Drawing.Point(544, 136);
            this.ComboBShell.Name = "ComboBShell";
            this.ComboBShell.Size = new System.Drawing.Size(121, 21);
            this.ComboBShell.TabIndex = 13;
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(544, 191);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(99, 23);
            this.ButSave.TabIndex = 14;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FAirship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 267);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBShell);
            this.Controls.Add(this.TextBScrews);
            this.Controls.Add(this.labShell);
            this.Controls.Add(this.labScrews);
            this.Name = "FAirship";
            this.Text = "Дирижабль";
            this.Load += new System.EventHandler(this.FAirship_Load);
            this.Controls.SetChildIndex(this.labScrews, 0);
            this.Controls.SetChildIndex(this.labShell, 0);
            this.Controls.SetChildIndex(this.TextBScrews, 0);
            this.Controls.SetChildIndex(this.ComboBShell, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labScrews;
        private System.Windows.Forms.Label labShell;
        private System.Windows.Forms.TextBox TextBScrews;
        private System.Windows.Forms.ComboBox ComboBShell;
        private System.Windows.Forms.Button ButSave;
    }
}