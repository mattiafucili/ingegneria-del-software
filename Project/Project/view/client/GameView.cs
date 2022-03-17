using System.Windows.Forms;

namespace Project.view {


	public partial class GameView : UserControl {

		public GameView() {
			InitializeComponent();
		}

		public Panel PanelGame {
			get {
				return (panelGame);
			}
		}

		public Label LabelTimer {
			get {
				return (lblTimer);
			}
		}

		public Label LabelLastWord {
			get {
				return (lblLastWord);
			}
		}

		public Label LabelLastSyllable {
			get {
				return (lblLastSyllable);
			}
		}

		public Button ButtonHelp {
			get {
				return (btnHelp);
			}
		}

		public TextBox TextWord {
			get {
				return (txtWord);
			}
		}

		public Label LabelBonus {
			get {
				return (lblBonus);
			}
		}

		public DataGridView WordsList {
			get {
				return (gridWordsList);
			}
		}

		public Label LabelCurrentScore {
			get {
				return (lblCurrentScore);
			}
		}	

		public Button ButtonPlay {
			get {
				return (btnPlay);
			}
		}

		public Label LabelScore {
			get {
				return (lblScore);
			}
		}

		public Button ButtonGiveUp {
			get {
				return (btnGiveUp);
			}
		}

		public Button ButtonGiveUp2 {
			get {
				return (btnGiveUp2);
			}
		}

		public Panel PanelWait {
			get {
				return (panelWait);
			}
		}

		public Label LabelCurrentPlayer {
			get {
				return (lblCurrentPlayer);
			}
		}

		public Label LabelWait {
			get {
				return (lblWait);
			}
		}

		public Panel PanelEnd {
			get {
				return (panelEnd);
			}
		}

		public Label LabelEndState {
			get {
				return (lblEndState);
			}
		}

		public Label LabelEndScore {
			get {
				return (lblEndScore);
			}
		}

		public Button ButtonHome {
			get {
				return (btnHome);
			}
		}

	}


}
