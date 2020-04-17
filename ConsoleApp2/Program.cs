using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MailAddress from = new MailAddress("keligamer63@gmail.com", "keLa");
            Console.WriteLine("Введите email адрес получателя");
            String recipientadress = Console.ReadLine();
            MailAddress to = new MailAddress(recipientadress);
            MailMessage message1 = new MailMessage(from, to);
            message1.Subject = "Hide";
            message1.Body = "<h2> Momento mori </h2>";
            message1.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            Console.WriteLine("Введите логин");
            String userlogin = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            String userpassword = Console.ReadLine();
            smtp.Credentials = new NetworkCredential(userlogin, userpassword);
            smtp.EnableSsl = true;
            smtp.Send(message1);
            Console.ReadLine();
        }
    }
}

