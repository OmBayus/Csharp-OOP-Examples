using System;

namespace Static
{

    class Student
    {
        public Student(string name,int numara)
        {
            this.Name = name;
            this.StudentNumber=numara;
        }
        public string Name { get; set; }

        public int StudentNumber { get; set; }

        public static string School = "İskender Paşa";
        public static string SchoolAdress = "Adresi";

        public void DisplayStudentDetails(){
            Console.WriteLine($"Name: {this.Name} Number: {this.StudentNumber}");
        }

        public static void DisplaySchoolDetails(){
            Console.WriteLine($"School Name: {School} Adress: {SchoolAdress}");
        }
    }


    static class HelplerMethods
    {
        public static string KarakterDuzelt(string str){
            return str
                .Replace("ö","o")
                .Replace("ı","i")
                .Replace("ü","u")
                .Replace("ş","s")
                .Replace("ç","c");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Ömer",616);
            var s2 = new Student("Fırat",434);
            var s3 = new Student("Furkkan",123);

            s1.DisplayStudentDetails();
            s2.DisplayStudentDetails();
            s3.DisplayStudentDetails();

            Student.DisplaySchoolDetails();

            string str = "ölçme ve değerlendirme";
            Console.WriteLine(HelplerMethods.KarakterDuzelt(str));
        }
    }
}
