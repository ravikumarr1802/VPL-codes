using System;
using System.Text;
class Program{
    public static void concat1(string s1){
        string s="To C#.net LAB";
        s1=string.Concat(s,s1);
    }
    public static void concat2(StringBuilder s1){
        s1.Append("To C#.net LAB");
    }
    public static void Main(){
        string s1="Welcome";
        StringBuilder s2=new StringBuilder("Welcome");
        concat1(s1);
        concat2(s2);
        Console.WriteLine("String: "+s1);
        Console.WriteLine("StringBuilder: "+s2);
    }   
}
