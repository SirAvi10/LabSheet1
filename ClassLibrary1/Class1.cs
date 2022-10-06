using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int mark;
        public int index;
        public Class1()
        {
            mark = 0;
            index = 0;
        }

        public void Start()
        {
            do
            {
                Console.Clear();
                Display();
                mark = int.Parse(Console.ReadLine());
                Result();

            } while (mark != -1);

            Environment.Exit(0);
        }
        private void Result()
        {
            index = 0;
            foreach (var i in Enum.GetValues(typeof(Category)))
            {
                if (mark <= (int)i && mark >= index)
                {
                    Console.WriteLine("Category is " + i);

                    Console.ReadLine();
                }
                index = (int)i + 1;
            }
        }
        private void Display()
        {
            index = 0;
            foreach (var i in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine("Category: " + i + " - has range " + index + " - " + (int)i);
                index = (int)i + 1;
            }
        }
    }
}
