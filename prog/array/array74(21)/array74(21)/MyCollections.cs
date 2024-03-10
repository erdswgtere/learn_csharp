namespace MyColletions{
    public static class MyColletionList{
        public static void InputMas(ref List<int> mas, ref int x, ref int y) {
            Random rand2 = new Random();
            for (int i = 0; i < mas.Capacity; i++) {
                mas.Add(rand2.Next(x, y));
                
            }
        }
        public static void PrintMasL<T>(ref List<T> mas){
            foreach(T el in mas){
                Console.Write($"{el, 3}");
            }
        }
        public static void array74(ref List<int> mas) {
            for(int i = 0;i < mas.Capacity;i++) {
                if (mas[i] != mas[0] && mas[i] != mas[mas.Capacity - 1]) {
                    mas[i] = 0;
                }
            }
            foreach (int el in mas) {
                Console.Write($"{el,3}");
            }
        }
        public static void Shuffle<T>(this List<T> mas) {
            Random rand = new Random();
            for (int i = mas.Count - 1; i > 0; i--) {
                int k = rand.Next(i + 1);
                T tmp = mas[k];
                mas[k] = mas[i];
                mas[i] = tmp;
            }
        }
    }
}
