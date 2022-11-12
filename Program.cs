//Skriv ut ett välkomstmeddelande till användaren
Console.WriteLine("Hej, det här programmet ska beräkna växel för den vara eller de varor du köper!");

//Deklarera de variabler som behövs för att räkna växel
decimal pris;
decimal betalat;
decimal växel;
string? strPris;
string? strBetalat;

//Be användaren mata in pris på den vara eller de varor hen köpt

//Ta reda på om användaren matat in ett giltig värde med TryParse
do
{
    Console.Write("Vad kostade din vara eller dina varor sammanlagt? Skriv summan (i kr): ");
    strPris = Console.ReadLine();
} while (!decimal.TryParse(strPris, out pris));


//Be användaren mata in summan på vad hen betalat

//Ta reda på onm användaren matat in ett giltigt värde med TryParse

do
{
    Console.Write("Vad betalade du? Skriv summan (i kr): ");
    strBetalat = Console.ReadLine();
} while (!decimal.TryParse(strBetalat, out betalat));


växel = betalat - pris;

/*Om användaren skriver in ett lägre belopp på betalat belopp än angett pris, 
säg åt användaren att betalad summa måste vara lika med
eller mer än angett pris */

while (växel < 0)
{
    do
    {
        Console.Write("Summan på betalat belopp måste vara lika med eller mer än angett pris, försök igen!: ");
        strBetalat = Console.ReadLine();

    } while (!decimal.TryParse(strBetalat, out betalat));

    växel = betalat - pris;
} 


//Om värdet på decimalerna i talet växel är >0.75 avrundas talet växel uppåt till närmaste heltal.
if (växel % 1.0m < 0.25m)
{
    växel = Math.Floor(växel);
}
if (växel % 1.0m >= 0.25m && växel % 1.0m <= 0.75m)
{
    växel = Math.Floor(växel) + 0.5m;
}
if (växel % 1.0m > 0.75m)
{
    växel = Math.Ceiling(växel);
}

Console.WriteLine("Du får tillbaka: " + växel + " kronor");
int tusenlappar = (int)(växel / 1000.0m);
växel = växel % 1000.0m;
int femhundralappar = (int)(växel / 500.0m);
växel = växel % 500.0m;
int hundralappar = (int)(växel / 100.0m);
växel = växel % 100.0m;
int femtiolappar = (int)(växel / 50.0m);
växel = växel % 50.0m;
int tjugolappar = (int)(växel / 20.0m);
växel = växel % 20.0m;
int tiokronor = (int)(växel / 10.0m);
växel = växel % 10.0m;
int femkronor = (int)(växel / 5.0m);
växel = växel % 5.0m;
int enkronor = (int)(växel / 1.0m);
växel = växel % 1.0m;
int femtioöring = (int)Math.Ceiling(växel);

Console.WriteLine("Du får tillbaka");

Console.WriteLine("tusenlappar: " + tusenlappar);
Console.WriteLine("femhundralappar: " + femhundralappar);
Console.WriteLine("hundralappar: " + hundralappar);
Console.WriteLine("femtiolappar: " + femtiolappar);
Console.WriteLine("tjugolappar: " + tjugolappar);
Console.WriteLine("tiokronor: " + tiokronor);
Console.WriteLine("femkronor: " + femkronor);
Console.WriteLine("enkronor: " + enkronor);
Console.WriteLine("femtioöringar: " + femtioöring);
