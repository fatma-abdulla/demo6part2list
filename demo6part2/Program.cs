
//using System.Collections;
//ArrayList list = new ArrayList();
////add element to list  add +insert+remove 

//list.Add(5);
//list.Insert(1,"good");
//list.Add("fatma");
//list.Add((true));
//list.Add("damra");

///peint all element

//foreach (var elementt in list)
//{
//    Console.WriteLine(elementt);

//}
//Console.WriteLine("list");
//Console.WriteLine(list[0]);


using System.Collections;
using System.ComponentModel.Design.Serialization;

ArrayList list2 = new ArrayList();
list2.Add(5);
list2.Add(true);
list2.Add("maryam");
list2.Insert(3, "sara");
list2.Remove(0);
list2.Add("fatma");
list2.Insert(5, "good");
list2.Add("ahmad");
list2.Add(2);
list2.RemoveAt(2);


foreach (var elementt in list2)
    { Console.WriteLine(elementt); 

}


Console.WriteLine("-------------------------------------------------------------");
//task3

ArrayList list3 = new ArrayList();

list3.Add("css");
list3.Add("HTML");
list3.Add("JAVA");
list3.Add("c#");
list3.Add("c++");
list3.Add("python");


Console.WriteLine("enter your langguge");
string s=Console.ReadLine().ToLower();


   if(list3.Contains(s))
    {
       /// indexof is the location of the iteme in the list 
        Console.WriteLine("Exist"+list3.IndexOf(s));
    }

//number of item in the list 

Console.WriteLine("Number of item: " + list3.Count);


