namespace Project.view {
	partial class StatisticsForm {
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
			this.statisticsView = new Project.view.StatisticsView();
			this.picStatistics = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picStatistics)).BeginInit();
			this.SuspendLayout();
			// 
			// statisticsView
			// 
			this.statisticsView.Location = new System.Drawing.Point(12, 108);
			this.statisticsView.Name = "statisticsView";
			this.statisticsView.Size = new System.Drawing.Size(540, 360);
			this.statisticsView.TabIndex = 0;
			// 
			// picStatistics
			// 
			this.picStatistics.BackgroundImage = global::Project.Properties.Resources.statistics;
			this.picStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picStatistics.Location = new System.Drawing.Point(79, 12);
			this.picStatistics.Name = "picStatistics";
			this.picStatistics.Size = new System.Drawing.Size(406, 90);
			this.picStatistics.TabIndex = 1;
			this.picStatistics.TabStop = false;
			// 
			// StatisticsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(564, 480);
			this.Controls.Add(this.picStatistics);
			this.Controls.Add(this.statisticsView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "StatisticsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StatisticsForm";
			((System.ComponentModel.ISupportInitialize)(this.picStatistics)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private StatisticsView statisticsView;
		private System.Windows.Forms.PictureBox picStatistics;
	}
}