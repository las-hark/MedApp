using System;
namespace LineApplication
{
    class Agesetting
    {
        private int age;
        public Agesetting()
        {
            Console.WriteLine("感谢使用");
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            { age = value; }
        }
    }
    class test
    { 
        static void Main(string[] args)
        {
            Agesetting ageset = new Agesetting();
            ageset.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age is "+ageset.Age);
        }
    }
}