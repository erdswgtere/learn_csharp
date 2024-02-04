double x, y;
Console.Write("x = ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
y = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка находится в ");
if(x > 0) {
    if(y > 0){
        Console.Write("I четверти");
    } else{
        Console.Write("IV четверти");
    }
} else {
    if(y > 0){
        Console.Write("II четверти");
    } else {
        Console.Write("III четверти");
    }

}
