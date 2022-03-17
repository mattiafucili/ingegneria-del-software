using Project.model;
using Project.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project.presenter {


	public class AvailableUsersPresenter : AbstractPresenter {
		private readonly Random random;
		private readonly Panel panelNewGame;

		public AvailableUsersPresenter(AvailableUsersView view, string username, Panel panelNewGame) : base(view, username) {
			#region Preconditions
			if (panelNewGame == null)
				throw (new ArgumentException("Panel null!"));
			#endregion

			random = new Random();
			this.panelNewGame = panelNewGame;
		}

		protected override void DoAttach() {
			Manager manager = Manager.GetInstance();
			manager.AvailableUsersChanged += AvailableUsersChanged;
				
			AvailableUsersView view = (AvailableUsersView) View;
			view.ListAvailableUsers.SelectionChanged += ListAvailableUsers_SelectionChanged;
			view.ButtonStart.Click += BtnStart_Click;
			view.ButtonRandom.Click += ButtonRandom_Click;
			view.ButtonBack.Click += ButtonBack_Click;

			AvailableUsersChanged(manager, EventArgs.Empty);
			ListAvailableUsers_SelectionChanged(view.ListAvailableUsers, EventArgs.Empty);
		}

		protected override void DoDetach() {
			Manager manager = Manager.GetInstance();
			manager.AvailableUsersChanged -= AvailableUsersChanged;

			AvailableUsersView view = (AvailableUsersView) View;
			view.ListAvailableUsers.SelectionChanged -= ListAvailableUsers_SelectionChanged;
			view.ButtonStart.Click -= BtnStart_Click;
			view.ButtonRandom.Click -= ButtonRandom_Click;
			view.ButtonBack.Click -= ButtonBack_Click;
		}

		private void ButtonRandom_Click(object sender, EventArgs e) {
			AvailableUsersView view = (AvailableUsersView) View;
			List<string> allUsers = view.GetAll;

			int index = random.Next(0, allUsers.Count);
			List<string> players = new List<string>();
			players.Add(Username);
			players.Add(allUsers[index]);

			CreateGame(players);
		}

		private void BtnStart_Click(object sender, EventArgs e) {
			List<string> players = new List<string>();

			AvailableUsersView view = (AvailableUsersView) View;
			players.Add(Username);
			players.AddRange(view.SelectedUsers);

			CreateGame(players);
		}

		private void CreateGame(List<string> players) {
			Manager manager = Manager.GetInstance();
			manager.NewGameUserVsUser(players);
		}

		private void ButtonBack_Click(object sender, EventArgs e) {
			panelNewGame.BringToFront();
		}

		private void ListAvailableUsers_SelectionChanged(object sender, EventArgs e) {
			AvailableUsersView view = (AvailableUsersView) View;
			view.ButtonStart.Enabled = (view.SelectedUsers.Count != 0);
		}

		private void AvailableUsersChanged(object sender, EventArgs e) {
			AvailableUsersView view = (AvailableUsersView) View;

			Manager manager = Manager.GetInstance();
			List<Player> availablesPlayers = manager.FindAvailablePlayers().ToList();
			Player toRemove = availablesPlayers.Find(x => x.Username.Equals(Username));
			availablesPlayers.Remove(toRemove);

			view.ListAvailableUsers.DataSource = availablesPlayers;
			view.ListAvailableUsers.Columns[0].Width = 224;

			view.ButtonStart.Enabled = (view.GetAll.Count != 0);
			view.ButtonRandom.Enabled = (view.GetAll.Count != 0);
		}

	}


}
