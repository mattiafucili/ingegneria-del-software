using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Project.model {


	public partial class Vocabulary {
		private static Vocabulary vocabulary = null;
		private readonly List<Word> wordsList;
		private readonly Random random;

		public event EventHandler VocabularyChanged;

		private Vocabulary() {
			wordsList = new List<Word>();
			random = new Random();
			Init();
		}

		private void Init() {
			string path = Directory.GetCurrentDirectory() + "/dizionario.txt";
			StreamReader reader = new StreamReader(path, Encoding.GetEncoding("Windows-1252"));

			string line = "";
			while ((line = reader.ReadLine()) != null) {
				string[] array = line.Split(',');
				string name = array[0];
				string lastSyllable = array[1];
				wordsList.Add(new PrivateWord(name, lastSyllable));
			}
			reader.Close();
		}

		public static Vocabulary GetInstance() {
			if ( vocabulary == null )
				vocabulary = new Vocabulary();
			return (vocabulary);
		}

		public IEnumerable<Word> All {
			get {
				return (from word in wordsList
						select word);
			}
		}

		public IEnumerable<Word> Search(bool filter, string startsWith) {
			#region Preconditions
			if (startsWith == null)
				throw (new ArgumentException("Search word null!"));
			#endregion

			return (from word in wordsList
					where (filter || word.Name.StartsWith(startsWith))
					select word);
		}

		public int Count {
			get {
				return (wordsList.Count);
			}
		}

		public bool Exists(string word) {
			#region Preconditions
			if (word == null)
				throw (new ArgumentException("Word null!"));
			#endregion

			PrivateWord dummyWord = new PrivateWord(word, "dummy");
			return (wordsList.Contains(dummyWord));
		}

		public Word WordByName(string word) {
			#region Preconditions
			if (word == null)
				throw (new ArgumentException("Word null!"));
			#endregion

			return ( wordsList.Find(x => x.Name.Equals(word)) );
		}

		public Word RandomWord() {
			int index = random.Next(0, Count);
			return (wordsList[index]);
		}

		private void OnVocabularyChanged() {
			if ( VocabularyChanged != null )
				VocabularyChanged(this, EventArgs.Empty);
		}

	}


}

