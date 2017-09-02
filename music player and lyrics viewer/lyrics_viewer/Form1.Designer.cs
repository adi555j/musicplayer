namespace lyrics_viewer
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
            this.back = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.play = new System.Windows.Forms.Button();
            this.Choosepath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(272, 248);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(119, 51);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(254, 153);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(72, 68);
            this.pause.TabIndex = 2;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_play_Click);
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(272, 77);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(119, 51);
            this.forward.TabIndex = 3;
            this.forward.Text = "forward";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 340);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // play
            // 
            this.play.AccessibleName = "play";
            this.play.Location = new System.Drawing.Point(332, 153);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(72, 68);
            this.play.TabIndex = 6;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // Choosepath
            // 
            this.Choosepath.Location = new System.Drawing.Point(254, 362);
            this.Choosepath.Name = "Choosepath";
            this.Choosepath.Size = new System.Drawing.Size(150, 30);
            this.Choosepath.TabIndex = 8;
            this.Choosepath.Text = "Choose path";
            this.Choosepath.UseVisualStyleBackColor = true;
            this.Choosepath.Click += new System.EventHandler(this.button2_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(416, 404);
            this.Controls.Add(this.Choosepath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.back);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button Choosepath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

