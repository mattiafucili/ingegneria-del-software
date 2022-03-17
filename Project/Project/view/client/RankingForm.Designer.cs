namespace Project.view {
	partial class RankingForm {
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
			this.rankingView = new Project.view.RankingView();
			this.picRanking = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picRanking)).BeginInit();
			this.SuspendLayout();
			// 
			// rankingView
			// 
			this.rankingView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.rankingView.Location = new System.Drawing.Point(11, 70);
			this.rankingView.Name = "rankingView";
			this.rankingView.Size = new System.Drawing.Size(501, 371);
			this.rankingView.TabIndex = 0;
			// 
			// picRanking
			// 
			this.picRanking.BackgroundImage = global::Project.Properties.Resources.ranking;
			this.picRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picRanking.Location = new System.Drawing.Point(91, 14);
			this.picRanking.Name = "picRanking";
			this.picRanking.Size = new System.Drawing.Size(340, 50);
			this.picRanking.TabIndex = 1;
			this.picRanking.TabStop = false;
			// 
			// RankingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(523, 454);
			this.Controls.Add(this.picRanking);
			this.Controls.Add(this.rankingView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "RankingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RankingForm";
			((System.ComponentModel.ISupportInitialize)(this.picRanking)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private RankingView rankingView;
		private System.Windows.Forms.PictureBox picRanking;
	}
}