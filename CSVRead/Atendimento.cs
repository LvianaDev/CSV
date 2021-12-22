using System;
using CsvHelper.Configuration.Attributes;

namespace ArtigoCsv
{
    public class Atendimento
    {
        [Name("id")]
        public int Id { get; set; }
        [Name("nome_clinica")]
        public string NomeClinica { get; set; }
        [Name("nome_paciente")]
        public string NomePaciente { get; set; }
        [Name("data_nascimento")]
        public DateTime DataNascimento { get; set; }
        [Name("data_atendimento")]
        public DateTime DataAtendimento { get; set; }
        [Name("especialidade")]
        public string Especialidade { get; set; }
    }
}