namespace OOTP.VehicleForms.AVehicleForms
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
            this.TextBNumScrews = new System.Windows.Forms.TextBox();
            this.labShell = new System.Windows.Forms.Label();
            this.ComboBShell = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labScrews
            // 
            this.labScrews.AutoSize = true;
            this.labScrews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labScrews.Location = new System.Drawing.Point(456, 164);
            this.labScrews.Name = "labScrews";
            this.labScrews.Size = new System.Drawing.Size(119, 20);
            this.labScrews.TabIndex = 12;
            this.labScrews.Text = "Кол-во винтов";
            // 
            // TextBNumScrews
            // 
            this.TextBNumScrews.Location = new System.Drawing.Point(634, 166);
            this.TextBNumScrews.Name = "TextBNumScrews";
            this.TextBNumScrews.Size = new System.Drawing.Size(132, 20);
            this.TextBNumScrews.TabIndex = 13;
            this.TextBNumScrews.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumScrews_KeyPress);
            // 
            // labShell
            // 
            this.labShell.AutoSize = true;
            this.labShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labShell.Location = new System.Drawing.Point(456, 227);
            this.labShell.Name = "labShell";
            this.labShell.Size = new System.Drawing.Size(84, 20);
            this.labShell.TabIndex = 14;
            this.labShell.Text = "Оболочка";
            // 
            // ComboBShell
            // 
            this.ComboBShell.FormattingEnabled = true;
            this.ComboBShell.Items.AddRange(new object[] {
            "",
            "Мягкая",
            "Полужесткая",
            "Жесткая"});
            this.ComboBShell.Location = new System.Drawing.Point(634, 229);
            this.ComboBShell.Name = "ComboBShell";
            this.ComboBShell.Size = new System.Drawing.Size(132, 21);
            this.ComboBShell.TabIndex = 15;
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(672, 266);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(94, 40);
            this.ButSave.TabIndex = 16;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FAirship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBShell);
            this.Controls.Add(this.labShell);
            this.Controls.Add(this.TextBNumScrews);
            this.Controls.Add(this.labScrews);
            this.Name = "FAirship";
            this.Text = "Дирижабль";
            this.Load += new System.EventHandler(this.FAirship_Load);
            this.Controls.SetChildIndex(this.labScrews, 0);
            this.Controls.SetChildIndex(this.TextBNumScrews, 0);
            this.Controls.SetChildIndex(this.labShell, 0);
            this.Controls.SetChildIndex(this.ComboBShell, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labScrews;
        private System.Windows.Forms.TextBox TextBNumScrews;
        private System.Windows.Forms.Label labShell;
        private System.Windows.Forms.ComboBox ComboBShell;
        private System.Windows.Forms.Button ButSave;
    }
}