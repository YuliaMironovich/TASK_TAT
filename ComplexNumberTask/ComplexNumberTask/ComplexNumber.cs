using System;
using System.Text;

namespace ComplexNumberTask
{
    /// <summary>
    /// /Class contains information about complex number and methods which works with complex number.
    /// Real part is a real part of complex number, imaginary - imaginary part of complex number.
    /// </summary>
    public class ComplexNumber
    {
        public double RealPart { get; set; }
        public double ImaginaryPart { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ComplexNumber ()
        {}

        /// <summary>
        /// Constructor initializes the object with the values passed.
        /// </summary>
        /// <param name="realPart">Real part of complex number.</param>
        /// <param name="imaginaryPart">Imaginary part of complex number.</param>
        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        /// <summary>
        /// Constructor copies the complex number and creates new complex number with the same fields.
        /// </summary>
        /// <param name="complexNumber">Copied complex number.</param>
        public ComplexNumber(ComplexNumber complexNumber)
        {
            RealPart = complexNumber.RealPart;
            ImaginaryPart = complexNumber.ImaginaryPart;
        }

        /// <summary>
        /// Methods returns modul of complex number. 
        /// </summary>
        /// <returns>Modul of complex numer</returns>
        public double GetModulOfComplexNumber ()
        {
            return Math.Sqrt(this.RealPart * this.RealPart + this.ImaginaryPart * this.ImaginaryPart);
        }

        /// <summary>
        /// Overloaded operator calculates the sum of two complex numbers.
        /// </summary>
        /// <param name="firstComplexNumber">First complex number for calculating the sum.</param>
        /// <param name="secondComplexNumber">Second complex number for calculating the sum.</param>
        /// <returns>Result of the sum in the form of new complex number.</returns>
        public static ComplexNumber operator +(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber)
        {
            ComplexNumber complexNumber = new ComplexNumber();
            checked
            {
                complexNumber.RealPart = (firstComplexNumber.RealPart + secondComplexNumber.RealPart);
                complexNumber.ImaginaryPart = (firstComplexNumber.ImaginaryPart + secondComplexNumber.ImaginaryPart);
            }  
            return complexNumber;
        }

        /// <summary>
        /// Overloaded operator calculates the defference of two complex numbers.
        /// </summary>
        /// <param name="firstComplexNumber">First complex number for calculating the difference.</param>
        /// <param name="secondComplexNumber">Second complex number for calculating the difference.</param>
        /// <returns>Result of the difference in the form of new complex number.</returns>
        public static ComplexNumber operator -(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber)
        {
            ComplexNumber complexNumber = new ComplexNumber();
            complexNumber.RealPart = checked(firstComplexNumber.RealPart - secondComplexNumber.RealPart);
            complexNumber.ImaginaryPart = checked(firstComplexNumber.ImaginaryPart - secondComplexNumber.ImaginaryPart);
            return complexNumber;
        }

        /// <summary>
        /// Overloaded operator calculates the multiplication of two complex numbers.
        /// </summary>
        /// <param name="firstComplexNumber">First complex number for calculating the multiplication.</param>
        /// <param name="secondComplexNumber">Second complex number for calculating the multiplication.</param>
        /// <returns>Result of the multiplication in the form of new complex number.</returns>
        public static ComplexNumber operator *(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber)
        {
            ComplexNumber complexNumber = new ComplexNumber();
            complexNumber.RealPart = checked(firstComplexNumber.RealPart * secondComplexNumber.RealPart) - 
                                     checked(firstComplexNumber.ImaginaryPart * secondComplexNumber.ImaginaryPart);
            complexNumber.ImaginaryPart = checked(firstComplexNumber.RealPart * secondComplexNumber.ImaginaryPart) + 
                                          checked(firstComplexNumber.ImaginaryPart * secondComplexNumber.RealPart);
            return complexNumber;
        }

        /// <summary>
        /// Overloaded operator calculates the division of two complex numbers.
        /// </summary>
        /// <param name="firstComplexNumber">First complex number for calculating the division.</param>
        /// <param name="secondComplexNumber">Second complex number for calculating the division.</param>
        /// <returns>Result of the division in the form of new complex number.</returns>
        public static ComplexNumber operator /(ComplexNumber firstComplexNumber, ComplexNumber secondComplexNumber)
        {
            ComplexNumber complexNumber = new ComplexNumber();
            double commonPart = checked(secondComplexNumber.RealPart * secondComplexNumber.RealPart) + 
                                checked(secondComplexNumber.ImaginaryPart * secondComplexNumber.ImaginaryPart);

            complexNumber.RealPart = checked((checked(firstComplexNumber.RealPart * secondComplexNumber.RealPart) +
                                      checked(firstComplexNumber.ImaginaryPart * secondComplexNumber.ImaginaryPart))) / commonPart;
            complexNumber.ImaginaryPart = (checked(firstComplexNumber.ImaginaryPart * secondComplexNumber.RealPart) -
                                           checked(firstComplexNumber.RealPart * secondComplexNumber.ImaginaryPart)) / commonPart;
            return complexNumber;
        }

        /// <summary>
        /// Method compares two complex object.
        /// </summary>
        /// <param name="complexNumber">Second complex number for comparing.</param>
        /// <returns>-1 if the first complex number less than second, 0 if they are equal, and 1 if the first bigger than second.</returns>
        public int CompareTo(ComplexNumber complexNumber)
        {
            return this.GetModulOfComplexNumber().CompareTo(complexNumber.GetModulOfComplexNumber());
        }

        /// <summary>
        /// Display complex number in console.
        /// </summary>
        /// <param name="complexNumber">Complex number for output.</param>
        public void Display()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Method converts complex number in string.
        /// </summary>
        /// <returns>Complex number in form of string</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.RealPart).Append(" + i * ").Append(this.ImaginaryPart);
            return stringBuilder.ToString();
        }
    }
}
