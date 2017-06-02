namespace Diplom
{
    partial class oVerificationForm
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
            this.dateTimePicker11 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker12 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker22 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker21 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ok2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker11
            // 
            this.dateTimePicker11.Location = new System.Drawing.Point(40, 33);
            this.dateTimePicker11.Name = "dateTimePicker11";
            this.dateTimePicker11.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker11.TabIndex = 0;
            // 
            // dateTimePicker12
            // 
            this.dateTimePicker12.Location = new System.Drawing.Point(290, 33);
            this.dateTimePicker12.Name = "dateTimePicker12";
            this.dateTimePicker12.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker12.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "до";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(400, 72);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(91, 23);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "ОК";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker12);
            this.groupBox1.Controls.Add(this.dateTimePicker11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_ok);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 120);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчет о совершенных событиях по типу прибора учета";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker22);
            this.groupBox2.Controls.Add(this.dateTimePicker21);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_ok2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчет о совершенных поверках по контролеру";
            // 
            // dateTimePicker22
            // 
            this.dateTimePicker22.Location = new System.Drawing.Point(290, 27);
            this.dateTimePicker22.Name = "dateTimePicker22";
            this.dateTimePicker22.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker22.TabIndex = 8;
            // 
            // dateTimePicker21
            // 
            this.dateTimePicker21.Location = new System.Drawing.Point(40, 27);
            this.dateTimePicker21.Name = "dateTimePicker21";
            this.dateTimePicker21.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker21.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "от";
            // 
            // button_ok2
            // 
            this.button_ok2.Location = new System.Drawing.Point(400, 70);
            this.button_ok2.Name = "button_ok2";
            this.button_ok2.Size = new System.Drawing.Size(91, 23);
            this.button_ok2.TabIndex = 11;
            this.button_ok2.Text = "ОК";
            this.button_ok2.UseVisualStyleBackColor = true;
            this.button_ok2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "до";
            // 
            // oVerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "oVerificationForm";
            this.Text = "oVerificationForm";
            this.Load += new System.EventHandler(this.oVerificationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker11;
        private System.Windows.Forms.DateTimePicker dateTimePicker12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker22;
        private System.Windows.Forms.DateTimePicker dateTimePicker21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ok2;
        private System.Windows.Forms.Label label4;
    }
}