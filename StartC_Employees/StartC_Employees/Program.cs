static void FileAppend()
{
    string patch = @"d:\Сотрудники.txt";
    using (FileStream file = new FileStream(patch, FileMode.Append))
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            char key = '2';
            do
            {
                string ID = String.Empty;
                Console.Write("Введите ваш ID: ");
                ID += $"{Console.ReadLine()} ";

                DateTime now = DateTime.Now;
                Console.WriteLine($"Время записи: {now}");
                ID += $"{now.ToString("g")} ";

                Console.Write("Введите ваш Ф.И.О.: ");
                string FullName = Console.ReadLine();
                ID += $"{FullName} ";

                Console.Write("Введите ваш возраст: ");
                string age = Console.ReadLine();
                ID += $"{age} ";

                Console.Write("Введите ваш рост: ");
                string growth = Console.ReadLine();
                ID += $"{growth} ";

                Console.Write("Введите дату вашего рождения: ");
                string birthsday = Console.ReadLine();
                ID += $"{birthsday} ";

                Console.Write("Введите место вашего рождения: ");
                string place = Console.ReadLine();
                ID += $"{place}";

                sw.WriteLine(ID);
                Console.WriteLine("\nПродолжить > 2\nСмотреть > 1");
            } while (key != '2');
        }
    }
}


static void ReadFile()
{
    string text = File.ReadAllText(@"d:\Сотрудники.txt");
    Console.WriteLine(text);
}


static void ChooseFile()
{
    Console.WriteLine("Для того чтобы заполнить данные введите > 2\nДля того чтобы читать введите > 1");
    Console.WriteLine("Чтобы закрыть введите 'n'");
    bool boolean = true;
    char key = '2';
    char value = '1';
    char stop = 'n'; 
    while (boolean)
    {
        char hide = Console.ReadKey(true).KeyChar;
        string wrote = Console.ReadLine();
        if (hide == '2') FileAppend();
        else if (hide == '1') ReadFile();
        else if (hide == stop)
        {
            Console.WriteLine("Вы закрыли файл 'Сотрудники'");
            break;
        }
        else Console.WriteLine("Неверная команда(!)\n");
    }
    if (boolean) boolean = false;
}
ChooseFile();
Console.ReadKey();
