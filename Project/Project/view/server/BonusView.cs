using System.Windows.Forms;

namespace Project.view {


	public partial class BonusView : UserControl {

		public BonusView() {
			InitializeComponent();
		}

		public RadioButton RadioDoubler {
			get {
				return (radioDoubler);
			}
		}

		public RadioButton RadioTripler {
			get {
				return (radioTripler);
			}
		}

		public RadioButton RadioSquare {
			get {
				return (radioSquare);
			}
		}

	}


}
