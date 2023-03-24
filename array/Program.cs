// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*TASK 1
L3:
Console.WriteLine("HER HANSI C DEYISENI DAXIL EDIN:");
string eded1 = Console.ReadLine();
int m;
if (!int.TryParse(eded1, out m))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L3;
}
L1:
Console.Write("MASSIVIN UZUNLUQUNU DAXIL ET:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
number[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < number.Length; i++)
{

if (number[i] < m)
{
Console.Write(number[i]+ " ");
}
}



/*TASK 2
L3:
Console.WriteLine("HER HANSI C DEYISENI DAXIL EDIN:");
string eded1 = Console.ReadLine();
int m;
if (!int.TryParse(eded1, out m))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L3;
}
L1:
Console.Write("MASSIVIN UZUNLUQUNU DAXIL ET:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
number[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
int count=0;
int average = 0; ;
for (int i = 0; i < number.Length; i++)
{

if (number[i] < m)
{
count++;
sum += number[i];
average = sum / count;
}

}
Console.WriteLine(average);
*/


//TASK 3
L3:
Console.WriteLine("HER HANSI C DEYISENI DAXIL EDIN:");
string eded1 = Console.ReadLine();
int m;
if (!int.TryParse(eded1, out m))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L3;
}
L1:
Console.Write("MASSIVIN UZUNLUQUNU DAXIL ET:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
number[i] = int.Parse(Console.ReadLine());
}
double multiple = 1;
double count = 0;
double haverage = 0; 
for (int i = 0; i < number.Length; i++)
{

if (number[i] > m)
{
count++;
multiple *= number[i];
haverage = (double)Math.Pow(multiple, 1.0 / count);
}
}
Console.WriteLine(Math.Round(haverage));


/*TASK 4
L3:
Console.WriteLine("HER HANSI C DEYISENI DAXIL EDIN:");
string eded1 = Console.ReadLine();
int m;
if (!int.TryParse(eded1, out m))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L3;
}
L1:
Console.Write("MASSIVIN UZUNLUQUNU DAXIL ET:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
number[i] = int.Parse(Console.ReadLine());
}
for(int i = 0; i < number.Length; i++)
{
if (number[i] > m)
{
Array.Sort(number);
Array.Reverse(number);
Console.Write(number[i]+" ");
}
}
*/

/*TASK 5
L3:
int max = 0;
Console.WriteLine("HER HANSI C DEYISENI DAXIL EDIN:");
string eded1 = Console.ReadLine();
int m;
if (!int.TryParse(eded1, out m))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L3;
}
L1:
Console.Write("MASSIVIN UZUNLUQUNU DAXIL ET:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
number[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < number.Length; i++)
{
if (number[i] < m)
{
if (number[i] > max)
{
max = number[i];
Console.WriteLine(max);
}

}
}
*/

/*TASK 6
Console.WriteLine("X massivi");
int N = int.Parse(Console.ReadLine());
double[] x = new double[N];

for (int i = 0; i < x.Length; i++)
{
l2:
    Console.Write($"[{i + 1}]=");
    if (!double.TryParse(Console.ReadLine(), out x[i]))
    {
        Console.WriteLine("Eded daxil edilmeyib");
        goto l2;
    }

}

Console.WriteLine("Y massivi");
int m = int.Parse(Console.ReadLine());
double[] y = new double[m];

for (int i = 0; i < y.Length; i++)
{
l4:
    Console.Write($"[{i + 1}]=");
    if (!double.TryParse(Console.ReadLine(), out y[i]))
    {
        Console.WriteLine("Eded daxil edilmeyib");
        goto l4;
    }

}

for (int i = 0; i < x.Length; i++)
{
    for (int j = 0; j < y.Length; j++)
    {
        if (x[i] == y[j] * y[j] && x[i] > 0 && y[i] > 0)
        {
            Console.WriteLine(x[i]);
        }
    }
}
*/


/*TASK 7
double max = 0;
double min = double.MaxValue;
L1:
Console.Write("MASSIVIN UZUNLUQUNU DAXIL ET:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
number[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < number.Length; i++)
{
if (number[i] > max)
{
max = number[i];
}
if (number[i] < min)
{
min = number[i];
}
double ededOrta = (max + min) / 2;
double hendesiOrta = (double)Math.Pow(max*min, 1.0/2.0);
Console.WriteLine("eded orta:" + ededOrta + " " + "hendesiOrta:" + hendesiOrta);

*/

