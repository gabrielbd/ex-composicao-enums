using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComposicaoEnums
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }
        public override string ToString()
        {
            return "Nome: " + Nome
                + ", Data de nascimento: "
                + DataNascimento.ToString("dd/MM/yyyy")
                + ", Email:  "
                + Email;
        }
    }
}
