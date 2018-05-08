class Program
    {
        /// <summary>
        /// execute result display
        ///  Parent.Method1
        ///  Parent.Method2
        ///  Child.Method1
        ///  Child.Method2
        ///  Parent.Protected.Method3
        ///  Child.Public.Method3
        ///  ---------------
        ///  Child.Method1
        ///  Parent.Method2
        ///  Child.Method1
        ///  Parent.Method2
        /// </summary>
        /// new 是阻断了多态的执行(表名相同的method，也可以理解为添加了一个新的method，脱离多态原则)，对于非virtual\abstract 可以添加new 
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();
            p.Method1();
            p.Method2();
            c.Method1();
            c.Method2();
            c.Method3();
            Console.WriteLine("---------------");
            Parent p2 = new Child();
            p2.Method1();
            p2.Method2();

            Parent p3 = c as Parent;
            p3.Method1();
            p3.Method2();
            Console.Read();         
        }
    }
    public class Parent
    {
        public virtual void Method1()
        {
            Console.WriteLine("Parent.Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Parent.Method2");
        }

        protected virtual void Method3()
        {
            Console.WriteLine("Parent.Protected.Method3");
        }
    }

    public class Child : Parent
    {
        public override void Method1()
        {
            Console.WriteLine("Child.Method1");
        }

        public new void Method2()
        {
            Console.WriteLine("Child.Method2");
        }

        public new void Method3()
        {
            base.Method3();
            Console.WriteLine("Child.Public.Method3");
        }
    }
