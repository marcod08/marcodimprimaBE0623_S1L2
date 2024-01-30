internal class Program
{
    private static void Main(string[] args)
    {
        Persona persona1 = new Persona("Marco", "Rossi", 35);
        persona1.GetDetails();

        Console.WriteLine("Nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Cognome:");
        string cognome = Console.ReadLine();
        Console.WriteLine("eta:");
        int eta = int.Parse(Console.ReadLine());

        Persona persona2 = new Persona(nome, cognome, eta);
        persona2.GetDetails();

        Console.ReadLine();
    }

    public class Persona
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public int eta { get; set; }

        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }

        public void GetDetails()
        {
            Console.WriteLine($"{nome} {cognome} {eta}");
        }

    }


}