
// namespace MyPractice
// {
//     interface IMovable
//     {
//         void Move();
//     }
//     interface ISound
//     {
//         public abstract void MakeSound();
//     }
//     abstract class Animal : IMovable, ISound
//     {
//         protected string name = string.Empty;
//         protected int age;
//         public Animal()
//         {

//         }

//         public Animal(string name, int age)
//         {
//             this.Name = name;
//             this.Age = age;
//         }
//         public string Name
//         {
//             get { return name; }
//             set { name = value ?? string.Empty; }
//         }

//         public int Age
//         {
//             get { return age; }
//             set
//             {
//                 if (value < 0)
//                 {
//                     Console.WriteLine("VALUE INVALID");
//                 }
//                 else
//                 {
//                     age = value;
//                 }
//             }
//         }
//         public abstract void Speak();

//         public virtual void Move()
//         {
//             Console.WriteLine($"{Name} is moving...");
//         }
//         public abstract void MakeSound();
//     }



//     class Dog : Animal
//     {
//         public override void Speak()
//         {
//             Console.WriteLine($"{this.Name} sủa");
//         }

//         public override void Move()
//         {
//             Console.WriteLine($"{this.Name} DI CHUYỂN BẰNG 4 CHÂN");
//         }

//         public override void MakeSound()
//         {
//             Console.WriteLine($"{this.Name} tạo tiếng ồn");
//         }
//     }

//     class Cat : Animal
//     {
//         public Cat(string name, int age) : base(name, age)
//         {
//         }

//         public override void Speak()
//         {
//             Console.WriteLine($"{Name} meow");
//         }

//         public override void MakeSound()
//         {
//             Console.WriteLine($"{this.Name} brr brr");
//         }
//     }

//     class Bird : Animal
//     {

//         public Bird(string name, int age) : base(name, age)
//         {

//         }
//         public void Fly()
//         {
//             Console.WriteLine($"{Name} flies");
//         }
//         public override void Speak()
//         {
//             Console.WriteLine($"{Name} chíp");
//         }
//         public override void MakeSound()
//         {
//             Console.WriteLine($"{this.Name} chip chip");
//         }
//     }

//     class Run
//     {
//         static void Main(string[] args)
//         {
//             Animal dog = new Dog();
//             dog.Name = "Vinh Phung";
//             dog.Age = 31;
//             Animal cat = new Cat("WEE", 3);
//             Animal bird = new Bird("Katt", 4);
//             List<IMovable> movables = new List<IMovable>();
//             movables.Add(dog);
//             movables.Add(cat);
//             movables.Add(bird);
//             dog.Speak();
//             cat.Speak();
//             dog.MakeSound();
//             cat.MakeSound();

//             foreach(IMovable i in movables)
//             {
//                 i.Move();
//             }
//         }
//     }
// }