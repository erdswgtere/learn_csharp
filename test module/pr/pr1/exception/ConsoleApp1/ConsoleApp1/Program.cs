namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            while (true) {
                try {
                    Console.Write("Введите русские буквы: ");
                    string s = Console.ReadLine();
                    string result = UpCaseRus(s);
                    Console.WriteLine("Результат: " + result);
                }
                catch (FormatException) {
                    Console.WriteLine("Это НЕ буква!!!\n");
                    continue;
                }
                break;
            }
            Console.WriteLine();
            
        }

        static string UpCaseRus(string s) {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] >= 'а' && arr[i] <= 'я' || arr[i] == 'ё' ||
                    arr[i] >= 'А' && arr[i] <= 'Я' || arr[i] == 'Ё')
                    arr[i] = arr[i].ToString().ToUpper()[0];
                else if(arr[i] >= 'a' && arr[i] <= 'z' ||
                        arr[i] >= 'А' && arr[i] <= 'Z' ) {
                  arr[i] = arr[i].ToString()[0];
                }
                else
                    throw new FormatException();
            }
            return new string(arr);
        }
    }
}
