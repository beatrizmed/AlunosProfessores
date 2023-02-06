namespace AlunosProfessores
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sairToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(575, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadAlunosToolStripMenuItem,
            this.cadProfessoresToolStripMenuItem,
            this.cadTurmasToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
			// 
			// cadAlunosToolStripMenuItem
			// 
			this.cadAlunosToolStripMenuItem.Name = "cadAlunosToolStripMenuItem";
			this.cadAlunosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cadAlunosToolStripMenuItem.Text = "Cad. Alunos";
			this.cadAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadAlunosToolStripMenuItem_Click);
			// 
			// cadProfessoresToolStripMenuItem
			// 
			this.cadProfessoresToolStripMenuItem.Name = "cadProfessoresToolStripMenuItem";
			this.cadProfessoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cadProfessoresToolStripMenuItem.Text = "Cad. Professores";
			this.cadProfessoresToolStripMenuItem.Click += new System.EventHandler(this.cadProfessoresToolStripMenuItem_Click);
			// 
			// cadTurmasToolStripMenuItem
			// 
			this.cadTurmasToolStripMenuItem.Name = "cadTurmasToolStripMenuItem";
			this.cadTurmasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cadTurmasToolStripMenuItem.Text = "Cad. Turmas";
			this.cadTurmasToolStripMenuItem.Click += new System.EventHandler(this.cadTurmasToolStripMenuItem_Click);
			// 
			// sairToolStripMenuItem1
			// 
			this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
			this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
			this.sairToolStripMenuItem1.Text = "Sair";
			this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(575, 420);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Cadastro";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadAlunosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadProfessoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadTurmasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
	}
}

