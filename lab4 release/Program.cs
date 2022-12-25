Random random = new Random();
int[] mass = new int[8];
Console.WriteLine("Старший разряд");
for (var index = 0; index < mass.Length; index++)
{
    mass[index] = random.Next(10, 100);
}
for (var index = 0; index < mass.Length; index++)
{
    Console.WriteLine(mass[index]);
}
Console.WriteLine("Младший разряд");
for (int i=0; i<mass.Length; i++)
{
    mass[i] = mass[i] %10;
    Console.WriteLine(mass[i]);
}


//var q = mass[0];
//var w = mass[1];
//var e = mass[2];
//var r = mass[3];
//var t = mass[4];
//var y = mass[5];
//var u = mass[6];
//var z = mass[7];







