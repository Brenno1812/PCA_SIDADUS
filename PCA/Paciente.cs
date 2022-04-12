namespace PCA
{
    class Paciente
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string TipoSanguinio { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string PontoReferencia { get; set; }
        public string Uf { get; set; }
        public string Naturalidade { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
        public string Alergias { get; set; }
        public string DoencasCronicas { get; set; }
        public string RemediosControlados { get; set; }

        public Paciente()
        {
        }

        public Paciente(string cpf, string nome, string tipoSanguinio, string email, string telefone, string cep, string rua, string numero, string complemento, string bairro, string pontoReferencia, string uf, string naturalidade, string estadoCivil, string sexo, string alergias, string doencasCronicas, string remediosControlados)
        {
            Cpf = cpf;
            Nome = nome;
            TipoSanguinio = tipoSanguinio;
            Email = email;
            Telefone = telefone;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            PontoReferencia = pontoReferencia;
            Uf = uf;
            Naturalidade = naturalidade;
            EstadoCivil = estadoCivil;
            Sexo = sexo;
            Alergias = alergias;
            DoencasCronicas = doencasCronicas;
            RemediosControlados = remediosControlados;
        }
    }
}
