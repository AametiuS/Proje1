Random random1 = new Random();
Random random2 = new Random();
Random random3 = new Random();
int harflerIcınRastgeleSayi1 = random1.Next(1, 6);
int harflerIcınRastgeleSayi2 = random1.Next(1, 6);
int harflerIcınRastgeleSayi3 = random1.Next(1, 6);
int harflerIcınRastgeleSayi4 = random1.Next(1, 6);
int harflerIcınRastgeleSayi5 = random1.Next(1, 6);

char randomLetter1 = ' ';
char randomLetter2 = ' ';
char randomLetter3 = ' ';
char randomLetter4 = ' ';
char randomLetter5 = ' ';

switch (harflerIcınRastgeleSayi1)
{
    case 1:
        randomLetter1 = 'A';
        break;
    case 2:
        randomLetter1 = 'B';
        break;
    case 3:
        randomLetter1 = 'C';
        break;
    case 4:
        randomLetter1 = 'D';
        break;
    case 5:
        randomLetter1 = 'E';
        break;
}

switch (harflerIcınRastgeleSayi2)
{
    case 1:
        randomLetter2 = 'A';
        break;
    case 2:
        randomLetter2 = 'B';
        break;
    case 3:
        randomLetter2 = 'C';
        break;
    case 4:
        randomLetter2 = 'D';
        break;
    case 5:
        randomLetter2 = 'E';
        break;
}

switch (harflerIcınRastgeleSayi3)
{
    case 1:
        randomLetter3 = 'A';
        break;
    case 2:
        randomLetter3 = 'B';
        break;
    case 3:
        randomLetter3 = 'C';
        break;
    case 4:
        randomLetter3 = 'D';
        break;
    case 5:
        randomLetter3 = 'E';
        break;
}

switch (harflerIcınRastgeleSayi4)
{
    case 1:
        randomLetter4 = 'A';
        break;
    case 2:
        randomLetter4 = 'B';
        break;
    case 3:
        randomLetter4 = 'C';
        break;
    case 4:
        randomLetter4 = 'D';
        break;
    case 5:
        randomLetter4 = 'E';
        break;
}

switch (harflerIcınRastgeleSayi5)
{
    case 1:
        randomLetter5 = 'A';
        break;
    case 2:
        randomLetter5 = 'B';
        break;
    case 3:
        randomLetter5 = 'C';
        break;
    case 4:
        randomLetter5 = 'D';
        break;
    case 5:
        randomLetter5 = 'E';
        break;
}

int x11Rastgele = random2.Next(1, 4);
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

int y11Rastgele = random3.Next(1, 4);
int y11 = 0;
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

int x12Rastgele = random2.Next(1, 4);
int x12 = 0;
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

int y12Rastgele = random3.Next(1, 4);
int y12 = 0;
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

int x13Rastgele = random2.Next(1, 4);
int x13 = 0;
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

int y13Rastgele = random3.Next(1, 4);
int y13 = 0;
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

int x14Rastgele = random2.Next(1, 4);
int x14 = 0;
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

int y14Rastgele = random3.Next(1, 4);
int y14 = 0;
switch (y14Rastgele)
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
int x15Rastgele = random2.Next(1, 4);
int x15 = 0;
switch (x15Rastgele)
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

int y15Rastgele = random3.Next(1, 4);
int y15 = 0;
switch (y15Rastgele)
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
                if(!(x12 == x11 && y12 == y11))
                {
                    Console.Write(randomLetter2);
                }
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
                while (!(x12 == x11 && y12 == y11))
                {
                    Console.Write(randomLetter2);
                }
            }
            else if (i == x13 && j == y13)
            {
                while (!(x13 == x12 && y13 == y12) || x13 == x11 && y13 == y11)
                {
                    Console.Write(randomLetter3);
                }
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
                while ((x11 == x12 && y11 == y12))
                {
                    Console.Write(randomLetter2);
                }
            }
            else if (i == x13 && j == y13)
            {
                while (((x12 == x13 && y12 == y13) || (x11 == x13 && y11 == y13)))
                {
                    Console.Write(randomLetter3);
                }
            }
            else if (i == x14 && j == y14)
            {
                while (((x14==x13 && y14 == y13) || (x14 == x12 && y14 == y12) || (x14 == x11 && y14 == y11)))
                {
                    Console.Write(randomLetter4);
                }
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
                while (!(x11 == x12 && y11 == y12))
                {
                    Console.Write(randomLetter2);
                }
            }
            else if (i == x13 && j == y13)
            {
                while (!(x12 == x13 && y12 == y13) || (x11 == x13 && y11 == y13))
                {
                    Console.Write(randomLetter3);
                }
            }
            else if (i == x14 && j == y14)
            {
                while (!(x14 == x13 && y14 == y13 || x14 == x12 && y14 == y12 || x14 == x11 && y14 == y11))
                {
                    Console.Write(randomLetter4);
                }
            }
            else if (i == x15 && j == y15)
            {
                while (!(x15 == x14 && y15 == y14 || x15 == x13 && y15 == y13 || x15 == x12 && y15 == y12 || x15 == x11 && x15 == y11))
                {
                    Console.Write(randomLetter5);
                }
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

