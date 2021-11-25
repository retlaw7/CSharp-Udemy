 using System;

namespace section6
{
    class Program
    {
        static void Main(string[] args)
        {
            Human walter = new Human("Walter", "Simons", "Brown", 21);
            walter.introduceMyself();

            Human michael = new Human("Michael", "Colhain", "Blue");
            michael.introduceMyself();

            Human sander = new Human("Sander", "Kuttekop", 21);
            sander.introduceMyself();

            Human amalia = new Human("Amalia", "Panjuta");
            amalia.introduceMyself();

            Human natalie = new Human("Natalie");
            natalie.introduceMyself();

            Human basicHuman = new Human();
            basicHuman.introduceMyself();
        }
    }
}