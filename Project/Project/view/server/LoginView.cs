using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.view {


	public partial class LoginView : UserControl {

		public LoginView() {
			InitializeComponent();
		}

		public TextBox TextUsername {
			get {
				return (txtUsername);
			}
		}

		public TextBox TextPassword {
			get {
				return (txtPassword);
			}
		}

		public Button ButtonLogin {
			get {
				return (btnLogin);
			}
		}
	}


}
