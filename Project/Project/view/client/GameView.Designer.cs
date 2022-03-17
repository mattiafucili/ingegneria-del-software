namespace Project.view {
	partial class GameView {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblBonus = new System.Windows.Forms.Label();
			this.lblLastSyllable = new System.Windows.Forms.Label();
			this.lblCurrentScore = new System.Windows.Forms.Label();
			this.lblTimer = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.lblLastWord = new System.Windows.Forms.Label();
			this.lblWait = new System.Windows.Forms.Label();
			this.panelGame = new System.Windows.Forms.Panel();
			this.lblListHeader = new System.Windows.Forms.Label();
			this.gridWordsList = new System.Windows.Forms.DataGridView();
			this.lblHeaderLastSyllable = new System.Windows.Forms.Label();
			this.lblHeaderName = new System.Windows.Forms.Label();
			this.btnHelp = new System.Windows.Forms.Button();
			this.txtWord = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnGiveUp = new System.Windows.Forms.Button();
			this.panelWait = new System.Windows.Forms.Panel();
			this.lblCurrentPlayer = new System.Windows.Forms.Label();
			this.panelEnd = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.Button();
			this.lblEndState = new System.Windows.Forms.Label();
			this.lblEndScore = new System.Windows.Forms.Label();
			this.btnGiveUp2 = new System.Windows.Forms.Button();
			this.panelGame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridWordsList)).BeginInit();
			this.panelWait.SuspendLayout();
			this.panelEnd.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblBonus
			// 
			this.lblBonus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBonus.ForeColor = System.Drawing.Color.White;
			this.lblBonus.Location = new System.Drawing.Point(27, 236);
			this.lblBonus.Name = "lblBonus";
			this.lblBonus.Size = new System.Drawing.Size(309, 28);
			this.lblBonus.TabIndex = 33;
			this.lblBonus.Text = "Lettera bonus: -";
			this.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLastSyllable
			// 
			this.lblLastSyllable.BackColor = System.Drawing.Color.Transparent;
			this.lblLastSyllable.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastSyllable.ForeColor = System.Drawing.Color.White;
			this.lblLastSyllable.Location = new System.Drawing.Point(33, 155);
			this.lblLastSyllable.Name = "lblLastSyllable";
			this.lblLastSyllable.Size = new System.Drawing.Size(296, 25);
			this.lblLastSyllable.TabIndex = 32;
			this.lblLastSyllable.Text = "(ultima sillaba: -)";
			this.lblLastSyllable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCurrentScore
			// 
			this.lblCurrentScore.BackColor = System.Drawing.Color.Transparent;
			this.lblCurrentScore.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentScore.ForeColor = System.Drawing.Color.White;
			this.lblCurrentScore.Location = new System.Drawing.Point(27, 264);
			this.lblCurrentScore.Name = "lblCurrentScore";
			this.lblCurrentScore.Size = new System.Drawing.Size(309, 28);
			this.lblCurrentScore.TabIndex = 31;
			this.lblCurrentScore.Text = "Punteggio parola: 0";
			this.lblCurrentScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTimer
			// 
			this.lblTimer.BackColor = System.Drawing.Color.Transparent;
			this.lblTimer.Font = new System.Drawing.Font("Candara", 18.25F);
			this.lblTimer.ForeColor = System.Drawing.Color.White;
			this.lblTimer.Location = new System.Drawing.Point(58, 67);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(246, 44);
			this.lblTimer.TabIndex = 30;
			this.lblTimer.Text = "15";
			this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblScore
			// 
			this.lblScore.BackColor = System.Drawing.Color.Transparent;
			this.lblScore.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.ForeColor = System.Drawing.Color.White;
			this.lblScore.Location = new System.Drawing.Point(63, 362);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(236, 28);
			this.lblScore.TabIndex = 29;
			this.lblScore.Text = "Punteggio partita: 0";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblLastWord
			// 
			this.lblLastWord.BackColor = System.Drawing.Color.Transparent;
			this.lblLastWord.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastWord.ForeColor = System.Drawing.Color.White;
			this.lblLastWord.Location = new System.Drawing.Point(33, 117);
			this.lblLastWord.Name = "lblLastWord";
			this.lblLastWord.Size = new System.Drawing.Size(296, 38);
			this.lblLastWord.TabIndex = 28;
			this.lblLastWord.Text = "Ultima parola: -";
			this.lblLastWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblWait
			// 
			this.lblWait.BackColor = System.Drawing.Color.Transparent;
			this.lblWait.Font = new System.Drawing.Font("Candara", 18.25F, System.Drawing.FontStyle.Bold);
			this.lblWait.ForeColor = System.Drawing.Color.White;
			this.lblWait.Location = new System.Drawing.Point(154, 211);
			this.lblWait.Name = "lblWait";
			this.lblWait.Size = new System.Drawing.Size(404, 62);
			this.lblWait.TabIndex = 36;
			this.lblWait.Text = "In attesa...";
			this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelGame
			// 
			this.panelGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.panelGame.Controls.Add(this.lblListHeader);
			this.panelGame.Controls.Add(this.gridWordsList);
			this.panelGame.Controls.Add(this.lblHeaderLastSyllable);
			this.panelGame.Controls.Add(this.lblHeaderName);
			this.panelGame.Controls.Add(this.btnHelp);
			this.panelGame.Controls.Add(this.txtWord);
			this.panelGame.Controls.Add(this.btnPlay);
			this.panelGame.Controls.Add(this.btnGiveUp);
			this.panelGame.Controls.Add(this.lblTimer);
			this.panelGame.Controls.Add(this.lblLastWord);
			this.panelGame.Controls.Add(this.lblBonus);
			this.panelGame.Controls.Add(this.lblScore);
			this.panelGame.Controls.Add(this.lblLastSyllable);
			this.panelGame.Controls.Add(this.lblCurrentScore);
			this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelGame.Location = new System.Drawing.Point(0, 0);
			this.panelGame.Name = "panelGame";
			this.panelGame.Size = new System.Drawing.Size(712, 415);
			this.panelGame.TabIndex = 37;
			// 
			// lblListHeader
			// 
			this.lblListHeader.BackColor = System.Drawing.Color.Transparent;
			this.lblListHeader.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblListHeader.ForeColor = System.Drawing.Color.White;
			this.lblListHeader.Location = new System.Drawing.Point(360, 67);
			this.lblListHeader.Name = "lblListHeader";
			this.lblListHeader.Size = new System.Drawing.Size(333, 25);
			this.lblListHeader.TabIndex = 50;
			this.lblListHeader.Text = "Lista delle parole utilizzate nel corso della partita";
			this.lblListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gridWordsList
			// 
			this.gridWordsList.AllowUserToAddRows = false;
			this.gridWordsList.AllowUserToDeleteRows = false;
			this.gridWordsList.AllowUserToResizeColumns = false;
			this.gridWordsList.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.gridWordsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridWordsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.gridWordsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridWordsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridWordsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridWordsList.ColumnHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridWordsList.DefaultCellStyle = dataGridViewCellStyle3;
			this.gridWordsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.gridWordsList.Location = new System.Drawing.Point(363, 130);
			this.gridWordsList.Margin = new System.Windows.Forms.Padding(4);
			this.gridWordsList.Name = "gridWordsList";
			this.gridWordsList.RowHeadersVisible = false;
			this.gridWordsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.gridWordsList.Size = new System.Drawing.Size(330, 260);
			this.gridWordsList.TabIndex = 49;
			this.gridWordsList.TabStop = false;
			// 
			// lblHeaderLastSyllable
			// 
			this.lblHeaderLastSyllable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.lblHeaderLastSyllable.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderLastSyllable.ForeColor = System.Drawing.Color.White;
			this.lblHeaderLastSyllable.Location = new System.Drawing.Point(539, 103);
			this.lblHeaderLastSyllable.Name = "lblHeaderLastSyllable";
			this.lblHeaderLastSyllable.Size = new System.Drawing.Size(132, 27);
			this.lblHeaderLastSyllable.TabIndex = 48;
			this.lblHeaderLastSyllable.Text = "Ultima sillaba";
			this.lblHeaderLastSyllable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblHeaderName
			// 
			this.lblHeaderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.lblHeaderName.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderName.ForeColor = System.Drawing.Color.White;
			this.lblHeaderName.Location = new System.Drawing.Point(363, 103);
			this.lblHeaderName.Name = "lblHeaderName";
			this.lblHeaderName.Size = new System.Drawing.Size(176, 27);
			this.lblHeaderName.TabIndex = 47;
			this.lblHeaderName.Text = "Nome";
			this.lblHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnHelp
			// 
			this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHelp.Font = new System.Drawing.Font("Candara", 14.25F);
			this.btnHelp.ForeColor = System.Drawing.Color.White;
			this.btnHelp.Location = new System.Drawing.Point(36, 305);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(135, 41);
			this.btnHelp.TabIndex = 46;
			this.btnHelp.Text = "Aiuto";
			this.btnHelp.UseVisualStyleBackColor = false;
			// 
			// txtWord
			// 
			// 
			// 
			// 
			this.txtWord.Border.BorderColor = System.Drawing.Color.Black;
			this.txtWord.Border.Class = "TextBoxBorder";
			this.txtWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtWord.Border.PaddingBottom = 5;
			this.txtWord.Border.PaddingLeft = 5;
			this.txtWord.Border.PaddingRight = 5;
			this.txtWord.Border.PaddingTop = 5;
			this.txtWord.ButtonCustom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.txtWord.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWord.Location = new System.Drawing.Point(27, 189);
			this.txtWord.Name = "txtWord";
			this.txtWord.PreventEnterBeep = true;
			this.txtWord.ShortcutsEnabled = false;
			this.txtWord.Size = new System.Drawing.Size(309, 43);
			this.txtWord.TabIndex = 45;
			this.txtWord.TabStop = false;
			// 
			// btnPlay
			// 
			this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlay.Font = new System.Drawing.Font("Candara", 14.25F);
			this.btnPlay.ForeColor = System.Drawing.Color.White;
			this.btnPlay.Location = new System.Drawing.Point(192, 305);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(135, 42);
			this.btnPlay.TabIndex = 43;
			this.btnPlay.Text = "Gioca";
			this.btnPlay.UseVisualStyleBackColor = false;
			// 
			// btnGiveUp
			// 
			this.btnGiveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnGiveUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnGiveUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnGiveUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnGiveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGiveUp.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGiveUp.ForeColor = System.Drawing.Color.White;
			this.btnGiveUp.Location = new System.Drawing.Point(604, 3);
			this.btnGiveUp.Name = "btnGiveUp";
			this.btnGiveUp.Size = new System.Drawing.Size(105, 32);
			this.btnGiveUp.TabIndex = 42;
			this.btnGiveUp.Text = "Abbandona";
			this.btnGiveUp.UseVisualStyleBackColor = false;
			// 
			// panelWait
			// 
			this.panelWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.panelWait.Controls.Add(this.btnGiveUp2);
			this.panelWait.Controls.Add(this.lblCurrentPlayer);
			this.panelWait.Controls.Add(this.lblWait);
			this.panelWait.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelWait.Location = new System.Drawing.Point(0, 0);
			this.panelWait.Name = "panelWait";
			this.panelWait.Size = new System.Drawing.Size(712, 415);
			this.panelWait.TabIndex = 38;
			// 
			// lblCurrentPlayer
			// 
			this.lblCurrentPlayer.BackColor = System.Drawing.Color.Transparent;
			this.lblCurrentPlayer.Font = new System.Drawing.Font("Candara", 18.25F, System.Drawing.FontStyle.Bold);
			this.lblCurrentPlayer.ForeColor = System.Drawing.Color.White;
			this.lblCurrentPlayer.Location = new System.Drawing.Point(154, 142);
			this.lblCurrentPlayer.Name = "lblCurrentPlayer";
			this.lblCurrentPlayer.Size = new System.Drawing.Size(404, 62);
			this.lblCurrentPlayer.TabIndex = 37;
			this.lblCurrentPlayer.Text = "Turno: -";
			this.lblCurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelEnd
			// 
			this.panelEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.panelEnd.Controls.Add(this.btnHome);
			this.panelEnd.Controls.Add(this.lblEndState);
			this.panelEnd.Controls.Add(this.lblEndScore);
			this.panelEnd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEnd.Location = new System.Drawing.Point(0, 0);
			this.panelEnd.Name = "panelEnd";
			this.panelEnd.Size = new System.Drawing.Size(712, 415);
			this.panelEnd.TabIndex = 39;
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.Color.White;
			this.btnHome.Location = new System.Drawing.Point(293, 291);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(127, 40);
			this.btnHome.TabIndex = 44;
			this.btnHome.Text = "Indietro";
			this.btnHome.UseVisualStyleBackColor = false;
			// 
			// lblEndState
			// 
			this.lblEndState.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEndState.ForeColor = System.Drawing.Color.White;
			this.lblEndState.Location = new System.Drawing.Point(158, 83);
			this.lblEndState.Name = "lblEndState";
			this.lblEndState.Size = new System.Drawing.Size(396, 88);
			this.lblEndState.TabIndex = 39;
			this.lblEndState.Text = "Stato partita";
			this.lblEndState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEndScore
			// 
			this.lblEndScore.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEndScore.ForeColor = System.Drawing.Color.White;
			this.lblEndScore.Location = new System.Drawing.Point(158, 184);
			this.lblEndScore.Name = "lblEndScore";
			this.lblEndScore.Size = new System.Drawing.Size(396, 62);
			this.lblEndScore.TabIndex = 40;
			this.lblEndScore.Text = "Punteggio finale: -";
			this.lblEndScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGiveUp2
			// 
			this.btnGiveUp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			this.btnGiveUp2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnGiveUp2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.btnGiveUp2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			this.btnGiveUp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGiveUp2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGiveUp2.ForeColor = System.Drawing.Color.White;
			this.btnGiveUp2.Location = new System.Drawing.Point(604, 3);
			this.btnGiveUp2.Name = "btnGiveUp2";
			this.btnGiveUp2.Size = new System.Drawing.Size(105, 32);
			this.btnGiveUp2.TabIndex = 43;
			this.btnGiveUp2.Text = "Abbandona";
			this.btnGiveUp2.UseVisualStyleBackColor = false;
			// 
			// GameView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelWait);
			this.Controls.Add(this.panelGame);
			this.Controls.Add(this.panelEnd);
			this.Name = "GameView";
			this.Size = new System.Drawing.Size(712, 415);
			this.panelGame.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridWordsList)).EndInit();
			this.panelWait.ResumeLayout(false);
			this.panelEnd.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblBonus;
		private System.Windows.Forms.Label lblLastSyllable;
		private System.Windows.Forms.Label lblCurrentScore;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblLastWord;
		private System.Windows.Forms.Label lblWait;
		private System.Windows.Forms.Panel panelGame;
		private System.Windows.Forms.Panel panelWait;
		private System.Windows.Forms.Panel panelEnd;
		private System.Windows.Forms.Label lblEndState;
		private System.Windows.Forms.Label lblEndScore;
		private System.Windows.Forms.Label lblCurrentPlayer;
		private System.Windows.Forms.Button btnGiveUp;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnPlay;
		private DevComponents.DotNetBar.Controls.TextBoxX txtWord;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Label lblHeaderLastSyllable;
		private System.Windows.Forms.Label lblHeaderName;
		private System.Windows.Forms.DataGridView gridWordsList;
		private System.Windows.Forms.Label lblListHeader;
		private System.Windows.Forms.Button btnGiveUp2;
	}
}
