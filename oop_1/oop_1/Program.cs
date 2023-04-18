using System.Data;

namespace oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName;
            string content;
            string tempContent;
            Files files = new Files();
            int number;
            

            Console.WriteLine("Введiть назву файла: ");
            fileName = Console.ReadLine();
            files.SetName(fileName);

            do
            {
                Console.WriteLine("Виберiть пункт меню: \n 1 - Ввести вмiст файлу \n 2 - Вивести iнформацiю про файл \n 0 - Вийти з програми");
                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Введiть вмiст: ");
                        tempContent = Console.ReadLine();
                        content = files.GetContent() + tempContent;
                        files.SetContent(content);
                        break;
                    case 2:
                        Console.WriteLine("Iмя файлу: " + files.GetName());
                        Console.WriteLine("Розмiр файлу: " + files.GetSize() + " бiт");
                        Console.WriteLine("Дата Створення: " + files.GetDateTime());
                        Console.WriteLine(files.GetContent());
                        break;
                    case 0:
                        number = 0;
                        break;
                }
            }
            while (number != 0);
            
               
            


        }
    }

    public class Files
    {
        string name;
        string content;
        int size;
        DateTime dateTime;

        public Files() 
        {
            dateTime = DateTime.Now;
        }
        public string GetName()
        {
            return name;
        }

        public int GetSize()
        {
            
            int temp;

            char[] a = content.ToCharArray();
            temp = a.Length;
            return temp;
        }

        public string GetContent() 
        {
            return content;
        }

        public DateTime GetDateTime()
        {
            return dateTime;
        }

        public void SetName(string name)
        {   
                this.name = name;
        }

        public void SetContent(string str) 
        {
            content = str;
        }



    }   
}