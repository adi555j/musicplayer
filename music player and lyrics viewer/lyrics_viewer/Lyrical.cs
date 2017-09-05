using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Text.RegularExpressions;

namespace lyrics_viewer
{
    public partial class Lyrical : Form
    {

        //////////////////////////////////////////////////////////
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        List<string> mp3 = new List<string>();
        double time = -1;
        bool pauseflag = false;

        public bool ended = false;

        public int listSize { get; private set; }
        public string dir { get; private set; }

        public void addValues()
        {
            DirectoryInfo d = new DirectoryInfo(dir);
            FileInfo[] Files = d.GetFiles("*.mp3");
            if (Files.Count() == 0)
            {
                MessageBox.Show("Mp3 Not Found", "Aw, Snap!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<string> x = new List<string>();
            foreach (FileInfo value in Files)
            {
                listBox1.Items.Add(value.Name);
                mp3.Add(value.Name);
                listSize++;
            }
            listBox1.SelectedIndex = 0;
        }

        /////////////////////////////////////////////////////////


        public Lyrical()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ReconcilerConsoleWindow_Load(object sender,EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;
            if(listBox1.SelectedIndex >= (listSize - 1))
            {
                listBox1.SelectedIndex = 0;
            }
            else
            {
                listBox1.SelectedIndex++;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;
            if(listBox1.SelectedIndex >= 0)
            {
                listBox1.SelectedIndex--;
            }
            else
            {
                listBox1.SelectedIndex = listSize - 1;
            }          
        }

        private void pause_play_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;
             pauseflag = true;
             time = wplayer.controls.currentPosition;    
             wplayer.URL = dir + mp3[listBox1.SelectedIndex];
             textBox1.Text = wplayer.URL;
             wplayer.controls.pause();
             wplayer.controls.stop();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            wplayer.URL = dir + mp3[listBox1.SelectedIndex];
            textBox1.Text = wplayer.URL;
            wplayer.controls.stop();

            wplayer.URL = dir + mp3[listBox1.SelectedIndex];
            textBox1.Text = wplayer.URL;
            wplayer.controls.play();
            //pause_play_click_status = true;

            string af = dir + mp3[listBox1.SelectedIndex];
            var file = TagLib.File.Create(@af);
            string ly = Lyrics.Lyric(file.Tag.AlbumArtists.First(), file.Tag.Title);
            richTextBox1.Clear();
            richTextBox1.AppendText(ly);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;
            string af=dir + mp3[listBox1.SelectedIndex];
            var file = TagLib.File.Create(@af);
            string ly = Lyrics.Lyric(file.Tag.AlbumArtists.First(),file.Tag.Title);
            richTextBox1.Clear();
            richTextBox1.AppendText(ly);

            if (pauseflag == false)
            {
                wplayer.URL = dir + mp3[listBox1.SelectedIndex];
                textBox1.Text = wplayer.URL;
                wplayer.controls.play();
            }
            if (pauseflag == true)
            {
                wplayer.URL = dir + mp3[listBox1.SelectedIndex];
                textBox1.Text = wplayer.URL;
                wplayer.controls.currentPosition = time;
                wplayer.controls.play();
                pauseflag = false;
                
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                folderBrowserDialog1.ShowDialog();
                dir = folderBrowserDialog1.SelectedPath;
                if (dir[dir.Length - 1] != '\\')
                {
                    dir = dir + "\\";
                }
            }
            else
            {
                dir = textBox1.Text;
            }
            addValues();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

    }
}

   