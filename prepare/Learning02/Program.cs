using System;

class Program
{
    static void Main(string[] args)
    {
        Person fred = new Person();
        fred.givenName = "fred";
        fred.familyName = "Flinstone";

        Person steve = new Person();
        steve.givenName = "steve";
        steve.familyName = "Minecraft";

        fred.EasternStyleName();
        steve.WesternStyleName();


    }
}