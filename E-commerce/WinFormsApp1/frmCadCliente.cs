using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ecommerce
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private async Task BuscarCEP()
        {
            string cep = mskCep.Text.Replace("-", "");
            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido");
                return;
            }

            HttpClient cliente = new HttpClient();
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            var resposta = await cliente.GetStringAsync(url);

            EnderecoCEP endereco = JsonConvert.DeserializeObject<EnderecoCEP>(resposta);
            if (endereco == null)
            {
                MessageBox.Show("CEP não encontrado");
                return;
            }

            txtRua.Text = endereco.Logradouro;
            txtBairro.Text = endereco.Bairro;
            txtCidade.Text = endereco.Cidade;
            cmbEstado.Text = endereco.Uf;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string senha = txtSenha.Text;
            if (senha.Length < 6)
            {
                MessageBox.Show("A senha dever ter no mínimo 6 caracteres");
                return;
            }


            Conexao conexao = new Conexao();

            using (SqlConnection con = conexao.Conectar())
            {
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    int clienteId;

                    string sqlCliente = "INSERT INTO tblcliente (nome, cpf, datanascimento, email, celular, telefone, senha) OUTPUT INSERTED.id VALUES(@nome, @cpf, @datanascimento, @email, @celular, @telefone, @senha)";

                    using (SqlCommand cmd = new SqlCommand(sqlCliente, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                        cmd.Parameters.AddWithValue("@cpf", mskCPF.Text);
                        cmd.Parameters.AddWithValue("@datanascimento", mskDtNascimento.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@celular", mskCelular.Text);
                        cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                        cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                        clienteId = (int)cmd.ExecuteScalar();
                    }

                    string sqlEndereco = ("INSERT INTO tblendereco VALUES(@cliente_id,@rua,@numero,@complemento,@bairro,@cidade,@estado,@cep,@observacoes)");

                    using (SqlCommand cmd = new SqlCommand(sqlEndereco, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@cliente_id", clienteId);
                        cmd.Parameters.AddWithValue("@rua", txtRua.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);
                        cmd.Parameters.AddWithValue("@cep", mskCep.Text);
                        cmd.Parameters.AddWithValue("@observacoes", txtObservacoes.Text);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNome.Clear();
                    mskCPF.Clear();
                    mskDtNascimento.Clear();
                    txtEmail.Clear();
                    mskCelular.Clear();
                    mskTelefone.Clear();
                    txtSenha.Clear();

                    txtRua.Clear();
                    txtNumero.Clear();
                    txtComplemento.Clear();
                    txtBairro.Clear();
                    txtCidade.Clear();
                    mskCep.Clear();
                    txtObservacoes.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void mskCep_Leave(object sender, EventArgs e)
        {
            await BuscarCEP();
        }
    }
}
