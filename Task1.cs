using System;
public class p1{
    public static void Main(string[] args){
        int n,rev=0,temp;
        Console.WriteLine("Enter a number: ");
        n=Convert.ToInt32(Console.ReadLine());
        temp=n;
        while(n>0)
        {
            rev=rev*10+n%10;
            n=n/10;
        }
        if(temp==rev)
        Console.Write("Palindrome");
        else
        Console.Write("Not a palindrome");
    }
}