// See https://aka.ms/new-console-template for more information

using Object_Oriented_Assignment_Animals;


Cat cat = new Cat(0);
Console.WriteLine("cat:");
Console.WriteLine("carnivorous" + cat.isCarnivorous());
Console.WriteLine("mammals" + cat.isMammals());
Console.WriteLine("legs" + cat.GetNumberOfLegs());
Console.Write("hello:");
cat.sayHello();
Console.Write("happy");
cat.sayHello(0);
Console.Write("scared");
cat.sayHello(1);

Console.WriteLine();
Dog dog = new Dog(0);
Console.WriteLine("dog:");
Console.WriteLine("carnivorous" + dog.isCarnivorous());
Console.WriteLine("mammals" + dog.isMammals());
Console.WriteLine("legs" + dog.GetNumberOfLegs());
Console.Write("hello:");
dog.sayHello();
Console.Write("happy");
dog.sayHello(0);
Console.Write("scared");
dog.sayHello(1);

Console.WriteLine();
Frog frog = new Frog(0);
Console.WriteLine("frog:");
Console.WriteLine("carnivorous" + frog.isCarnivorous());
Console.WriteLine("mammals" + frog.isMammals());
Console.WriteLine("legs" + frog.GetNumberOfLegs());
Console.WriteLine("has gills" + frog.hasGills());
Console.WriteLine("lats eggs" + frog.hasLaysEggs());
Console.Write("hello:");
frog.sayHello();
Console.Write("happy");
frog.sayHello(0);
Console.Write("scared");
frog.sayHello(1);


