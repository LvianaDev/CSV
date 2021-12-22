using CsvHelper.Configuration;

namespace ArtigoCsv
{
    public class AtendimentoMap : ClassMap<Atendimento>
    {
        public AtendimentoMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.NomeClinica).Name("nome_clinica");
            Map(m => m.NomePaciente).Name("nome_paciente");
            Map(m => m.DataNascimento).Name("data_nascimento");
            Map(m => m.DataAtendimento).Name("data_atendimento");
            Map(m => m.Especialidade).Name("especialidade");
        }
    }
}
