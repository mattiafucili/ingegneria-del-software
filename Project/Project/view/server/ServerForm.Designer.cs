namespace Project.view {
	partial class ServerForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.vocabularyView = new Project.view.VocabularyView();
			this.bonusView = new Project.view.BonusView();
			this.buttonView = new Project.view.ButtonView();
			this.SuspendLayout();
			// 
			// vocabularyView
			// 
			this.vocabularyView.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vocabularyView.ForeColor = System.Drawing.Color.White;
			this.vocabularyView.Location = new System.Drawing.Point(62, 125);
			this.vocabularyView.Margin = new System.Windows.Forms.Padding(4);
			this.vocabularyView.Name = "vocabularyView";
			this.vocabularyView.Size = new System.Drawing.Size(527, 355);
			this.vocabularyView.TabIndex = 4;
			// 
			// bonusView
			// 
			this.bonusView.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bonusView.ForeColor = System.Drawing.Color.White;
			this.bonusView.Location = new System.Drawing.Point(13, 13);
			this.bonusView.Margin = new System.Windows.Forms.Padding(4);
			this.bonusView.Name = "bonusView";
			this.bonusView.Size = new System.Drawing.Size(447, 96);
			this.bonusView.TabIndex = 3;
			// 
			// buttonView
			// 
			this.buttonView.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonView.Location = new System.Drawing.Point(494, 36);
			this.buttonView.Margin = new System.Windows.Forms.Padding(4);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(136, 50);
			this.buttonView.TabIndex = 5;
			// 
			// ServerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(651, 509);
			this.Controls.Add(this.buttonView);
			this.Controls.Add(this.vocabularyView);
			this.Controls.Add(this.bonusView);
			this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "ServerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "";
			this.Text = "ServerForm";
			this.ResumeLayout(false);

		}

		#endregion
		private BonusView bonusView;
		private VocabularyView vocabularyView;
		private ButtonView buttonView;
	}
}