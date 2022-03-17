namespace Project.view {
	partial class RankingView {
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
			this.lblHeaderScore = new System.Windows.Forms.Label();
			this.lblHeaderPosition = new System.Windows.Forms.Label();
			this.lblHeaderName = new System.Windows.Forms.Label();
			this.lblPosition = new System.Windows.Forms.Label();
			this.gridRanking = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridRanking)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHeaderScore
			// 
			this.lblHeaderScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.lblHeaderScore.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderScore.ForeColor = System.Drawing.Color.White;
			this.lblHeaderScore.Location = new System.Drawing.Point(293, 69);
			this.lblHeaderScore.Name = "lblHeaderScore";
			this.lblHeaderScore.Size = new System.Drawing.Size(186, 27);
			this.lblHeaderScore.TabIndex = 6;
			this.lblHeaderScore.Text = "Punteggio";
			this.lblHeaderScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblHeaderPosition
			// 
			this.lblHeaderPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.lblHeaderPosition.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderPosition.ForeColor = System.Drawing.Color.White;
			this.lblHeaderPosition.Location = new System.Drawing.Point(3, 69);
			this.lblHeaderPosition.Name = "lblHeaderPosition";
			this.lblHeaderPosition.Size = new System.Drawing.Size(50, 27);
			this.lblHeaderPosition.TabIndex = 5;
			this.lblHeaderPosition.Text = "#";
			this.lblHeaderPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblHeaderName
			// 
			this.lblHeaderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.lblHeaderName.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderName.ForeColor = System.Drawing.Color.White;
			this.lblHeaderName.Location = new System.Drawing.Point(53, 69);
			this.lblHeaderName.Name = "lblHeaderName";
			this.lblHeaderName.Size = new System.Drawing.Size(240, 27);
			this.lblHeaderName.TabIndex = 7;
			this.lblHeaderName.Text = "Nome";
			this.lblHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPosition
			// 
			this.lblPosition.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPosition.ForeColor = System.Drawing.Color.White;
			this.lblPosition.Location = new System.Drawing.Point(31, 21);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(439, 32);
			this.lblPosition.TabIndex = 8;
			this.lblPosition.Text = "La tua posizione: -";
			this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gridRanking
			// 
			this.gridRanking.AllowUserToAddRows = false;
			this.gridRanking.AllowUserToDeleteRows = false;
			this.gridRanking.AllowUserToResizeColumns = false;
			this.gridRanking.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.gridRanking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridRanking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.gridRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridRanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridRanking.ColumnHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridRanking.DefaultCellStyle = dataGridViewCellStyle3;
			this.gridRanking.GridColor = System.Drawing.Color.Black;
			this.gridRanking.Location = new System.Drawing.Point(3, 96);
			this.gridRanking.Margin = new System.Windows.Forms.Padding(4);
			this.gridRanking.Name = "gridRanking";
			this.gridRanking.RowHeadersVisible = false;
			this.gridRanking.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.gridRanking.Size = new System.Drawing.Size(494, 265);
			this.gridRanking.TabIndex = 50;
			this.gridRanking.TabStop = false;
			// 
			// RankingView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.lblHeaderName);
			this.Controls.Add(this.lblHeaderScore);
			this.Controls.Add(this.lblHeaderPosition);
			this.Controls.Add(this.gridRanking);
			this.Name = "RankingView";
			this.Size = new System.Drawing.Size(501, 371);
			((System.ComponentModel.ISupportInitialize)(this.gridRanking)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblHeaderScore;
		private System.Windows.Forms.Label lblHeaderPosition;
		private System.Windows.Forms.Label lblHeaderName;
		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.DataGridView gridRanking;
	}
}
