using System.Windows.Forms.VisualStyles;

namespace Dobavte_v_steam_396633146_poszhalusta
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel = new System.Windows.Forms.Panel();
            this.Friends = new System.Windows.Forms.PictureBox();
            this.checkBoxTrajectory = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.NumberOfPlanets = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Friends)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel.Location = new System.Drawing.Point(14, 14);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(544, 512);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // Friends
            // 
            this.Friends.Image = ((System.Drawing.Image)(resources.GetObject("Friends.Image")));
            this.Friends.Location = new System.Drawing.Point(568, 204);
            this.Friends.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(310, 322);
            this.Friends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Friends.TabIndex = 9;
            this.Friends.TabStop = false;
            // 
            // checkBoxTrajectory
            // 
            this.checkBoxTrajectory.AutoSize = true;
            this.checkBoxTrajectory.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxTrajectory.ForeColor = System.Drawing.Color.Black;
            this.checkBoxTrajectory.Location = new System.Drawing.Point(636, 44);
            this.checkBoxTrajectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxTrajectory.Name = "checkBoxTrajectory";
            this.checkBoxTrajectory.Size = new System.Drawing.Size(155, 20);
            this.checkBoxTrajectory.TabIndex = 2;
            this.checkBoxTrajectory.Text = "Показывать траектории";
            this.checkBoxTrajectory.UseVisualStyleBackColor = false;
            this.checkBoxTrajectory.CheckedChanged += new System.EventHandler(this.checkBoxTrajectory_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(568, 70);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(310, 27);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Создать планеты";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(568, 137);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(310, 27);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Остановить время";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.Location = new System.Drawing.Point(568, 171);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(310, 27);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Настройки планет";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(568, 104);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(310, 27);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Запустить время";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // NumberOfPlanets
            // 
            this.NumberOfPlanets.BackColor = System.Drawing.Color.Cyan;
            this.NumberOfPlanets.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfPlanets.Location = new System.Drawing.Point(568, 14);
            this.NumberOfPlanets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumberOfPlanets.Name = "NumberOfPlanets";
            this.NumberOfPlanets.Size = new System.Drawing.Size(310, 23);
            this.NumberOfPlanets.TabIndex = 7;
            this.NumberOfPlanets.Text = "2";
            this.NumberOfPlanets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 541);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.NumberOfPlanets);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.checkBoxTrajectory);
            this.Controls.Add(this.Friends);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Добавьте в стим 396633146";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Friends)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.CheckBox checkBoxTrajectory;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TextBox NumberOfPlanets;
        private System.Windows.Forms.PictureBox Friends;
    }
}