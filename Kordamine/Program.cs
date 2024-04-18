using System;

class Program
{
    struct Student
    {
        public string LastName;
        public string FirstName;
        public string GroupCode;
        public int[] Grades;

        public bool Scholarship()
        {
            foreach (int grade in Grades)
            {
                if (grade < 4)
                {
                    return false;
                }
            }
            return true;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        Console.WriteLine("Введите символ для подсчета его вхождений:");
        char Char = Console.ReadKey().KeyChar;
        Console.WriteLine(); // переход на новую строку после ввода символа

        int totalChars = input.Length;
        int CharCount = 0;

        foreach (char ch in input)
        {
            if (ch == Char)
            {
                CharCount++;
            }
        }

        double percentage = (double)CharCount / totalChars * 100;

        Console.WriteLine($"Процент вхождения символа '{Char}' в строку: {percentage}%"); 

        // массива 10x10
        double[,] matrix = new double[10, 10];

        // заполнение массива случайными числами от 1 до 100
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = random.NextDouble() * 100;
            }
        }

        // вычисление суммы элементов каждой строки
        double[] rowSums = new double[10];
        for (int i = 0; i < 10; i++)
        {
            double sum = 0;
            for (int j = 0; j < 10; j++)
            {
                sum += matrix[i, j];
            }
            rowSums[i] = sum;
        }

        // вычисление элементов каждого столбца
        double[] columnProducts = new double[10];
        for (int j = 0; j < 10; j++)
        {
            double product = 1;
            for (int i = 0; i < 10; i++)
            {
                product *= matrix[i, j];
            }
            columnProducts[j] = product;
        }

        // нахождение максимального элемента главной диагонали
        double maxDiagonalElement = matrix[0, 0];
        for (int i = 1; i < 10; i++)
        {
            if (matrix[i, i] > maxDiagonalElement)
            {
                maxDiagonalElement = matrix[i, i];
            }
        }

        // вывод результатов
        Console.WriteLine("Суммы элементов каждой строки:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {rowSums[i]}");
        }

        Console.WriteLine("\nПроизведения элементов каждого столбца:");
        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine($"Столбец {j + 1}: {columnProducts[j]}");
        }

        Console.WriteLine($"\nМаксимальный элемент главной диагонали: {maxDiagonalElement}");
    

    // Создаем массив Student
    Student[] students = new Student[3];
    students[0] = new Student
        {
            LastName = "Kaja",
            FirstName = "Kallas",
            GroupCode = "TARgv22",
            Grades = new int[] { 5, 4, 5, 5 }
        };
students[1] = new Student
{
    LastName = "Ounapuu",
    FirstName = "Petr",
    GroupCode = "TARge23",
    Grades = new int[] { 2, 3, 3, 2 }
};
students[2] = new Student
{
    LastName = "Odins",
    FirstName = "Eduard",
    GroupCode = "TARgv23",
    Grades = new int[] { 5, 5, 5, 5 }
};


        // Выводим информацию о студентах и их оценках
        Console.WriteLine("Информация о студентах и их оценках:");
        foreach (Student student in students)
        {
            Console.WriteLine($"Фамилия: {student.LastName}, Имя: {student.FirstName}, Группа: {student.GroupCode}");
            Console.Write("Оценки: ");
            foreach (int grade in student.Grades)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    // Определяем студентов, которые будут получать стипендию
    Console.WriteLine("Студенты, которые получат стипендию:");
foreach (Student student in students)
{
    if (student.Scholarship())
    {
        Console.WriteLine($"{student.LastName} {student.FirstName}");
    }
}      
    }

}
