namespace Project.view {
	partial class ButtonView {
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
			this.btnNewClient = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNewClient
			// 
			this.btnNewClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnNewClient.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNewClient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnNewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnNewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewClient.ForeColor = System.Drawing.Color.White;
			this.btnNewClient.Location = new System.Drawing.Point(0, 0);
			this.btnNewClient.Name = "btnNewClient";
			this.btnNewClient.Size = new System.Drawing.Size(152, 58);
			this.btnNewClient.TabIndex = 0;
			this.btnNewClient.TabStop = false;
			this.btnNewClient.Text = "Nuovo client";
			this.btnNewClient.UseVisualStyleBackColor = false;
			// 
			// ButtonView
			// 
			this.Controls.Add(this.btnNewClient);
			this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ButtonView";
			this.Size = new System.Drawing.Size(152, 58);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNewClient;
	}
}
