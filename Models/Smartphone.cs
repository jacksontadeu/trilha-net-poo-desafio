using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo {  get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei,int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
       
       
        public override string ToString()
        {
            StringBuilder texto = new StringBuilder();
            texto.AppendLine($"Modelo.: {Modelo}");
            texto.AppendLine($"IMEI...: {IMEI}");
            texto.AppendLine($"Número.: {Numero}");
            texto.Append($"Memória: {Memoria}");
            return texto.ToString();
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}