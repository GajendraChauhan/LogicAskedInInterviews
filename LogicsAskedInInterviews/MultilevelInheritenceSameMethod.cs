using System;

namespace LogicsAskedInInterviews
{
    /* Q:- How to call a function of parent's parent class, if method name are same in all the base classes?
       Suppose Class C inherits B and B inherits A. Class A and B both are having a method with same name.
       How will you call parent's parent class method in this scenario ?
     */

    public class Person
    {
        public void persondet()
        {
            Console.WriteLine("this is the person class");
        }
    }

    public class Bird : Person
    {
        public void persondet()
        {
            Console.WriteLine("this is the birddet Class");
        }
    }

    public class Animal : Bird
    {
        public void animaldet()
        {
            // one way to call base class method.
            //persondet();

            #region Using ((ClassName)this).MethodName
            // second way to call base class method.
            ((Bird)this).persondet();

            // Call base.base class method, if method name are same.
            ((Person)this).persondet();
            #endregion

            #region Using class object but referencing particular base class
            Person p = new Animal();
            p.persondet();
            #endregion

            Console.WriteLine("this is the Animal Class");
        }
    } 
}
