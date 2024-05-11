using LabaWS10;

internal class Program
{
    private static void Main(string[] args)
    {
        SomeClass someobject1 = new("someobject1");
        SomeClass someobject = new("someobject");
        someobject.SomeAnotherMethod(someobject.someTitle);
        someobject1.SomeAnotherMethod(someobject1.someTitle);
        AnotherClass anotherobject = new("anotherobject");
        someobject1.SomeAnotherMethod(someobject1.someTitle);
        someobject.SomeAnotherMethod(someobject.someTitle);
        someobject.SomeAnotherMethod(someobject.someTitle);
    }
}