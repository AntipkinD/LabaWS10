using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaWS10
{

    internal class SomeClass
    {
        internal string someTitle { get; set; }
        internal delegate void SomeDelegate(string text);
        internal static event SomeDelegate CallR;
        public SomeClass(string title)
        {
            someTitle = title;
            //SomeAnotherMethod(someTitle);
        }

        internal void SomeMethod(string title)
        {
            title = someTitle;
            Console.WriteLine(title);
        }
        internal void SomeAnotherMethod(string title)
        {
            CallR = SomeMethod;
            SomeDelegate delegati = CallR;
            delegati?.Invoke(title);
        }
    }
    internal class AnotherClass
    {
        internal string anotherTitle { get; set; }
        public AnotherClass(string title)
        {
            anotherTitle = title;
            SomeClass.CallR += AnotherMethod;
        }
        internal void AnotherMethod(string title)
        {
            title = anotherTitle;
            Console.WriteLine(title);
        }
    }
}
