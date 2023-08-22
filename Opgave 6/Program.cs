using Opgave_6;

MyList list = new MyList();
MyList list2 = new MyList();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);

Console.WriteLine("List 1:");
list.printNumbers();
Console.WriteLine("List 2:");
list2.addRandomNumbers();
list2.printNumbers();
