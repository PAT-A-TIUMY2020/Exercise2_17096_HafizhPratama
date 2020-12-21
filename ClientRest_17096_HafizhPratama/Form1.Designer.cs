namespace ClientRest_17096_HafizhPratama
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBoxNIM = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.textBoxProdi = new System.Windows.Forms.TextBox();
			this.textBoxAngkatan = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonJumlah = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(116, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "NIM";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(116, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(116, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Prodi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(116, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Angkatan";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(116, 228);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Total Mahasiswa";
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Location = new System.Drawing.Point(231, 228);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(16, 17);
			this.labelTotal.TabIndex = 5;
			this.labelTotal.Text = "0";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(119, 335);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(570, 150);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// textBoxNIM
			// 
			this.textBoxNIM.Location = new System.Drawing.Point(234, 39);
			this.textBoxNIM.Name = "textBoxNIM";
			this.textBoxNIM.Size = new System.Drawing.Size(320, 22);
			this.textBoxNIM.TabIndex = 7;
			// 
			// textBoxNama
			// 
			this.textBoxNama.Location = new System.Drawing.Point(234, 85);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(320, 22);
			this.textBoxNama.TabIndex = 8;
			// 
			// textBoxProdi
			// 
			this.textBoxProdi.Location = new System.Drawing.Point(234, 132);
			this.textBoxProdi.Name = "textBoxProdi";
			this.textBoxProdi.Size = new System.Drawing.Size(320, 22);
			this.textBoxProdi.TabIndex = 9;
			// 
			// textBoxAngkatan
			// 
			this.textBoxAngkatan.Location = new System.Drawing.Point(234, 177);
			this.textBoxAngkatan.Name = "textBoxAngkatan";
			this.textBoxAngkatan.Size = new System.Drawing.Size(320, 22);
			this.textBoxAngkatan.TabIndex = 10;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(614, 38);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 11;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(614, 84);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonCreate.TabIndex = 12;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(614, 131);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate.TabIndex = 13;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(614, 176);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 14;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonJumlah
			// 
			this.buttonJumlah.Location = new System.Drawing.Point(614, 222);
			this.buttonJumlah.Name = "buttonJumlah";
			this.buttonJumlah.Size = new System.Drawing.Size(75, 23);
			this.buttonJumlah.TabIndex = 15;
			this.buttonJumlah.Text = "Jumlah";
			this.buttonJumlah.UseVisualStyleBackColor = true;
			this.buttonJumlah.Click += new System.EventHandler(this.buttonJumlah_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 520);
			this.Controls.Add(this.buttonJumlah);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxAngkatan);
			this.Controls.Add(this.textBoxProdi);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.textBoxNIM);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxNIM;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.TextBox textBoxProdi;
		private System.Windows.Forms.TextBox textBoxAngkatan;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonJumlah;
	}
}

