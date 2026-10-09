using System.Runtime.CompilerServices;

Random rnd = new Random();

char randomLetter1 = (char)rnd.Next(65, 66);
char randomLetter2 = (char)rnd.Next(65, 67);
char randomLetter3 = (char)rnd.Next(65, 68);
char randomLetter4 = (char)rnd.Next(65, 69);
char randomLetter5 = (char)rnd.Next(65, 70);
char randomLetter6 = (char)rnd.Next(65, 70);

int x11Rastgele = rnd.Next(1, 4);
int x11 = 0;
switch (x11Rastgele)
{
    case 1:
        x11 = 3;
        break;
    case 2:
        x11 = 5;
        break;
    case 3:
        x11 = 7;
        break;
}
int y11Rastgele = rnd.Next(1, 4);
int
    y11 = 0;
switch (y11Rastgele)
{
    case 1:
        y11 = 4;
        break;
    case 2:
        y11 = 7;
        break;
    case 3:
        y11 = 10;
        break;
}

int x12 = 0;
int y12 = 0;
int x13 = 0;
int y13 = 0;
int x14 = 0;
int y14 = 0;
int x15 = 0;
int y15 = 0;
int x16 = 0;
int y16 = 0;
int x12Rastgele = 0;
int x13Rastgele = 0;
int x14Rastgele = 0;
int x15Rastgele = 0;
int x16Rastgele = 0;
int y12Rastgele = 0;
int y13Rastgele = 0;
int y14Rastgele = 0;
int y15Rastgele = 0;
int y16Rastgele = 0;


do
{
    x12Rastgele = rnd.Next(1, 4);
    switch (x12Rastgele)
    {
        case 1:
            x12 = 3;
            break;
        case 2:
            x12 = 5;
            break;
        case 3:
            x12 = 7;
            break;
    }
    y12Rastgele = rnd.Next(1, 4);
    switch (y12Rastgele)
    {
        case 1:
            y12 = 4;
            break;
        case 2:
            y12 = 7;
            break;
        case 3:
            y12 = 10;
            break;
    }
} while ((x11 == x12 && y11 == y12));

do
{
    x13Rastgele = rnd.Next(1, 4);
    switch (x13Rastgele)
    {
        case 1:
            x13 = 3;
            break;
        case 2:
            x13 = 5;
            break;
        case 3:
            x13 = 7;
            break;
    }
    y13Rastgele = rnd.Next(1, 4);
    switch (y13Rastgele)
    {
        case 1:
            y13 = 4;
            break;
        case 2:
            y13 = 7;
            break;
        case 3:
            y13 = 10;
            break;
    }
} while ((x12 == x13 && y12 == y13) || (x11 == x13 && y11 == y13));

do
{
    x14Rastgele = rnd.Next(1, 4);
    switch (x14Rastgele)
    {
        case 1:
            x14 = 3;
            break;
        case 2:
            x14 = 5;
            break;
        case 3:
            x14 = 7;
            break;
    }
    y14Rastgele = rnd.Next(1, 4);
    switch (y14Rastgele)
    {
        case 1:
            y14 = 4;
            break;
        case 2:
            y14 = 7;
            break;
        case 3:
            y14 = 10;
            break;
    }
} while ((x14 == x13 && y14 == y13 || x14 == x12 && y14 == y12 || x14 == x11 && y14 == y11));

do
{
    x15Rastgele = rnd.Next(1, 4);
    switch (x15Rastgele)
    {
        case 1:
            x15 = 3;
            break;
        case 2:
            x15 = 5;
            break;
        case 3:
            x15 = 7;
            break;
    }
    y15Rastgele = rnd.Next(1, 4);
    switch (y15Rastgele)
    {
        case 1:
            y15 = 4;
            break;
        case 2:
            y15 = 7;
            break;
        case 3:
            y15 = 10;
            break;
    }
} while ((x15 == x14 && y15 == y14 || x15 == x13 && y15 == y13 || x15 == x12 && y15 == y12 || (x15 == x11 && x15 == y11)));

