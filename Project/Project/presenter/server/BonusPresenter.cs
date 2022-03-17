using Project.model;
using Project.view;
using System;
using System.Windows.Forms;

namespace Project.presenter {


	public class BonusPresenter {
		private BonusView bonusView;

		public BonusPresenter(BonusView view) {
			bonusView = view;

			bonusView.RadioDoubler.CheckedChanged += RadioBonus_CheckedChanged;
			bonusView.RadioTripler.CheckedChanged += RadioBonus_CheckedChanged;
			bonusView.RadioSquare.CheckedChanged += RadioBonus_CheckedChanged;
		}

		private void RadioBonus_CheckedChanged(object sender, EventArgs e) {
			if (sender is RadioButton) {
				RadioButton radioButton = (RadioButton) sender;
				if (radioButton.Checked) {
					string algorithmName = (string) radioButton.Tag;
					SwitchAlgorithm(algorithmName);
				}
			}
		}

		private void SwitchAlgorithm(string algorithmName) {
			LetterFlyweight.SetBonusAlgorithm(algorithmName);
		}

	}


}
