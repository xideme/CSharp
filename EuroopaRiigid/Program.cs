using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Dictionary<string, string> ReadFromFile(string fileName)
    {
        Dictionary<string, string> countryCapital = new Dictionary<string, string>();
        Dictionary<string, string> capitalCountry = new Dictionary<string, string>();
        List<string> countries = new List<string>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('-');
                string country = parts[0].Trim();
                string capital = parts[1].Trim();

                countryCapital[country] = capital;
                capitalCountry[capital] = country;
                countries.Add(country);
            }
        }

        return countryCapital;
    }

    static void WriteToFile(string fileName, List<string> list)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (string item in list)
            {
                writer.WriteLine(item);
            }
        }
        Console.WriteLine("Dictionary saved!");
    }

    static void ViewCountryCapital(Dictionary<string, string> countryCapital, Dictionary<string, string> capitalCountry)
    {
        Console.WriteLine("\nSearch for capital 1 or country 2\n");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1 || choice == 2)
        {
            if (choice == 1)
            {
                Console.Write("Enter the capital: ");
                string capital = Console.ReadLine();
                if (capitalCountry.ContainsKey(capital))
                {
                    Console.WriteLine("Country: " + capitalCountry[capital]);
                }
                else
                {
                    Console.WriteLine("Capital not found in the list!");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Enter country: ");
                string country = Console.ReadLine();
                if (countryCapital.ContainsKey(country))
                {
                    Console.WriteLine("Capital: " + countryCapital[country]);
                }
                else
                {
                    Console.WriteLine("Country not found in the list!");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void AddDeleteCountryCapital(Dictionary<string, string> countryCapital, Dictionary<string, string> capitalCountry, List<string> countries)
    {
        Console.WriteLine("\nAdd 1 or Delete 2\n");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1 || choice == 2)
        {
            if (choice == 1)
            {
                Console.Write("Enter new country: ");
                string newCountry = Console.ReadLine();
                Console.Write("Enter the capital of the country: ");
                string newCapital = Console.ReadLine();

                if (!countryCapital.ContainsKey(newCountry))
                {
                    countryCapital[newCountry] = newCapital;
                    capitalCountry[newCapital] = newCountry;
                    countries.Add(newCountry);
                    WriteToFile("RiigidPealinnad.txt", new List<string>(countryCapital.Keys));
                }
                else
                {
                    Console.WriteLine("This country already exists in the list!");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Delete by country 1 or by capital 2");
                int deleteChoice = int.Parse(Console.ReadLine());
                if (deleteChoice == 1 || deleteChoice == 2)
                {
                    if (deleteChoice == 1)
                    {
                        Console.Write("Enter the country: ");
                        string countryToDelete = Console.ReadLine();
                        if (countryCapital.ContainsKey(countryToDelete))
                        {
                            string capitalToDelete = countryCapital[countryToDelete];
                            countryCapital.Remove(countryToDelete);
                            capitalCountry.Remove(capitalToDelete);
                            countries.Remove(countryToDelete);
                            WriteToFile("RiigidPealinnad.txt", new List<string>(countryCapital.Keys));
                        }
                        else
                        {
                            Console.WriteLine("This country is not in the list!");
                        }
                    }
                    else if (deleteChoice == 2)
                    {
                        Console.Write("Enter the capital: ");
                        string capitalToDelete = Console.ReadLine();
                        if (capitalCountry.ContainsKey(capitalToDelete))
                        {
                            string countryToDelete = capitalCountry[capitalToDelete];
                            capitalCountry.Remove(capitalToDelete);
                            countryCapital.Remove(countryToDelete);
                            countries.Remove(countryToDelete);
                            WriteToFile("RiigidPealinnad.txt", new List<string>(countryCapital.Keys));
                        }
                        else
                        {
                            Console.WriteLine("This capital is not in the list!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void Game(Dictionary<string, string> countryCapital, Dictionary<string, string> capitalCountry, List<string> countries)
    {
        int score = 0;
        double percent = 0;
        List<int> gameAnswers = new List<int>();
        Console.Write("\nChoose Country To Capital 1 or Capital To Country 2: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1 || choice == 2)
        {
            if (choice == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    int randomIndex = new Random().Next(0, countries.Count);
                    while (gameAnswers.Contains(randomIndex))
                    {
                        randomIndex = new Random().Next(0, countries.Count);
                    }
                    gameAnswers.Add(randomIndex);

                    Console.Write("Try {0}: Guess the capital of {1}?", i + 1, countries[randomIndex]);
                    string guessCapital = Console.ReadLine();
                    if (guessCapital.ToLower() == countryCapital[countries[randomIndex]].ToLower())
                    {
                        score++;
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer!");
                    }
                }
                percent = (score / 5.0) * 100;
                Console.WriteLine("Game over! Your score: {0} out of 5 turns ({1}%)", score, percent);
            }
            else if (choice == 2)
            {
                List<string> capitals = new List<string>(capitalCountry.Keys);
                for (int i = 0; i < 5; i++)
                {
                    int randomIndex = new Random().Next(0, capitals.Count);
                    while (gameAnswers.Contains(randomIndex))
                    {
                        randomIndex = new Random().Next(0, capitals.Count);
                    }
                    gameAnswers.Add(randomIndex);

                    Console.Write("Turn {0}: Guess the country of capital {1}?", i + 1, capitals[randomIndex]);
                    string guessCountry = Console.ReadLine();
                    if (guessCountry.ToLower() == capitalCountry[capitals[randomIndex]].ToLower())
                    {
                        score++;
                        Console.WriteLine("Correct answer!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer!");
                    }
                }
                percent = (score / 5.0) * 100;
                Console.WriteLine("Game over! Your score: {0} out of 5 turns ({1}%)", score, percent);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, string> countryCapital = ReadFromFile("../../../RiigidPealinnad.txt");
        Dictionary<string, string> capitalCountry = new Dictionary<string, string>();
        foreach (var item in countryCapital)
        {
            capitalCountry[item.Value] = item.Key;
        }

        List<string> countries = new List<string>(countryCapital.Keys);

        while (true)
        {
            Console.WriteLine("\nView Country or Capital - 1\nAdd/Delete Country or Capital - 2\nGame - 3\nExit - 4\n");
            Console.Write("What option do you choose? ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
            {
                if (choice == 1)
                {
                    ViewCountryCapital(countryCapital, capitalCountry);
                }
                else if (choice == 2)
                {
                    AddDeleteCountryCapital(countryCapital, capitalCountry, countries);
                }
                else if (choice == 3)
                {
                    Game(countryCapital, capitalCountry, countries);
                }
                else if (choice == 4)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
