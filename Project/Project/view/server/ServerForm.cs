using Project.model;
using Project.presenter;
using System;
using System.Windows.Forms;

namespace Project.view {


	public partial class ServerForm : Form {

		public ServerForm() {
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		public BonusView BonusView {
			get {
				return (bonusView);
			}
		}

		public ButtonView ButtonView {
			get {
				return (buttonView);
			}
		}

		public VocabularyView VocabularyView {
			get {
				return (vocabularyView);
			}
		}

	}


}
