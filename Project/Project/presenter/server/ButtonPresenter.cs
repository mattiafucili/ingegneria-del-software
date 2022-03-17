using Project.view;
using System;

namespace Project.presenter {


	public class ButtonPresenter {
		
		public ButtonPresenter(ButtonView view) {
			view.ButtonNewClient.Click += Button_Click;
		}

		private void Button_Click(object sender, EventArgs e) {
			using (LoginForm loginForm = new LoginForm()) {
				LoginPresenter loginPresenter = new LoginPresenter(loginForm);
				loginForm.ShowDialog();

				string username = loginPresenter.Username;
				string password = loginPresenter.Password;

				if (username != null && password != null) {
					ClientForm clientForm = new ClientForm(username, password);
					clientForm.Show();
				}
			}
		}

	}


}
