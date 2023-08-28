﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CardAPI.Data.Dtos.Cliente
{
    public class CreateClienteDto
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório")]
        public string Cpf { get; set; }
    }
}