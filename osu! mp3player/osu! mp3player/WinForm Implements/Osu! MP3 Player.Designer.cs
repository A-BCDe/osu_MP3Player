namespace osu__mp3player.WinForm_Implements
{
    partial class Osu__MP3_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Osu__MP3_Player));
            this.Title = new System.Windows.Forms.Label();
            this.TitleTextLabel = new System.Windows.Forms.Label();
            this.TitleTextUnicodeLabel = new System.Windows.Forms.Label();
            this.SongTrackBar = new System.Windows.Forms.TrackBar();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.FindSongButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.MuteBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SongTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(14, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(77, 35);
            this.Title.TabIndex = 0;
            this.Title.Text = "State";
            // 
            // TitleTextLabel
            // 
            this.TitleTextLabel.AutoSize = true;
            this.TitleTextLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleTextLabel.Location = new System.Drawing.Point(17, 62);
            this.TitleTextLabel.Name = "TitleTextLabel";
            this.TitleTextLabel.Size = new System.Drawing.Size(66, 20);
            this.TitleTextLabel.TabIndex = 1;
            this.TitleTextLabel.Text = "TitleText";
            // 
            // TitleTextUnicodeLabel
            // 
            this.TitleTextUnicodeLabel.AutoSize = true;
            this.TitleTextUnicodeLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TitleTextUnicodeLabel.Location = new System.Drawing.Point(17, 89);
            this.TitleTextUnicodeLabel.Name = "TitleTextUnicodeLabel";
            this.TitleTextUnicodeLabel.Size = new System.Drawing.Size(123, 20);
            this.TitleTextUnicodeLabel.TabIndex = 2;
            this.TitleTextUnicodeLabel.Text = "TitleTextUnicode";
            // 
            // SongTrackBar
            // 
            this.SongTrackBar.Location = new System.Drawing.Point(12, 120);
            this.SongTrackBar.Name = "SongTrackBar";
            this.SongTrackBar.Size = new System.Drawing.Size(742, 56);
            this.SongTrackBar.TabIndex = 3;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeLabel.Location = new System.Drawing.Point(657, 102);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(95, 20);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "00:00 / 00:00";
            // 
            // PrevButton
            // 
            this.PrevButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PrevButton.Location = new System.Drawing.Point(12, 244);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(142, 51);
            this.PrevButton.TabIndex = 5;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlayButton.Location = new System.Drawing.Point(162, 244);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(142, 51);
            this.PlayButton.TabIndex = 6;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PauseButton.Location = new System.Drawing.Point(312, 244);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(142, 51);
            this.PauseButton.TabIndex = 7;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopButton.Location = new System.Drawing.Point(462, 244);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(142, 51);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NextButton.Location = new System.Drawing.Point(612, 244);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(142, 51);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FindSongButton
            // 
            this.FindSongButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindSongButton.Location = new System.Drawing.Point(12, 302);
            this.FindSongButton.Name = "FindSongButton";
            this.FindSongButton.Size = new System.Drawing.Size(142, 51);
            this.FindSongButton.TabIndex = 10;
            this.FindSongButton.Text = "Find Song";
            this.FindSongButton.UseVisualStyleBackColor = true;
            this.FindSongButton.Click += new System.EventHandler(this.FindSongButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SettingsButton.Location = new System.Drawing.Point(162, 302);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(142, 51);
            this.SettingsButton.TabIndex = 11;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinimizeButton.Location = new System.Drawing.Point(612, 302);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(142, 51);
            this.MinimizeButton.TabIndex = 12;
            this.MinimizeButton.Text = "Minimize";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(650, 182);
            this.VolumeTrackBar.Maximum = 1000;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(104, 56);
            this.VolumeTrackBar.TabIndex = 13;
            this.VolumeTrackBar.Value = 1000;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.VolumeLabel.Location = new System.Drawing.Point(692, 156);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(62, 20);
            this.VolumeLabel.TabIndex = 14;
            this.VolumeLabel.Text = "Volume";
            // 
            // MuteBox
            // 
            this.MuteBox.AutoSize = true;
            this.MuteBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MuteBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MuteBox.Location = new System.Drawing.Point(584, 192);
            this.MuteBox.Name = "MuteBox";
            this.MuteBox.Size = new System.Drawing.Size(66, 24);
            this.MuteBox.TabIndex = 15;
            this.MuteBox.Text = "mute";
            this.MuteBox.UseVisualStyleBackColor = true;
            this.MuteBox.CheckedChanged += new System.EventHandler(this.MuteBox_CheckedChanged);
            // 
            // Osu__MP3_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 365);
            this.Controls.Add(this.MuteBox);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.FindSongButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.SongTrackBar);
            this.Controls.Add(this.TitleTextUnicodeLabel);
            this.Controls.Add(this.TitleTextLabel);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Gulim", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Osu__MP3_Player";
            this.Text = "Osu! MP3 Player";
            ((System.ComponentModel.ISupportInitialize)(this.SongTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TitleTextLabel;
        private System.Windows.Forms.Label TitleTextUnicodeLabel;
        private System.Windows.Forms.TrackBar SongTrackBar;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button FindSongButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.CheckBox MuteBox;
    }
}