namespace Project.view {
	partial class VocabularyView {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gridVocabulary = new System.Windows.Forms.DataGridView();
			this.groupVocabulary = new System.Windows.Forms.GroupBox();
			this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.lblResults = new System.Windows.Forms.Label();
			this.lblHeaderLastSyllable = new System.Windows.Forms.Label();
			this.lblHeaderName = new System.Windows.Forms.Label();
			this.lblWordCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridVocabulary)).BeginInit();
			this.groupVocabulary.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridVocabulary
			// 
			this.gridVocabulary.AllowUserToAddRows = false;
			this.gridVocabulary.AllowUserToDeleteRows = false;
			this.gridVocabulary.AllowUserToResizeColumns = false;
			this.gridVocabulary.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(215)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.gridVocabulary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.gridVocabulary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.gridVocabulary.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridVocabulary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridVocabulary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gridVocabulary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridVocabulary.ColumnHeadersVisible = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridVocabulary.DefaultCellStyle = dataGridViewCellStyle6;
			this.gridVocabulary.GridColor = System.Drawing.Color.Black;
			this.gridVocabulary.Location = new System.Drawing.Point(16, 125);
			this.gridVocabulary.Margin = new System.Windows.Forms.Padding(4);
			this.gridVocabulary.Name = "gridVocabulary";
			this.gridVocabulary.RowHeadersVisible = false;
			this.gridVocabulary.Size = new System.Drawing.Size(494, 211);
			this.gridVocabulary.TabIndex = 6;
			this.gridVocabulary.TabStop = false;
			// 
			// groupVocabulary
			// 
			this.groupVocabulary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.groupVocabulary.Controls.Add(this.txtSearch);
			this.groupVocabulary.Controls.Add(this.gridVocabulary);
			this.groupVocabulary.Controls.Add(this.lblResults);
			this.groupVocabulary.Controls.Add(this.lblHeaderLastSyllable);
			this.groupVocabulary.Controls.Add(this.lblHeaderName);
			this.groupVocabulary.Controls.Add(this.lblWordCount);
			this.groupVocabulary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupVocabulary.ForeColor = System.Drawing.Color.White;
			this.groupVocabulary.Location = new System.Drawing.Point(0, 0);
			this.groupVocabulary.Name = "groupVocabulary";
			this.groupVocabulary.Size = new System.Drawing.Size(527, 355);
			this.groupVocabulary.TabIndex = 0;
			this.groupVocabulary.TabStop = false;
			this.groupVocabulary.Text = " Vocabolario ";
			// 
			// txtSearch
			// 
			// 
			// 
			// 
			this.txtSearch.Border.BorderColor = System.Drawing.Color.Black;
			this.txtSearch.Border.Class = "TextBoxBorder";
			this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txtSearch.Border.PaddingBottom = 5;
			this.txtSearch.Border.PaddingLeft = 5;
			this.txtSearch.Border.PaddingRight = 5;
			this.txtSearch.Border.PaddingTop = 5;
			this.txtSearch.ButtonCustom.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
			this.txtSearch.Location = new System.Drawing.Point(16, 53);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PreventEnterBeep = true;
			this.txtSearch.ShortcutsEnabled = false;
			this.txtSearch.Size = new System.Drawing.Size(243, 32);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TabStop = false;
			// 
			// lblResults
			// 
			this.lblResults.Location = new System.Drawing.Point(265, 53);
			this.lblResults.Name = "lblResults";
			this.lblResults.Size = new System.Drawing.Size(154, 32);
			this.lblResults.TabIndex = 3;
			this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHeaderLastSyllable
			// 
			this.lblHeaderLastSyllable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.lblHeaderLastSyllable.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderLastSyllable.Location = new System.Drawing.Point(255, 98);
			this.lblHeaderLastSyllable.Name = "lblHeaderLastSyllable";
			this.lblHeaderLastSyllable.Size = new System.Drawing.Size(238, 27);
			this.lblHeaderLastSyllable.TabIndex = 5;
			this.lblHeaderLastSyllable.Text = "Ultima sillaba";
			this.lblHeaderLastSyllable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblHeaderName
			// 
			this.lblHeaderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(75)))), ((int)(((byte)(152)))));
			this.lblHeaderName.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderName.Location = new System.Drawing.Point(16, 98);
			this.lblHeaderName.Name = "lblHeaderName";
			this.lblHeaderName.Size = new System.Drawing.Size(239, 27);
			this.lblHeaderName.TabIndex = 4;
			this.lblHeaderName.Text = "Nome";
			this.lblHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblWordCount
			// 
			this.lblWordCount.Location = new System.Drawing.Point(14, 23);
			this.lblWordCount.Name = "lblWordCount";
			this.lblWordCount.Size = new System.Drawing.Size(304, 26);
			this.lblWordCount.TabIndex = 1;
			this.lblWordCount.Text = "Numero di parole nel vocabolario: -";
			this.lblWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VocabularyView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupVocabulary);
			this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "VocabularyView";
			this.Size = new System.Drawing.Size(527, 355);
			((System.ComponentModel.ISupportInitialize)(this.gridVocabulary)).EndInit();
			this.groupVocabulary.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridVocabulary;
		private System.Windows.Forms.GroupBox groupVocabulary;
		private System.Windows.Forms.Label lblWordCount;
		private System.Windows.Forms.Label lblHeaderLastSyllable;
		private System.Windows.Forms.Label lblHeaderName;
		private System.Windows.Forms.Label lblResults;
		private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
	}
}
