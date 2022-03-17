using System.Windows.Forms;

namespace Project.view {


	public partial class RankingForm : Form {

		public RankingForm() {
			InitializeComponent();
		}

		public RankingView RankingView {
			get {
				return (rankingView);
			}
		}

	}


}
