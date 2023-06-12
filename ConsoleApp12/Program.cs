using ConsoleApp12;

static void Main(string[] args)
{
    Console.WriteLine("Intorduce ti va numele dumneavoastra");
    string nume = Console.ReadLine();
    Console.WriteLine("Introduceti prenumele dumneavoastra");
    string prenume = Console.ReadLine();
    Console.WriteLine("Intoduceti va  varsta dumneavoastra");
    int varsta = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduceti va cnp ul dumneavoastra");
    int cnp = int.Parse(Console.ReadLine());

    Pacient pacient = new Pacient(nume, prenume, varsta, cnp);

    pacient.Text();

    Console.WriteLine(pacient.VerificareCnp(varsta));

    Medic medic = new Medic("Denisa Lescaie ", 35, " cardiologie");

    medic.Text();


    Console.WriteLine("Tastati in ce data doriti sa fiti programati");
    int data = int.Parse(Console.ReadLine());
    Console.WriteLine("Tastati luna ");
    int luna = int.Parse(Console.ReadLine());

    string numeDoctor = "Denisa Lescaie";

    ProgramarePacient programarePacient1 = new ProgramarePacient(data, luna, 2023);

    ProgramarePacient programarePacient2 = new ProgramarePacient(numeDoctor);


    programarePacient2.Programari(data, luna);
    programarePacient1.Programari("Denisa Lescaie");

    Console.ReadLine();

    CabinetMedical cabinet = new CabinetMedical("Cabinet Bella", " Bulevardul Titu Maiorescu , nr 9 ,Cluj , Judetul Cluj ", 8, 16);

    cabinet.Text();

    Reteta reteta = new Reteta(" Calmcardio ", "stopTensiune");
    Reteta reteta1 = new Reteta("Denisa Lescaie");

    reteta1.Text();
    reteta.Text();




}
    