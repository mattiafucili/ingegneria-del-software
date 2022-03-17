using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Project.view {


	public partial class DifficultyView : UserControl {

		public DifficultyView() {
			InitializeComponent();
		}

		public Label LabelMaximum {
			get {
				return (lblMaximumValue);
			}
		}

		public Label LabelAverage {
			get {
				return (lblAverageValue);
			}
		}

		public Label LabelTotal {
			get {
				return (lblTotalValue);
			}
		}

		public Label LabelWin {
			get {
				return (lblWinValue);
			}
		}

		public Label LabelDefeat {
			get {
				return (lblDefeatValue);
			}
		}

		public Label LabelDraw {
			get {
				return (lblDraw);
			}
		}

	}


}
