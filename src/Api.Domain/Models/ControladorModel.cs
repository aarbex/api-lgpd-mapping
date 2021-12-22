namespace Api.Domain.Models
{
    public class ControladorModel
    {
        private string _razaoSocial;
        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }

        private string _nomeFantasia;
        public string NomeFantasia
        {
            get { return _nomeFantasia; }
            set { _nomeFantasia = value; }
        }

        private string _cnpj;
        public string CNPJ
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        private string _telefone;
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        private string _telefoneAdicional;
        public string TelefoneAdicional
        {
            get { return _telefoneAdicional; }
            set { _telefoneAdicional = value; }
        }

        private string _cep;
        public string CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _logradouro;
        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }

        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private string _complemento;
        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

        private string _bairro;
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private string _localidade;
        public string Localidade
        {
            get { return _localidade; }
            set { _localidade = value; }
        }

        private string _uf;
        public string UF
        {
            get { return _uf; }
            set { _uf = value; }
        }
    }
}
