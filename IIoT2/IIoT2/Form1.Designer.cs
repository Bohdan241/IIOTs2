using System.Windows.Forms;

namespace IIoT2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_I00 = new System.Windows.Forms.CheckBox();
            this.checkBox_I01 = new System.Windows.Forms.CheckBox();
            this.checkBox_I04 = new System.Windows.Forms.CheckBox();
            this.checkBox_I03 = new System.Windows.Forms.CheckBox();
            this.checkBox_I02 = new System.Windows.Forms.CheckBox();
            this.button_run = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label_connection = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer_read_output = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поїзд метрополітену №365";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Управління відкриттям дверей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статус:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(98, 99);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(95, 25);
            this.label_status.TabIndex = 3;
            this.label_status.Text = "Зачинені";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IIoT2.Properties.Resources.closed;
            this.pictureBox1.Location = new System.Drawing.Point(11, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox_I00
            // 
            this.checkBox_I00.AutoSize = true;
            this.checkBox_I00.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_I00.Location = new System.Drawing.Point(587, 127);
            this.checkBox_I00.Name = "checkBox_I00";
            this.checkBox_I00.Size = new System.Drawing.Size(178, 29);
            this.checkBox_I00.TabIndex = 5;
            this.checkBox_I00.Text = "поїзд зупинено";
            this.checkBox_I00.UseVisualStyleBackColor = true;
            this.checkBox_I00.CheckedChanged += new System.EventHandler(this.checkBox_I00_CheckedChanged);
            // 
            // checkBox_I01
            // 
            this.checkBox_I01.AutoSize = true;
            this.checkBox_I01.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_I01.Location = new System.Drawing.Point(587, 162);
            this.checkBox_I01.Name = "checkBox_I01";
            this.checkBox_I01.Size = new System.Drawing.Size(271, 29);
            this.checkBox_I01.TabIndex = 6;
            this.checkBox_I01.Text = "кнопка відкриття дверей";
            this.checkBox_I01.UseVisualStyleBackColor = true;
            this.checkBox_I01.CheckedChanged += new System.EventHandler(this.checkBox_I01_CheckedChanged);
            // 
            // checkBox_I04
            // 
            this.checkBox_I04.AutoSize = true;
            this.checkBox_I04.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_I04.Location = new System.Drawing.Point(587, 267);
            this.checkBox_I04.Name = "checkBox_I04";
            this.checkBox_I04.Size = new System.Drawing.Size(379, 29);
            this.checkBox_I04.TabIndex = 7;
            this.checkBox_I04.Text = "кнопка \"Аварійне відкриття дверей\"";
            this.checkBox_I04.UseVisualStyleBackColor = true;
            this.checkBox_I04.CheckedChanged += new System.EventHandler(this.checkBox_I04_CheckedChanged);
            // 
            // checkBox_I03
            // 
            this.checkBox_I03.AutoSize = true;
            this.checkBox_I03.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_I03.Location = new System.Drawing.Point(587, 232);
            this.checkBox_I03.Name = "checkBox_I03";
            this.checkBox_I03.Size = new System.Drawing.Size(193, 29);
            this.checkBox_I03.TabIndex = 8;
            this.checkBox_I03.Text = "з диспетчерської";
            this.checkBox_I03.UseVisualStyleBackColor = true;
            this.checkBox_I03.CheckedChanged += new System.EventHandler(this.checkBox_I03_CheckedChanged);
            // 
            // checkBox_I02
            // 
            this.checkBox_I02.AutoSize = true;
            this.checkBox_I02.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_I02.Location = new System.Drawing.Point(587, 197);
            this.checkBox_I02.Name = "checkBox_I02";
            this.checkBox_I02.Size = new System.Drawing.Size(213, 29);
            this.checkBox_I02.TabIndex = 9;
            this.checkBox_I02.Text = "з кабіни машиніста";
            this.checkBox_I02.UseVisualStyleBackColor = true;
            this.checkBox_I02.CheckedChanged += new System.EventHandler(this.checkBox_I02_CheckedChanged);
            // 
            // button_run
            // 
            this.button_run.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_run.Location = new System.Drawing.Point(587, 359);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(150, 50);
            this.button_run.TabIndex = 10;
            this.button_run.Text = "Запускати";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // button_stop
            // 
            this.button_stop.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_stop.Location = new System.Drawing.Point(743, 359);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(150, 50);
            this.button_stop.TabIndex = 11;
            this.button_stop.Text = "Стоп";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label_connection
            // 
            this.label_connection.AutoSize = true;
            this.label_connection.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_connection.ForeColor = System.Drawing.Color.Red;
            this.label_connection.Location = new System.Drawing.Point(798, 412);
            this.label_connection.Name = "label_connection";
            this.label_connection.Size = new System.Drawing.Size(136, 25);
            this.label_connection.TabIndex = 12;
            this.label_connection.Text = "Відключення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(587, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Статус підключення:";
            // 
            // timer_read_output
            // 
            this.timer_read_output.Enabled = true;
            this.timer_read_output.Tick += new System.EventHandler(this.timer_read_output_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(978, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_connection);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.checkBox_I02);
            this.Controls.Add(this.checkBox_I03);
            this.Controls.Add(this.checkBox_I04);
            this.Controls.Add(this.checkBox_I01);
            this.Controls.Add(this.checkBox_I00);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "IIoT Lab2 Lukhanin Bohdan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_status;
        private PictureBox pictureBox1;
        private CheckBox checkBox_I00;
        private CheckBox checkBox_I01;
        private CheckBox checkBox_I04;
        private CheckBox checkBox_I03;
        private CheckBox checkBox_I02;
        private Button button_run;
        private Button button_stop;
        private Label label_connection;
        private Label label4;
        private Timer timer_read_output;
    }
}