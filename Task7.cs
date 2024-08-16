using System;
using System.Threading;
public class ExThread
{
    public void Mythread1()
    {
        for(int z=0;z<3;z++)
        {
            Console.WriteLine("First Thread");
        }
    }
}
public class thread
{
    public static void Main(string[] args)
    {
        ExThread obj=new ExThread();
        Thread thr=new Thread(new ThreadStart(obj.Mythread1));
        thr.Start();
        Console.WriteLine("Thread is abort");
        thr.Abort();
    }
}