﻿namespace EfCore.Data.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
    }
}