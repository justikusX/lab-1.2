
try
{
    Console.WriteLine("Введите оценку по математике : ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите оценку по физике: ");
    int f = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите оценку по информатике: ");
    int inf = int.Parse(Console.ReadLine());
    if ((m == 4 && f == 4 && inf == 4) || (m == 5 && f == 5 && inf == 5))
    {
        Console.WriteLine("Студент получил степендию (ИСТИНА)");
    }
    else Console.WriteLine("Студент не получил степендию(ЛОЖ)");
    if (m >= 6 || f >= 6 || inf >= 6) Console.WriteLine("Ошибка ввода данных, введите верные данне от 2 до 5");
    

}
catch
{

}
