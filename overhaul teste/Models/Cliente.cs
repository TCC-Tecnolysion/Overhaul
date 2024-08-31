﻿namespace overhaul_teste.Models
{
    public class Cliente
    {
        //CRIANDO O ENCAPSULAMENTO DO OBJETO COM GET E SET
        // ARRAY
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int? Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string TipoCliente { get; set; }
        public int CepCli { get; set; }
        public int NumEnd { get; set; }
        public string CompEnd { get; set; }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

        public List<Cliente>? ListaCliente { get; set; }
    }

}
