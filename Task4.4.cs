using System;
public class Father{
    public static string Fname(){
        return "Ravi";
    }
}
public class FC:Father{
    public static string CName(){
        return "Rohan";
    }
}
public class SC:Father{
    public static string CName(){
        return "Nikhil";
    }
}
public class Inheritance4{
    public static void Main(string[] args){
        Console.WriteLine("My Name is: "+FC.CName()+"\nMy Father Name is: "+FC.Fname());
        Console.WriteLine("My Name is: "+SC.CName()+"\nMy Father Name is: "+SC.Fname());
    }
}