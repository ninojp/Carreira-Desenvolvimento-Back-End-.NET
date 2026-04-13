using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoClassesObjetos
{
    internal class Consulta
    {
        private bool foiReagendada;
        public string NomePaciente { get; set; }
        public string NomeMedico { get; set; }
        public DateTime DataConsulta { get; set; }
        public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
        {
            NomePaciente = nomePaciente;
            NomeMedico = nomeMedico;
            DataConsulta = dataConsulta;
            foiReagendada = false;
        }
        public void ReagendarConsulta(DateTime novaData)
        {
            DataConsulta = novaData;
            foiReagendada = true;
        }
        public void ExibirDetalhesConsulta()
        {
            Console.WriteLine("Consulta marcada com " + NomeMedico + " para o paciente " + NomePaciente + ".");
            if (foiReagendada)
            {
                Console.WriteLine("Nova data: " + DataConsulta.ToString("dd/MM/yyyy"));
            }
            else
            {
                Console.WriteLine("Data: " + DataConsulta.ToString("dd/MM/yyyy"));
            }
            Console.WriteLine();
        }
    }
}
