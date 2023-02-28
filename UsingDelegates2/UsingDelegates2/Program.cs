namespace UsingDelegates2
{
    public class Program
    {
        public delegate bool Notif(string message);
        public static void Main(string[] args)
        {
            Notif n1 = new Notif(EmailNotif);
            Notif n2 = new Notif(SmsNotif);



            SendNotif(n1,"email sent....");
            SendNotif(n2, "sms sent....");

            Console.WriteLine("Hello, World!");
        }


        public static bool EmailNotif(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public static bool SmsNotif(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public static bool SendNotif(Notif notification, string message)
        {

            notification.Invoke(message);
            return true;
        }





    }
}