using Project.model;
using Project.view;
using System;
using System.Windows.Forms;

namespace Project.presenter {


	public class DifficultiesPresenter : AbstractPresenter {
		private Panel panelNewGame;

		public DifficultiesPresenter(DifficultiesView view, string username, Panel panelNewGame) : base (view, username) {
			#region Preconditions
			if (panelNewGame == null)
				throw (new ArgumentException("Panel null!"));
			#endregion

			this.panelNewGame = panelNewGame;
		}

		protected override void DoAttach() {
			DifficultiesView view = (DifficultiesView) View;
			foreach (Control control in view.Controls)
				if (control is Button && control.Tag != null)
					control.Click += Click;
			view.ButtonBack.Click += ButtonBack_Click;
		}

		protected override void DoDetach() {
			DifficultiesView view = (DifficultiesView) View;
			foreach (Control control in view.Controls)
				if (control is Button && control.Tag != null)
					control.Click -= Click;
			view.ButtonBack.Click -= ButtonBack_Click;
		}

		private void ButtonBack_Click(object sender, EventArgs e) {
			panelNewGame.BringToFront();
		}

		private void Click(object sender, EventArgs e) {
			if (sender is Button) {
				Button button = (Button) sender;
				string difficulty = Convert.ToString(button.Tag);
				CreateGame(difficulty);
			}
		}

		private void CreateGame(string difficulty) {
			Manager manager = Manager.GetInstance();
			manager.NewGameUserVsComputer(Username, difficulty);
		}

	}


}
