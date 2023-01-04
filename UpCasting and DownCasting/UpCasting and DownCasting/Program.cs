


using UpCasting_and_DownCasting.Models;

#region UpCasting DownCasting


//Salmon salmon1 = new Salmon();
//Eagle eagle1 = new Eagle();

//Animal animal1 = eagle1;

//animal1.Sound();

//animal1.Test();

//Console.WriteLine(animal1.Speed);



//Animal animal3 = new Salmon();

//Animal animal2 = salmon1;

//Bird bird = new Bird();






//Animal animal = new Animal();
//Bird bird1 = new Bird();

//salmon1.Sound();
//eagle1.Sound();
//animal1.Sound();
//bird1.Sound();





//Eagle eagle1 = new Eagle();

//Animal animal1 = new Animal();

//Eagle eagle2 = (Eagle) animal1;


#endregion

#region Boxing Am Boxing

//string str = "Mizo";

//Object obj1 = str;

//string name = obj1.ToString();




//int num1 = 55;

//object obj1 = num1;

//int num3 = (int)obj1;





//string str = "100";

//object obj1 = str;

//int num3 = (int)obj1;

//var result = int.Parse(str);





//bool isMarried = false;

//object obj1 = isMarried;

//bool result = (bool)obj1;

//Console.WriteLine(result);

#endregion

#region Implisit Explisit

//byte num1 = 22;

//int num2 = num1;




//int num1 = 120;

//byte num2 =(byte) num1;

//Console.WriteLine(num2);




//byte num3 = 55;

//int num4 = num3;

//Console.WriteLine(num4);






//Bird bird = new Bird();

//Fish fish = new Fish();

//Animal animal1 = new Bird();

//Animal animal2 = new Fish();



//object[] objects = { 1, 2, "Salam", "Eleykum", bird, fish, "Saqol", animal1, animal2 };



//foreach (var item in objects)
//{
//	if (item is Animal)
//	{
//		((Animal)item).Name = "test";

//		Console.WriteLine(((Animal)item).Name);
//	}
//	else
//	{
//		Console.WriteLine(item);
//	}
//}


//foreach (var item in objects)
//{
//    Animal animal = item as Animal;

//    if (animal != null)
//    {
//        animal.Name = "Vav";

//        Console.WriteLine(animal.Name);
//    }
//    else
//    {
//        Console.WriteLine(item);
//    }
//}



#endregion







