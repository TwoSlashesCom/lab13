using lab13;

DoublyLinkedList linkedList = new DoublyLinkedList();

linkedList.AddLast(int.Parse(Console.ReadLine()));
linkedList.AddLast(int.Parse(Console.ReadLine()));

string str;

while ((str = Console.ReadLine()) != "")
{
    int number = int.Parse(str);

    if (Math.Abs(number - linkedList.GetFirst()) < Math.Abs(number - linkedList.GetLast()))
    {
        linkedList.AddFirst(number);
    }

    else
    {
        linkedList.AddLast(number);
    }
}

Console.WriteLine(linkedList.ToString());

//linkedList.Add(10);
//linkedList.Add(23);
//linkedList.Add(31);
//linkedList.AddFirst(0);
//foreach (var item in linkedList)
//{
//    Console.WriteLine(item);
//}

//linkedList.Remove(2);

//foreach (var t in linkedList.BackEnumerator())
//{
//    Console.WriteLine(t);
//}
//Console.WriteLine(linkedList.Count);    
