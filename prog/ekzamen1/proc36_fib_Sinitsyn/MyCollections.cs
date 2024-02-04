namespace MyColletions{
    public static class MyColletionList{
        public static void InputMasInt10(ref int[] mas){
            for (int i = 0; i < mas.Length; i++){
                mas[i] = i + 10;
            }
        }
        public static void PrintMasL<T>(ref List<T> mas){
            foreach(T el in mas){
                Console.Write($"{el, 3}");
            }
        }
        public static void FoundUnsuccessStudL<T>(ref List<T> mas){
            int k = 0;
            foreach(T el in mas){
                if(Convert.ToInt32(el) == 2){
                    k++;
                }
            }
            Console.WriteLine($"Кол-во неуспевающих: {k}");
        }
        private static Random rand = new Random();
        public static void Shuffle<T>(this List<T> mas){
            for(int i = mas.Count - 1; i > 0; i--){
                int k = rand.Next(i + 1);
                T tmp = mas[k];
                mas[k] =  mas[i];
                mas[i] = tmp;
            }
        } 
    }
}
