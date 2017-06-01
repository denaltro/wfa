namespace Diplom
{
    partial class VerificationListForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_wait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(12, 35);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(396, 20);
            this.textBox_path.TabIndex = 0;
            this.textBox_path.Text = "D:\\Downloads\\Gvs_khvs_uozhilstroyservis_ch1.xls";
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(414, 64);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 23);
            this.button_load.TabIndex = 1;
            this.button_load.Text = "Загрузить";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Укажите путь к файлу - оборотной ведомости из РИЦ";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(414, 33);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Открыть";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Контролер";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(79, 101);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 15);
            this.progressBar1.Step = 2;
            this.progressBar1.TabIndex = 6;
            // 
            // label_wait
            // 
            this.label_wait.AutoSize = true;
            this.label_wait.Location = new System.Drawing.Point(87, 119);
            this.label_wait.Name = "label_wait";
            this.label_wait.Size = new System.Drawing.Size(35, 13);
            this.label_wait.TabIndex = 7;
            this.label_wait.Text = "label3";
            // 
            // VerificationListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 139);
            this.Controls.Add(this.label_wait);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.textBox_path);
            this.Name = "VerificationListForm";
            this.Text = "VerificationList";
            this.Load += new System.EventHandler(this.VerificationListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_wait;
    }
}