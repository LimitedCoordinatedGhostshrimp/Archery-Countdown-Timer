using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Licznik_Łuczniczy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string end_time_text, change_time_text, startup_time_text, number_of_rounds_text;
        public static int change_time, end_time, number_of_changes, startup_time, shooting_mode, number_of_rounds;
        public static bool is_startup_enabled, is_sound_enabled;

        private void start_btn_Click(object sender, EventArgs e)
        {
            if(end_time_tb.Text==""&&end_time_rb3.Checked) {
                MessageBox.Show("Uzupełnić czas trwania serii!");
                return;
            }
            else if (end_time_tb.Text != "" && end_time_rb3.Checked)
            {
                end_time_text = end_time_tb.Text;
                try
                {
                    end_time = int.Parse(end_time_text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Czas trwania serii ma być liczbą całkowitą.");
                    end_time_tb.Text = "";
                    return;
                }
            }

            if (change_time_tb.Text == "" && change_time_rb2.Checked)
            {
                MessageBox.Show("Uzupełnić czas trwania zmiany na linii strzelań!");
                return;
            }
            else if (change_time_tb.Text != "" && change_time_rb2.Checked)
            {
                change_time_text = change_time_tb.Text;
                try
                {
                    change_time = int.Parse(change_time_text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Czas trwania zmiany na linii strzelań ma być liczbą całkowitą.");
                    change_time_tb.Text = "";
                    return;
                }
            }

            if (start_up_time_tb.Text == "" && startup_timer_enable_checkbox.Checked)
            {
                MessageBox.Show("Uzupełnić czas trwania serii!");
                return;
            }
            else if (start_up_time_tb.Text != "" && startup_timer_enable_checkbox.Checked)
            {
                startup_time_text = start_up_time_tb.Text;
                try
                {
                    startup_time = int.Parse(startup_time_text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Czas startowy musi być liczbą całkowitą.");
                    start_up_time_tb.Text = "";
                    return;
                }
            }

            if (number_of_rounds_tb.Text == "")
            {
                MessageBox.Show("Wpisać ilość serii.");
                return;
            }
            else if (number_of_rounds_tb.Text != "")
            {
                number_of_rounds_text = number_of_rounds_tb.Text;
                try
                {
                    number_of_rounds = int.Parse(number_of_rounds_text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ilość rund musi być liczbą całkowitą.");
                    number_of_rounds_tb.Text = "";
                    return;
                }
            }

            if (end_time_rb1.Checked) end_time = 120;
            else if (end_time_rb2.Checked) end_time = 90;

            if (change_time_rb1.Checked) 
                number_of_changes = 1;
            else if (change_time_rb2.Checked)
                number_of_changes = 2;
           
            if (startup_timer_enable_checkbox.Checked)
                is_startup_enabled = true;
            else 
                is_startup_enabled = false;

            is_sound_enabled = enable_sound_checkbox.Checked;

            if (consecutive_mode_rb.Checked)
                shooting_mode = 1;
            else
                shooting_mode = 2;


            Form f2 = new Form2();
            f2.ShowDialog();

        }

        private void change_time_rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (change_time_rb1.Checked)
                change_time_tb.Enabled = false;
        }
        private void change_time_rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (change_time_rb2.Checked)
                change_time_tb.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void startup_timer_enable_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (startup_timer_enable_checkbox.Checked)
                start_up_time_tb.Enabled = true;
            else
                start_up_time_tb.Enabled = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.strzala.info/");
        }
        private void end_time_rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (end_time_rb1.Checked)
                end_time_tb.Enabled = false;
        }
        private void end_time_rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (end_time_rb2.Checked)
                end_time_tb.Enabled = false;
        }
        private void end_time_rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (end_time_rb3.Checked)
                end_time_tb.Enabled = true;
        }

    }
}
