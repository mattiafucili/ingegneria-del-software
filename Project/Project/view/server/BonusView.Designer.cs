namespace Project.view {
	partial class BonusView {
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
			this.radioDoubler = new System.Windows.Forms.RadioButton();
			this.radioTripler = new System.Windows.Forms.RadioButton();
			this.radioSquare = new System.Windows.Forms.RadioButton();
			this.groupBonus = new System.Windows.Forms.GroupBox();
			this.groupBonus.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioDoubler
			// 
			this.radioDoubler.AutoSize = true;
			this.radioDoubler.Checked = true;
			this.radioDoubler.ForeColor = System.Drawing.Color.White;
			this.radioDoubler.Location = new System.Drawing.Point(33, 44);
			this.radioDoubler.Margin = new System.Windows.Forms.Padding(4);
			this.radioDoubler.Name = "radioDoubler";
			this.radioDoubler.Size = new System.Drawing.Size(92, 22);
			this.radioDoubler.TabIndex = 1;
			this.radioDoubler.TabStop = true;
			this.radioDoubler.Tag = "x2";
			this.radioDoubler.Text = "Raddoppia";
			this.radioDoubler.UseVisualStyleBackColor = true;
			// 
			// radioTripler
			// 
			this.radioTripler.AutoSize = true;
			this.radioTripler.ForeColor = System.Drawing.Color.White;
			this.radioTripler.Location = new System.Drawing.Point(190, 44);
			this.radioTripler.Margin = new System.Windows.Forms.Padding(4);
			this.radioTripler.Name = "radioTripler";
			this.radioTripler.Size = new System.Drawing.Size(69, 22);
			this.radioTripler.TabIndex = 2;
			this.radioTripler.Tag = "x3";
			this.radioTripler.Text = "Triplica";
			this.radioTripler.UseVisualStyleBackColor = true;
			// 
			// radioSquare
			// 
			this.radioSquare.AutoSize = true;
			this.radioSquare.ForeColor = System.Drawing.Color.White;
			this.radioSquare.Location = new System.Drawing.Point(317, 44);
			this.radioSquare.Margin = new System.Windows.Forms.Padding(4);
			this.radioSquare.Name = "radioSquare";
			this.radioSquare.Size = new System.Drawing.Size(97, 22);
			this.radioSquare.TabIndex = 3;
			this.radioSquare.Tag = "^2";
			this.radioSquare.Text = "Al quadrato";
			this.radioSquare.UseVisualStyleBackColor = true;
			// 
			// groupBonus
			// 
			this.groupBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.groupBonus.Controls.Add(this.radioSquare);
			this.groupBonus.Controls.Add(this.radioDoubler);
			this.groupBonus.Controls.Add(this.radioTripler);
			this.groupBonus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBonus.ForeColor = System.Drawing.Color.White;
			this.groupBonus.Location = new System.Drawing.Point(0, 0);
			this.groupBonus.Margin = new System.Windows.Forms.Padding(4);
			this.groupBonus.Name = "groupBonus";
			this.groupBonus.Padding = new System.Windows.Forms.Padding(4);
			this.groupBonus.Size = new System.Drawing.Size(447, 96);
			this.groupBonus.TabIndex = 0;
			this.groupBonus.TabStop = false;
			this.groupBonus.Text = " Algoritmo per il calcolo della lettera bonus ";
			// 
			// BonusView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBonus);
			this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "BonusView";
			this.Size = new System.Drawing.Size(447, 96);
			this.groupBonus.ResumeLayout(false);
			this.groupBonus.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton radioDoubler;
		private System.Windows.Forms.RadioButton radioTripler;
		private System.Windows.Forms.RadioButton radioSquare;
		private System.Windows.Forms.GroupBox groupBonus;
	}
}
