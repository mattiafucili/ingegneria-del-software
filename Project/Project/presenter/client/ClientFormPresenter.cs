using Project.model;
using Project.view;
using System;
using System.Windows.Forms;

namespace Project.presenter {


	public class ClientFormPresenter : AbstractPresenter {
		private string password;

		private AvailableUsersPresenter availableUsersPresenter;
		private DifficultiesPresenter difficultiesPresenter;
		private GamePresenter gamePresenter;

		public ClientFormPresenter(ClientForm form, string username, string password) : base(form, username) {
			#region Preconditions
			if (password == null)
				throw (new ArgumentException("Password null!"));
			#endregion

			this.password = password;
			form.PanelNewGame.BringToFront();
		}

		private void Form_Load(object sender, EventArgs e) {
			ClientForm form = (ClientForm) View;
			availableUsersPresenter = new AvailableUsersPresenter(form.AvailableUsersView, Username, form.PanelNewGame);
			difficultiesPresenter = new DifficultiesPresenter(form.DifficultiesView, Username, form.PanelNewGame);
			gamePresenter = new GamePresenter(form.GameView, Username, form.PanelNewGame);
		}

		private void Form_FormClosing(object sender, FormClosingEventArgs e) {
			Manager manager = Manager.GetInstance();
			manager.Logout(Username, password);
			Detach();
		}

		private void ButtonStatistics_Click(object sender, EventArgs e) {
			StatisticsForm statisticsForm = new StatisticsForm(Username);
			StatisticsPresenter statisticsPresenter = new StatisticsPresenter(statisticsForm.StatisticsView, Username);
			statisticsForm.ShowDialog();
		}

		private void ButtonRanking_Click(object sender, EventArgs e) {
			RankingForm rankingForm = new RankingForm();
			RankingPresenter rankingPresenter = new RankingPresenter(rankingForm.RankingView, Username);
			rankingForm.ShowDialog();
		}

		private void BtnNewGameVsUser_Click(object sender, EventArgs e) {
			ClientForm form = (ClientForm) View;
			form.AvailableUsersView.BringToFront();
		}

		private void BtnNewGameVsComputer_Click(object sender, EventArgs e) {
			ClientForm form = (ClientForm) View;
			form.DifficultiesView.BringToFront();
		}

		protected override void DoAttach() {
			ClientForm form = (ClientForm) View;
			form.Load += Form_Load;
			form.FormClosing += Form_FormClosing;
			form.ButtonStatistics.Click += ButtonStatistics_Click;
			form.ButtonRanking.Click += ButtonRanking_Click;
			form.ButtonNewGameVsUser.Click += BtnNewGameVsUser_Click;
			form.ButtonNewGameVsComputer.Click += BtnNewGameVsComputer_Click;
		}

		protected override void DoDetach() {
			availableUsersPresenter.Detach();
			difficultiesPresenter.Detach();
			gamePresenter.Detach();

			ClientForm form = (ClientForm) View;
			form.Load -= Form_Load;
			form.FormClosing -= Form_FormClosing;
			form.ButtonStatistics.Click -= ButtonStatistics_Click;
			form.ButtonRanking.Click -= ButtonRanking_Click;
			form.ButtonNewGameVsUser.Click -= BtnNewGameVsUser_Click;
			form.ButtonNewGameVsComputer.Click -= BtnNewGameVsComputer_Click;

			Manager manager = Manager.GetInstance();
			Game game = manager.GameByUsername(Username);
			if ( game != null )
				game.GiveUp(Username);
		}

	}


}
