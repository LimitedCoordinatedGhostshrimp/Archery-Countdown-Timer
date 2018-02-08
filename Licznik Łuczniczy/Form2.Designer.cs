namespace Licznik_Łuczniczy
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.timer_numbers_label = new System.Windows.Forms.Label();
            this.startup_timer = new System.Windows.Forms.Timer(this.components);
            this.abort_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.end_timer = new System.Windows.Forms.Timer(this.components);
            this.change_timer = new System.Windows.Forms.Timer(this.components);
            this.state_label = new System.Windows.Forms.Label();
            this.change_indicator_label = new System.Windows.Forms.Label();
            this.restart_btn = new System.Windows.Forms.Button();
            this.next_round_btn = new System.Windows.Forms.Button();
            this.finish_timer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer_numbers_label
            // 
            this.timer_numbers_label.AutoSize = true;
            this.timer_numbers_label.BackColor = System.Drawing.Color.Transparent;
            this.timer_numbers_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 300F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timer_numbers_label.Location = new System.Drawing.Point(177, 23);
            this.timer_numbers_label.Name = "timer_numbers_label";
            this.timer_numbers_label.Size = new System.Drawing.Size(0, 566);
            this.timer_numbers_label.TabIndex = 0;
            this.timer_numbers_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startup_timer
            // 
            this.startup_timer.Interval = 1000;
            this.startup_timer.Tick += new System.EventHandler(this.startup_timer_Tick);
            // 
            // abort_btn
            // 
            this.abort_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abort_btn.Location = new System.Drawing.Point(742, 461);
            this.abort_btn.Name = "abort_btn";
            this.abort_btn.Size = new System.Drawing.Size(100, 40);
            this.abort_btn.TabIndex = 1;
            this.abort_btn.Text = "Stop";
            this.abort_btn.UseVisualStyleBackColor = true;
            this.abort_btn.Click += new System.EventHandler(this.abort_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pause_btn.Location = new System.Drawing.Point(742, 415);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(100, 40);
            this.pause_btn.TabIndex = 2;
            this.pause_btn.Text = "Pauza";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // end_timer
            // 
            this.end_timer.Interval = 1000;
            this.end_timer.Tick += new System.EventHandler(this.end_timer_Tick);
            // 
            // change_timer
            // 
            this.change_timer.Interval = 1000;
            this.change_timer.Tick += new System.EventHandler(this.change_timer_Tick);
            // 
            // state_label
            // 
            this.state_label.AutoSize = true;
            this.state_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.state_label.Location = new System.Drawing.Point(12, 23);
            this.state_label.Name = "state_label";
            this.state_label.Size = new System.Drawing.Size(0, 135);
            this.state_label.TabIndex = 3;
            // 
            // change_indicator_label
            // 
            this.change_indicator_label.AutoSize = true;
            this.change_indicator_label.BackColor = System.Drawing.Color.Transparent;
            this.change_indicator_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 144F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.change_indicator_label.Location = new System.Drawing.Point(32, 229);
            this.change_indicator_label.Name = "change_indicator_label";
            this.change_indicator_label.Size = new System.Drawing.Size(0, 272);
            this.change_indicator_label.TabIndex = 4;
            // 
            // restart_btn
            // 
            this.restart_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restart_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restart_btn.Location = new System.Drawing.Point(742, 369);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(100, 40);
            this.restart_btn.TabIndex = 5;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // next_round_btn
            // 
            this.next_round_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.next_round_btn.Location = new System.Drawing.Point(358, 415);
            this.next_round_btn.Name = "next_round_btn";
            this.next_round_btn.Size = new System.Drawing.Size(155, 71);
            this.next_round_btn.TabIndex = 6;
            this.next_round_btn.Text = "Następna seria";
            this.next_round_btn.UseVisualStyleBackColor = true;
            this.next_round_btn.Visible = false;
            this.next_round_btn.Click += new System.EventHandler(this.next_round_btn_Click);
            // 
            // finish_timer_btn
            // 
            this.finish_timer_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finish_timer_btn.Location = new System.Drawing.Point(742, 320);
            this.finish_timer_btn.Name = "finish_timer_btn";
            this.finish_timer_btn.Size = new System.Drawing.Size(100, 43);
            this.finish_timer_btn.TabIndex = 7;
            this.finish_timer_btn.Text = "Zakończ odliczanie";
            this.finish_timer_btn.UseVisualStyleBackColor = true;
            this.finish_timer_btn.Click += new System.EventHandler(this.finish_timer_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(854, 509);
            this.Controls.Add(this.finish_timer_btn);
            this.Controls.Add(this.next_round_btn);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.change_indicator_label);
            this.Controls.Add(this.state_label);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.abort_btn);
            this.Controls.Add(this.timer_numbers_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Licznik";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timer_numbers_label;
        private System.Windows.Forms.Timer startup_timer;
        private System.Windows.Forms.Button abort_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Timer end_timer;
        private System.Windows.Forms.Timer change_timer;
        private System.Windows.Forms.Label state_label;
        private System.Windows.Forms.Label change_indicator_label;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button next_round_btn;
        private System.Windows.Forms.Button finish_timer_btn;
    }
}