using Project.model;
using Project.view;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.presenter {


	public class VocabularyPresenter {
		private VocabularyView view;
		private Vocabulary vocabulary;

		public VocabularyPresenter(VocabularyView view) {
			this.view = view;
			view.TxtSearch.TextChanged += TxtSearch_TextChanged;
			vocabulary = Vocabulary.GetInstance();
			RefreshGUI();
		}

		private void TxtSearch_TextChanged(object sender, EventArgs e) {
			RefreshGUI();
		}

		private void RefreshGUI() {
			IEnumerable<Word> words = GetWords();

			view.GridVocabulary.DataSource = words.ToList();
			view.GridVocabulary.Columns["Name"].Width = 238;
			view.GridVocabulary.Columns["LastSyllable"].Width = 238;

			view.LblResults.Text = "Risultati: " + words.Count();
			view.LblResults.Visible = !view.TxtSearch.Text.Equals(string.Empty);

			Vocabulary vocabulary = Vocabulary.GetInstance();
			view.LblWordCount.Text = "Numero di parole nel vocabolario: " + vocabulary.Count;
		}

		private IEnumerable<Word> GetWords() {
			string startsWith = view.TxtSearch.Text;
			return (vocabulary.Search(startsWith.Equals(string.Empty), startsWith));
		}

	}


}
