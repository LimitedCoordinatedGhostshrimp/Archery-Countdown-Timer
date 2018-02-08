namespace Licznik_Łuczniczy
{
    partial class Form1
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
            this.start_btn = new System.Windows.Forms.Button();
            this.end_time_rb1 = new System.Windows.Forms.RadioButton();
            this.end_time_rb2 = new System.Windows.Forms.RadioButton();
            this.end_time_rb3 = new System.Windows.Forms.RadioButton();
            this.end_time_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.change_time_rb1 = new System.Windows.Forms.RadioButton();
            this.change_time_rb2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.change_time_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.start_up_time_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startup_timer_enable_checkbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.enable_sound_checkbox = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.alternating_mode_rb = new System.Windows.Forms.RadioButton();
            this.consecutive_mode_rb = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.number_of_rounds_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 328);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(458, 23);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // end_time_rb1
            // 
            this.end_time_rb1.AutoSize = true;
            this.end_time_rb1.Checked = true;
            this.end_time_rb1.Location = new System.Drawing.Point(6, 20);
            this.end_time_rb1.Name = "end_time_rb1";
            this.end_time_rb1.Size = new System.Drawing.Size(103, 21);
            this.end_time_rb1.TabIndex = 1;
            this.end_time_rb1.TabStop = true;
            this.end_time_rb1.Text = "120 sekund";
            this.end_time_rb1.UseVisualStyleBackColor = true;
            this.end_time_rb1.CheckedChanged += new System.EventHandler(this.end_time_rb1_CheckedChanged);
            // 
            // end_time_rb2
            // 
            this.end_time_rb2.AutoSize = true;
            this.end_time_rb2.Location = new System.Drawing.Point(6, 47);
            this.end_time_rb2.Name = "end_time_rb2";
            this.end_time_rb2.Size = new System.Drawing.Size(95, 21);
            this.end_time_rb2.TabIndex = 2;
            this.end_time_rb2.Text = "90 sekund";
            this.end_time_rb2.UseVisualStyleBackColor = true;
            this.end_time_rb2.CheckedChanged += new System.EventHandler(this.end_time_rb2_CheckedChanged);
            // 
            // end_time_rb3
            // 
            this.end_time_rb3.AutoSize = true;
            this.end_time_rb3.Location = new System.Drawing.Point(6, 74);
            this.end_time_rb3.Name = "end_time_rb3";
            this.end_time_rb3.Size = new System.Drawing.Size(55, 21);
            this.end_time_rb3.TabIndex = 3;
            this.end_time_rb3.Text = "Inny";
            this.end_time_rb3.UseVisualStyleBackColor = true;
            this.end_time_rb3.CheckedChanged += new System.EventHandler(this.end_time_rb3_CheckedChanged);
            // 
            // end_time_tb
            // 
            this.end_time_tb.Enabled = false;
            this.end_time_tb.Location = new System.Drawing.Point(6, 101);
            this.end_time_tb.Name = "end_time_tb";
            this.end_time_tb.Size = new System.Drawing.Size(55, 22);
            this.end_time_tb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "sekund";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ilość zmian na linii strzelań";
            // 
            // change_time_rb1
            // 
            this.change_time_rb1.AutoSize = true;
            this.change_time_rb1.Checked = true;
            this.change_time_rb1.Location = new System.Drawing.Point(6, 27);
            this.change_time_rb1.Name = "change_time_rb1";
            this.change_time_rb1.Size = new System.Drawing.Size(37, 21);
            this.change_time_rb1.TabIndex = 8;
            this.change_time_rb1.TabStop = true;
            this.change_time_rb1.Text = "1";
            this.change_time_rb1.UseVisualStyleBackColor = true;
            this.change_time_rb1.CheckedChanged += new System.EventHandler(this.change_time_rb1_CheckedChanged);
            // 
            // change_time_rb2
            // 
            this.change_time_rb2.AutoSize = true;
            this.change_time_rb2.Location = new System.Drawing.Point(6, 54);
            this.change_time_rb2.Name = "change_time_rb2";
            this.change_time_rb2.Size = new System.Drawing.Size(37, 21);
            this.change_time_rb2.TabIndex = 9;
            this.change_time_rb2.Text = "2";
            this.change_time_rb2.UseVisualStyleBackColor = true;
            this.change_time_rb2.CheckedChanged += new System.EventHandler(this.change_time_rb2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Czas na zmianę na linii strzelań";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "sekund";
            // 
            // change_time_tb
            // 
            this.change_time_tb.Enabled = false;
            this.change_time_tb.Location = new System.Drawing.Point(3, 101);
            this.change_time_tb.Name = "change_time_tb";
            this.change_time_tb.Size = new System.Drawing.Size(55, 22);
            this.change_time_tb.TabIndex = 11;
            this.change_time_tb.Text = "10";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Licznik_Łuczniczy.Properties.Resources.logo_strzala;
            this.pictureBox1.Location = new System.Drawing.Point(409, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.end_time_rb1);
            this.panel1.Controls.Add(this.end_time_rb2);
            this.panel1.Controls.Add(this.end_time_rb3);
            this.panel1.Controls.Add(this.end_time_tb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 130);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Czas trwania serii";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.change_time_rb1);
            this.panel2.Controls.Add(this.change_time_rb2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.change_time_tb);
            this.panel2.Location = new System.Drawing.Point(239, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 130);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.start_up_time_tb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.startup_timer_enable_checkbox);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 61);
            this.panel3.TabIndex = 16;
            // 
            // start_up_time_tb
            // 
            this.start_up_time_tb.Location = new System.Drawing.Point(6, 30);
            this.start_up_time_tb.Name = "start_up_time_tb";
            this.start_up_time_tb.Size = new System.Drawing.Size(55, 22);
            this.start_up_time_tb.TabIndex = 7;
            this.start_up_time_tb.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "sekund";
            // 
            // startup_timer_enable_checkbox
            // 
            this.startup_timer_enable_checkbox.AutoSize = true;
            this.startup_timer_enable_checkbox.Checked = true;
            this.startup_timer_enable_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startup_timer_enable_checkbox.Location = new System.Drawing.Point(6, 3);
            this.startup_timer_enable_checkbox.Name = "startup_timer_enable_checkbox";
            this.startup_timer_enable_checkbox.Size = new System.Drawing.Size(175, 21);
            this.startup_timer_enable_checkbox.TabIndex = 1;
            this.startup_timer_enable_checkbox.Text = "Aktywuj licznik startowy";
            this.startup_timer_enable_checkbox.UseVisualStyleBackColor = true;
            this.startup_timer_enable_checkbox.CheckedChanged += new System.EventHandler(this.startup_timer_enable_checkbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(294, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Autor: Sandra Tołkacz\r\nVer 1.1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.enable_sound_checkbox);
            this.panel4.Location = new System.Drawing.Point(239, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 26);
            this.panel4.TabIndex = 18;
            // 
            // enable_sound_checkbox
            // 
            this.enable_sound_checkbox.AutoSize = true;
            this.enable_sound_checkbox.Location = new System.Drawing.Point(6, 3);
            this.enable_sound_checkbox.Name = "enable_sound_checkbox";
            this.enable_sound_checkbox.Size = new System.Drawing.Size(74, 21);
            this.enable_sound_checkbox.TabIndex = 0;
            this.enable_sound_checkbox.Text = "Dźwięk";
            this.enable_sound_checkbox.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.alternating_mode_rb);
            this.panel5.Controls.Add(this.consecutive_mode_rb);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(239, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 73);
            this.panel5.TabIndex = 19;
            // 
            // alternating_mode_rb
            // 
            this.alternating_mode_rb.AutoSize = true;
            this.alternating_mode_rb.Checked = true;
            this.alternating_mode_rb.Location = new System.Drawing.Point(7, 49);
            this.alternating_mode_rb.Name = "alternating_mode_rb";
            this.alternating_mode_rb.Size = new System.Drawing.Size(183, 21);
            this.alternating_mode_rb.TabIndex = 2;
            this.alternating_mode_rb.TabStop = true;
            this.alternating_mode_rb.Text = "Naprzemienny (AB->BA)";
            this.alternating_mode_rb.UseVisualStyleBackColor = true;
            // 
            // consecutive_mode_rb
            // 
            this.consecutive_mode_rb.AutoSize = true;
            this.consecutive_mode_rb.Location = new System.Drawing.Point(7, 22);
            this.consecutive_mode_rb.Name = "consecutive_mode_rb";
            this.consecutive_mode_rb.Size = new System.Drawing.Size(173, 21);
            this.consecutive_mode_rb.TabIndex = 1;
            this.consecutive_mode_rb.Text = "Sekwencyjny (AB->AB)";
            this.consecutive_mode_rb.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tryb zmian na linii strzelań";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.number_of_rounds_tb);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(12, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 54);
            this.panel6.TabIndex = 20;
            // 
            // number_of_rounds_tb
            // 
            this.number_of_rounds_tb.Location = new System.Drawing.Point(7, 25);
            this.number_of_rounds_tb.Name = "number_of_rounds_tb";
            this.number_of_rounds_tb.Size = new System.Drawing.Size(55, 22);
            this.number_of_rounds_tb.TabIndex = 7;
            this.number_of_rounds_tb.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "serii";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ilość serii w rundzie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 365);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Licznik Łuczniczy MKŁ Strzała - setup window Ver 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.RadioButton end_time_rb1;
        private System.Windows.Forms.RadioButton end_time_rb2;
        private System.Windows.Forms.RadioButton end_time_rb3;
        private System.Windows.Forms.TextBox end_time_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton change_time_rb1;
        private System.Windows.Forms.RadioButton change_time_rb2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox change_time_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox start_up_time_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox startup_timer_enable_checkbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox enable_sound_checkbox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton alternating_mode_rb;
        private System.Windows.Forms.RadioButton consecutive_mode_rb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox number_of_rounds_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

