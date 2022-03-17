using Project.model;
using Project.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using timers = System.Timers;

namespace Project.presenter {

	public class GamePresenter : AbstractPresenter {
		private static readonly int MAX = 15;

		private readonly Dictionary<GameState, string> statesMap;
		private Panel panelNewGame;
		private timers.Timer timer = new timers.Timer(1000);

		public GamePresenter(GameView view, string username, Panel panelNewGame) : base(view, username) {
			#region Preconditions
			if (panelNewGame == null)
				throw (new ArgumentException("Panel null!"));
			#endregion

			statesMap = new Dictionary<GameState, string>();
			statesMap.Add(GameState.WIN, "Hai vinto!");
			statesMap.Add(GameState.DEFEAT, "Hai perso!");
			statesMap.Add(GameState.DRAW, "Pareggio!");

			this.panelNewGame = panelNewGame;
		}

		private void User_GameStarted(object sender, EventArgs e) {
			GameView view = (GameView)View;
			view.BringToFront();

			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);
			game.GameChanged += Game_GameChanged;

			if (game.CurrentPlayer.Equals(Username))
				ShowGame();
			else
				ShowWait();
		}

		private void Game_GameChanged(object sender, EventArgs e) {
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);

			if (game.GetState(Username) != GameState.NOT_SET) {
				game.GameChanged -= Game_GameChanged;
				timer.Stop();
				ShowEnd();
			} else {
				if (game.CurrentPlayer.Equals(Username))
					ShowGame();
				else
					ShowWait();
			}
		}

		private void ShowEnd() {
			GameView view = (GameView)View;
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);

			string result = statesMap[game.GetState(Username)];
			view.LabelEndState.Text = result;
			view.LabelEndScore.Text = "Punteggio finale: " + Convert.ToString(game.GetScore(Username));
			view.PanelEnd.BringToFront();
		}

		private void ShowGame() {
			GameView view = (GameView)View;
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);

			view.LabelTimer.Text = Convert.ToString(MAX);
			view.LabelLastWord.Text = "Ultima parola: " + game.LastWord;
			view.LabelLastSyllable.Text = "Ultima sillaba: " + game.LastWord.LastSyllable;
			view.TextWord.Clear();
			view.LabelBonus.Text = "Lettera bonus: " + Convert.ToString(game.CharBonus);
			view.LabelScore.Text = "Punteggio partita: " + Convert.ToString(game.GetScore(Username));
			view.ButtonHelp.Enabled = game.HasHelp(Username);

			view.WordsList.DataSource = game.WordsList.ToList();

			view.WordsList.Columns["Name"].Width = 176;
			view.WordsList.Columns["LastSyllable"].Width = 131;

			view.PanelGame.BringToFront();
			timer.Start();
		}

		private void ShowWait() {
			GameView view = (GameView)View;
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);

			view.LabelCurrentPlayer.Text = "Turno: " + game.CurrentPlayer;
			view.PanelWait.BringToFront();
		}

		private void TxtWord_TextChanged(object sender, EventArgs e) {
			RefreshScore();
		}

		private void TextWord_KeyDown(object sender, KeyEventArgs e) {
			if (!char.IsLetter((char)e.KeyCode) && !(e.KeyCode == Keys.Back))
				e.SuppressKeyPress = true;
		}

		private void BtnPlay_Click(object sender, EventArgs e) {
			GameView view = (GameView)View;
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);

			timer.Stop();
			game.Play(Username, view.TextWord.Text);
		}

		private void Timer_Elapsed(object sender, timers.ElapsedEventArgs e) {
			GameView view = (GameView)View;
			int current = Convert.ToInt32(view.LabelTimer.Text);
			current = current - 1;
			view.LabelTimer.Text = Convert.ToString(current);
			if (current == 0) {
				Thread t = new Thread(Timeout);
				t.Start();
			}
		}

		private void BtnHelp_Click(object sender, EventArgs e) {
			GetHelp();
		}

		private void BtnGiveUp_Click(object sender, EventArgs e) {
			GameView view = (GameView)View;
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);

			timer.Stop();
			game.GiveUp(Username);
		}

		private void LetterFlyweight_BonusAlgorithmChanged(object sender, EventArgs e) {
			RefreshScore();
		}

		private void BtnHome_Click(object sender, EventArgs e) {
			panelNewGame.BringToFront();
		}

		private void RefreshScore() {
			GameView view = (GameView)View;
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);

			if (game != null) {
				int score = LetterFlyweight.Evaluate(view.TextWord.Text, game.CharBonus);
				view.LabelCurrentScore.Text = "Punteggio parola: " + Convert.ToString(score);
			}
		}

		private void Timeout() {
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);
			game.Play(Username, "notexists");
			timer.Stop();
		}

		private void GetHelp() {
			GameView view = (GameView)View;
			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);

			string help = game.GetHelp(Username);
			view.TextWord.Text = help;
			view.ButtonHelp.Enabled = game.HasHelp(Username);
		}

		protected override void DoAttach() {
			GameView view = (GameView)View;

			view.TextWord.TextChanged += TxtWord_TextChanged;
			view.TextWord.KeyDown += TextWord_KeyDown;
			view.ButtonPlay.Click += BtnPlay_Click;
			timer.Elapsed += Timer_Elapsed;
			view.ButtonHelp.Click += BtnHelp_Click;
			view.ButtonGiveUp.Click += BtnGiveUp_Click;
			view.ButtonGiveUp2.Click += BtnGiveUp_Click;
			LetterFlyweight.BonusAlgorithmChanged += LetterFlyweight_BonusAlgorithmChanged;
			view.ButtonHome.Click += BtnHome_Click;

			Manager manager = Manager.GetInstance();
			manager.AttachUser(Username, User_GameStarted);
		}

		protected override void DoDetach() {
			GameView view = (GameView)View;

			view.TextWord.TextChanged -= TxtWord_TextChanged;
			view.TextWord.KeyDown -= TextWord_KeyDown;
			view.ButtonPlay.Click -= BtnPlay_Click;
			timer.Elapsed -= Timer_Elapsed;
			view.ButtonHelp.Click -= BtnHelp_Click;
			view.ButtonGiveUp.Click -= BtnGiveUp_Click;
			view.ButtonGiveUp2.Click -= BtnGiveUp_Click;
			LetterFlyweight.BonusAlgorithmChanged -= LetterFlyweight_BonusAlgorithmChanged;
			view.ButtonHome.Click -= BtnHome_Click;
		}

	}


}
