// See https://aka.ms/new-console-template for more information

double salario, ventas, cantid_a, totalS = 0, TotalT = 0, totalV = 0;
string text;
Console.Write("Cual es tu nombre = ");
text = Console.ReadLine();
Console.Write("Salario bruto = ");
salario = double.Parse(Console.ReadLine());
Console.Write("Cuantas ventas hiciste = ");
ventas = double.Parse(Console.ReadLine());
Console.Write("Cuantos años tienes en la empresa = ");
cantid_a = double.Parse(Console.ReadLine());
if (ventas <= 600)
{
    totalV = salario + (salario * 0.05);
}
else if (ventas > 600 && ventas <= 3000)
{
    totalV = salario + (salario * 0.07);
}
else if (ventas > 3000)
{
    totalV = salario + (salario * 0.06) + 300;
}
double TotalD = 0;
if (cantid_a <= 3)
{
    TotalD = totalV - (totalV * 0.065);
}
else if (cantid_a >= 4)
{
    TotalD = totalV - (totalV * 0.040);
}
Console.WriteLine("\t\nTu nombre es = " + text);
Console.WriteLine("\t\nTu sueldo bruto es = " + salario);
Console.WriteLine("\t\nTu porcentaje de ventas sumadas = " + (totalV - salario));
Console.WriteLine("\t\nEl total ganado de salario + ventas - impuestos es = " + TotalD);
Console.WriteLine("\t\ncantidad de años en la empresa = " + cantid_a);
//guardado1;
//guardado2;
//guardado3;
//guardado4;