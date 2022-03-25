using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;


namespace Code
{
    class Program
    {
        public static void Main()
        {
           
            //Valid();
           // ClockWise();
            SameLength();
    
           
        }


      


        public static void ClockWise ()
        {
            int n = 5;
            int k = 1;
            var y = n % k;
            if (y==0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(y + k);
            }
            

        }




        public static void Valid ()
        {
            string s = "accfd";
            Dictionary<char, int> dictionary = new Dictionary<char, int>();


            foreach (var item in s)
            {
                if (dictionary.ContainsKey(item))
                {
                        dictionary[item] = dictionary[item] + 1;
                }
                else
                {
                        dictionary[item] = 1;
                }
            }
            var d=new List<int>();
            int y = 0;
            int r = 0;
            foreach (var f in dictionary)
            {
                if (!d.Contains(f.Value))
                {
                    d.Add(f.Value);
                }
                else
                {
                    y = f.Value;
                    r++;
                }

            }

            if (r==1)
            {
                if (d.Count > 2)
                {
                    Console.WriteLine("No");
                }
                else if (d.Count == 1)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    if (y == 0)
                    {
                        Console.WriteLine("No");
                    }
                    else
                    {
                        if (d.Contains(y))
                        {
                            d.Remove(y);
                        }

                        for (int i = 0; i < d.Count; i++)
                        {
                            if (d[i] != 1)
                            {
                                if (y < d[i])
                                {
                                    if (d[i] - y == 1)
                                    {
                                        Console.WriteLine("Yes");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Yes");
                            }


                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
     
           

        }





        public static void SameLength()
        {
            var words = new string[] { "foo", "bar" };
            var s = "barfoothefoobarman";
            var g=new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i] != words[j])
                    {
                        var t = words[i] + words[j];
                        if (!words.Contains(t))
                        {
                            g.Add(t);
                        }
                    }
                }
            }

         
        }




        //public static void Socks()
        //{
        //    int u = 0;
        //    string y = "";
        //    var t = new int[] { 1, 2, 3, 4, 1, 2, 3, 1 };
        //    for (int i = 0; i < t.Length; i++)
        //    {
        //        for (int j = i+1; j < t.Length; j++)
        //        {
        //            if (t[i]==t[j])
        //            {
        //                u++;
        //            }
        //        }
        //        if (u > 0)
        //        {
                    
        //            if (!y.Contains(t[i].ToString()))
        //            {
        //                Console.WriteLine(t[i]);
        //                y += t[i];
        //            }
        //            u = 0;
        //        }
        //    }
        //}


        //public static void Donts()
        //{
        //    var num="173";
        //    var f=new char[]{'0','1','2','3','4','5','6','7','8','9','-'};
        //    for (int i = 0 ; i <= f.Length; i++)
        //    {
        //        if (num.Length > i)
        //        {
        //            if (f.Contains(num[i]))
        //            {
        //                var s = Array.IndexOf(f,num[i]);
        //                Console.Write(s);
        //            }
        //        }
        //    }
            
           

        //}

        //public static void Question1()
        //{
        //    string a = "   the day is sunny the the the sunny is is";
        //    Dictionary<string, int> dictionary = new Dictionary<string, int>();
        //    var words = a.Split(' ');

        //    foreach (var item in words)
        //    {
        //        {

        //            if (dictionary.ContainsKey(item))
        //            {
        //                dictionary[item] = dictionary[item] + 1;
        //            }
        //            else
        //            {
        //                dictionary[item] = 1;
        //            }

        //        }

        //    }

        //    foreach (var f in dictionary)
        //    {
        //        if (f.Key != string.Empty)
        //        {
        //            Console.WriteLine($"{f.Value}   {f.Key}");
        //        }
        //    }

        //}


        //public static void Question2()
        //{
        //    var words = new string[] { "aaa", "aa", "d", "cd", "aaa", "aaaa" };
        //    var s = new List<string>();
        //    Dictionary<string, int> dictionary = new Dictionary<string, int>();

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if (!dictionary.ContainsValue(words[i].Length))
        //        {
        //            s.Add(words[i]);
        //            for (int j = 1; j < words.Length; j++)
        //            {

        //                if (words[i].Length == words[j].Length)
        //                {
        //                    if (!s.Contains(words[j]))
        //                    {
        //                        s.Add(words[j]);
        //                    }
        //                }
        //            }

        //            if (s.Count != 2)
        //            {
        //                s.Clear();
        //            }
        //            else
        //            {
        //                int y = 0;
        //                foreach (var g in s[0])
        //                {
        //                    if (s[1].Contains(g))
        //                    {
        //                        y++;
        //                    }
        //                }

        //                if (y == 0)
        //                {
        //                    dictionary.Add(s[0], s[0].Length);
        //                    s.Clear();
        //                }
        //                else
        //                {
        //                    s.Clear();
        //                }
        //            }
        //        }


        //    }
                      


        //    int p = 0;
        //    if (dictionary.Count != 0)
        //    {
        //        foreach (var g in dictionary)
        //        {
        //            if (p < g.Value)
        //            {
        //                p = g.Value;
        //            }
        //        }
        //    }

        //    Console.WriteLine(p * p);

        //}



        //public static void Question3()
        //{
        //    string a = "a1B";
        //    int g = 0;
        //    int f = 0;
        //    int p = 0;
        //    int d = 0;
        //    int r = 0;
        //    if (a.Length >= 6)
        //    {
        //        r += 1;
        //    }

        //    if (a.Length >=6 && a.Length <= 20)
        //    {
        //        r += 1;
        //    }

        //    var t = a.ToUpper();
        //    var y = a.ToLower();
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        int h;
        //        var s = int.TryParse(a[i].ToString(), out h);
        //        if (s)
        //        {
        //            p++;
        //        }
        //        else
        //        {
        //            if (a[i] == t[i])
        //            {
        //                g++;
        //            }

        //            if (a[i] == y[i])
        //            {
        //                f++;
        //            }
        //        }

        //    }

        //    int u = 0;
        //    for (int i = 0; i < a.Length - 1; i++)
        //    {
        //        if (a[i] == a[i + 1])
        //        {
        //            d++;
        //        }
        //        else
        //        {
        //            d = 0;
        //        }
        //        if (d == 2)
        //        {
        //            u += 1;
        //        }
        //    }

        //    if (u < 0)
        //    {
        //        r += 1;
        //    }
           
        //    if (g > 0)
        //    {
        //        r += 1;
        //    }

        //    if (f > 0)
        //    {
        //        r += 1;
        //    }

        //    if (p > 0)
        //    {
        //        r += 1;
        //    }


        //    if (r < 6)
        //    {
        //        Console.WriteLine(6-r);
        //    }
        //    else
        //    {
        //        Console.WriteLine(0);
        //    }


        //}




        //public  static int  Advertising()
        //{
        //    int y = 50;
        //    int h = 2;
        //    int k = 0;
        //    for (int i = 1 ,j=1; i < y; i++)
        //    {
        //        if (i==1)
        //        {
                  
        //            k= (h + h) - j;
        //            h += k;
                    
        //        }
        //        else
        //        {
        //            if (i % 2 ==0)
        //            {
        //                j++;
        //                k = (k + k) - j;
        //                h += k;
        //            }
        //            else
        //            {
        //                k = (k + k) - j;
        //                h += k;
        //            }
        //        }
              
        //    }

        //    return h;
        //}


        //public static int Sweet(int n,int m,int s,int l=0)
        //{
            
        //    if (m==0)
        //    {
        //        return l;
        //    }

        //    if (s > n)
        //    {
        //        s = 1;
        //    }
        //    else
        //    {
        //        l = s;
        //    }

        //    return Sweet(n, m--, s++,l);
        //    //for (int i = m; i > 0; i--)
        //    //{  


        //    //    if (s > n)
        //    //    { 
        //    //        s = 1;
        //    //    }
        //    //    else
        //    //    {
        //    //        l = s;
        //    //    }

        //    //    s++;
        //    //}
        //    //return l;
        //}
        //public static void Dont ()
        //{
        //    var num=-123;
        //    num = Math.Abs(123);
        //    for (int i = -1; i <= num; i++)
        //    {
        //        int f = num % 10;
        //        Console.WriteLine(f);
        //        num = num / 10;

        //    }

        //}
    }
}




     
