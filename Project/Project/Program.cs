using Project.model;
using Project.presenter;
using Project.view;
using System;
using System.Windows.Forms;

namespace Project {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Init();

			ServerForm serverForm = new ServerForm();
			BonusPresenter bonusPresenter = new BonusPresenter(serverForm.BonusView);
			VocabularyPresenter vocabularyPresenter = new VocabularyPresenter(serverForm.VocabularyView);
			ButtonPresenter buttonPresenter = new ButtonPresenter(serverForm.ButtonView);

			Application.Run(serverForm);
		}

		private static void Init() {
			Vocabulary.GetInstance();

			Manager manager = Manager.GetInstance();
			for (int i = 1; i < 100; i++) {
				manager.AddUser("utente" + i, "password");
			}
		}
	}
}
