using System;

namespace notes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            #region Value type casting
            #region implicit casting (safe casting)
            int x = 29; // 4 bytes
            long y = (long)x; // 8 bytes // we should write this (long)x to convert int to long
                              // but it do this automaticaly (implicit casting) 
            #endregion
            
            #region explicit casting ( unsafe casting ) 
            long a = 1010101010; //8 bytes
            int b = (int)a; //int y = x; // 4 bytes (cant change from long to int bec its smaller)
                            // overflow exeption (change the values)
            checked
            {
                b = (int)a;
            } // mission of checked to check the code we put in scope of it
              // there is unchecked its function to skip code from being checked
            #endregion

            #region Parse (convert from string to ant data type)
            // to store data with data tyoe integer that we get from user
            // int number;
            // to get data from user
            //Console.ReadLine();
            // to view message to user 
            // Console.WriteLine();
            // take two steps with each other
            //int number = Console.ReadLine(); // give error bec any data from user console.readline take string only
            // so we use parse 
            // int is struct =>that mean its have bulting function such as Parse 
            //int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Data User"); // line is display block
            string Name = Console.ReadLine();

            Console.Write("Enter Age : "); // line is display inline 
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Salary : ")
            double Salary = double.Parse(Console.ReadLine());

            Console.Clear(); // clear the view not the real data 

            Console.WriteLine("Name : " + Name + "Age : " + Age + "Salary : " + Salary);

            #endregion

            #endregion

            #region Operators

            #region Unary operators ( ++ , -- )
            int x = 4;
            // ++x => prefix (add 1 first then print x)
            // x++ => postfix (print x first then add 1 )
            Console.WriteLine(++x)
            Console.WriteLine(x++)

            // --x => prefix (subtract 1 first then print x)
            // x-- => postfix (print x first then subtract 1 )
            #endregion

            #region Binary operators
            // sum , multiply , subtract , add , divided , modelus %

            // 8 % 5 = 3 => ba2y el kesma eli hwa feh kam 5 fy el 8 
            #endregion

            #region Assignment operator

            int x = 1

            x += 1 // x = x + 1
            x -= 1 // x = x - 1
            x *= 1 // x = x * 1
            x %= 1 // x = x % 1


            #endregion

            #region Relational operators
            // == , != , < , >  <= , >=       ====> btrag3 true or false
            int A = 10
            int B = 5
            // A == B => False
            // A != B => True
            // A > B => True
            // A < B => False

            #endregion

            #region Logical operators (short circut) 
            // dont need to check all the code 
            // ! , && , ||

            Console.WriteLine(!true) // out is false
            // true && false = false
            // true || false = true


            #endregion

            #region Bitwise operators (long circut)
            // it will check all the code even if you dont need this
            // ^ , & , | , >> , <<

            // ^ is not => and work on binary numbers
            // true & false = false like && , the dif
            // true | false = true  like ||


            #endregion

            #region Ternary operator (conditionaly opperator)

            int x = 4;
            int y = 5;

            string Message = x > y ? " X greater than 4" : "X less than 4" // like if condition shortcut in react 
            Console.WriteLine(Message);
            #endregion

            #region periority operators
            // unary operator (prefix)
            // ( )
            // * , / , %
            // + , -
            #endregion


            #endregion

            #region String formating

            // equation = X + Y = Result
            // equation = 5 + 10 = 15
            int X = 5;
            int Y = 10;
            int Result = X + Y;

            Console.WriteLine("Equation = " + X + " + " + Y + " = " + Result); // not recommended
            // string => immutable data type (cant change the value)

            #region Composite formate
            Console.WriteLine("Equation = {0} , {1} , {2}" , X, Y , Result) // lazm nafs tarteb
            #endregion

            #region String Manipolition
            // string manipolition ==>> $
            Console.WriteLine($"Equation = {X}, {Y}, {Result}"); // what we use like javascript 
            #endregion

            #endregion

            #region Control statment (Conditional statment - loop statment)
            #region Conditional statment (If , Switch)

            // write code that if user enter 1 = jan , 2 = feb , 3 = mar , other = unknown

            Console.WriteLine("Enter Month Number");
            int MonthNumber = int.Parse(Console.ReadLine());

            if(MonthNumber == 1)
            {
                Console.WriteLine("Month is Jan");
            }
            else if (MonthNumber == 2)
            {
                Console.WriteLine("Month is Feb");
            }
            else if (MonthNumber == 3)
            {
                Console.WriteLine("Month is Mar");
            }
            else  
            {
                Console.WriteLine("Month is unknown");
            }

            // check every condition line by line until you found the matching condition

            /////////////////////////////////////////////////

            switch (MonthNumber) {

                case 1:
                    Console.WriteLine("Month is Feb");
                    break;
                case 2:
                    Console.WriteLine("Month is Feb");
                    break;
                case 3:
                    Console.WriteLine("Month is Mar");
                    break;
                default:
                    Console.WriteLine("Month is unknown");
                    break ; 

            }
            // go to the matching condition direct by jumbing table with numeric data only
            // so its faster than if with numeric data 
            #endregion
            #endregion
        }
    }
}
