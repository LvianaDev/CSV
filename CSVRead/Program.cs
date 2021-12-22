using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace ArtigoCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            using (var reader = new StreamReader("/Users/lucas/Desktop/CSV/Clinica.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var atendimentos = csv.GetRecords<Atendimento>();

                foreach (var atendimento in atendimentos)
                    Console.WriteLine($"Paciente: {atendimento.NomePaciente}, Clínica: {atendimento.NomeClinica}");
            }
        }
    }
}