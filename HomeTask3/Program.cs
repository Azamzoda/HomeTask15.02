
int  printNumbers(int n) 
{
    if (n ==0) 
    {
        return 0; 
    } 
    else {
     return printNumbers(n-1)+n;
    }
}
int n=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(printNumbers(n));
