using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunosProfessores
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cadAlunosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Alunos addAlu = new Alunos();
			addAlu.ShowDialog();
		}


		private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cadProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Professores addProf= new Professores();
			addProf.ShowDialog();
		}

		private void cadTurmasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Turmas addTurmas = new Turmas();
			addTurmas.ShowDialog();
		}

		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
