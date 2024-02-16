
void printNumbers(int n) 
{
    if (n == 0) 
    {
        return; 
    } 
    else {
     printNumbers(n-1);
     System.Console.Write(n+" ");
    }
}
int n=Convert.ToInt32(Console.ReadLine());
printNumbers(n);