using BoekenWinkel;
Boeken.Eigenaar = "VDAB";
decimal totaleWinst = 0;


Leesboek kleinDuimpje = new Leesboek("klein duimpje", "Charles Perrault", 5, new Genre (8,"sprookje"), "kinderverhaal");
WoordenBoek vanDale = new WoordenBoek("Woorden Boek", "Van Dale", 5,new Genre(20,"vreemd"), "Nederlands");
Leesboek frankenstein = new Leesboek("Frankenstein", "Mary Wollstonecraft Godwinn", 10, new Genre(12, "Horror"), "Klassiek Horrorverhaal");
BoekenRek rek = new BoekenRek(breedte: 100, hoogte: 100,kostprijs: 200);

IVoorwerpen[] voorwerpen = new IVoorwerpen[4];

voorwerpen[0] = rek;
voorwerpen[1] = kleinDuimpje;
voorwerpen[2] = vanDale;
voorwerpen[3] = frankenstein;   

 foreach (IVoorwerpen voorwerp in voorwerpen)
{
    Console.WriteLine(voorwerp.ToonGegevens());
    totaleWinst += voorwerp.Winst;
    Console.WriteLine();    

}
 Console.WriteLine("Totale winst: " + totaleWinst);

