using Project.model;
using Project.view;
using System;

namespace Project.presenter {


	public class LoginPresenter {
		private LoginForm form;

		private string username;
		private string password;

		public LoginPresenter(LoginForm form) {
			form.LoginView.ButtonLogin.Click += ButtonLogin_Click;

			this.form = form;
			username = null;
			password = null;
		}

		public string Username {
			get {
				return username;
			}
		}

		public string Password {
			get {
				return password;
			}
		}

		private void ButtonLogin_Click(object sender, EventArgs e) {
			string username = form.LoginView.TextUsername.Text;
			string password = form.LoginView.TextPassword.Text;

			bool result = Manager.GetInstance().Login(username, password);
			if (result == true) {
				this.username = username;
				this.password = password;
				form.Close();
			} else {
				System.Windows.Forms.MessageBox.Show("Login fallito!");
				form.LoginView.TextUsername.Text = string.Empty;
				form.LoginView.TextPassword.Text = string.Empty;
			}
		}

	}


}
