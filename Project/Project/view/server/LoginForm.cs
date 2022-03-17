using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.view {


	public partial class LoginForm : Form {
		public LoginForm() {
			InitializeComponent();
		}

		public LoginView LoginView {
			get {
				return (loginView);
			}
		}

	}


}
