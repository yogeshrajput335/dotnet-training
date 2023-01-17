namespace InheritanceUniverse
{
    public class ClassA {
        public string value = "CLASS A";
        public void DisplayA(){
            Console.WriteLine("This is class A");
        }
    }
    
    
    public class ClassB  {
        public int age = 10;
        public void DisplayB(){
            Console.WriteLine("This is class B");
        }
    }

    public class ClassC : ClassA {
        public int age = 10;
        public void DisplayB(){
            Console.WriteLine("This is class B");
        }
    }
}