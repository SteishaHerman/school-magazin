using school_magazine;

Console.WriteLine("\t******************************************");
Console.WriteLine("\t\tМИНСКАЯ СРЕДНЯЯ ШКОЛА\n");
Console.Write("\t******************************************\n");
string line;

while (true)
{
    var magazin = new Magazin();
    Console.WriteLine("\n\tВыберите цифру:\n\t1)Вывести список учащихся \n\t2)Добавить запись \n\t3)Удалить запись \n\t4)Редактировать запись \n\t5)Выход");
    Console.Write("\n\t");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (number == 1) magazin.ReadEntry();
    if (number == 2) magazin.NewEntry();
    if (number == 3) magazin.DeleteEntry();
    if (number == 4) magazin.EditEntry();
    if (number == 5) break;
}
