namespace osu__mp3player.WinForm_Implements
{
    partial class FindingSongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindingSongForm));
            this.FindSongLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.findSongListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FindSongLabel
            // 
            this.FindSongLabel.AutoSize = true;
            this.FindSongLabel.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.FindSongLabel.Location = new System.Drawing.Point(12, 9);
            this.FindSongLabel.Name = "FindSongLabel";
            this.FindSongLabel.Size = new System.Drawing.Size(135, 35);
            this.FindSongLabel.TabIndex = 0;
            this.FindSongLabel.Text = "Find Song";
            // 
            // textTextBox
            // 
            this.textTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textTextBox.Location = new System.Drawing.Point(153, 22);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(427, 27);
            this.textTextBox.TabIndex = 1;
            this.textTextBox.TextChanged += new System.EventHandler(this.textTextBox1_TextChanged);
            // 
            // findSongListBox
            // 
            this.findSongListBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findSongListBox.FormattingEnabled = true;
            this.findSongListBox.HorizontalScrollbar = true;
            this.findSongListBox.ItemHeight = 20;
            this.findSongListBox.Location = new System.Drawing.Point(18, 47);
            this.findSongListBox.Name = "findSongListBox";
            this.findSongListBox.Size = new System.Drawing.Size(562, 204);
            this.findSongListBox.TabIndex = 2;
            this.findSongListBox.SelectedIndexChanged += new System.EventHandler(this.findSongListBox_SelectedIndexChanged);
            // 
            // FindingSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 272);
            this.Controls.Add(this.findSongListBox);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.FindSongLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FindingSongForm";
            this.Text = "Find Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FindSongLabel;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.ListBox findSongListBox;
    }
}