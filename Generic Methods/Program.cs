using System;

//ref link:https://www.youtube.com/watch?v=MW65bc_EWt8&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=4
//

class List<T> // List structure that can take any generic type
{
    T[] ints = new T[3];
    int currentIndex;

    public void Add(T i)
    {
        if (currentIndex == ints.Length)
            Grow();
        ints[currentIndex++] = i;
    }

    public T Get(int index)
    {
        return ints[index];
    }
    void Grow()
    {
        T[] temp = new T[ints.Length * 2];
        Array.Copy(ints, temp, ints.Length);
        ints = temp;
    }

    public int Length { get { return ints.Length; } }

}

class MainClass
{   // Generic Method
    static void PrintItems<T>(List<T> items)
    {
        for (int i = 0; i < items.Length; i++)
            Console.WriteLine(items.Get(i));
    }
    static void P<T>(T item)
    {
        Console.WriteLine(item);
    }
    static void Main()
    {
        P(5);   // instead of Console.WriteLine(5);
        P("Kulpot");
        //ListInt myInts = new ListInt();
        //List<int> myInts = new List<int>();
        //myInts.Add(12); myInts.Add(25); myInts.Add(92);
        //myInts.Add(5);
        //for (int i = 0; i < myInts.Length; i++)
        //Console.WriteLine(myInts.Get(i));
        //PrintItems(myInts);
        //List<string> myStrings = new List<string>();
        //myStrings.Add("Bob");
        //myStrings.Add("Suzy");
        //myStrings.Add("Fred");
        //for (int i = 0; i < myStrings.Length; i++)
        //Console.WriteLine(myStrings.Get(i));
        //PrintItems(myStrings);
    }
}