namespace OOTP
{
    partial class FMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lvVehicles = new System.Windows.Forms.ListView();
            this.columnHeaderVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComboBVehicleType = new System.Windows.Forms.ComboBox();
            this.ButAdd = new System.Windows.Forms.Button();
            this.ContextMStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReadToolStripMI = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvVehicles
            // 
            this.lvVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderVehicle,
            this.columnHeaderName});
            this.lvVehicles.FullRowSelect = true;
            this.lvVehicles.HideSelection = false;
            this.lvVehicles.Location = new System.Drawing.Point(35, 33);
            this.lvVehicles.Name = "lvVehicles";
            this.lvVehicles.Size = new System.Drawing.Size(387, 380);
            this.lvVehicles.TabIndex = 14;
            this.lvVehicles.UseCompatibleStateImageBehavior = false;
            this.lvVehicles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderVehicle
            // 
            this.columnHeaderVehicle.Text = "Транспорт";
            this.columnHeaderVehicle.Width = 170;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 213;
            // 
            // ComboBVehicleType
            // 
            this.ComboBVehicleType.FormattingEnabled = true;
            this.ComboBVehicleType.Items.AddRange(new object[] {
            "Дирижабль",
            "Самолет",
            "Автомобиль",
            "Мотоцикл",
            "Подлодка",
            "Парусник"});
            this.ComboBVehicleType.Location = new System.Drawing.Point(468, 69);
            this.ComboBVehicleType.Name = "ComboBVehicleType";
            this.ComboBVehicleType.Size = new System.Drawing.Size(149, 21);
            this.ComboBVehicleType.TabIndex = 15;
            // 
            // ButAdd
            // 
            this.ButAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButAdd.Location = new System.Drawing.Point(649, 56);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(114, 48);
            this.ButAdd.TabIndex = 16;
            this.ButAdd.Text = "Создать";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // ContextMStrip
            // 
            this.ContextMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReadToolStripMI,
            this.UpdateToolStripMI,
            this.DeleteToolStripMI});
            this.ContextMStrip.Name = "ContextMStrip";
            this.ContextMStrip.Size = new System.Drawing.Size(149, 70);
            // 
            // ReadToolStripMI
            // 
            this.ReadToolStripMI.Name = "ReadToolStripMI";
            this.ReadToolStripMI.Size = new System.Drawing.Size(148, 22);
            this.ReadToolStripMI.Text = "Просмотреть";
            this.ReadToolStripMI.Click += new System.EventHandler(this.ReadToolStripMI_Click);
            // 
            // UpdateToolStripMI
            // 
            this.UpdateToolStripMI.Name = "UpdateToolStripMI";
            this.UpdateToolStripMI.Size = new System.Drawing.Size(148, 22);
            this.UpdateToolStripMI.Text = "Изменить";
            this.UpdateToolStripMI.Click += new System.EventHandler(this.UpdateToolStripMI_Click);
            // 
            // DeleteToolStripMI
            // 
            this.DeleteToolStripMI.Name = "DeleteToolStripMI";
            this.DeleteToolStripMI.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMI.Text = "Удалить";
            this.DeleteToolStripMI.Click += new System.EventHandler(this.DeleteToolStripMI_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.ComboBVehicleType);
            this.Controls.Add(this.lvVehicles);
            this.Name = "FMain";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ContextMStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVehicles;
        private System.Windows.Forms.ColumnHeader columnHeaderVehicle;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ComboBox ComboBVehicleType;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.ContextMenuStrip ContextMStrip;
        private System.Windows.Forms.ToolStripMenuItem ReadToolStripMI;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMI;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMI;
    }
}

