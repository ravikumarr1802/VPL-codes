using System;
namespace Program;
public class Program{
    public int id;
    public string name;
    public float salary;
    public void insert(int i,string n,float s)
    {
        id=i;
        name=n;
        salary=s;
    }
    public void display()
    {
        Console.WriteLine(id+" "+name+" "+salary);
    }
}
class Demo{
    public static void Main(string[] args){
        Program p1=new Program();
        Console.WriteLine("Enter employ no:");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter employ name:");
        string b=Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter employ salary:");
        float c=float.Parse(Console.ReadLine());
        p1.insert(a,b,c);
        p1.display();
    }
}
