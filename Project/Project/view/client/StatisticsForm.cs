using System.Windows.Forms;

namespace Project.view {


	public partial class StatisticsForm : Form {
		public StatisticsForm(string username) {
			InitializeComponent();
		}

		public StatisticsView StatisticsView {
			get {
				return (statisticsView);
			}
		}

	}


}
