

void probel(int n)
{
    if(n==0)
    {
        return ;
    }
    else{
        probel(n/10);
        Console.Write(n%10 +" ");
    }
}

int n=Convert.ToInt32(Console.ReadLine());
probel(n);
