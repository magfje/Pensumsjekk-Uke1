using System.Text;

namespace PensumsjekkUke1 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            var go = true;
            while (go) {
                Console.WriteLine("Write a name");
                var n1 = Console.ReadLine();
                if (n1 == null) {
                    return;
                } else {
                    Console.WriteLine(n1 + " is a " + RandomHobby() + "\r\n");
                }
            }
        }

        static string RandomHobby() {
            string[] hobbys = { "ninja🥷", "politi👮", "brannmann🧑‍🚒", "trollmann🧙‍♂️", "lege👨‍⚕️", "astronaut👨‍🚀" };

            Random rnd = new();
            int randHobby = rnd.Next(minValue: 0, hobbys.Length - 1);
            return hobbys[randHobby];
        }
    }
}