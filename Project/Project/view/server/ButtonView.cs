using System.Windows.Forms;

namespace Project.view {


	public partial class ButtonView : UserControl {

		public ButtonView() {
			InitializeComponent();
		}

		public Button ButtonNewClient {
			get {
				return (btnNewClient);
			}
		}

	}


}
