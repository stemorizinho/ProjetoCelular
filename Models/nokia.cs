namespace ProjetoCelular.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class nokia : Smartphone
    {

        public nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { 

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
          Console.WriteLine($"Instalando {nomeApp} no  iphone");
          Console.WriteLine($"{nomeApp} Instalado com sucesso no Nokia");
        }
    }

}