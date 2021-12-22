using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

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

            List<Atendimento> atendimentos;

            using (var reader = new StreamReader("Clinica.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<AtendimentoMap>();

                atendimentos = csv.GetRecords<Atendimento>().ToList();

                foreach (var atendimento in atendimentos)
                    Console.WriteLine($"Paciente: {atendimento.NomePaciente}, Clínica: {atendimento.NomeClinica}");
            }

            using (var writer = new StreamWriter("Clinica.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<AtendimentoMap>();

                csv.WriteHeader<Atendimento>();
                csv.NextRecord();

                csv.WriteRecords(atendimentos);
            }
        }
    }
}