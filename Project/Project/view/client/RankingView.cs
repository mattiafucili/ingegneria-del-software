using System.Windows.Forms;

namespace Project.view {


	public partial class RankingView : UserControl {

		public RankingView() {
			InitializeComponent();
		}

		public Label LabelPosition {
			get {
				return (lblPosition);
			}
		}

		public DataGridView GridRanking {
			get {
				return (gridRanking);
			}
		}

	}


}
