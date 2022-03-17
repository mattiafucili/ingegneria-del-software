using System;
using System.Windows.Forms;

namespace Project.presenter {


	public abstract class AbstractPresenter {
		private readonly Control view;
		private readonly string username;

		private bool attached;

		public AbstractPresenter(Control view, string username) {
			#region Preconditions
			if (view == null)
				throw (new ArgumentException("View null!"));
			if (username == null)
				throw (new ArgumentException("Username null!"));
			#endregion

			this.view = view;
			this.username = username;

			attached = false;

			Attach();
		}

		public Control View {
			get {
				return (view);
			}
		}

		public string Username {
			get {
				return (username);
			}
		}

		public void Attach() {
			if (!attached) {
				DoAttach();
				attached = true;
			}
		}

		protected abstract void DoAttach();

		public void Detach() {
			if (attached) {
				DoDetach();
				attached = false;
			}
		}

		protected abstract void DoDetach();

	}


}
