using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrograms
{
    public interface MobileAuthenticationInterface
    {
        bool Authenticate();
    }
    public class FaceRecognitionAuthentication : MobileAuthenticationInterface
    {
        public bool Authenticate()
        {

            Console.WriteLine("Authenticating using face recognition...");

            return true;
        }
        public class FingerPrintAuthentication : MobileAuthenticationInterface
        {
            public bool Authenticate()
            {

                Console.WriteLine("Authenticating using fingerprint...");

                return true;
            }
        }
        public class PasswordAuthentication : MobileAuthenticationInterface
        {
            public bool Authenticate()
            {

                Console.WriteLine("Authenticating using password...");

                return true;
            }


        }
        class testInterface
        {
            static void Main(string[] args)
            {
                MobileAuthenticationInterface face = new FaceRecognitionAuthentication();
                MobileAuthenticationInterface finger = new FingerPrintAuthentication();
                MobileAuthenticationInterface pwd = new PasswordAuthentication();

                Console.WriteLine("Face Recognition Authentication Success: {face.Authenticate()}");
                Console.WriteLine("Finger Recognition Authentication Success: {finger.Authenticate()}");
                Console.WriteLine("Password Recognition Authentication Success: {pwd.Authenticate()}");
                Console.ReadLine();
                
            }
        }
    }
}
