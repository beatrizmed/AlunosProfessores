using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunosProfessores
{
	public partial class Alunos : Form
	{
		public Alunos()
		{
			InitializeComponent();

			label7.Enabled = false;
			label10.Enabled = false;
			label4.Enabled = false;
			label5.Enabled = false;
			label2.Enabled = false;
			label6.Enabled = false;
			label1.Enabled = false;
			label9.Enabled = false;
			label3.Enabled = false;

		}

		SqlConnection sqlCon = null;
		private string strCon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AlunosProfessores;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		private string strSql = String.Empty;
		
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

			strSql = "update CadastroAlunosProfessores set Nome=@Nome, Telefone=@Telefone, Email=@Email, Endereco=@Endereco, Numero=@Numero, Bairro=@Bairro, RG=@RG, CPF=@CPF";

			sqlCon = new SqlConnection(strCon);

			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			//comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
			//comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_telefone.Text;
			//comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
			//comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
			//comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txt_numero.Text;
			//comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
			//comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txt_rg.Text;
			//comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;

			comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = label2.Text;
			comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = label3.Text;
			comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = label4.Text;
			comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = label5.Text;
			comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = label6.Text;
			comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = label7.Text;
			comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = label9.Text;
			comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = label10.Text;

			try
			{
				sqlCon.Open();

				comando.ExecuteNonQuery();

				MessageBox.Show("Cadastro alterado!");
				
			}
			catch(Exception ex) 
			{	
				MessageBox.Show(ex.Message);
			}

			finally
			{
				sqlCon.Close();
			}
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			label7.Enabled = true;
			label10.Enabled = true;
			label4.Enabled = true;
			label5.Enabled = true;
			label2.Enabled = true;
			label6.Enabled = true;
			label1.Enabled = true;
			label9.Enabled = true;
			label3.Enabled = true;
		}

		private void salvarButton2_Click(object sender, EventArgs e)
		{
			strSql = "INSERT INTO CadastroAlunosProfessores (Nome, Telefone, Email, Endereco, Numero, Bairro, RG, CPF) values(@Nome,@Telefone,@Email,@Endereco,@Numero,@Bairro,@RG,@CPF)";
			
			sqlCon = new SqlConnection(strCon);
			
			SqlCommand comando = new SqlCommand(strSql, sqlCon);
			SqlTransaction trans = null;

			//comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
			//comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_telefone.Text;
			//comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
			//comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
			//comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txt_numero.Text;
			//comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
			//comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txt_rg.Text;
			//comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;

			comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = label2.Text;
			comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = label3.Text;
			comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = label4.Text;
			comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = label5.Text;
			comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = label6.Text;
			comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = label7.Text;
			comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = label9.Text;
			comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = label10.Text;

			try
			{
				sqlCon.Open();

				trans = sqlCon.BeginTransaction();

				trans.Commit();

				comando.ExecuteNonQuery();

				MessageBox.Show("Cadastro Feito!");

				
			}

			catch (Exception ex) 
			{
				trans.Rollback();

				MessageBox.Show(ex.Message);
			}

			finally
			{ 
				sqlCon.Close(); 
			}

		
		}

		private void pesqButton3_Click(object sender, EventArgs e)
		{
			strSql = "select*from CadastroAlunosProfessores where Nome=@pesquisar";

			sqlCon = new SqlConnection(strCon);

			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			comando.Parameters.Add("@pesquisar",SqlDbType.VarChar). Value = label1.Text;

			try
			{
				if (label1.Text == string.Empty) 
				{
					MessageBox.Show("Você precisa informar um nome!");
				}

				sqlCon.Open();

				SqlDataReader dr = comando.ExecuteReader();

				if (dr.HasRows == false)
				{
					throw new Exception("Este nome não está cadastrado!");
				}

				dr.Read();

				label2.Text = Convert.ToString(dr["Nome"]);
				label3.Text = Convert.ToString(dr["Telefone"]);
				label4.Text = Convert.ToString(dr["Email"]);
				label5.Text = Convert.ToString(dr["Endereco"]);
				label6.Text = Convert.ToString(dr["Numero"]);
				label7.Text = Convert.ToString(dr["Bairro"]);
				label9.Text = Convert.ToString(dr["RG"]);
				label10.Text = Convert.ToString(dr["CPF"]);

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			finally
			{ 
				sqlCon.Close();
			}

						
		}

		private void excButton5_Click(object sender, EventArgs e)
		{
			strSql = "delete from CadastroAlunosProfessores where Nome=@Nome";

			sqlCon = new SqlConnection(strCon);

			SqlCommand comando = new SqlCommand(strSql, sqlCon);

			comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = label2.Text;

			try
			{
				sqlCon.Open();
				comando.ExecuteNonQuery();
				MessageBox.Show("Exclusão feita!");
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}

			finally
			{
				sqlCon.Close();
			}
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
