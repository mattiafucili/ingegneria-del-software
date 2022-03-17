using Project.model;
using Project.view;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Project.presenter {


	public class DifficultyPresenter {
		private DifficultyView view;

		public DifficultyPresenter(DifficultyView view, Statistics statistics) {
			this.view = view;

			Type type = statistics.GetType();
			foreach (Control control in view.Controls)
				if (control is Label && control.Tag != null) {
					PropertyInfo property = type.GetProperty(Convert.ToString(control.Tag));
					MethodInfo getMethod = property.GetGetMethod();
					control.Text = Convert.ToString(getMethod.Invoke(statistics, null));
				}
		}

	}


}
