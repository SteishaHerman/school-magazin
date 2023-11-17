Console.WriteLine("\t******************************************");
Console.WriteLine("\t\tМИНСКАЯ СРЕДНЯЯ ШКОЛА\n");
Console.WriteLine("\t******************************************\n\n");
string line;
//string[] informationFile;
FileInfo fileInfo = new FileInfo(@"C:\Users\Agerman\source\repos\school magazine\student.txt");
if (!fileInfo.Exists)
{
    StreamWriter writeFile = File.CreateText(@"C:\Users\Agerman\source\repos\school magazine\student.txt");
    Console.Write("Был создан файл, пожалуйста заполните следующие данные:\n");
    NewEntry();
}
ReadEntry();
Console.WriteLine("\n");
Console.WriteLine("\tВыберите цифру:\n\t1)Вывести список учащихся \n\t2)Добавить запись \n\t3)Удалить запись \n\t4)Выход ");
int number = Convert.ToInt32(Console.ReadLine());
void DeleteEntry()
{   }
void ReadEntry()
{
    StreamReader readFile = new StreamReader(@"C:\Users\Agerman\source\repos\school magazine\student.txt");
    line = readFile.ReadLine();
    while (line != null)
    {
        Console.WriteLine("\t" + line);
        line = readFile.ReadLine();
    }
    readFile.Close();
}
void NewEntry()
{
    StreamWriter writeFile = File.AppendText(@"C:\Users\Agerman\source\repos\school magazine\student.txt");
    string readInf;
    Console.Write("1)Id: ");
    readInf = Console.ReadLine();
    writeFile.Write(readInf + " ");
    Console.Write("\n2)ФИО школьника: ");
    readInf = Console.ReadLine();
    writeFile.Write(readInf+" ");
    Console.Write("\n3)Номер класса: ");
    readInf = Console.ReadLine();
    writeFile.Write(readInf+" ");
    Console.Write("\n4)Буква класса: ");
    readInf = Console.ReadLine();
    writeFile.Write(readInf+"\n");
    writeFile.Close();
}//
Console.WriteLine();