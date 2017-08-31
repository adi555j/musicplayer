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

namespace lyrics_viewer
{
    public partial class Form1 : Form
    {

        //////////////////////////////////////////////////////////
        string dir = @"D:\musik\Music\";
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        List<string> mp3 = new List<string>();
        double time = -1;
        bool pauseflag = false;

        public int listSize { get; private set; }

        public void addValues()
        {
            DirectoryInfo d = new DirectoryInfo(dir);
            FileInfo[] Files = d.GetFiles("*.mp3");
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


        public Form1()
        {
            InitializeComponent();
            addValues();
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
            if(listBox1.SelectedIndex >= listSize)
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
            if(listBox1.SelectedIndex >= 0)
            {
                listBox1.SelectedIndex--;
            }
            else
            {
                listBox1.SelectedIndex = listSize - 1;
                textBox1.Text = listSize.ToString();
            }          
        }

        private void pause_play_Click(object sender, EventArgs e)
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}

   