using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace Project.view {


	public partial class VocabularyView : UserControl {

		public VocabularyView() {
			InitializeComponent();
		}

		public Label LblWordCount {
			get {
				return (lblWordCount);
			}
		}

		public TextBox TxtSearch {
			get {
				return (txtSearch);
			}
		}

		public Label LblResults {
			get {
				return (lblResults);
			}
		}

		public DataGridView GridVocabulary {
			get {
				return (gridVocabulary);
			}
		}

	}


}
