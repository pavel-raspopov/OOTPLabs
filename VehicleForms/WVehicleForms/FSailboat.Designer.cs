namespace OOTP.VehicleForms.WVehicleForms
{
    partial class FSailboat
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
            this.labSails = new System.Windows.Forms.Label();
            this.TextBNumSails = new System.Windows.Forms.TextBox();
            this.labMasts = new System.Windows.Forms.Label();
            this.TextBNumMasts = new System.Windows.Forms.TextBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labSails
            // 
            this.labSails.AutoSize = true;
            this.labSails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSails.Location = new System.Drawing.Point(437, 164);
            this.labSails.Name = "labSails";
            this.labSails.Size = new System.Drawing.Size(125, 20);
            this.labSails.TabIndex = 14;
            this.labSails.Text = "Кол-во парусов";
            // 
            // TextBNumSails
            // 
            this.TextBNumSails.Location = new System.Drawing.Point(628, 166);
            this.TextBNumSails.Name = "TextBNumSails";
            this.TextBNumSails.Size = new System.Drawing.Size(126, 20);
            this.TextBNumSails.TabIndex = 15;
            this.TextBNumSails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumSails_KeyPress);
            // 
            // labMasts
            // 
            this.labMasts.AutoSize = true;
            this.labMasts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labMasts.Location = new System.Drawing.Point(437, 227);
            this.labMasts.Name = "labMasts";
            this.labMasts.Size = new System.Drawing.Size(103, 20);
            this.labMasts.TabIndex = 16;
            this.labMasts.Text = "Кол-во мачт";
            // 
            // TextBNumMasts
            // 
            this.TextBNumMasts.Location = new System.Drawing.Point(628, 229);
            this.TextBNumMasts.Name = "TextBNumMasts";
            this.TextBNumMasts.Size = new System.Drawing.Size(126, 20);
            this.TextBNumMasts.TabIndex = 17;
            this.TextBNumMasts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBNumMasts_KeyPress);
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(657, 293);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(97, 42);
            this.ButSave.TabIndex = 18;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // FSailboat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.TextBNumMasts);
            this.Controls.Add(this.labMasts);
            this.Controls.Add(this.TextBNumSails);
            this.Controls.Add(this.labSails);
            this.Name = "FSailboat";
            this.Text = "FSailboat";
            this.Load += new System.EventHandler(this.FSailboat_Load);
            this.Controls.SetChildIndex(this.labSails, 0);
            this.Controls.SetChildIndex(this.TextBNumSails, 0);
            this.Controls.SetChildIndex(this.labMasts, 0);
            this.Controls.SetChildIndex(this.TextBNumMasts, 0);
            this.Controls.SetChildIndex(this.ButSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSails;
        private System.Windows.Forms.TextBox TextBNumSails;
        private System.Windows.Forms.Label labMasts;
        private System.Windows.Forms.TextBox TextBNumMasts;
        private System.Windows.Forms.Button ButSave;
    }
}