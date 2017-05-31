namespace Diplom
{
    partial class ControllersForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox_controller = new System.Windows.Forms.TextBox();
            this.ControllerFioLabel = new System.Windows.Forms.Label();
            this.button_controller_add = new System.Windows.Forms.Button();
            this.button_delete_controller = new System.Windows.Forms.Button();
            this.Identificator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox_address = new System.Windows.Forms.ListBox();
            this.comboBox_street = new System.Windows.Forms.ComboBox();
            this.comboBox_houses = new System.Windows.Forms.ComboBox();
            this.button_address_add = new System.Windows.Forms.Button();
            this.button_address_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificator,
            this.FIO});
            this.dataGridView2.Location = new System.Drawing.Point(221, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(192, 250);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // textBox_controller
            // 
            this.textBox_controller.Location = new System.Drawing.Point(12, 28);
            this.textBox_controller.Name = "textBox_controller";
            this.textBox_controller.Size = new System.Drawing.Size(173, 20);
            this.textBox_controller.TabIndex = 1;
            // 
            // ControllerFioLabel
            // 
            this.ControllerFioLabel.AutoSize = true;
            this.ControllerFioLabel.Location = new System.Drawing.Point(12, 12);
            this.ControllerFioLabel.Name = "ControllerFioLabel";
            this.ControllerFioLabel.Size = new System.Drawing.Size(34, 13);
            this.ControllerFioLabel.TabIndex = 2;
            this.ControllerFioLabel.Text = "ФИО";
            // 
            // button_controller_add
            // 
            this.button_controller_add.Location = new System.Drawing.Point(12, 239);
            this.button_controller_add.Name = "button_controller_add";
            this.button_controller_add.Size = new System.Drawing.Size(75, 23);
            this.button_controller_add.TabIndex = 3;
            this.button_controller_add.Text = "Добавить";
            this.button_controller_add.UseVisualStyleBackColor = true;
            this.button_controller_add.Click += new System.EventHandler(this.button_controller_add_Click);
            // 
            // button_delete_controller
            // 
            this.button_delete_controller.Location = new System.Drawing.Point(110, 239);
            this.button_delete_controller.Name = "button_delete_controller";
            this.button_delete_controller.Size = new System.Drawing.Size(75, 23);
            this.button_delete_controller.TabIndex = 4;
            this.button_delete_controller.Text = "Удалить";
            this.button_delete_controller.UseVisualStyleBackColor = false;
            this.button_delete_controller.Click += new System.EventHandler(this.button_delete_controller_Click);
            // 
            // Identificator
            // 
            this.Identificator.HeaderText = "Идентификатор";
            this.Identificator.Name = "Identificator";
            this.Identificator.Visible = false;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // listBox_address
            // 
            this.listBox_address.FormattingEnabled = true;
            this.listBox_address.Location = new System.Drawing.Point(12, 137);
            this.listBox_address.Name = "listBox_address";
            this.listBox_address.Size = new System.Drawing.Size(173, 95);
            this.listBox_address.TabIndex = 5;
            // 
            // comboBox_street
            // 
            this.comboBox_street.FormattingEnabled = true;
            this.comboBox_street.Location = new System.Drawing.Point(12, 54);
            this.comboBox_street.Name = "comboBox_street";
            this.comboBox_street.Size = new System.Drawing.Size(173, 21);
            this.comboBox_street.TabIndex = 6;
            this.comboBox_street.SelectedIndexChanged += new System.EventHandler(this.comboBox_street_SelectedIndexChanged);
            // 
            // comboBox_houses
            // 
            this.comboBox_houses.FormattingEnabled = true;
            this.comboBox_houses.Location = new System.Drawing.Point(12, 81);
            this.comboBox_houses.Name = "comboBox_houses";
            this.comboBox_houses.Size = new System.Drawing.Size(173, 21);
            this.comboBox_houses.TabIndex = 7;
            // 
            // button_address_add
            // 
            this.button_address_add.Location = new System.Drawing.Point(12, 108);
            this.button_address_add.Name = "button_address_add";
            this.button_address_add.Size = new System.Drawing.Size(22, 23);
            this.button_address_add.TabIndex = 8;
            this.button_address_add.Text = "+";
            this.button_address_add.UseVisualStyleBackColor = true;
            this.button_address_add.Click += new System.EventHandler(this.button_address_add_Click);
            // 
            // button_address_del
            // 
            this.button_address_del.Location = new System.Drawing.Point(40, 108);
            this.button_address_del.Name = "button_address_del";
            this.button_address_del.Size = new System.Drawing.Size(22, 23);
            this.button_address_del.TabIndex = 9;
            this.button_address_del.Text = "-";
            this.button_address_del.UseVisualStyleBackColor = true;
            this.button_address_del.Click += new System.EventHandler(this.button_address_del_Click);
            // 
            // ControllersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 274);
            this.Controls.Add(this.button_address_del);
            this.Controls.Add(this.button_address_add);
            this.Controls.Add(this.comboBox_houses);
            this.Controls.Add(this.comboBox_street);
            this.Controls.Add(this.listBox_address);
            this.Controls.Add(this.button_delete_controller);
            this.Controls.Add(this.button_controller_add);
            this.Controls.Add(this.ControllerFioLabel);
            this.Controls.Add(this.textBox_controller);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ControllersForm";
            this.Text = "ControllersForm";
            this.Load += new System.EventHandler(this.ControllersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox_controller;
        private System.Windows.Forms.Label ControllerFioLabel;
        private System.Windows.Forms.Button button_controller_add;
        private System.Windows.Forms.Button button_delete_controller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificator;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.ListBox listBox_address;
        private System.Windows.Forms.ComboBox comboBox_street;
        private System.Windows.Forms.ComboBox comboBox_houses;
        private System.Windows.Forms.Button button_address_add;
        private System.Windows.Forms.Button button_address_del;
    }
}