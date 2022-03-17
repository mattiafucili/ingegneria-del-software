using System.Windows.Forms;
using dev = DevComponents.DotNetBar;

namespace Project.view {
	public partial class StatisticsView : UserControl {
		public StatisticsView() {
			InitializeComponent();
		}

		public dev.TabControl TabStatistics {
			get {
				return (tabStatistics);
			}
		}
	}
}
