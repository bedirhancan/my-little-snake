namespace Snake
{
	partial class Form
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			game = new PictureBox();
			scoreLabel = new Label();
			menu = new Panel();
			btn_maın = new Button();
			btn_con = new Button();
			title = new Label();
			panelMenu = new Panel();
			btn_play = new Button();
			btn_exit = new Button();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)game).BeginInit();
			menu.SuspendLayout();
			panelMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// game
			// 
			game.Location = new Point(12, 12);
			game.Name = "game";
			game.Size = new Size(500, 500);
			game.TabIndex = 0;
			game.TabStop = false;
			// 
			// scoreLabel
			// 
			scoreLabel.AutoSize = true;
			scoreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
			scoreLabel.Location = new Point(72, 94);
			scoreLabel.Name = "scoreLabel";
			scoreLabel.Size = new Size(62, 15);
			scoreLabel.TabIndex = 1;
			scoreLabel.Text = "Score : 99";
			// 
			// menu
			// 
			menu.Controls.Add(btn_maın);
			menu.Controls.Add(scoreLabel);
			menu.Controls.Add(btn_con);
			menu.Controls.Add(title);
			menu.Location = new Point(133, 137);
			menu.Name = "menu";
			menu.Size = new Size(265, 251);
			menu.TabIndex = 2;
			menu.Visible = false;
			// 
			// btn_maın
			// 
			btn_maın.BackColor = Color.IndianRed;
			btn_maın.Location = new Point(53, 157);
			btn_maın.Name = "btn_maın";
			btn_maın.Size = new Size(103, 36);
			btn_maın.TabIndex = 2;
			btn_maın.Text = "Main Menu";
			btn_maın.UseVisualStyleBackColor = false;
			btn_maın.Click += btn_maın_Click;
			// 
			// btn_con
			// 
			btn_con.BackColor = SystemColors.ActiveCaption;
			btn_con.Location = new Point(53, 114);
			btn_con.Name = "btn_con";
			btn_con.Size = new Size(103, 37);
			btn_con.TabIndex = 1;
			btn_con.Text = "Continue";
			btn_con.UseVisualStyleBackColor = false;
			btn_con.Click += btn_con_Click;
			// 
			// title
			// 
			title.AutoSize = true;
			title.Font = new Font("Segoe UI", 23.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
			title.Location = new Point(53, 52);
			title.Name = "title";
			title.Size = new Size(103, 42);
			title.TabIndex = 0;
			title.Text = "Pause";
			title.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panelMenu
			// 
			panelMenu.Controls.Add(btn_play);
			panelMenu.Controls.Add(btn_exit);
			panelMenu.Controls.Add(pictureBox1);
			panelMenu.Location = new Point(12, 12);
			panelMenu.Name = "panelMenu";
			panelMenu.Size = new Size(500, 500);
			panelMenu.TabIndex = 3;
			// 
			// btn_play
			// 
			btn_play.BackColor = SystemColors.ActiveCaption;
			btn_play.Location = new Point(341, 474);
			btn_play.Name = "btn_play";
			btn_play.Size = new Size(75, 23);
			btn_play.TabIndex = 3;
			btn_play.Text = "Play";
			btn_play.UseVisualStyleBackColor = false;
			btn_play.Click += btn_play_Click;
			// 
			// btn_exit
			// 
			btn_exit.BackColor = Color.IndianRed;
			btn_exit.Location = new Point(422, 474);
			btn_exit.Name = "btn_exit";
			btn_exit.Size = new Size(75, 23);
			btn_exit.TabIndex = 1;
			btn_exit.Text = "Exit";
			btn_exit.UseVisualStyleBackColor = false;
			btn_exit.Click += btn_exit_Click_1;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.None;
			pictureBox1.Image = Properties.Resources._a4abd977_af02_4b1e_b966_9a3cb9463ea2;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(500, 500);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// Form
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(524, 528);
			Controls.Add(panelMenu);
			Controls.Add(menu);
			Controls.Add(game);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form";
			Text = "My Little Snake";
			Load += Form1_Load;
			KeyDown += Form_KeyDown;
			((System.ComponentModel.ISupportInitialize)game).EndInit();
			menu.ResumeLayout(false);
			menu.PerformLayout();
			panelMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox game;
		private Label score;
		private Label scoreLabel;
		private Panel menu;
		private Label title;
		private Button btn_maın;
		private Button btn_con;
		private Panel panelMenu;
		private PictureBox pictureBox1;
		private Button btn_play;
		private Button btn_exit;
	}
}