do
{
    x16Rastgele = rnd.Next(1, 4);
    switch (x16Rastgele)
    {
        case 1:
            x16 = 3;
            break;
        case 2:
            x16 = 5;
            break;
        case 3:
            x16 = 7;
            break;
    }
    y16Rastgele = rnd.Next(1, 4);
    switch (y16Rastgele)
    {
        case 1:
            y16 = 4;
            break;
        case 2:
            y16 = 7;
            break;
        case 3:
            y16 = 10;
            break;
    }
} while (((x16 == x15 && y16 == y15) || (x16 == x14 && y16 == y14) || (x16 == x13 && y16 == y13) || (x16 == x12 && y16 == y12) || (x16 == x11 && y16 == y11)));

Console.WriteLine("1:Human");
Console.WriteLine("2:Computer");

string secimGirdisi = "";
int secimGirdisiSayi = 0;

do
{
    Console.Write("Choose the player: ");
    secimGirdisi = (Console.ReadLine());

    if ((!int.TryParse(secimGirdisi, out secimGirdisiSayi) || string.IsNullOrWhiteSpace(secimGirdisi)))
    {
        Console.WriteLine("Enter a valid option");
    }
    else if (secimGirdisiSayi > 2 || secimGirdisiSayi < 0)
    {
        Console.WriteLine("Enter a valid option");
    }

} while ((!int.TryParse(secimGirdisi, out secimGirdisiSayi) || string.IsNullOrWhiteSpace(secimGirdisi)) || (secimGirdisiSayi > 2 || secimGirdisiSayi < 0));

string player_choice = "";
string name = "";
char A = 'A';
char B = 'B';
char C = 'C';
char D = 'D';
char E = 'E';

switch (secimGirdisiSayi)
{
    case 1:
        player_choice = "Human";
        do
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Invalide name please enter your name again: ");
            }

        } while (string.IsNullOrWhiteSpace(name));
        break;
    case 2:
        player_choice = "Computer";
        break;
}
Console.Write("Write number of types of symbols between 1 - 5: ");
int secenek = Convert.ToInt32(Console.ReadLine());

int sembollerinCesitSayisi = 0;

string sembol = "";
switch (secenek)
{
    case 1:
        A = 'A';
        sembol = ($"{A}");
        sembollerinCesitSayisi = 1;
        break;
    case 2:
        A = 'A';
        B = 'B';
        sembol = ($"{A},{B}");
        sembollerinCesitSayisi = 2;
        break;
    case 3:
        A = 'A';
        B = 'B';
        C = 'C';
        sembol = ($"{A},{B},{C}");
        sembollerinCesitSayisi = 3;
        break;
    case 4:
        A = 'A';
        B = 'B';
        C = 'C';
        D = 'D';
        sembol = ($"{A},{B},{C},{D}");
        sembollerinCesitSayisi = 4;
        break;
    case 5:
        A = 'A';
        B = 'B';
        C = 'C';
        D = 'D';
        E = 'E';
        sembol = ($"{A},{B},{C},{D},{E}");
        sembollerinCesitSayisi = 5;
        break;
    default:
        while (!(secenek == 1 || secenek == 2 || secenek == 3 || secenek == 4 || secenek == 5))
        {
            if (!(secenek == 1 || secenek == 2 || secenek == 3 || secenek == 4 || secenek == 5))
            {
                Console.WriteLine("Invalid option.Please try again.");
                Console.Write("Write number of types of symbols between 1 - 5: ");
                secenek = Convert.ToInt32(Console.ReadLine());
            }
        }
        break;
}

string sembolSayisiGirdisi = "";
int sembolSayisiGirdisiDogru = 0;

do
{
    Console.Write("Write number of symbols between 1 - 6: ");
    sembolSayisiGirdisi = (Console.ReadLine());

    if ((!int.TryParse(sembolSayisiGirdisi, out sembolSayisiGirdisiDogru) || string.IsNullOrWhiteSpace(sembolSayisiGirdisi)))
    {
        Console.WriteLine("Number of symbols can not be less than number of types of symbols.");
    }
    else if (sembolSayisiGirdisiDogru < sembollerinCesitSayisi)
    {
        Console.WriteLine("Number of symbols can not be less than number of types of symbols.");
    }
    else if (sembolSayisiGirdisiDogru > 6)
    {
        Console.WriteLine("Number of symbols can not be less than number of types of symbols.");
    }

} while ((sembolSayisiGirdisiDogru < sembollerinCesitSayisi) || (sembolSayisiGirdisiDogru > 6));


