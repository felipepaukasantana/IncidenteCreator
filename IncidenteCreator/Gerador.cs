using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;

namespace IncidenteCreator
{
    public class Gerador
    {
        public Incidente CriarPastasIncidente(Incidente incidente)
        {
            var caminhoIncidentes = ConfigurationManager.AppSettings["caminhoGeral"].ToString();

            incidente.pasta = string.Format(@"{0} - {1}\", incidente.numero, RetornarPastaSemCaractereEspecial(incidente.resumo));
            incidente.caminho = string.Format("{0}{1}", caminhoIncidentes, incidente.pasta);
            incidente.consultas = string.Format("{0}{1}", incidente.caminho, @"Consultas\");

            System.IO.Directory.CreateDirectory(incidente.caminho);
            System.IO.Directory.CreateDirectory(incidente.consultas);

            return incidente;
        }

        private string RetornarPastaSemCaractereEspecial(string resumo)
        {
            var pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
            var replacement = string.Empty;
            var rgx = new Regex(pattern);
            return rgx.Replace(resumo, replacement); 
        }

        public void CriarTemplate(Incidente incidente)
        {
            var nomeTemplate = string.Format("{0}{1}.txt", incidente.caminho, incidente.numero);
            var stream = File.CreateText(nomeTemplate);

            stream.WriteLine(incidente.pasta);
            stream.WriteLine("---- Descrição");
            stream.WriteLine(incidente.descricao);
            stream.WriteLine();
            stream.WriteLine("---- Identificação");
            stream.WriteLine();
            stream.WriteLine("---- Solicitante");
            stream.WriteLine(incidente.solicitante);
            stream.WriteLine();
            stream.WriteLine("---- Solução");
            stream.WriteLine();
            stream.WriteLine("---- Porto SDM");

            stream.Close();
        }

        public void CriarConsultas(Incidente incidente)
        {
            var nomeTemplate = string.Format("{0}INC_{1}_SAUDE_{2}_1.sql", incidente.consultas, incidente.numero, ConfigurationManager.AppSettings["nome"].ToString());
            var stream = File.CreateText(nomeTemplate);

            stream.WriteLine("SET COLSEP ';'");
            stream.WriteLine("SET PAGESIZE 2000");
            stream.WriteLine("SET TRIMSPOOL ON");
            stream.WriteLine("SET TRIMOUT ON");
            stream.WriteLine("SET TERMOUT OFF");
            stream.WriteLine("SET WRAP OFF");
            stream.WriteLine("SET LINESIZE 10000");
            stream.WriteLine("SET NUMWIDTH 16");
            stream.WriteLine("ALTER SESSION SET CURRENT_SCHEMA = SAUDE;");

            stream.Close();
        }
    }
}
