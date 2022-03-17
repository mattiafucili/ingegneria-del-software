using Project.model;
using Project.view;
using System.Collections.Generic;

namespace Project.presenter {


	public class RankingPresenter : AbstractPresenter {

		public RankingPresenter(RankingView view, string username) : base (view, username) {
			Manager manager = Manager.GetInstance();
			IEnumerable<User> ranking = manager.GetRanking();

			List<UtilityClass> items = new List<UtilityClass>();
			int index = 1;
			foreach (User user in ranking) {
				UtilityClass utility = new UtilityClass(index, user.Username, user.GetStatistics("None").TotalScore);
				items.Add(utility);

				if (user.Username.Equals(username))
					view.LabelPosition.Text = "La tua posizione: " + index;

				index = index + 1;
			}

			view.GridRanking.DataSource = items;
			view.GridRanking.Columns["Position"].Width = 50;
			view.GridRanking.Columns["Username"].Width = 240;
			view.GridRanking.Columns["Score"].Width = 185;
		}

		protected override void DoAttach() { }

		protected override void DoDetach() { }

		private class UtilityClass {
			private int position;
			private string username;
			private int score;

			public UtilityClass(int position, string username, int score) {
				this.position = position;
				this.username = username;
				this.score = score;
			}

			public int Position {
				get {
					return position;
				}
			}

			public string Username {
				get {
					return username;
				}
			}

			public int Score {
				get {
					return score;
				}
			}
		}

	}


}
