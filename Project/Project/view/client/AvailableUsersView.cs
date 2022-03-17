using System.Collections.Generic;
using System.Windows.Forms;
using Project.model;
using System;

namespace Project.view {


	public partial class AvailableUsersView : UserControl {

		public AvailableUsersView() {
			InitializeComponent();
		}

		public DataGridView ListAvailableUsers {
			get {
				return (listAvailableUsers);
			}
		}

		public Button ButtonStart {
			get {
				return (btnStart);
			}
		}

		public Button ButtonRandom {
			get {
				return (btnRandom);
			}
		}

		public Button ButtonBack {
			get {
				return (btnBack);
			}
		}

		public List<string> SelectedUsers {
			get {
				List<string> selectedItems = new List<string>();
				foreach (DataGridViewCell cell in listAvailableUsers.SelectedCells)
					selectedItems.Add(Convert.ToString(cell.Value));
				return (selectedItems);
			}
		}

		public List<string> GetAll {
			get {
				List<string> allItems = new List<string>();
				foreach (DataGridViewRow row in listAvailableUsers.Rows)
					allItems.Add(Convert.ToString(row.Cells[0].Value));
				return (allItems);
			}
		}

	}


}
