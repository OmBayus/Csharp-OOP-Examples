using System;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("b: ");
                int b = int.Parse(Console.ReadLine());

                var sonuc = a / b;

                Console.WriteLine("{0} / {1} = {2}",a,b,sonuc);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("0 a bölünemez");
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex){
                Console.WriteLine("Sadece sayilar");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex){
                Console.WriteLine("Hatalı");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            


        }
    }
}
