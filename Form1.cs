using ViaCep;

namespace ProjetoCepAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            var cep = new ViaCepClient().Search(mskCEP.Text);
            var endereco = cep.Street;
            var bairro = cep.Neighborhood;
            var cidade = cep.City;
            var estado = cep.StateInitials;

            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;

            txtEndereco.Text = endereco;
            txtBairro.Text = bairro;
            txtCidade.Text = cidade;
            txtEstado.Text = estado;


        }
        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
