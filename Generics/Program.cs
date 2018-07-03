using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T>
    {
        private List<T> mValue = new List<T>();

        public void addValue(T _object)
        {
            mValue.Add(_object);
        }
        public T GetValue(int i)
        {
            return mValue[i];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tworzymy liste string czy int?\nS/I");
            _Function();
            Console.ReadKey();

            void _Function()
            {
                string wybor = Console.ReadLine();
                //bool _sprawdzenie = wybor != null && wybor.Length > 0;

                try
                {
                    if (wybor != null && wybor.ToLower()[0] == 's')
                    {
                        var list = new MyList<String>();
                        Console.WriteLine("podaj ilosc string do wprowadzenia");
                        int _liczba = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wprowadz stringi");
                        for (int i = 0; i < _liczba; i++)
                        {
                            Console.WriteLine("String numer :" + i);
                            list.addValue(Console.ReadLine());
                        }

                        Console.WriteLine("wypiszmy stringi");
                        

                        for (int i = 0; i < _liczba; i++)
                        {
                            // Console.WriteLine(list.GetValue(i));
                            Console.WriteLine(string.Join(", ", list.GetValue(i)));
                        }
                    }
                    else if (wybor != null && wybor.ToLower()[0] == 'i')
                    {
                        var list = new MyList<int>();
                        Console.WriteLine("podaj ilosc liczb do wprowadzenia");
                        int _liczba = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wprowadz liczby");
                        for (int i = 0; i < _liczba; i++)
                        {
                            list.addValue(int.Parse(Console.ReadLine()));
                        }
                        Console.WriteLine("wypiszmy liczby");
                        for (int i = 0; i < _liczba; i++)
                        {
                            Console.WriteLine(list.GetValue(i));
                        }
                    } else if (wybor == null || wybor.ToLower()[0] != 's' || wybor.ToLower()[0] != 'i')
                    {
                        Console.WriteLine("nie podales prawidlowej odpowiedzi");
                    }
                    
                }
                catch (Exception ex)
                {

                    Console.WriteLine("cos poszlo nie tak ziomeczki " + ex.Message);
                }
                    
               
               
                //if (_sprawdzenie == true && wybor.ToLower()[0] == 's')
                //{
                //    var list = new MyList<String>();
                //    Console.WriteLine("podaj ilosc string do wprowadzenia");
                //    int _liczba = int.Parse(Console.ReadLine());
                //    Console.WriteLine("Wprowadz stringi");
                //    for (int i = 0; i < _liczba; i++)
                //    {
                //        Console.WriteLine("String numer :" + i);
                //        list.addValue(Console.ReadLine());
                //    }

                //    Console.WriteLine("wypiszmy stringi");
                //    for (int i = 0; i < _liczba; i++)
                //    {
                //        Console.WriteLine(list.GetValue(i));
                //    }
                //}
                //else if (_sprawdzenie == true && wybor.ToLower()[0] == 'i')
                //{
                //    var list = new MyList<int>();
                //    Console.WriteLine("podaj ilosc liczb do wprowadzenia");
                //    int _liczba = int.Parse(Console.ReadLine());
                //    Console.WriteLine("Wprowadz liczby");
                //    for (int i = 0; i < _liczba; i++)
                //    {
                //        list.addValue(int.Parse(Console.ReadLine()));
                //    }
                //    Console.WriteLine("wypiszmy liczby");
                //    for (int i = 0; i < _liczba; i++)
                //    {
                //        Console.WriteLine(list.GetValue(i));
                //    }
                //}
            }
        }
        
    }
}
