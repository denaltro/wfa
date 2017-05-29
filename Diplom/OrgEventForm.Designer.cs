namespace Diplom
{
    partial class OrgEventForm
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
            this.comboBox_counterType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_eventType = new System.Windows.Forms.ComboBox();
            this.comboBox_implementer = new System.Windows.Forms.ComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_place = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_house = new System.Windows.Forms.TextBox();
            this.textBox_building = new System.Windows.Forms.TextBox();
            this.textBox_apartment = new System.Windows.Forms.TextBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_counterType
            // 
            this.comboBox_counterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_counterType.FormattingEnabled = true;
            this.comboBox_counterType.Items.AddRange(new object[] {
            "Холодная вода",
            "Горячая вода",
            "Электрический счетчик"});
            this.comboBox_counterType.Location = new System.Drawing.Point(112, 66);
            this.comboBox_counterType.Name = "comboBox_counterType";
            this.comboBox_counterType.Size = new System.Drawing.Size(233, 21);
            this.comboBox_counterType.TabIndex = 0;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(113, 120);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker_date.TabIndex = 2;
            // 
            // textBox_street
            // 
            this.textBox_street.Location = new System.Drawing.Point(135, 40);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(156, 20);
            this.textBox_street.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип счетчика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Место установки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Исполнитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Тип события";
            // 
            // comboBox_eventType
            // 
            this.comboBox_eventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eventType.FormattingEnabled = true;
            this.comboBox_eventType.Items.AddRange(new object[] {
            "Установка",
            "Переустановка",
            "Поверка",
            "Демонтаж"});
            this.comboBox_eventType.Location = new System.Drawing.Point(112, 13);
            this.comboBox_eventType.Name = "comboBox_eventType";
            this.comboBox_eventType.Size = new System.Drawing.Size(233, 21);
            this.comboBox_eventType.TabIndex = 10;
            // 
            // comboBox_implementer
            // 
            this.comboBox_implementer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_implementer.FormattingEnabled = true;
            this.comboBox_implementer.Location = new System.Drawing.Point(113, 146);
            this.comboBox_implementer.Name = "comboBox_implementer";
            this.comboBox_implementer.Size = new System.Drawing.Size(232, 21);
            this.comboBox_implementer.TabIndex = 11;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(367, 198);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 12;
            this.button_ok.Text = "ОК";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(448, 198);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_place
            // 
            this.textBox_place.Location = new System.Drawing.Point(113, 93);
            this.textBox_place.Name = "textBox_place";
            this.textBox_place.Size = new System.Drawing.Size(232, 20);
            this.textBox_place.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ул";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "дом";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "стр";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "кв";
            // 
            // textBox_house
            // 
            this.textBox_house.Location = new System.Drawing.Point(330, 40);
            this.textBox_house.Name = "textBox_house";
            this.textBox_house.Size = new System.Drawing.Size(43, 20);
            this.textBox_house.TabIndex = 19;
            // 
            // textBox_building
            // 
            this.textBox_building.Location = new System.Drawing.Point(409, 40);
            this.textBox_building.Name = "textBox_building";
            this.textBox_building.Size = new System.Drawing.Size(49, 20);
            this.textBox_building.TabIndex = 20;
            // 
            // textBox_apartment
            // 
            this.textBox_apartment.Location = new System.Drawing.Point(489, 40);
            this.textBox_apartment.Name = "textBox_apartment";
            this.textBox_apartment.Size = new System.Drawing.Size(36, 20);
            this.textBox_apartment.TabIndex = 21;
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(114, 173);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(177, 20);
            this.textBox_count.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Показания";
            // 
            // OrgEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 229);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_apartment);
            this.Controls.Add(this.textBox_building);
            this.Controls.Add(this.textBox_house);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_place);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.comboBox_implementer);
            this.Controls.Add(this.comboBox_eventType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_street);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.comboBox_counterType);
            this.Name = "OrgEventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_counterType;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_eventType;
        private System.Windows.Forms.ComboBox comboBox_implementer;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_place;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_house;
        private System.Windows.Forms.TextBox textBox_building;
        private System.Windows.Forms.TextBox textBox_apartment;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Label label11;
    }
}