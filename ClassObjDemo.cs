namespace dotnetTraining{
    public class A {
        public A(){

        }
        public int i =10;
    }

    public class B{
        public B(){
            
        }
        public static void UseA(){
            A a = new A();
            Console.WriteLine(a.i);
        }
    }
}