/*TASK 8

Console.WriteLine("X massivi");

    double[] x = new double[14];

    for (int i = 0; i < x.Length; i++)
    {
    l2:
        Console.Write($"[{i + 1}]=");
        if (!double.TryParse(Console.ReadLine(), out x[i]))
        {
            Console.WriteLine("Eded daxil edilmeyib");
            goto l2;
        }

    }

    Console.WriteLine("Y massivi");

    double[] y = new double[14];

    for (int i = 0; i < y.Length; i++)
    {
    l4:
        Console.Write($"[{i + 1}]=");
        if (!double.TryParse(Console.ReadLine(), out y[i]))
        {
            Console.WriteLine("Eded daxil edilmeyib");
            goto l4;
        }

    }
    double[] yeni = new double[0];
    int say = 0;
    for (int i = 0; i < x.Length; i++)
    {
        for (int j = 0; j < y.Length; j++)
        {
            if (x[i] == y[j] && x[i] > 0 && y[i] > 0)
            {
                double len = x[i] * x[i];
                Array.Resize(ref yeni, say + 1);
                yeni[say] = len;
                say++;
            }
        }
    }

    Console.WriteLine("Yeni massiv:");
    for (int i = 0; i < yeni.Length; i++)
    {
        Console.WriteLine(yeni[i]);
    }
*/

/*TASK 9
Console.WriteLine("25 elementli massiv");

double[] x = new double[25];

for (int i = 0; i < x.Length; i++)
{
l2:
Console.Write($"[{i + 1}]=");
if (!double.TryParse(Console.ReadLine(), out x[i]))
{
    Console.WriteLine("Eded daxil edilmeyib");
    goto l2;
}
}

double[] y = new double[8];
double[] z = new double[17];

for (int i = 0; i < x.Length; i++)
{
if (i < 8)
{
    y[i] = x[i] * x[i];
}
else
{
    z[i - 8] = x[i] / 4;
}
}

Console.WriteLine("Ilk 8 in kvadratinin elementleri:");
for (int i = 0; i < y.Length; i++)
{
Console.Write($"{y[i]} ");
}

Console.WriteLine("Diger 4-e bolunmus elementler:");
for (int i = 0; i < z.Length; i++)
{
Console.Write($"{z[i]}  ");
}
*/

/*TASK 10
//int max = 0;
int max = int.MinValue;
L1:
Console.Write("MASSIVIN UZUNLUQUNU DAXIL ET:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
number[i] = int.Parse(Console.ReadLine());
}
foreach (int item in number)
{
if (item < 0)
{
    if (max < item)
        max = item;
}
}
Console.WriteLine(max);
*/

/*task 11
L1:
Console.Write("MASSIVIN UZUNLUQUNU DAXIL ET:");
string eded = Console.ReadLine();
int n ;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int[] number = new int[n];
for (int i = 0; i < number.Length; i++)
{
Random random = new Random();
number[i] = random.Next(1, 100);
}
for (int i = 0; i < number.Length; i++)
{
    Array.Sort(number);
    Array.Reverse(number);
    Console.Write(number[i] + " ");
}
*/

/*TASK 12
l2:
Console.WriteLine("Massivin uzunlugu: ");

    double[] x = new double[20];

    for (int i = 0; i < x.Length; i++)
    {
    l3:
        Console.Write($"[{i + 1}]=");
        if (!double.TryParse(Console.ReadLine(), out x[i]))
        {
            Console.WriteLine("Eded daxil edilmeyib");
            goto l3;
        }
    }
    double sum = 0;
    double sum2 = 1;
    double divide = x.Length / 2;
    double count = 0;
    double count2 = 0;

    for (int i = 0; i < divide; i++)
    {
        sum += x[i];
        count++;
    }

    for (int i = (int)divide; i < x.Length; i++)
    {
        sum2 *= x[i];
        count2++;
    }

    double edediOrta = (double)sum / count;
    double hendesiOrta = Math.Pow(sum2, 1.0 / count2);

    Console.WriteLine($"Ilk yarinin ededi ortasi: {edediOrta}");
    Console.WriteLine($"Ikinci yarinin hendesi ortasi: {hendesiOrta}");
*/