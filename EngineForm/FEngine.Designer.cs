namespace OOTP.EngineForm
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
            this.labExpend = new System.Windows.Forms.Label();
            this.labPower = new System.Windows.Forms.Label();
            this.labEffic = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.TextBExpend = new System.Windows.Forms.TextBox();
            this.TextBPower = new System.Windows.Forms.TextBox();
            this.TextBEffic = new System.Windows.Forms.TextBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.ComboBEngineType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labExpend
            // 
            this.labExpend.AutoSize = true;
            this.labExpend.Location = new System.Drawing.Point(56, 42);
            this.labExpend.Name = "labExpend";
            this.labExpend.Size = new System.Drawing.Size(148, 13);
            this.labExpend.TabIndex = 0;
            this.labExpend.Text = "Расход топлива ( л/100 км )";
            // 
            // labPower
            // 
            this.labPower.AutoSize = true;
            this.labPower.Location = new System.Drawing.Point(56, 84);
            this.labPower.Name = "labPower";
            this.labPower.Size = new System.Drawing.Size(99, 13);
            this.labPower.TabIndex = 1;
            this.labPower.Text = "Мощность ( л.  с. )";
            // 
            // labEffic
            // 
            this.labEffic.AutoSize = true;
            this.labEffic.Location = new System.Drawing.Point(56, 129);
            this.labEffic.Name = "labEffic";
            this.labEffic.Size = new System.Drawing.Size(31, 13);
            this.labEffic.TabIndex = 2;
            this.labEffic.Text = "КПД";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(56, 175);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(81, 13);
            this.labType.TabIndex = 3;
            this.labType.Text = "Тип двигателя";
            // 
            // TextBExpend
            // 
            this.TextBExpend.Location = new System.Drawing.Point(279, 39);
            this.TextBExpend.Name = "TextBExpend";
            this.TextBExpend.Size = new System.Drawing.Size(128, 20);
            this.TextBExpend.TabIndex = 4;
            this.TextBExpend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBExpend_KeyPress);
            // 
            // TextBPower
            // 
            this.TextBPower.Location = new System.Drawing.Point(279, 81);
            this.TextBPower.Name = "TextBPower";
            this.TextBPower.Size = new System.Drawing.Size(128, 20);
            this.TextBPower.TabIndex = 5;
            this.TextBPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBPower_KeyPress);
            // 
            // TextBEffic
            // 
            this.TextBEffic.Location = new System.Drawing.Point(279, 126);
            this.TextBEffic.Name = "TextBEffic";
            this.TextBEffic.Size = new System.Drawing.Size(128, 20);
            this.TextBEffic.TabIndex = 6;
            this.TextBEffic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBEffic_KeyPress);
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(188, 211);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(91, 23);
            this.ButSave.TabIndex = 8;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // ComboBEngineType
            // 
            this.ComboBEngineType.FormattingEnabled = true;
            this.ComboBEngineType.Items.AddRange(new object[] {
            "",
            "Бензиновый",
            "Дизельный",
            "Газовый",
            "Электрический"});
            this.ComboBEngineType.Location = new System.Drawing.Point(279, 172);
            this.ComboBEngineType.Name = "ComboBEngineType";
            this.ComboBEngineType.Size = new System.Drawing.Size(128, 21);
            this.ComboBEngineType.TabIndex = 9;
            // 
            // FEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 251);
            this.Controls.Add(this.ComboBEngineType);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.TextBEffic);
            this.Controls.Add(this.TextBPower);
            this.Controls.Add(this.TextBExpend);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labEffic);
            this.Controls.Add(this.labPower);
            this.Controls.Add(this.labExpend);
            this.Name = "FEngine";
            this.Text = "Двигатель";
            this.Load += new System.EventHandler(this.FEngine_Load);
            this.Shown += new System.EventHandler(this.FEngine_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labExpend;
        private System.Windows.Forms.Label labPower;
        private System.Windows.Forms.Label labEffic;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.TextBox TextBExpend;
        private System.Windows.Forms.TextBox TextBPower;
        private System.Windows.Forms.TextBox TextBEffic;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.ComboBox ComboBEngineType;
    }
}