using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class DisplayNumber
    {
        Queue<int> queue1 = new Queue<int>();
        int[] arr;
        List<int> list1 = null;
        Dictionary<int, int> dict1 = null;
        public void StartProg()
        {
            int valueEntered;
            do
            {
                Console.WriteLine("Enter value");
                valueEntered = int.Parse(Console.ReadLine());
                queue1.Enqueue(valueEntered);

            } while (valueEntered != -1);

            if (valueEntered == -1)
            {
                FillCollection();
                DisplayResult();
            }
        }

        public void FillCollection()
        {
            arr = new int[queue1.Count];
            list1 = new List<int>();
            dict1 = new Dictionary<int, int>();

            for(int i =0; i<queue1.Count-1;i++)
            {
                int temp = queue1.Dequeue();
                arr[i] = temp;
                list1.Add(temp);
                dict1.Add(i, temp);
            }
           
        }

        public void DisplayResult()
        {
            for (int i = 0; i < arr.Length ; i++)
            {
                var arrayValue = arr[i];
                var listValue = list1[i];
                var dictValue = dict1[i];

                arr[i] = queue1.Dequeue();

                list1.Add(i);
                dict1.Add(i, queue1.Dequeue());
            }

        }
    }

}
