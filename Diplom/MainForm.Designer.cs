namespace Diplom
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.исполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адресаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.листОсмотраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перерасчетДляРИЦToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CounterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Implementer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.актыПриемкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исполнителиToolStripMenuItem,
            this.адресаToolStripMenuItem,
            this.документыToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // исполнителиToolStripMenuItem
            // 
            this.исполнителиToolStripMenuItem.Name = "исполнителиToolStripMenuItem";
            this.исполнителиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.исполнителиToolStripMenuItem.Text = "Исполнители";
            this.исполнителиToolStripMenuItem.Click += new System.EventHandler(this.исполнителиToolStripMenuItem_Click);
            // 
            // адресаToolStripMenuItem
            // 
            this.адресаToolStripMenuItem.Name = "адресаToolStripMenuItem";
            this.адресаToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.адресаToolStripMenuItem.Text = "Адреса";
            this.адресаToolStripMenuItem.Click += new System.EventHandler(this.адресаToolStripMenuItem_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.листОсмотраToolStripMenuItem,
            this.перерасчетДляРИЦToolStripMenuItem,
            this.реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem,
            this.актыПриемкиToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // листОсмотраToolStripMenuItem
            // 
            this.листОсмотраToolStripMenuItem.Name = "листОсмотраToolStripMenuItem";
            this.листОсмотраToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.листОсмотраToolStripMenuItem.Text = "Лист осмотра";
            this.листОсмотраToolStripMenuItem.Click += new System.EventHandler(this.листОсмотраToolStripMenuItem_Click);
            // 
            // перерасчетДляРИЦToolStripMenuItem
            // 
            this.перерасчетДляРИЦToolStripMenuItem.Name = "перерасчетДляРИЦToolStripMenuItem";
            this.перерасчетДляРИЦToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.перерасчетДляРИЦToolStripMenuItem.Text = "Перерасчет для РИЦ";
            this.перерасчетДляРИЦToolStripMenuItem.Click += new System.EventHandler(this.перерасчетДляРИЦToolStripMenuItem_Click);
            // 
            // реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem
            // 
            this.реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem.Name = "реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem";
            this.реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem.Text = "Реестр снятия и установки электросчётчиков";
            this.реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem.Click += new System.EventHandler(this.реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AddressId,
            this.Address,
            this.CounterType,
            this.Place,
            this.Date,
            this.Implementer,
            this.EventType});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(815, 468);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Идентификатор";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // AddressId
            // 
            this.AddressId.HeaderText = "Идентификатор адреса";
            this.AddressId.Name = "AddressId";
            this.AddressId.Visible = false;
            // 
            // Address
            // 
            this.Address.FillWeight = 213.1978F;
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // CounterType
            // 
            this.CounterType.FillWeight = 77.36037F;
            this.CounterType.HeaderText = "Тип счетчика";
            this.CounterType.Name = "CounterType";
            // 
            // Place
            // 
            this.Place.FillWeight = 77.36037F;
            this.Place.HeaderText = "Место устновки";
            this.Place.Name = "Place";
            // 
            // Date
            // 
            this.Date.FillWeight = 77.36037F;
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // Implementer
            // 
            this.Implementer.FillWeight = 77.36037F;
            this.Implementer.HeaderText = "Исполнитель";
            this.Implementer.Name = "Implementer";
            // 
            // EventType
            // 
            this.EventType.FillWeight = 77.36037F;
            this.EventType.HeaderText = "Событие";
            this.EventType.Name = "EventType";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(590, 501);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(671, 500);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Изменить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(752, 501);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 4;
            this.button_remove.Text = "Удалить";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // актыПриемкиToolStripMenuItem
            // 
            this.актыПриемкиToolStripMenuItem.Name = "актыПриемкиToolStripMenuItem";
            this.актыПриемкиToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.актыПриемкиToolStripMenuItem.Text = "Акты приемки";
            this.актыПриемкиToolStripMenuItem.Click += new System.EventHandler(this.актыПриемкиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 535);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem исполнителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn CounterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Implementer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem листОсмотраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перерасчетДляРИЦToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрСнятияИУстановкиЭлектросчётчиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актыПриемкиToolStripMenuItem;
    }
}