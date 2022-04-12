using System;
using System.Collections.Generic;
using System.Text;

namespace PCA
{
    class Funcionario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Sexo { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string PontoReferencia { get; set; }
        public string Uf { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string cpf, string nome, string matricula, string sexo, string cargo, string telefone, string email, string cep, string rua, string numero, string complemento, string bairro, string pontoReferencia, string uf)
        {
            Cpf = cpf;
            Nome = nome;
            Matricula = matricula;
            Sexo = sexo;
            Cargo = cargo;
            Telefone = telefone;
            Email = email;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            PontoReferencia = pontoReferencia;
            Uf = uf;
        }
    }
}
