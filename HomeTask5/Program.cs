int cnt=0;
int  probel(int n)
{

    if(n==0)
    {
    return 0;
    }
    else{

        probel(n/10);
    
      return cnt++;
    }
}

probel(1234);
System.Console.WriteLine(cnt);