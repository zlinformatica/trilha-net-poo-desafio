
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // <<<IMPLEMENTADO>>>
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // <<<IMPLEMENTADO>>>
        public override void InstalarAplicativo(string nome)
        {
            bool instaladoComSucesso = false;
            do
            {
                Console.WriteLine($"Verificando memória disponível no Nokia...");

                if (64 >= Memoria)
                {
                    Console.WriteLine($"Instalando o aplicativo no Nokia...");
                    instaladoComSucesso = true;
                }
                else
                {
                    Console.WriteLine($"Erro: <<<Memória insuficiente para instalar {nome}>>> É necessário pelo menos {Memoria} MB.");
                    break;
                }

            } while (!instaladoComSucesso);

            if (instaladoComSucesso)
            {
                Console.WriteLine($"Aplicativo {nome} instalado com sucesso!");
            }
        }
    }
}