using System;

namespace Tasks
{
     // reverse string
 
     /*public static class Task1
     {
         public static void Main(string[] args)
         {
             Console.Write("Enter a string: ");
             var x = Console.ReadLine();
             if (x == null) return;
             for (var i = x.Length - 1; i >= 0; i--)
             {
                 Console.Write(x[i]);
             }
         }
     }
     */
     //--------------------------------------------------
     
     // count a
    /* public class Task2
     {
         public static void Main(string[] args)
         {
             Console.Write("Enter a string: ");
             var y = Console.ReadLine();
             if (y == null) return;
             var countA = 0;
             foreach (var c in y)
             {
             if (c == 'a' || c == 'A') countA++;
             }
             Console.Write($"A was repeated {countA} times");
         } 
 
     
     }*/
     //----------------------------------------------------

     //last index of a 
     /* public class Task3
     {
         public static void Main(string[] args)
         {
             Console.Write("Enter a string: ");
             var z = Console.ReadLine();
             if (z == null) return;
             for (var i = z.Length - 1; i >= 0; i--)
             {
              if (z[i] != 'a' && z[i] != 'A') continue;
              Console.Write($"A's last index is {i}");
              break;
             }
         }

     }*/
     //--------------------------------------------------

     // remove all a
     /*public class Task4
     {
         public static void Main(string[] args)
         {
             Console.Write("Enter a string: ");
             var a = Console.ReadLine();
             if (a == null) return;
             for (int i = 0; i < a.Length; i++)
             {
               if (a[i] != 'a')continue;
               a = a.Replace(a[i].ToString, "");
             }
             Console.Write(a);
         }
     }*/
     //---------------------------------------------------

     // add 0 after each a
     /*public class Task5
     {
         public static void Main(string[] args)
         {
             Console.Write("Enter a  string:");
             var b = Console.ReadLine();
             if (b == null) return;
             for (int i = 0; i < b.Length; i++)
             {
               if (b[i] != 'a') continue;
               b = b.Insert(i + 1, "0");
             }
             Console.Write(b);
         }
     }*/
     //---------------------------------------------------

     //remove duplicate
     /*public class Task8
     {
         public static void Main(string[] args)
         {
             Console.Write("Enter a string: ");
             var c = Console.ReadLine();
             if (c == null) return;
             var unique =new HashSet<char>(c);
             foreach (var s in unique)
             {
             Console.Write(s);
             }
         }
     }*/
     //--------------------------------------------------

     
     /*public class Task9
     {
         public static void Main(string[] args)
         {
              Console.Write("please enter a  size of list:");
             var size = Convert.ToInt32(Console.ReadLine());
             var arr = new int[size];
             for (int i = 0; i < size; i++)
             {
             Console.Write($"please enter element {i+1}: ");
             arr[i] = Convert.ToInt32(Console.ReadLine());
             }

             var average = arr.Average();
             var minDistance = double.PositiveInfinity;
             var num = -1;
              for (int i = 0; i < arr.Length; i++)
             {
             var distance = average - arr[i];
             if (!(Math.Abs(distance) < minDistance)) continue;
             minDistance = Math.Abs(distance);
             num = arr[i];
             }
         
             Console.WriteLine($"{average} is the average ");
             Console.Write($"{num} is the nearest to the mean \n the difference is {minDistance} ");
         }
     }*/
     //------------------------------------------------------
     

     /*public class Task10
     {
         public static void Main(string[] args)
         {
             Console.Write("please enter a  size of list:");
             var size = Convert.ToInt32(Console.ReadLine());
             var arr = new int[size];
             for (int i = 0; i < size; i++)
             {
             Console.Write($"please enter element {i+1}: ");
             arr[i] = Convert.ToInt32(Console.ReadLine());
             }

             var min = arr[0];
             var max = arr[0];

             foreach (var i in arr)
             {
             if (i>max )
             {
                 max = i;
             }

             if (i<min)
             {
                 min = i;
             }
             }
         Console.WriteLine($"the min of the array is {min}");
         Console.WriteLine($"the max of the array is {max}");
         Console.WriteLine($"the mean of the max and min is {(max+min)/2}");

     }
 }*/
 //------------------------------------------------------
    /* public class Task11
     {
          public static void Main(string[] args)
         {
             Console.Write("please enter a list separated by space :");
             var s = Console.ReadLine().Split();
             if (s== null)return;
             var newString = "";
             for (int i = 0; i < s.Length; i++)
             {
                 if (i == s.Length-1)
                 {
                   newString = newString.Insert(newString.Length  , s[i]);
                   break;
                 }
                 newString = newString.Insert(newString.Length  , $"{s[i]} , ");
                 var current = Convert.ToInt32(s[i]);
                 var next = Convert.ToInt32(s[i+1]);
                 while ((current + 1) != next)
                 {
                    newString = newString.Insert(newString.Length, $"{++current} , ");
                 }
             }
         Console.Write(newString);
         }
     }*/
     //---------------------------------------------------

     /*public class Task12
     {
         public static void Main(string[] args)
         {
             Console.Write("please enter a  size of list:");
             var size = Convert.ToInt32(Console.ReadLine());
             var arr = new int[size];
             for (int i = 0; i < size; i++)
             {
                 Console.Write($"please enter element {i+1}: ");
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }

             var average = arr.Average();
             var lessThanAvgCount = 0;
         
             foreach (var i in arr)
             {
                 if (i >= average)continue;
                 lessThanAvgCount++;
             }
         Console.WriteLine($"{average} is the average");
         Console.Write($"the numbers less than average are {lessThanAvgCount} number");
         }
     }*/
     //--------------------------------------------

    /* public class Task13
     {
         public static void Main(string[] args)
         {
             Console.Write("please enter a  size of list:");
             var size = Convert.ToInt32(Console.ReadLine());
             var arr = new int[size];
             for (int i = 0; i < size; i++)
             {
                 Console.Write($"please enter element {i+1}: ");
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }

             var average = arr.Average();
             Console.Write("the numbers greater than avg are : " );
             foreach (var i in arr)
             {
                 if (i>average)
                 {
                 Console.Write($"{i} ");
                 }
             }
         }
     }*/
}


