﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using NAudio.Wave;
using System.Speech.Synthesis;
using System.Net.Http;
using System.Threading;

namespace TALES_V2
{
    public partial class Form1 : Form
    {
        private List<Data> dataList = new List<Data>();
        private string defSourceLang = "en";
        bool play, mute, language;
        int volume;

        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;
        AudioFileReader audioFileReader1;
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            Size = new Size(1260, 600);
            MinimumSize = new Size(800, 500);

            var sql = "SELECT * FROM 'Tales'";

            try
            {
                // Converts database to objects
                using (var con = new SQLiteConnection("Data Source=DATA/DataBase.db"))
                {
                    con.Open();
                    using (var com = new SQLiteCommand(sql, con))
                    {
                        using (var r = com.ExecuteReader())
                            // reads each row from database
                            while (r.Read())
                            {
                                dataList.Add(new Data(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3)));
                            }
                        com.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!play)
            {   //pause
                if (waveOutDevice != null)
                    waveOutDevice.Pause();
                btnPlay.BackgroundImage = Properties.Resources.pauseIcon;
            }
            else 
            {   //play
                if (waveOutDevice != null)
                    waveOutDevice.Play();
                btnPlay.BackgroundImage = Properties.Resources.playIcon;
            }
            play = !play;
        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            if (!mute)
            {   //mute
                if (waveOutDevice != null)
                    waveOutDevice.Volume = 0;
                btnVol.BackgroundImage = Properties.Resources.muteIcon;
            }
            else
            {   //unmute
                if (waveOutDevice != null)
                    waveOutDevice.Volume = 1;
                btnVol.BackgroundImage = Properties.Resources.volumeIcon;
            }
            mute = !mute;
        }
        private void btnLanguage_Click_1(object sender, EventArgs e)
        {
            if (!language)
            {
                lbGR_EN.Text = "GR";
                btnLanguage.BackgroundImage = Properties.Resources.grIcon;
            }
            else
            {
                lbGR_EN.Text = "EN";
                btnLanguage.BackgroundImage = Properties.Resources.enIcon;
            }
            language = !language;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            play = false;
            mute = false;
            language = false;
            volume = 60;

            // Make each Item on the table
            foreach (Data data in dataList)
            {
                Item item = new Item(data.Id, data.Title, data.Category, taleListPnl.Width);
                item.Click += new System.EventHandler(select_Click);
                taleListPnl.Controls.Add(item);
            }
        }

        private async Task<string> getTrans(string sourceLang, string targetLang, string text)
        {
            string url = "https://api.mymemory.translated.net/get";
            //string sourceLang = "en"; // Αγγλικά
            //string targetLang = "el"; // gr

            // Δημιουργία HTTP client
            using (HttpClient client = new HttpClient())
            {
                // Δημιουργία πλήρους URL με τα query parameters
                string requestUrl = $"{url}?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";

                try
                {
                    // Κλήση της API
                    HttpResponseMessage response = await client.GetAsync(requestUrl);

                    // Βεβαιώσου ότι η κλήση πέτυχε
                    response.EnsureSuccessStatusCode();

                    // Ανάγνωση του περιεχομένου της απάντησης
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Ανάλυση της JSON απάντησης και εξαγωγή της μετάφρασης
                    JObject jsonResponse = JObject.Parse(responseBody);
                    string translatedText = jsonResponse["responseData"]["translatedText"].ToString();

                    // Εμφάνιση μόνο της μετάφρασης
                    return translatedText;
                }
                catch (Exception e)
                {
                    // Διαχείριση σφαλμάτων
                    return $"Σφάλμα: {e.Message}";
                }
            }
        }

        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time <= 100)
                label1.Text = (time++).ToString() + "%";
        }

        private void select_Click(dynamic sender, EventArgs e)
        {
            foreach (Item item in taleListPnl.Controls)
                if (item != sender)
                    if (item.s)
                        item.unSel();
            if (!sender.s)
            {
                sender.sel();
                playStory(sender.Id);
            }
        }

        private async void playStory(int id)
        {
            waveOutDevice?.Dispose();
            audioFileReader?.Dispose();
            using (var synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SetOutputToWaveFile("output.wav");
                if (language)
                {
                    //synthesizer.SelectVoice("Microsoft Stefanos");
                    string text = dataList[id].History;
                    if (text.Length > 500)
                    {
                        string txt = "";
                        int l = text.Length / 500; 
                        int t = text.Length / (l + 1);

                        panel1.Visible = true;
                        timer1.Interval = 100 / (l * 2);
                        timer1.Enabled = true;
                        for (int i = 0; i <= l; i++)
                        {
                            string s = text.Substring(i * t, i == l? text.Length - (i * t): t);
                            txt += await getTrans(defSourceLang, "el", s);
                            Thread.Sleep(2000);
                        }
                        timer1.Stop();
                        time = 0;
                        panel1.Visible = false;
                        synthesizer.Speak(txt);
                    }
                    else
                    {
                        string txt = await getTrans(defSourceLang, "el", dataList[id].History);
                        Thread.Sleep(1000);
                        synthesizer.Speak(txt);
                    }

                }
                else
                    synthesizer.Speak(dataList[id].History);
            }

            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader("output.wav");
            waveOutDevice.Init(audioFileReader);

            btnPlay.BackgroundImage = Properties.Resources.playIcon;

            waveOutDevice.Play();
            play = true;
        }
    }

    class Item : FlowLayoutPanel
    {
        public bool s = false;
        public int Id;
        private Label Sid;
        private Label c;

        public Item(int id, string title, string cat, int width)
        {
            Id = id;
            BackColor = Color.Transparent;
            Width = width - 19;
            FlowDirection = FlowDirection.TopDown;

            Sid = new Label()
            {
                AutoSize = true,
                Text = id + 1 + ") " + title,
                Font = new Font("French Script MT", 17),
                ForeColor = Color.White
            };

            c = new Label()
            {
                Text = cat,
                Font = new Font("French Script MT", 10),
                ForeColor = Color.White
            };
            Controls.Add(Sid);
            Controls.Add(c);
        }

        public void sel()
        {
            s = true;
            BackColor = Color.FromArgb(80, 255, 255, 255);
            Sid.BackColor = Color.Transparent;
            c.BackColor = Color.Transparent;
        }

        public void unSel()
        {
            s = false;
            c.SendToBack();
            BackColor = Color.Transparent;
            Sid.BackColor = Color.Transparent;
            c.BackColor = Color.Transparent;
        }
    }

    class Data
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string History { get; set; }

        public Data(int id, string category, string title, string history)
        {
            Id = id;
            Category = category;
            Title = title;
            History = history;
        }
    }
}
