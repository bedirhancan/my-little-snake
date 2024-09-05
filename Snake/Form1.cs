namespace Snake
{
	public partial class Form : System.Windows.Forms.Form
	{
		public enum Direction
		{
			UP,
			DOWN,
			LEFT,
			RIGHT
		}

		public int X = 1, Y = 1;
		public int skor = 0;
		public Direction dr = Direction.RIGHT;
		public Location feed = new Location(-1, -1);
		public List<Location> tales = new List<Location>();
		public bool Game = false;

		// Thread kontrolü için
		private ManualResetEvent gamePauseEvent = new ManualResetEvent(false);
		private Thread gameThread;

		// Tek bir Random nesnesi
		private Random rnd = new Random();

		public void ResetEverything()
		{
			skor = 0; X = 1; Y = 1;
			dr = Direction.RIGHT;
			feed = new Location(-1, -1);
			tales = new List<Location>();
			tales.Add(new Location(0, 0));
		}

		public Form()
		{
			InitializeComponent();

			tales.Add(new Location(0, 0));

			CalcTable();

			gameThread = new Thread(new ThreadStart(() =>
			{
				while (true)
				{
					gamePauseEvent.WaitOne(); // Thread'i beklet

					if (dr == Direction.RIGHT) X++;
					else if (dr == Direction.DOWN) Y++;
					else if (dr == Direction.UP) Y--;
					else if (dr == Direction.LEFT) X--;

					CalcTable();
					Thread.Sleep(100);
				}
			}));

			gameThread.Start();
		}

		private void Form1_Load(object sender, EventArgs e) { }

		public void CalcTable()
		{
			try { Invoke(new Action(() => scoreLabel.Text = "Score:" + skor)); }
			catch { }

			Bitmap bmp = new Bitmap(500, 500);

			//tales coll
			if (tales.Count != 1)
			{
				for (int i = 1; i < tales.Count; i++)
				{
					if (tales[i].x == X && tales[i].y == Y)
					{
						ShowMenu(1);
					}
				}
			}

			//feed coll
			if (X == feed.x && Y == feed.y)
			{
				skor++;
				tales.Add(new Location(feed.x, feed.y));
				feed = new Location(-1, -1);
			}

			//outside coll
			if (X == 0 || Y == 0 || X == 51 || Y == 51)
			{
				ShowMenu(1);
			}
			else
			{
				//snake
				for (int i = (X - 1) * 10; i < X * 10; i++)
				{
					for (int j = (Y - 1) * 10; j < Y * 10; j++)
					{
						bmp.SetPixel(i, j, Color.Black);
					}
				}
			}

			//tales
			if (tales.Count != 1)
			{
				for (int k = 0; k < tales.Count; k++)
				{
					for (int i = (tales[k].x - 1) * 10; i < tales[k].x * 10; i++)
					{
						for (int j = (tales[k].y - 1) * 10; j < tales[k].y * 10; j++)
						{
							bmp.SetPixel(i, j, Color.Black);
						}
					}
				}
			}

			tales[0] = new Location(X, Y);
			for (int i = tales.Count - 1; i > 0; i--)
			{
				tales[i] = tales[i - 1];
			}

			//feed
			if (feed.x == -1)
			{
				feed = new Location(rnd.Next(1, 50), rnd.Next(1, 50));
			}

			for (int i = (feed.x - 1) * 10; i < feed.x * 10; i++)
			{
				for (int j = (feed.y - 1) * 10; j < feed.y * 10; j++)
				{
					bmp.SetPixel(i, j, Color.Red);
				}
			}

			game.Image = bmp;
		}

		private void Form_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.S) dr = Direction.DOWN;
			if (e.KeyCode == Keys.A) dr = Direction.LEFT;
			if (e.KeyCode == Keys.D) dr = Direction.RIGHT;
			if (e.KeyCode == Keys.W) dr = Direction.UP;

			if (e.KeyCode == Keys.Escape)
			{
				ShowMenu(0);
			}
		}

		public void ShowMenu(int status)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action<int>(ShowMenu), status);
			}
			else
			{
				if (status == 0)
				{
					title.Text = "Pause";
					btn_con.Text = "Continue";

					menu.Visible = true;
					gamePauseEvent.Reset(); // Thread'i durdur
					Game = false;
				}
				else if (status == 1)
				{
					title.Text = "Game Over";
					btn_con.Text = "Play Again";

					menu.Visible = true;
					gamePauseEvent.Reset(); // Thread'i durdur
					Game = false;
				}
			}
		}

		// made by alaska
		public class Location
		{
			public int x, y;
			public Location(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
		}

		private void btn_con_Click(object sender, EventArgs e)
		{
			string str = ((Button)sender).Text;

			menu.Visible = false;
			this.Focus();
			Game = true;
			gamePauseEvent.Set(); // Thread'i devam ettir
			if (str == "Play Again")
			{
				ResetEverything();
			}
		}

		private void btn_maýn_Click(object sender, EventArgs e)
		{
			panelMenu.Visible = true;
			menu.Visible = false;
			Game = false;
		}

		private void btn_play_Click(object sender, EventArgs e)
		{
			panelMenu.Visible = false;
			this.Focus();
			Game = true;
			gamePauseEvent.Set(); // Thread'i devam ettir
			ResetEverything();
		}

		private void btn_exit_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
