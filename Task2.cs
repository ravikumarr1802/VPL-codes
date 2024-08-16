using System;
public class Cal{
    public static int add(int a,int b){
        return(a+b);
    }
    public static int add(int a,int b,int c){
        return(a+b+c);
    }
}
public class OverLoading{
    public static void Main(string[] args){
        Console.WriteLine(Cal.add(10,20));
        Console.WriteLine(Cal.add(10,11,12));
    }
}