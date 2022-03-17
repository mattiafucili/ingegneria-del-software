namespace Project.view {
	partial class ClientForm {
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
			this.panelNewGame = new System.Windows.Forms.Panel();
			this.picTitle = new System.Windows.Forms.PictureBox();
			this.btnNewGameVsComputer = new System.Windows.Forms.Button();
			this.btnNewGameVsUser = new System.Windows.Forms.Button();
			this.btnRanking = new System.Windows.Forms.Button();
			this.btnStatistics = new System.Windows.Forms.Button();
			this.difficultiesView = new Project.view.DifficultiesView();
			this.availableUsersView = new Project.view.AvailableUsersView();
			this.gameView = new Project.view.GameView();
			this.panelNewGame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// panelNewGame
			// 
			this.panelNewGame.Controls.Add(this.picTitle);
			this.panelNewGame.Controls.Add(this.btnNewGameVsComputer);
			this.panelNewGame.Controls.Add(this.btnNewGameVsUser);
			this.panelNewGame.Controls.Add(this.btnRanking);
			this.panelNewGame.Controls.Add(this.btnStatistics);
			this.panelNewGame.Location = new System.Drawing.Point(13, 14);
			this.panelNewGame.Margin = new System.Windows.Forms.Padding(2);
			this.panelNewGame.Name = "panelNewGame";
			this.panelNewGame.Size = new System.Drawing.Size(712, 415);
			this.panelNewGame.TabIndex = 8;
			// 
			// picTitle
			// 
			this.picTitle.BackgroundImage = global::Project.Properties.Resources.gameName;
			this.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picTitle.Location = new System.Drawing.Point(44, 3);
			this.picTitle.Name = "picTitle";
			this.picTitle.Size = new System.Drawing.Size(624, 163);
			this.picTitle.TabIndex = 47;
			this.picTitle.TabStop = false;
			// 
			// btnNewGameVsComputer
			// 
			this.btnNewGameVsComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnNewGameVsComputer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnNewGameVsComputer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnNewGameVsComputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnNewGameVsComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewGameVsComputer.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewGameVsComputer.ForeColor = System.Drawing.Color.White;
			this.btnNewGameVsComputer.Location = new System.Drawing.Point(370, 307);
			this.btnNewGameVsComputer.Name = "btnNewGameVsComputer";
			this.btnNewGameVsComputer.Size = new System.Drawing.Size(154, 59);
			this.btnNewGameVsComputer.TabIndex = 46;
			this.btnNewGameVsComputer.Text = "Nuova partita contro il computer";
			this.btnNewGameVsComputer.UseVisualStyleBackColor = false;
			// 
			// btnNewGameVsUser
			// 
			this.btnNewGameVsUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnNewGameVsUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnNewGameVsUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnNewGameVsUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnNewGameVsUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewGameVsUser.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewGameVsUser.ForeColor = System.Drawing.Color.White;
			this.btnNewGameVsUser.Location = new System.Drawing.Point(188, 307);
			this.btnNewGameVsUser.Name = "btnNewGameVsUser";
			this.btnNewGameVsUser.Size = new System.Drawing.Size(154, 59);
			this.btnNewGameVsUser.TabIndex = 45;
			this.btnNewGameVsUser.Text = "Nuova partita contro un giocatore";
			this.btnNewGameVsUser.UseVisualStyleBackColor = false;
			// 
			// btnRanking
			// 
			this.btnRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnRanking.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnRanking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnRanking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRanking.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRanking.ForeColor = System.Drawing.Color.White;
			this.btnRanking.Location = new System.Drawing.Point(370, 188);
			this.btnRanking.Name = "btnRanking";
			this.btnRanking.Size = new System.Drawing.Size(127, 40);
			this.btnRanking.TabIndex = 44;
			this.btnRanking.Text = "CLASSIFICA";
			this.btnRanking.UseVisualStyleBackColor = false;
			// 
			// btnStatistics
			// 
			this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStatistics.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStatistics.ForeColor = System.Drawing.Color.White;
			this.btnStatistics.Location = new System.Drawing.Point(215, 188);
			this.btnStatistics.Name = "btnStatistics";
			this.btnStatistics.Size = new System.Drawing.Size(127, 40);
			this.btnStatistics.TabIndex = 43;
			this.btnStatistics.Text = "STATISTICHE";
			this.btnStatistics.UseVisualStyleBackColor = false;
			// 
			// difficultiesView
			// 
			this.difficultiesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.difficultiesView.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.difficultiesView.Location = new System.Drawing.Point(13, 14);
			this.difficultiesView.Margin = new System.Windows.Forms.Padding(4);
			this.difficultiesView.Name = "difficultiesView";
			this.difficultiesView.Size = new System.Drawing.Size(712, 415);
			this.difficultiesView.TabIndex = 1;
			// 
			// availableUsersView
			// 
			this.availableUsersView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.availableUsersView.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.availableUsersView.Location = new System.Drawing.Point(13, 14);
			this.availableUsersView.Margin = new System.Windows.Forms.Padding(4);
			this.availableUsersView.Name = "availableUsersView";
			this.availableUsersView.Size = new System.Drawing.Size(712, 415);
			this.availableUsersView.TabIndex = 0;
			// 
			// gameView
			// 
			this.gameView.Location = new System.Drawing.Point(13, 14);
			this.gameView.Name = "gameView";
			this.gameView.Size = new System.Drawing.Size(712, 415);
			this.gameView.TabIndex = 9;
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(739, 443);
			this.Controls.Add(this.panelNewGame);
			this.Controls.Add(this.difficultiesView);
			this.Controls.Add(this.availableUsersView);
			this.Controls.Add(this.gameView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ClientForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClientForm";
			this.panelNewGame.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private AvailableUsersView availableUsersView;
		private DifficultiesView difficultiesView;
		private System.Windows.Forms.Panel panelNewGame;
		private GameView gameView;
		private System.Windows.Forms.Button btnNewGameVsComputer;
		private System.Windows.Forms.Button btnNewGameVsUser;
		private System.Windows.Forms.Button btnRanking;
		private System.Windows.Forms.Button btnStatistics;
		private System.Windows.Forms.PictureBox picTitle;
	}
}