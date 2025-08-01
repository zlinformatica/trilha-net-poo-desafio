namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        // <<<IMPLEMENTADO>>>
        // public string Numero { get; set; }
        // private string Modelo { get; set; }
        // private string IMEI { get; set; }
        // private int Memoria { get; set; }
        
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string IMEI { get; private set; }
        public int Memoria { get; private set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            // <<<IMPLEMENTADO>>>
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Realizando chamada...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}
