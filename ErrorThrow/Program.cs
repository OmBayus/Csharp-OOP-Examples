using System;
using System.Linq;

namespace ErrorThrow
{
    class Program
    {
        static void check_password(string password){
            if(password.Length<8 && password.Length>15){
                throw new Exception("Parola 8 ile 15 karakter arasında olmalıdır");
            }
            if(!password.Any(char.IsDigit)){
                throw new Exception("Parola en az bir rakam içermelidir");
            }
            if(!password.Any(char.IsLetter)){
                throw new Exception("Parola en az bir harf içermelidir");
            }
        }
        static void Main(string[] args)
        {
            // int sayi = 10;
            // if (sayi>5){
            //     throw new Exception("sayi 5 den büyük olamaz");
            // }


            string parola = "12345678";

            check_password(parola);
        }
    }
}
