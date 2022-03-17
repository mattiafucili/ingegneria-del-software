using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Project.model {


	public static partial class LetterFlyweight {
		private static readonly Dictionary<char, Letter> alphabet;
		public static event EventHandler BonusAlgorithmChanged;

		static LetterFlyweight() {
			alphabet = new Dictionary<char, Letter>();

			string interfaceName = typeof(Letter).Name;
			BonusAlgorithm defaultAlgorithm = BonusAlgorithmStrategy.DefaultAlgorithm;

			IEnumerable<Letter> lettersList = from type in Assembly.GetExecutingAssembly().GetTypes()
											  where (type.GetInterface(interfaceName, true) != null)
											  where (type.IsClass) && (!type.IsAbstract)
											  where (type.GetConstructor(new Type[] { typeof(BonusAlgorithm) }) != null)
											  select ((Letter) Activator.CreateInstance(type, new object[] { defaultAlgorithm }));

			foreach (Letter letter in lettersList)
				alphabet.Add(letter.Character, letter);
		}

		public static IEnumerable<char> All {
			get {
				return (from letter in alphabet
						select letter.Key);
			}
		}

		public static Letter GetLetter(char character) {
			#region Prectionditions
			if (!alphabet.ContainsKey(character))
				throw (new ArgumentException("Invalid character!"));
			#endregion

			return (alphabet[character]);
		}

		public static void SetBonusAlgorithm(string name) {
			#region Prectionditions
			if (name == null)
				throw (new ArgumentException("Name algorithm null!"));
			if (!BonusAlgorithmStrategy.All.Contains(name))
				throw (new ArgumentException("Invalid algorithm name!"));
			#endregion

			BonusAlgorithm newBonusAlgorithm = BonusAlgorithmStrategy.GetAlgorithm(name);
			foreach (KeyValuePair<char, Letter> item in alphabet) {
				Letter letter = item.Value;
				letter.BonusAlgorithm = newBonusAlgorithm;
			}
			OnBonusAlgorithmChanged();
		}

		public static int Evaluate(string word, char charBonus) {
			#region Preconditions
			if (word == null)
				throw (new ArgumentException("Word null!"));
			if (!All.Contains(charBonus))
				throw (new ArgumentException("Invalid bonus char!"));
			foreach (char character in word)
				if (!All.Contains(character))
					throw (new ArgumentException("Invalid word!"));
			#endregion

			int value = 0;
			foreach (char character in word) {
				Letter letter = GetLetter(character);
				value = value + letter.GetScore(charBonus);
			}
			return (value);
		}

		private static void OnBonusAlgorithmChanged() {
			if ( BonusAlgorithmChanged != null )
				BonusAlgorithmChanged(null, EventArgs.Empty);
		}

	}


}