string hareketSayisiGirdisi = "";
int hareketSayisi;
do
{
    Console.Write("Enter number of shifts between 1 - 20: ");
    hareketSayisiGirdisi = (Console.ReadLine());

    if ((!int.TryParse(hareketSayisiGirdisi, out hareketSayisi) || string.IsNullOrWhiteSpace(hareketSayisiGirdisi)))
    {
        Console.WriteLine("Please enter a number");
    }
    else if (hareketSayisi > 20)
    {
        Console.WriteLine("Please enter a valid number between 1 - 20");
    }

} while ((!int.TryParse(hareketSayisiGirdisi, out hareketSayisi) || string.IsNullOrWhiteSpace(hareketSayisiGirdisi)) || (hareketSayisi > 20));

Console.WriteLine();

Console.WriteLine("Game Mode");
Console.WriteLine("-------------");

if (player_choice == "Human")
{
    Console.WriteLine($"Human:{name}");
}
else if (player_choice == "Computer")
{
    Console.WriteLine($"Player: {player_choice}");
}

Console.WriteLine($"Symbols: {sembol}");
Console.WriteLine($"Number of Symbols: {sembolSayisiGirdisiDogru}");
Console.WriteLine($"Number of Shifts: {hareketSayisi}");

Console.WriteLine();

Console.WriteLine("--- Target Board ---");

Console.WriteLine();

int satir = 10;
int sutun = 14;

