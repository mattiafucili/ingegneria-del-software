using DevComponents.DotNetBar;
using Project.model;
using Project.view;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project.presenter {


	public class StatisticsPresenter : AbstractPresenter {

		public StatisticsPresenter(StatisticsView view, string username) : base(view, username) {
			Manager manager = Manager.GetInstance();
			IEnumerable<Statistics> statisticsList = manager.StatisticsByUsername(Username);

			foreach (Statistics statistics in statisticsList) {
				Difficulty difficulty = DifficultyFlyweight.GetDifficulty(statistics.Difficulty);
				string tabText = difficulty.DisplayName;
				TabItem tabPage = new TabItem();
				tabPage.Text = tabText;
				TabControlPanel panel = new TabControlPanel();
				panel.Style.BackColor1.Alpha = 255;
				panel.Style.BackColor1.Color = Color.FromArgb(0, 150, 255);
				panel.Style.BackColor2.Alpha = 255;
				panel.Style.BackColor2.Color = Color.FromArgb(0, 150, 255);
				panel.Style.BorderColor.Alpha = 255;
				panel.Style.BorderColor.Color = Color.FromArgb(0, 150, 255);
				panel.Dock = DockStyle.Fill;
				DifficultyView difficultyView = new DifficultyView();
				difficultyView.Dock = DockStyle.Fill;
				DifficultyPresenter difficultyPresenter = new DifficultyPresenter(difficultyView, statistics);
				panel.Controls.Add(difficultyView);
				tabPage.AttachedControl = panel;
				view.TabStatistics.Tabs.Add(tabPage);
			}
		}

		protected override void DoAttach() { }

		protected override void DoDetach() { }

	}


}
