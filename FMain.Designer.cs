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
            this.labSerType = new System.Windows.Forms.Label();
            this.ComboBSers = new System.Windows.Forms.ComboBox();
            this.ButSave = new System.Windows.Forms.Button();
            this.ButLoad = new System.Windows.Forms.Button();
            this.SaveFD = new System.Windows.Forms.SaveFileDialog();
            this.OpenFD = new System.Windows.Forms.OpenFileDialog();
            this.labArchiving = new System.Windows.Forms.Label();
            this.ComboBArchiving = new System.Windows.Forms.ComboBox();
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
            this.DeleteToolStripMI.Size = new System.Drawing.Size(148, 22);
            this.DeleteToolStripMI.Text = "Удалить";
            this.DeleteToolStripMI.Click += new System.EventHandler(this.DeleteToolStripMI_Click);
            // 
            // labSerType
            // 
            this.labSerType.AutoSize = true;
            this.labSerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSerType.Location = new System.Drawing.Point(464, 160);
            this.labSerType.Name = "labSerType";
            this.labSerType.Size = new System.Drawing.Size(147, 20);
            this.labSerType.TabIndex = 18;
            this.labSerType.Text = "Тип сериализации";
            // 
            // ComboBSers
            // 
            this.ComboBSers.FormattingEnabled = true;
            this.ComboBSers.Items.AddRange(new object[] {
            "Бинарный",
            "JSON",
            "Текстовый"});
            this.ComboBSers.Location = new System.Drawing.Point(642, 162);
            this.ComboBSers.Name = "ComboBSers";
            this.ComboBSers.Size = new System.Drawing.Size(131, 21);
            this.ComboBSers.TabIndex = 19;
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButSave.Location = new System.Drawing.Point(500, 322);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(106, 42);
            this.ButSave.TabIndex = 20;
            this.ButSave.Text = "Сохранить";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // ButLoad
            // 
            this.ButLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButLoad.Location = new System.Drawing.Point(635, 322);
            this.ButLoad.Name = "ButLoad";
            this.ButLoad.Size = new System.Drawing.Size(106, 42);
            this.ButLoad.TabIndex = 21;
            this.ButLoad.Text = "Загрузить";
            this.ButLoad.UseVisualStyleBackColor = true;
            this.ButLoad.Click += new System.EventHandler(this.ButLoad_Click);
            // 
            // labArchiving
            // 
            this.labArchiving.AutoSize = true;
            this.labArchiving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labArchiving.Location = new System.Drawing.Point(464, 234);
            this.labArchiving.Name = "labArchiving";
            this.labArchiving.Size = new System.Drawing.Size(90, 20);
            this.labArchiving.TabIndex = 22;
            this.labArchiving.Text = "Архивация";
            // 
            // ComboBArchiving
            // 
            this.ComboBArchiving.FormattingEnabled = true;
            this.ComboBArchiving.Location = new System.Drawing.Point(642, 234);
            this.ComboBArchiving.Name = "ComboBArchiving";
            this.ComboBArchiving.Size = new System.Drawing.Size(131, 21);
            this.ComboBArchiving.TabIndex = 23;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBArchiving);
            this.Controls.Add(this.labArchiving);
            this.Controls.Add(this.ButLoad);
            this.Controls.Add(this.ButSave);
            this.Controls.Add(this.ComboBSers);
            this.Controls.Add(this.labSerType);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.ComboBVehicleType);
            this.Controls.Add(this.lvVehicles);
            this.Name = "FMain";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ContextMStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label labSerType;
        private System.Windows.Forms.ComboBox ComboBSers;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.Button ButLoad;
        private System.Windows.Forms.SaveFileDialog SaveFD;
        private System.Windows.Forms.OpenFileDialog OpenFD;
        private System.Windows.Forms.Label labArchiving;
        private System.Windows.Forms.ComboBox ComboBArchiving;
    }
}

