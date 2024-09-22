/*****************************************************
******************************************************
**                                                  **
**  Программа обработки исключений в задачах        **
**  на примере работы с файлами                     **
**  Задача: Найти длину самой длинной строки.       **
**                                                  **
**  Выполнил: студент 3 курса ЕПК гр. И-32          **
**  Синицын М.В                                     **
**  Проверил: преподаватель "Поддержка и            **
**  тестирование программных модулей" Фомин А. Т.   **
**                                                  **
******************************************************
*****************************************************/
internal class Program{
    public static void Main(){
        while(true){         
            try{
                string path = "file.txt";
                FileInfo fileInfo = new FileInfo(path); 
                int kolString = 0;
                if(!fileInfo.Exists){
                    Console.Write("Введите количество строк в файле: ");
                    kolString = Convert.ToInt32(Console.ReadLine());
                }
                var methodComplete = Task.Run(()=>{
                FindLongString(fileInfo, path, kolString);
                });
                methodComplete.Wait();
                break;
            }
            catch(AggregateException ex){
                Console.WriteLine($"Ошибка! {ex.Message}");
            }
        }
    }
    static Random rnd = new Random();
    public static void FindLongString(FileInfo fileInfo, string path, int kolString){
        int stringLenght = 0;
        int strnum = 0;
        if(fileInfo.Exists){
            string[] strings = File.ReadAllLines(path);
            for(int i = 0; i<strings.Length; i++){
                if(strings[i].Length > stringLenght){
                    stringLenght = strings[i].Length;
                }
            }
            for(strnum = 0; strnum<strings.Length; strnum++){
                if(strings[strnum].Length == stringLenght){
                    break;
                }
            }
            
        }else{
            for(int i = 0; i < kolString;i++){
                File.AppendAllText(path,$"{GetRandomString(rnd.Next(0, 100))}\n");         
            }
            string[] strings = File.ReadAllLines(path);
            for(int i = 0; i<kolString; i++){
                if(strings[i].Length > stringLenght){
                    stringLenght = strings[i].Length;
                }
            }
            for(strnum = 0; strnum<kolString; strnum++){
                if(strings[strnum].Length == stringLenght){
                    break;
                }
            }
        }
        Console.WriteLine($"Самое длинная строка это строка №{strnum} и её длинна равна: {stringLenght}");
    }
   
        static string GetRandomString(int pwdLength)
        {   
            const string ch = "qwertyuiopasdfghjklzxcvbnm0123456789";
            char[] letters = ch.ToCharArray();            
            string s = "";
            for (int i = 0; i < pwdLength; i++)
            {
                s+=letters[rnd.Next(letters.Length)].ToString();
            }
            return s;
        }
}