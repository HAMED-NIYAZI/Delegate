namespace Delegate
{
    internal class Program
    {
        //Declaring Delegates

        private delegate bool SendNotification(string message);
        static void Main(string[] args)
        {
            //Instantiating Delegates
            /*
            //SendNotification Notif1 = new SendNotification(SendEmail);
            //SendNotification Notif2 = new SendNotification(SendSms);

            //Notif1("success");
            //Notif2("success");
            */


            //Multicasting of a Delegate
            SendNotification Notif;
            SendNotification Notif1 = new SendNotification(SendEmail);
            SendNotification Notif2 = new SendNotification(SendSms);

            Notif = Notif1;
            Notif += Notif2;
            Notif("success");



            //////////////////////////////////////////

            Console.ReadKey();
        }

        public static bool SendEmail(string message)
        {
            Console.WriteLine("Email Sent.........");
            return true;
        }

        public static bool SendSms(string message)
        {
            Console.WriteLine("Sms Sent.........");
            return true;
        }
    }
}