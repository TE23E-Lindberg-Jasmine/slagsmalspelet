using System.Text.RegularExpressions;

int hjältehp = 100 ;
int skurkhp = 100 ;

string hjältenamn  = "hello kitty" ;
string skurknamn   =  "labubu";

Random generator = new Random();

while (hjältehp > 0 && skurkhp> 0)

{

Console.Clear();
Console.WriteLine("\n Runda 1");
Console.WriteLine($"{hjältenamn}: {hjältehp} {skurknamn}: {skurkhp}\n ");

int skada1 = generator.Next (10);
skurkhp -= skada1;
skurkhp = Math.Max(0,skurkhp);
Console.WriteLine($"{skurknamn}gör {skada1} skada på {hjältenamn}");


int skada2 = generator.Next (10); 
hjältehp -= skada2;
hjältehp= Math.Max(0,hjältehp);
Console.WriteLine($"{hjältenamn} gör {skada2} skada på {skurknamn}");

Console.WriteLine ("tryck nånstans för att fortsätta.");
Console.ReadKey();


}


{

Console.WriteLine("\nRunda 2");
Console.WriteLine($"{hjältenamn}: {hjältehp} {skurknamn}: {skurkhp}\n ");

int skada3 = generator.Next (50);
skurkhp -= skada3;
skurkhp = Math.Max(0,skurkhp);
Console.WriteLine($"{skurknamn}gör {skada3} skada på {hjältenamn}");


int skada4 = generator.Next (50); 
hjältehp -= skada4;
hjältehp= Math.Max(0,hjältehp);
Console.WriteLine($"{hjältenamn} gör {skada4} skada på {skurknamn}");

Console.WriteLine ("tryck nånstans för att fortsätta.");
Console.ReadKey();


}


Console.WriteLine("\n striden är slut");

if(hjältehp == 0 && skurkhp == 0)

{
Console.WriteLine("Oavgjort");
Console.ReadLine();
}

else if (hjältehp == 0)

{
Console.WriteLine($"{skurknamn} vann");
Console.WriteLine();
}

if (skurkhp == 0)

{
Console.WriteLine($"{hjältenamn} vann");
Console.ReadLine();
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();