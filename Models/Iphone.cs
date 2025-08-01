// namespace DesafioPOO.Models
// {
//     // TODO: Herdar da classe "Smartphone"
//     public class Iphone
//     {
//         // TODO: Sobrescrever o método "InstalarAplicativo"
//     }
// }

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // <<<IMPLEMENTADO>>>
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
             : base(numero, modelo, imei, memoria) { }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // <<<IMPLEMENTADO>>>
        public override void InstalarAplicativo(string nome)
        {
            bool instaladoComSucesso = false;
            do
            {
                Console.WriteLine($"Verificando memória disponível no iPhone...");

                if (128 >= Memoria)
                {
                    Console.WriteLine($"Instalando o aplicativo no iPhone...");
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