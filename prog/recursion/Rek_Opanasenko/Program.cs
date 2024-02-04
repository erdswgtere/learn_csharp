static ulong F(ulong x){
    if (x<=15)
        return x * x + 3 * x + 9;
    else if (x>15 && x % 3 == 0)
            return F(x - 1) + x - 2;
        else
            return F(x - 2) + x + 2;
}
int k=0;
for (uint i = 1; i < 1000; i++){
    ulong d = F(i);
    bool r=true;
    while (d != 0){
        if (d % 2 == 0){
           d /= 10;
        }else{
            r=false;
            break;
        }
    }
    if (r==true) k++;
}
Console.WriteLine(k);