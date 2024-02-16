
void even(int a, int b)
{
    if (a==b)
    {
        return;
        
    }
    else {
        
        if (a%2==0){
            System.Console.Write(a + " ");
        }
         even(a+1,b);
    }
    
}
System.Console.WriteLine();
void Odd(int a, int b)
{
    if (a==b)
    {
        return;
        
    }
    else {
        
        if (a%2!=0){
            System.Console.Write(a + " ");
        }
         Odd(a+1,b);
    }
    
    
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"All even numbers from 1 to 20 are :");
even(a,b);
System.Console.WriteLine();
System.Console.WriteLine($"All odd numbers from 1 to 20 are :");
Odd(a,b);