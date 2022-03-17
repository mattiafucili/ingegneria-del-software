namespace Project.view {
	partial class LoginView {
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
			this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnLogin = new System.Windows.Forms.Button();
			this.groupLogin = new System.Windows.Forms.GroupBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.groupLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			// 
			// 
			// 
			this.txtUsername.Border.BorderColor = System.Drawing.Color.Black;
			this.txtUsername.Border.Class = "TextBoxBorder";
			this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtUsername.Border.PaddingBottom = 5;
			this.txtUsername.Border.PaddingLeft = 5;
			this.txtUsername.Border.PaddingRight = 5;
			this.txtUsername.Border.PaddingTop = 5;
			this.txtUsername.ButtonCustom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.txtUsername.Location = new System.Drawing.Point(135, 40);
			this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PreventEnterBeep = true;
			this.txtUsername.ShortcutsEnabled = false;
			this.txtUsername.Size = new System.Drawing.Size(231, 32);
			this.txtUsername.TabIndex = 7;
			// 
			// txtPassword
			// 
			// 
			// 
			// 
			this.txtPassword.Border.BorderColor = System.Drawing.Color.Black;
			this.txtPassword.Border.Class = "TextBoxBorder";
			this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtPassword.Border.PaddingBottom = 5;
			this.txtPassword.Border.PaddingLeft = 5;
			this.txtPassword.Border.PaddingRight = 5;
			this.txtPassword.Border.PaddingTop = 5;
			this.txtPassword.ButtonCustom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.txtPassword.Location = new System.Drawing.Point(135, 80);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '•';
			this.txtPassword.PreventEnterBeep = true;
			this.txtPassword.ShortcutsEnabled = false;
			this.txtPassword.Size = new System.Drawing.Size(231, 32);
			this.txtPassword.TabIndex = 8;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(125, 132);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(158, 46);
			this.btnLogin.TabIndex = 9;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			// 
			// groupLogin
			// 
			this.groupLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.groupLogin.Controls.Add(this.lblPassword);
			this.groupLogin.Controls.Add(this.lblUsername);
			this.groupLogin.Controls.Add(this.btnLogin);
			this.groupLogin.Controls.Add(this.txtUsername);
			this.groupLogin.Controls.Add(this.txtPassword);
			this.groupLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupLogin.ForeColor = System.Drawing.Color.White;
			this.groupLogin.Location = new System.Drawing.Point(0, 0);
			this.groupLogin.Name = "groupLogin";
			this.groupLogin.Size = new System.Drawing.Size(408, 203);
			this.groupLogin.TabIndex = 10;
			this.groupLogin.TabStop = false;
			this.groupLogin.Text = " Effettua il login ";
			// 
			// lblPassword
			// 
			this.lblPassword.Location = new System.Drawing.Point(42, 80);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(86, 32);
			this.lblPassword.TabIndex = 12;
			this.lblPassword.Text = "Password:";
			this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblUsername
			// 
			this.lblUsername.Location = new System.Drawing.Point(42, 40);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(86, 32);
			this.lblUsername.TabIndex = 11;
			this.lblUsername.Text = "Username:";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LoginView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.groupLogin);
			this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoginView";
			this.Size = new System.Drawing.Size(408, 203);
			this.groupLogin.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
		private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.GroupBox groupLogin;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUsername;
	}
}
