using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9310_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q;

            //1
            q = Arr2Q(new int[] { 0, 9, 1, 7, 3, 9, 1, 3, 2, 1 });
            Console.WriteLine(Max2Digit(q));
            q = Arr2Q(new int[] { 0, 0, 1, 4, 3, 3, 1, 3, 2, 8 });
            Console.WriteLine(Max2Digit(q));

            //2
            q = Arr2Q(new int[] { 17, 1, 17, 2, 7, 6, 36, 2, 1, 2, 5, 5 });
            RemoveDups(q);
            Console.WriteLine(q);

            //3
            q = Arr2Q(new int[] { 2, 4, 1, 5, 2, 8, 9, 1, 5, 7 });
            Console.WriteLine(QCouples(q));

            //4
            q = Arr2Q(new int[] { 2, 3, 5, 8, 13, 4, 4, 8, 3, 6, 9, 15 });
            Console.WriteLine(FibSeq(q));

            //5
            q = Arr2Q(new int[] { 20, 5, 2, 1, 2, 36, 6, 3, 2, 17, 1, 17 });
            Console.WriteLine(ProductsQ(q));
            q = Arr2Q(new int[] { 20, 5, 2, 3, 17, 1, 17 });
            Console.WriteLine(ProductsQ(q));
            q = Arr2Q(new int[] { 20, 5, 2, 3 });
            Console.WriteLine(ProductsQ(q));

            //6
            Queue<char> q1 = Arr2Q(new char[] { 'f', 'e', 'e', 'e', 'e', 'd', 'c', 'c', 'b', 'b', 'b' });
            Console.WriteLine(Pairs(q1));
            Console.WriteLine(q1);

        }

        static Queue<T> Arr2Q<T>(T[] arr)
        {
            Queue<T> q = new Queue<T>();
            foreach (T value in arr)
                q.Insert(value);
            return q;
        }

        //1
        //input: queue of digits (0-9)
        //output: max 2 digit number which can be composed of the digits
        //assume: at least 2 digits
        //example: 0, 9, 1, 7, 3, 9, 1, 3, 2, 1   return 99
        //example: 0, 0, 1, 4, 3, 3, 1, 3, 2, 8   return 84
        //cannot use array, don't need to restore Q
        //what is the complexity?

        static int Max2Digit(Queue<int> q)
        {
            return 0;
        }


        //2
        //input: queue of ints
        //output: void, queue is without duplicates
        //example: queuehead = [17,1,17,2,7,6,36,2,1,2,5,5] -> queuehead = [17,1,2,7,6,36,5] 
        //cannot use array
        //what is the complexity?

        static void RemoveDups(Queue<int> q) //O(n^2)
        {

        }

        //3
        //input: queue of ints
        //output: new queue, with only the ints which appear EXACTLY twice
        //example: queuehead = [2,4,1,5,2,8,9,1,5,7], new queuehead = [2,1,5] 
        //notes: no need to restore original q
        //what is the complexity?

        static Queue<int> QCouples(Queue<int> q)
        {
            return null;
        }

        //4
        //input: queue of ints, made from Fibonacci sequences (no gaps). Minimum queue length = 2
        //output: new queue, with Fibonacci sequence lengths
        //example: queuehead = [2,3,5,8,13,4,4,8,3,6,9,15], new queuehead = [5,3,4] 
        //notes: no need to restore original q, each sub sequence at least length 2
        //tip: what's the minimum sequence length?
        //what is the complexity?
        static Queue<int> FibSeq(Queue<int> q)
        {
            return null;
        }


        //5
        //input: queue of ints, minimum length = 2
        //output: True, if the first number in a sequence = multiplication of the following numbers
        //example: queuehead = [20,5,2,1,2,36,6,3,2,17,1,17], return: true
        //example: queuehead = [20,5,2,3,17,1,17], return: false
        //example: queuehead = [20,5,2,3], return: false
        //notes: no need to restore original q
        //שימו לב, מכפלה באנגלית זה product
        //what is the complexity?

        static bool ProductsQ(Queue<int> q)
        {
            return false;
        }

        //6
        //input: queue of chars (q)
        //output: new queue of chars. only chars from q which are equal to the following char are copied
        //example: queuehead = ['f','e','e','e','e','d','c','c','b','b','b'], return: queuehead['e','e','e','c','b','b']
        //note: last char in q has no following char, so not copied to new queue
        //need to restore queue
        //what is the complexity?

        static Queue<char> Pairs(Queue<char> q)
        {
            return null;
        }


    }
}
