using System.ComponentModel;

namespace PasswordManager{
    interface IPassword {
        int PassLenght();

        int MaxPassLenght();

        int MinPassLenght();


    }

    class Password : IPassword {
        private string password;
        private static int maxPassLenght = 20;
        private static int minPassLenght = 8;

        public int PassLenght(){
            return 0;
        }

        public int MaxPassLenght(){
            return maxPassLenght;

        }

        public int MinPassLenght(){
            return minPassLenght;

        }

    }
}