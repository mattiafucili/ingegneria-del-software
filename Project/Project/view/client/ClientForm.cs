using Project.presenter;
using System.Windows.Forms;

namespace Project.view {
	public partial class ClientForm : Form {

		public ClientForm(string username, string password) {
			InitializeComponent();

			ClientFormPresenter clientFormPresenter = new ClientFormPresenter(this, username, password);
		}

		public Panel PanelNewGame {
			get {
				return (panelNewGame);
			}
		}

		public Button ButtonStatistics {
			get {
				return (btnStatistics);
			}
		}

		public Button ButtonRanking {
			get {
				return (btnRanking);
			}
		}

		public Button ButtonNewGameVsUser {
			get {
				return (btnNewGameVsUser);
			}
		}

		public Button ButtonNewGameVsComputer {
			get {
				return (btnNewGameVsComputer);
			}
		}

		public AvailableUsersView AvailableUsersView {
			get {
				return (availableUsersView);
			}
		}

		public DifficultiesView DifficultiesView {
			get {
				return (difficultiesView);
			}
		}

		public GameView GameView {
			get {
				return (gameView);
			}
		}
	}
}
