using System;

namespace LogicsAskedInInterviews
{
    public class TryCatchTasks
    {
        /* Q:- What will be the output when we call super or global exception before anyother exceptoin?
         * A:- Code will give compile time error saying "A previous catch clause already catches all
         * exceptions of this or of a super type."
         */
        public void CallSupertypeExceptionFirst()
        {
            try
            {
                int a = 2, b = 0;
                var v = a / b;
            }

            catch (Exception ex)
            {
                Console.WriteLine("C");
            }

            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("A");
            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("B");
            //}
        }

        /* Q:- What will be the output when we call super or global exception after all other exceptoins?
         * A:- It will give error as per error matches with the catch clause, in this case "B". If error
         * doesn't match then it will throw global exception."
         */
        public void CallSupertypeExceptionLast()
        {
            try
            {
                int a = 2, b = 0;
                var v = a / b;
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("A");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("B");
            }

            catch (Exception ex)
            {
                Console.WriteLine("C");
            }
        }
    }
}
