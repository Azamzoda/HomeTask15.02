
void printNumbers(int n) 
{
    if (n ==0) 
    {
        return; 
    } 
    else {
     System.Console.Write(n+" ");
     printNumbers(n-1);
    }
}
int n=Convert.ToInt32(Console.ReadLine());
printNumbers(n);

