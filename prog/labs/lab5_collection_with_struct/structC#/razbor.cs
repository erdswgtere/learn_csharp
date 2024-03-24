using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_19_La6a
{
    using System;
    using System.Collections.Generic;

    struct FurnitureRecord
    {
        public DateTime DateStart;   // дата покупки мебели
        public DateTime DateEndOfWarranty;   // дата окончания гарантии
        public string UserName;     // имя покупателя
        public string UserSurname;   // фамилия покупателя
        public long UserCode;     // уникальный код покупателя
        public string FurnitureTitle;     // название мебели
        public string FurnitureFactory;     // название изготовителя мебели
        public string FurnitureCode;     // уникальный код мебели
    }

    class Program
    {
        static List<FurnitureRecord> furnitureList = new List<FurnitureRecord>();
        static Queue<FurnitureRecord> furnitureQueue = new Queue<FurnitureRecord>();
        static LinkedList<FurnitureRecord> furnitureLinkedList = new LinkedList<FurnitureRecord>();

        static void Main()
        {
            Console.WriteLine("Программа учета мебели и оргтехники");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите вариант:");
                Console.WriteLine("1. Добавить запись");
                Console.WriteLine("2. Удалить запись");
                Console.WriteLine("3. Редактировать запись");
                Console.WriteLine("4. Поиск информации");
                Console.WriteLine("5. Вывести все записи");
                Console.WriteLine("6. Выход");

                int choice = ReadIntFromConsole(1, 6);

                switch (choice)
                {
                    case 1:
                        AddFurniture();
                        break;
                    case 2:
                        RemoveFurniture();
                        break;
                    case 3:
                        EditFurniture();
                        break;
                    case 4:
                        SearchInformation();
                        break;
                    case 5:
                        PrintAllFurniture();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static void AddFurniture()
        {
            Console.WriteLine("Добавление записи");
            FurnitureRecord furniture = ReadFurnitureData();
            furnitureList.Add(furniture);
            furnitureQueue.Enqueue(furniture);
            furnitureLinkedList.AddLast(furniture);
            Console.WriteLine("Запись успешно добавлена.");
        }

        static void RemoveFurniture()
        {
            Console.WriteLine("Удаление записи");
            Console.WriteLine("Введите уникальный код мебели для удаления:");
            string furnitureCode = Console.ReadLine();

            bool removedFromList = furnitureList.RemoveAll(f => f.FurnitureCode == furnitureCode) > 0;
            bool removedFromQueue = false;
            bool removedFromLinkedList = false;

            if (removedFromList)
            {
                while (furnitureQueue.Count > 0)
                {
                    var currentItem = furnitureQueue.Dequeue();
                    if (currentItem.FurnitureCode == furnitureCode)
                    {
                        removedFromQueue = true;
                    }
                    else
                    {
                        furnitureQueue.Enqueue(currentItem);
                    }
                }

                var currentNode = furnitureLinkedList.First;
                while (currentNode != null)
                {
                    if (currentNode.Value.FurnitureCode == furnitureCode)
                    {
                        var nodeToRemove = currentNode;
                        currentNode = currentNode.Next;

                        furnitureLinkedList.Remove(nodeToRemove);
                        removedFromLinkedList = true;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                    }
                }
            }

            if (removedFromList && removedFromQueue && removedFromLinkedList)
            {
                Console.WriteLine("Запись успешно удалена.");
            }
            else
            {
                Console.WriteLine("Запись не найдена.");
            }
        }

        static void EditFurniture()
        {
            Console.WriteLine("Редактирование записи");
            Console.WriteLine("Введите уникальный код мебели для редактирования:");
            string furnitureCode = Console.ReadLine();

            FurnitureRecord furniture = furnitureList.Find(f => f.FurnitureCode == furnitureCode);
            if (furniture.Equals(default(FurnitureRecord)))
            {
                Console.WriteLine("Запись не найдена.");
            }
            else
            {
                Console.WriteLine("Исходные данные:");
                PrintFurniture(furniture);

                FurnitureRecord newFurniture = ReadFurnitureData();
                int index = furnitureList.FindIndex(f => f.FurnitureCode == furnitureCode);
                furnitureList[index] = newFurniture;

                var currentNode = furnitureLinkedList.First;
                while (currentNode != null)
                {
                    if (currentNode.Value.FurnitureCode == furnitureCode)
                    {
                        currentNode.Value = newFurniture;
                        break;
                    }
                    currentNode = currentNode.Next;
                }

                Console.WriteLine("Запись успешно отредактирована.");
                Console.WriteLine("Обновленные данные:");
                PrintFurniture(newFurniture);
            }
        }

        static void SearchInformation()
        {
            Console.WriteLine("Поиск информации");
            Console.WriteLine("Введите уникальный код покупателя:");
            long userCode = long.Parse(Console.ReadLine());

            Console.WriteLine("Результаты поиска:");
            List<FurnitureRecord> results = furnitureList.FindAll(f => f.UserCode == userCode);
            if (results.Count == 0)
            {
                Console.WriteLine("Нет записей, связанных с указанным кодом покупателя.");
            }
            else
            {
                foreach (var furniture in results)
                {
                    PrintFurniture(furniture);
                }
            }
        }

        static void PrintAllFurniture()
        {
            Console.WriteLine("Все записи:");
            foreach (var furniture in furnitureList)
            {
                PrintFurniture(furniture);
            }
        }

        static void PrintFurniture(FurnitureRecord furniture)
        {
            Console.WriteLine($"Дата покупки: {furniture.DateStart}");
            Console.WriteLine($"Дата окончания гарантии: {furniture.DateEndOfWarranty}");
            Console.WriteLine($"Имя покупателя: {furniture.UserName}");
            Console.WriteLine($"Фамилия покупателя: {furniture.UserSurname}");
            Console.WriteLine($"Уникальный код покупателя: {furniture.UserCode}");
            Console.WriteLine($"Название мебели: {furniture.FurnitureTitle}");
            Console.WriteLine($"Название изготовителя мебели: {furniture.FurnitureFactory}");
            Console.WriteLine($"Уникальный код мебели: {furniture.FurnitureCode}");
            Console.WriteLine();
        }

        static FurnitureRecord ReadFurnitureData()
        {
            Console.WriteLine("Введите данные о мебели:");
            Console.Write("Дата покупки: ");
            DateTime dateStart = DateTime.Parse(Console.ReadLine());
            Console.Write("Дата окончания гарантии: ");
            DateTime dateEndOfWarranty = DateTime.Parse(Console.ReadLine());
            Console.Write("Имя покупателя: ");
            string userName = Console.ReadLine();

            Console.Write("Фамилия покупателя: ");
            string userSurname = Console.ReadLine();
            Console.Write("Уникальный код покупателя: ");
            long userCode = long.Parse(Console.ReadLine());
            Console.Write("Название мебели: ");
            string furnitureTitle = Console.ReadLine();
            Console.Write("Название изготовителя мебели: ");
            string furnitureFactory = Console.ReadLine();
            Console.Write("Уникальный код мебели: ");
            string furnitureCode = Console.ReadLine();

            return new FurnitureRecord
            {
                DateStart = dateStart,
                DateEndOfWarranty = dateEndOfWarranty,
                UserName = userName,
                UserSurname = userSurname,
                UserCode = userCode,
                FurnitureTitle = furnitureTitle,
                FurnitureFactory = furnitureFactory,
                FurnitureCode = furnitureCode
            };
        }

        static int ReadIntFromConsole(int minValue, int maxValue)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value) && value >= minValue && value <= maxValue)
                {
                    return value;
                }
                Console.WriteLine($"Ожидалось целое число от {minValue} до {maxValue}.");
            }
        }
    }
}