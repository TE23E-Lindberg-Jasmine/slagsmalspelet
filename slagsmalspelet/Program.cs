
using System.Net.Security;
string skurknamn;


int hjältehp = 100;
int skurkhp = 100;


Console.WriteLine("Skriv in ditt namn");
string hjältenamn = Console.ReadLine();
Console.WriteLine($" Hej {hjältenamn}");

string enemyPic;

Console.Clear();
Console.WriteLine("Tryck för att veta vem din fiende är");
Console.ReadLine();


// Slumpar vilken fiende man får 

if (Random.Shared.Next(2) == 0)
{
      enemyPic = """
            c~~p,---------.
      ,---'oo  )           \
      ( O O                  )/
      `=^='                 /
            \    ,     .   /
            \\  |-----'|  /
            ||__|    |_|__|

      """;
      skurknamn = "Moo deng";

}

else
{
      enemyPic = """

        _
       / \      _-'
     _/|  \-''- _ /
__-' { |          \
    /             \
    /       "o.  |o }
    |            \ ;
                  ',
       \_         __\
         ''-_    \.//
           / '-____'
          /
        _'
      _-'

""";
      skurknamn = "Alpha sigma";
}


Console.Clear();
new Random();

while (hjältehp > 0 && skurkhp > 0)

{
      Console.WriteLine(enemyPic);

      Console.WriteLine("\n NY RUNDA");
      Console.WriteLine($"{hjältenamn}: {hjältehp} {skurknamn}: {skurkhp}\n ");

      int skada1 = Random.Shared.Next(50);
      skurkhp -= skada1;
      skurkhp = Math.Max(0, skurkhp);
      Console.WriteLine($"{skurknamn}gör {skada1} skada på {hjältenamn}");


      int skada2 = Random.Shared.Next(50);
      hjältehp -= skada2;
      hjältehp = Math.Max(0, hjältehp);
      Console.WriteLine($"{hjältenamn} gör {skada2} skada på {skurknamn}");

      Console.WriteLine("tryck nånstans för att fortsätta.");
      Console.ReadKey();

}


Console.WriteLine("\n striden är slut");

if (hjältehp == 0 && skurkhp == 0)

{
      Console.WriteLine("Oavgjort");
      Console.WriteLine("):");
      Console.ReadLine();
}


if (hjältehp == 0)

{
      Console.WriteLine($"{skurknamn} vann");
      Console.WriteLine($"{enemyPic}");
      Console.ReadLine();
}

if (skurkhp == 0)

{
      Console.WriteLine($"{hjältenamn} vann");
      Console.WriteLine("""

                \||/
                |  @___oo
      /\  /\   / (__,,,,|
     ) /^\) ^\/ _)
     )   /^\/   _)
     )   _ /  / _)
 /\  )/\/ ||  | )_)
<  >      |(,,) )__)
 ||      /    \)___)\
 | \____(      )___) )___
  \______(_______;;; __;;;



""");

      Console.ReadLine();
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();





