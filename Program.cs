using System;

class Program{

    static void Main(string[] args){

        string degisken = "Dersimiz CSharp, Hoşgeldiniz";
        string degisken2 = "CSharp";

        //Lenght
        Console.WriteLine(degisken.Length);

        //ToUpper , ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat
        Console.WriteLine(string.Concat(degisken, "Merhaba"));

        //Compare ,CompareTo

        Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
        Console.WriteLine(String.Compare(degisken,degisken2,true));
        Console.WriteLine(String.Compare(degisken,degisken2,false));

        //Contains
        Console.WriteLine(degisken.Contains(degisken2));
        Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
        Console.WriteLine(degisken.StartsWith("Merhaba"));

        //IndexOf
        Console.WriteLine(degisken.IndexOf("CS"));
        Console.WriteLine(degisken.IndexOf("Zikriye"));
        Console.WriteLine(degisken.LastIndexOf("i"));

        //Insert

        Console.WriteLine(degisken.Insert(0,"Merhaba"));

        //padLeft ,PadRight

        Console.WriteLine(degisken + degisken2.PadLeft(30));
        Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
        Console.WriteLine(degisken.PadRight(50) + degisken2);
        Console.WriteLine(degisken.PadRight(50,'-')+ degisken2);

        //remove
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(5,3));
        Console.WriteLine(degisken.Remove(0,1));

        //replace

        Console.WriteLine(degisken.Replace("CSharp","C#"));
        Console.WriteLine(degisken.Replace(" ","*"));

        //split
        Console.WriteLine(degisken.Split(' ')[1]);









    }
}