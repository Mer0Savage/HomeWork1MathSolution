using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace declaringMethod {
    class MathClass {
        int inputInt1, inputInt2;
        int Addition, Subtraction, Multiplication, Division;

        public void AcceptIntInputs() {
            Console.WriteLine("Please enter a number greater than 0.");
            inputInt1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number greater than 0.");
            inputInt2 = Convert.ToInt32(Console.ReadLine());
        }

        public void PubAddition() {
            Addition = inputInt1 + inputInt2;
            Console.WriteLine($"{inputInt1}+{inputInt2} = {Addition}");
        }
        public void PubSubtraction() {
            Subtraction = inputInt1 - inputInt2;
            Console.WriteLine($"{inputInt1}-{inputInt2} = {Subtraction}");
        }
        public void PubMultiplication() {
            Multiplication = inputInt1 * inputInt2;
            Console.WriteLine($"{inputInt1}*{inputInt2} = {Multiplication}");
        }
        public void PubDivision() {
            Division = inputInt1 / inputInt2;
            Console.WriteLine($"{inputInt1}/{inputInt2} = {Division}");
        }

        static void Main(string[] args) {

            MathClass MC = new MathClass();
            MC.AcceptIntInputs();
            MC.PubAddition();
            MC.PubSubtraction();
            MC.PubMultiplication();
            MC.PubDivision();
        }
    }
}