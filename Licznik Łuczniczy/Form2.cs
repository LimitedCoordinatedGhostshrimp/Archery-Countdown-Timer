using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace Licznik_Łuczniczy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (Form1.is_startup_enabled == false)
                startup_timer.Interval = 0;

            center_labels_method();
            startup_timer.Enabled = true;
            startup_timer.Start();

        }
        void play_sound(System.Media.SoundPlayer sound, bool lever)
        {
            if (lever)
                sound.Play();
            else
                return;
        }
        void center_labels_method()
        {
            //Górna belka - Informacja o tym co się aktualnie dzieje
            state_label.Location = new Point(
                this.ClientSize.Width / 2 - state_label.Size.Width / 2,
                40
                );
            state_label.Anchor = AnchorStyles.None;
            // Główny licznik
            timer_numbers_label.Location = new Point(
                 this.ClientSize.Width / 2 - timer_numbers_label.Size.Width / 2,
                 this.ClientSize.Height / 2 - timer_numbers_label.Size.Height / 2 - 50
                 );
            timer_numbers_label.Anchor = AnchorStyles.None;

            // A i B
            change_indicator_label.Location = new Point(
                this.ClientSize.Width / 2 - change_indicator_label.Size.Width / 2,
                this.ClientSize.Height / 2 - change_indicator_label.Size.Height / 2 + 230
                );
            change_indicator_label.Anchor = AnchorStyles.None;

            // Pozycja przycisku restart
            next_round_btn.Location = new Point(
                this.ClientSize.Width / 2 - next_round_btn.Size.Width / 2,
                this.ClientSize.Height / 2 - next_round_btn.Size.Height / 2 + 350
                );
        }
        void flip_indicators_method()
        {
            if (indicators_table_index == 0)
                indicators_table_index = 1;
            else
                indicators_table_index = 0;
        }
        private void abort_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool timer_state = true;
        int timer_selector = 0;
        

        //Zmienne początkowe

        System.Media.SoundPlayer whistle_sound_1x = new System.Media.SoundPlayer(Licznik_Łuczniczy.Properties.Resources.whistle_sound);
        System.Media.SoundPlayer whistle_sound_2x = new System.Media.SoundPlayer(Licznik_Łuczniczy.Properties.Resources.whistle_sound_2x);
        System.Media.SoundPlayer whistle_sound_3x = new System.Media.SoundPlayer(Licznik_Łuczniczy.Properties.Resources.whistle_sound_3x);

        bool is_sound_enabled = Form1.is_sound_enabled;
        bool is_startup_enabled = Form1.is_startup_enabled;

        int startup_time = Form1.startup_time;
        int number_of_changes = Form1.number_of_changes; //ilość zmian na linii strzelać. 1 lub 2
        int actual_change = 1; //początkowa seria
        int change_time = Form1.change_time;
        int end_time = Form1.end_time;
        int kontrolka = 1; //służy do informowania o to w jakim miejscu serii się jest
        int number_of_rounds = Form1.number_of_rounds;

        int shooting_mode = Form1.shooting_mode;
        string[] indicators_table = new string[] { "A", "B" };
        int indicators_table_index = 0;
        //Koniec zmiennych początkowych

        private void startup_timer_Tick(object sender, EventArgs e)
        {

            if (Form1.is_startup_enabled == false)
            {
                startup_timer.Enabled = false;
                startup_timer.Stop();
                end_timer.Enabled = true;
                end_timer.Start();
            }

            //Dźwięk na początku
            if (startup_time == Form1.startup_time)
                play_sound(whistle_sound_2x, is_sound_enabled);
            if (number_of_changes > 1)
                change_indicator_label.Text = indicators_table[indicators_table_index];
            if (number_of_rounds > 1)
                state_label.Text = "Seria " + actual_change;
            this.BackColor = Color.FromArgb(255, 85, 85);
            timer_numbers_label.Text = startup_time.ToString();
            startup_time--;
            if (startup_time == -1)
            {
                startup_time = Form1.startup_time;
                startup_timer.Stop();
                startup_timer.Enabled = false;
                end_timer.Enabled = true;
                end_timer.Start();
            }
            center_labels_method();
        }

        private void end_timer_Tick(object sender, EventArgs e)
        {
            //Dźwięk i napis na górze
            if (end_time == Form1.end_time)
                play_sound(whistle_sound_1x, is_sound_enabled);
            if (number_of_rounds > 1)
                state_label.Text = "Seria " + actual_change;
            if (number_of_changes > 1)
                change_indicator_label.Text = indicators_table[indicators_table_index];

            if (end_time >30)
                this.BackColor = Color.FromArgb(105, 189, 69);
            else
                this.BackColor = Color.FromArgb(243, 168, 38);

            timer_numbers_label.Text = end_time.ToString();
            end_time--;

            if (end_time == -1)
            {
                end_timer.Enabled = false;
                end_timer.Stop();
                play_sound(whistle_sound_2x, is_sound_enabled);
                end_time = Form1.end_time;

                if (number_of_changes > 1)
                {
                    if (kontrolka == 1)
                    {
                        kontrolka = 2;
                        if (shooting_mode == 1) //Gdy strzelamy AB->AB
                        {
                            flip_indicators_method();
                        }
                        else //Gdy strzelamy AB->BA
                        {
                            flip_indicators_method();
                        }
                        
                        change_timer.Enabled = true;
                        change_timer.Start();
                    }
                    else if (kontrolka == 2)
                    {
                        //MessageBox.Show("tujestem");
                        kontrolka = 1;
                        if (shooting_mode == 1) //Gdy strzelamy AB->AB
                        {
                            flip_indicators_method();
                        }
                        else //Gdy strzelamy AB->BA
                        {
                            // Nic nie rób
                        }
                        next_round_btn.Visible = true;
                    }
                }
                else
                {

                }
            }
            center_labels_method();
        }
        private void change_timer_Tick(object sender, EventArgs e)
        {
            if(number_of_rounds>1)
            state_label.Text = "Seria " + actual_change;
            if (number_of_changes > 1)
                change_indicator_label.Text = indicators_table[indicators_table_index];
            this.BackColor = Color.FromArgb(255, 85, 85);

            timer_numbers_label.Text = change_time.ToString();
            change_time--;

            if (change_time == -1)
            {
                change_timer.Enabled = false;
                change_timer.Stop();
                change_time = Form1.change_time;

                if (number_of_changes > 1)
                {
                    end_timer.Enabled = true;
                    end_timer.Start();
                }
            }
            center_labels_method();
        }
        private void restart_btn_Click(object sender, EventArgs e) //do poprawy później
        {
            end_timer.Enabled = false;
            end_timer.Stop();
            startup_timer.Enabled = false;
            startup_timer.Stop();
            change_timer.Enabled = false;
            change_timer.Stop();

            startup_time = Form1.startup_time;
            end_time = Form1.end_time;
            change_time = Form1.change_time;
            actual_change = 1; //początkowa seria
            kontrolka = 1; //służy do informowania o to w jakim miejscu serii się jest
            number_of_rounds = Form1.number_of_rounds;
            indicators_table_index = 0;

            startup_timer.Enabled = true;
            startup_timer.Start();
            this.BackColor = Color.FromArgb(255, 85, 85);
            timer_numbers_label.Text = startup_time.ToString();
            pause_btn.PerformClick();
            center_labels_method();
            restart_btn.Enabled = false;
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            restart_btn.Enabled = true;
            if (timer_state == true)
            {

                if (startup_timer.Enabled)
                    timer_selector = 1;
                if (end_timer.Enabled)
                    timer_selector = 2;
                if (change_timer.Enabled)
                    timer_selector = 3;


                if (timer_selector == 0)
                    return;
                else
                {
                    timer_state = false;
                    pause_btn.Text = "Kontynuuj";
                    if (timer_selector == 1)
                    {
                        startup_timer.Stop();
                    }
                    else if (timer_selector == 2)
                    {
                        end_timer.Stop();
                    }
                    else
                    {
                        change_timer.Stop();
                    }
                }
            }
            else
            {
                if (timer_selector == 1)
                {
                    startup_timer.Start();
                }
                else if (timer_selector == 2)
                {
                    end_timer.Start();
                }
                else
                {
                    change_timer.Start();
                }
                timer_selector = 0;
                timer_state = true;
                pause_btn.Text = "Pauza";
            }

        }


        private void next_round_btn_Click(object sender, EventArgs e)
        {
            
            if (actual_change < number_of_rounds)
            {
                actual_change++; //pokazuje która seria
                kontrolka = 1;
                startup_timer.Enabled = true;
                startup_timer.Start();
                next_round_btn.Visible = false;
                
            }
            else
            {
                next_round_btn.Visible = false;
            }
        }

        private void finish_timer_btn_Click(object sender, EventArgs e)
        {
            if (startup_timer.Enabled)
                startup_time = 0;
            if (end_timer.Enabled)
                end_time = 0;
            if (change_timer.Enabled)
                change_time = 0;
        }
    }
}