if (sembolSayisiGirdisiDogru == 1)
{
    for (int i = 1; i < satir; i++)
    {
        for (int j = 1; j < sutun; j++)
        {
            if (i == x11 && j == y11)
            {
                Console.Write(randomLetter1);
            }
            else if (i == 2 && j == 2 || (i == 2 && j == 12) || (i == 8 && j == 2) || (i == 8 && j == 12))
            {
                Console.Write("+");
            }
            else if ((i == 2 && (j > 2 && j < 13)) || i == 8 && (j > 2 && j < 13))
            {
                Console.Write("-");
            }
            else if ((i > 2 && i < 9) && (j == 2 || j == 12))
            {
                Console.Write("|");
            }
            else if (i == 3 && j == 1)
            {
                Console.Write("1");
            }
            else if (i == 5 && j == 1)
            {
                Console.Write("2");
            }
            else if (i == 7 && j == 1)
            {
                Console.Write("3");
            }
            else if (i == 1 && j == 4)
            {
                Console.Write("7");
            }
            else if (i == 1 && j == 7)
            {
                Console.Write("8");
            }
            else if (i == 1 && j == 10)
            {
                Console.Write("9");
            }
            else if (i == 9 && j == 3)
            {
                Console.Write("10");
            }
            else if (i == 9 && j == 5)
            {
                Console.Write("11");
            }
            else if (i == 9 && j == 7)
            {
                Console.Write("12");
            }
            else if (i == 3 && j == 13)
            {
                Console.Write("4");
            }
            else if (i == 5 && j == 13)
            {
                Console.Write("5");
            }
            else if (i == 7 && j == 13)
            {
                Console.Write("6");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
if (sembolSayisiGirdisiDogru == 2)
{
    for (int i = 1; i < satir; i++)
    {
        for (int j = 1; j < sutun; j++)
        {
            if (i == x11 && j == y11)
            {
                Console.Write(randomLetter1);
            }
            else if (i == x12 && j == y12)
            {
                Console.Write(randomLetter2);
            }
            else if (i == 2 && j == 2 || (i == 2 && j == 12) || (i == 8 && j == 2) || (i == 8 && j == 12))
            {
                Console.Write("+");
            }
            else if ((i == 2 && (j > 2 && j < 13)) || i == 8 && (j > 2 && j < 13))
            {
                Console.Write("-");
            }
            else if ((i > 2 && i < 9) && (j == 2 || j == 12))
            {
                Console.Write("|");
            }
            else if (i == 3 && j == 1)
            {
                Console.Write("1");
            }
            else if (i == 5 && j == 1)
            {
                Console.Write("2");
            }
            else if (i == 7 && j == 1)
            {
                Console.Write("3");
            }
            else if (i == 1 && j == 4)
            {
                Console.Write("7");
            }
            else if (i == 1 && j == 7)
            {
                Console.Write("8");
            }
            else if (i == 1 && j == 10)
            {
                Console.Write("9");
            }
            else if (i == 9 && j == 3)
            {
                Console.Write("10");
            }
            else if (i == 9 && j == 5)
            {
                Console.Write("11");
            }
            else if (i == 9 && j == 7)
            {
                Console.Write("12");
            }
            else if (i == 3 && j == 13)
            {
                Console.Write("4");
            }
            else if (i == 5 && j == 13)
            {
                Console.Write("5");
            }
            else if (i == 7 && j == 13)
            {
                Console.Write("6");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

if (sembolSayisiGirdisiDogru == 3)
{
    for (int i = 1; i < satir; i++)
    {
        for (int j = 1; j < sutun; j++)
        {
            if (i == x11 && j == y11)
            {
                Console.Write(randomLetter1);
            }
            else if (i == x12 && j == y12)
            {
                Console.Write(randomLetter2);
            }
            else if (i == x13 && j == y13)
            {
                Console.Write(randomLetter3);
            }
            else if (i == 2 && j == 2 || (i == 2 && j == 12) || (i == 8 && j == 2) || (i == 8 && j == 12))
            {
                Console.Write("+");
            }
            else if ((i == 2 && (j > 2 && j < 13)) || i == 8 && (j > 2 && j < 13))
            {
                Console.Write("-");
            }
            else if ((i > 2 && i < 9) && (j == 2 || j == 12))
            {
                Console.Write("|");
            }
            else if (i == 3 && j == 1)
            {
                Console.Write("1");
            }
            else if (i == 5 && j == 1)
            {
                Console.Write("2");
            }
            else if (i == 7 && j == 1)
            {
                Console.Write("3");
            }
            else if (i == 1 && j == 4)
            {
                Console.Write("7");
            }
            else if (i == 1 && j == 7)
            {
                Console.Write("8");
            }
            else if (i == 1 && j == 10)
            {
                Console.Write("9");
            }
            else if (i == 9 && j == 3)
            {
                Console.Write("10");
            }
            else if (i == 9 && j == 5)
            {
                Console.Write("11");
            }
            else if (i == 9 && j == 7)
            {
                Console.Write("12");
            }
            else if (i == 3 && j == 13)
            {
                Console.Write("4");
            }
            else if (i == 5 && j == 13)
            {
                Console.Write("5");
            }
            else if (i == 7 && j == 13)
            {
                Console.Write("6");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

if (sembolSayisiGirdisiDogru == 4)
{
    for (int i = 1; i < satir; i++)
    {
        for (int j = 1; j < sutun; j++)
        {
            if (i == x11 && j == y11)
            {
                Console.Write(randomLetter1);
            }
            else if (i == x12 && j == y12)
            {
                Console.Write(randomLetter2);
            }
            else if (i == x13 && j == y13)
            {
                Console.Write(randomLetter3);
            }
            else if (i == x14 && j == y14)
            {
                Console.Write(randomLetter4);
            }
            else if (i == 2 && j == 2 || (i == 2 && j == 12) || (i == 8 && j == 2) || (i == 8 && j == 12))
            {
                Console.Write("+");
            }
            else if ((i == 2 && (j > 2 && j < 13)) || i == 8 && (j > 2 && j < 13))
            {
                Console.Write("-");
            }
            else if ((i > 2 && i < 9) && (j == 2 || j == 12))
            {
                Console.Write("|");
            }
            else if (i == 3 && j == 1)
            {
                Console.Write("1");
            }
            else if (i == 5 && j == 1)
            {
                Console.Write("2");
            }
            else if (i == 7 && j == 1)
            {
                Console.Write("3");
            }
            else if (i == 1 && j == 4)
            {
                Console.Write("7");
            }
            else if (i == 1 && j == 7)
            {
                Console.Write("8");
            }
            else if (i == 1 && j == 10)
            {
                Console.Write("9");
            }
            else if (i == 9 && j == 3)
            {
                Console.Write("10");
            }
            else if (i == 9 && j == 5)
            {
                Console.Write("11");
            }
            else if (i == 9 && j == 7)
            {
                Console.Write("12");
            }
            else if (i == 3 && j == 13)
            {
                Console.Write("4");
            }
            else if (i == 5 && j == 13)
            {
                Console.Write("5");
            }
            else if (i == 7 && j == 13)
            {
                Console.Write("6");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

if (sembolSayisiGirdisiDogru == 5)
{
    for (int i = 1; i < satir; i++)
    {
        for (int j = 1; j < sutun; j++)
        {
            if (i == x11 && j == y11)
            {
                Console.Write(randomLetter1);
            }
            else if (i == x12 && j == y12)
            {
                Console.Write(randomLetter2);
            }
            else if (i == x13 && j == y13)
            {
                Console.Write(randomLetter3);
            }
            else if (i == x14 && j == y14)
            {
                Console.Write(randomLetter4);
            }
            else if (i == x15 && j == y15)
            {
                Console.Write(randomLetter5);
            }
            else if (i == 2 && j == 2 || (i == 2 && j == 12) || (i == 8 && j == 2) || (i == 8 && j == 12))
            {
                Console.Write("+");
            }
            else if ((i == 2 && (j > 2 && j < 13)) || i == 8 && (j > 2 && j < 13))
            {
                Console.Write("-");
            }
            else if ((i > 2 && i < 9) && (j == 2 || j == 12))
            {
                Console.Write("|");
            }
            else if (i == 3 && j == 1)
            {
                Console.Write("1");
            }
            else if (i == 5 && j == 1)
            {
                Console.Write("2");
            }
            else if (i == 7 && j == 1)
            {
                Console.Write("3");
            }
            else if (i == 1 && j == 4)
            {
                Console.Write("7");
            }
            else if (i == 1 && j == 7)
            {
                Console.Write("8");
            }
            else if (i == 1 && j == 10)
            {
                Console.Write("9");
            }
            else if (i == 9 && j == 3)
            {
                Console.Write("10");
            }
            else if (i == 9 && j == 5)
            {
                Console.Write("11");
            }
            else if (i == 9 && j == 7)
            {
                Console.Write("12");
            }
            else if (i == 3 && j == 13)
            {
                Console.Write("4");
            }
            else if (i == 5 && j == 13)
            {
                Console.Write("5");
            }
            else if (i == 7 && j == 13)
            {
                Console.Write("6");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

if (sembolSayisiGirdisiDogru == 6)
{
    for (int i = 1; i < satir; i++)
    {
        for (int j = 1; j < sutun; j++)
        {
            if (i == x11 && j == y11)
            {
                Console.Write(randomLetter1);
            }
            else if (i == x12 && j == y12)
            {
                Console.Write(randomLetter2);
            }
            else if (i == x13 && j == y13)
            {
                Console.Write(randomLetter3);
            }
            else if (i == x14 && j == y14)
            {
                Console.Write(randomLetter4);
            }
            else if (i == x15 && j == y15)
            {
                Console.Write(randomLetter5);
            }
            else if (i == x16 && j == y16)
            {
                Console.Write(randomLetter6);
            }
            else if (i == 2 && j == 2 || (i == 2 && j == 12) || (i == 8 && j == 2) || (i == 8 && j == 12))
            {
                Console.Write("+");
            }
            else if ((i == 2 && (j > 2 && j < 13)) || i == 8 && (j > 2 && j < 13))
            {
                Console.Write("-");
            }
            else if ((i > 2 && i < 9) && (j == 2 || j == 12))
            {
                Console.Write("|");
            }
            else if (i == 3 && j == 1)
            {
                Console.Write("1");
            }
            else if (i == 5 && j == 1)
            {
                Console.Write("2");
            }
            else if (i == 7 && j == 1)
            {
                Console.Write("3");
            }
            else if (i == 1 && j == 4)
            {
                Console.Write("7");
            }
            else if (i == 1 && j == 7)
            {
                Console.Write("8");
            }
            else if (i == 1 && j == 10)
            {
                Console.Write("9");
            }
            else if (i == 9 && j == 3)
            {
                Console.Write("10");
            }
            else if (i == 9 && j == 5)
            {
                Console.Write("11");
            }
            else if (i == 9 && j == 7)
            {
                Console.Write("12");
            }
            else if (i == 3 && j == 13)
            {
                Console.Write("4");
            }
            else if (i == 5 && j == 13)
            {
                Console.Write("5");
            }
            else if (i == 7 && j == 13)
            {
                Console.Write("6");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}