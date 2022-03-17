namespace Project.view {
	partial class StatisticsView {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tabStatistics = new DevComponents.DotNetBar.TabControl();
			((System.ComponentModel.ISupportInitialize)(this.tabStatistics)).BeginInit();
			this.SuspendLayout();
			// 
			// tabStatistics
			// 
			this.tabStatistics.CanReorderTabs = false;
			this.tabStatistics.ColorScheme.TabBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.tabStatistics.ColorScheme.TabBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.tabStatistics.ColorScheme.TabBorder = System.Drawing.Color.Black;
			this.tabStatistics.ColorScheme.TabItemHotText = System.Drawing.Color.White;
			this.tabStatistics.ColorScheme.TabItemSelectedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.tabStatistics.ColorScheme.TabItemSelectedBackground2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.tabStatistics.ColorScheme.TabItemSelectedBorder = System.Drawing.Color.Black;
			this.tabStatistics.ColorScheme.TabItemSelectedText = System.Drawing.Color.White;
			this.tabStatistics.ColorScheme.TabItemText = System.Drawing.Color.White;
			this.tabStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabStatistics.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.tabStatistics.Location = new System.Drawing.Point(0, 0);
			this.tabStatistics.Name = "tabStatistics";
			this.tabStatistics.SelectedTabFont = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabStatistics.SelectedTabIndex = -1;
			this.tabStatistics.Size = new System.Drawing.Size(483, 253);
			this.tabStatistics.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
			this.tabStatistics.TabIndex = 52;
			this.tabStatistics.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
			this.tabStatistics.Text = "tabControl1";
			// 
			// StatisticsView
			// 
			this.Controls.Add(this.tabStatistics);
			this.Name = "StatisticsView";
			this.Size = new System.Drawing.Size(483, 253);
			((System.ComponentModel.ISupportInitialize)(this.tabStatistics)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevComponents.DotNetBar.TabControl tabStatistics;
	}
}
