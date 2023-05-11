namespace Zombie_Game
{
    partial class ZombieGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZombieGame));
            this.ammoLabel = new System.Windows.Forms.Label();
            this.killsLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.NameLable = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ScoreBoardGrid = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteFromScorboardButton = new System.Windows.Forms.Button();
            this.UpdateNameButton = new System.Windows.Forms.Button();
            this.LoadAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoardGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ammoLabel
            // 
            this.ammoLabel.AutoSize = true;
            this.ammoLabel.BackColor = System.Drawing.Color.LightGray;
            this.ammoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ammoLabel.Location = new System.Drawing.Point(958, -2);
            this.ammoLabel.Name = "ammoLabel";
            this.ammoLabel.Size = new System.Drawing.Size(71, 24);
            this.ammoLabel.TabIndex = 3;
            this.ammoLabel.Text = "Ammo:";
            // 
            // killsLabel
            // 
            this.killsLabel.AutoSize = true;
            this.killsLabel.BackColor = System.Drawing.Color.LightGray;
            this.killsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.killsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.killsLabel.Location = new System.Drawing.Point(958, 21);
            this.killsLabel.Name = "killsLabel";
            this.killsLabel.Size = new System.Drawing.Size(48, 24);
            this.killsLabel.TabIndex = 4;
            this.killsLabel.Text = "Kills:";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.LightGray;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.healthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.healthLabel.Location = new System.Drawing.Point(958, 43);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(69, 24);
            this.healthLabel.TabIndex = 5;
            this.healthLabel.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.LightGray;
            this.healthBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.healthBar.Location = new System.Drawing.Point(1034, 48);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(145, 16);
            this.healthBar.TabIndex = 6;
            this.healthBar.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.Color.Transparent;
            this.playerImage.Image = global::Zombie_Game.Properties.Resources.newRight;
            this.playerImage.Location = new System.Drawing.Point(443, 338);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(50, 61);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 8;
            this.playerImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(951, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 452);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Location = new System.Drawing.Point(955, 76);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(239, 38);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start Game";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartGame);
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.BackColor = System.Drawing.Color.LightGray;
            this.NameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLable.Location = new System.Drawing.Point(959, 262);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(60, 20);
            this.NameLable.TabIndex = 11;
            this.NameLable.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(1020, 262);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(152, 20);
            this.NameTextBox.TabIndex = 12;
            this.NameTextBox.Tag = "NameTextBox";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxChange);
            // 
            // ScoreBoardGrid
            // 
            this.ScoreBoardGrid.AllowUserToAddRows = false;
            this.ScoreBoardGrid.AllowUserToDeleteRows = false;
            this.ScoreBoardGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ScoreBoardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreBoardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.PlayerScore});
            this.ScoreBoardGrid.Location = new System.Drawing.Point(951, 287);
            this.ScoreBoardGrid.Name = "ScoreBoardGrid";
            this.ScoreBoardGrid.ReadOnly = true;
            this.ScoreBoardGrid.Size = new System.Drawing.Size(244, 163);
            this.ScoreBoardGrid.TabIndex = 13;
            this.ScoreBoardGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCellClick);
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // PlayerScore
            // 
            this.PlayerScore.HeaderText = "Score";
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.ReadOnly = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Chartreuse;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(956, 124);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 31);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveScoreBoard);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(1019, 124);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(61, 31);
            this.LoadButton.TabIndex = 15;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadScoreButton);
            // 
            // DeleteFromScorboardButton
            // 
            this.DeleteFromScorboardButton.BackColor = System.Drawing.Color.Tomato;
            this.DeleteFromScorboardButton.FlatAppearance.BorderSize = 0;
            this.DeleteFromScorboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFromScorboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFromScorboardButton.Location = new System.Drawing.Point(956, 167);
            this.DeleteFromScorboardButton.Name = "DeleteFromScorboardButton";
            this.DeleteFromScorboardButton.Size = new System.Drawing.Size(239, 36);
            this.DeleteFromScorboardButton.TabIndex = 16;
            this.DeleteFromScorboardButton.Text = "Delete From ScoreBoard";
            this.DeleteFromScorboardButton.UseVisualStyleBackColor = false;
            this.DeleteFromScorboardButton.Click += new System.EventHandler(this.DeleteFromScoreboardButton);
            // 
            // UpdateNameButton
            // 
            this.UpdateNameButton.BackColor = System.Drawing.Color.Yellow;
            this.UpdateNameButton.FlatAppearance.BorderSize = 0;
            this.UpdateNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateNameButton.Location = new System.Drawing.Point(957, 214);
            this.UpdateNameButton.Name = "UpdateNameButton";
            this.UpdateNameButton.Size = new System.Drawing.Size(239, 36);
            this.UpdateNameButton.TabIndex = 17;
            this.UpdateNameButton.Text = "Update Name ScoreBoard";
            this.UpdateNameButton.UseVisualStyleBackColor = false;
            this.UpdateNameButton.Click += new System.EventHandler(this.UpdateNameB);
            // 
            // LoadAddButton
            // 
            this.LoadAddButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.LoadAddButton.FlatAppearance.BorderSize = 0;
            this.LoadAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadAddButton.Location = new System.Drawing.Point(1084, 124);
            this.LoadAddButton.Name = "LoadAddButton";
            this.LoadAddButton.Size = new System.Drawing.Size(109, 31);
            this.LoadAddButton.TabIndex = 19;
            this.LoadAddButton.Text = "Load + Add";
            this.LoadAddButton.UseVisualStyleBackColor = false;
            this.LoadAddButton.Click += new System.EventHandler(this.LoadaAndAddButton);
            // 
            // ZombieGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1194, 450);
            this.Controls.Add(this.LoadAddButton);
            this.Controls.Add(this.UpdateNameButton);
            this.Controls.Add(this.DeleteFromScorboardButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ScoreBoardGrid);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.killsLabel);
            this.Controls.Add(this.ammoLabel);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZombieGame";
            this.Text = "Zombie Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreBoardGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ammoLabel;
        private System.Windows.Forms.Label killsLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DataGridView ScoreBoardGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerScore;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button DeleteFromScorboardButton;
        private System.Windows.Forms.Button UpdateNameButton;
        private System.Windows.Forms.Button LoadAddButton;
    }
}

