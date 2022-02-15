using System;

namespace Harvard_Referencing_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal("Harry", "Drew", "Life", 5, 10);
            string bibliographyCitation = journal.BuildBibliographyCitation();
            string textReference = journal.BuildInTextCitation("Work hard.");

            Book really = new Book("Harry", "Drew", 2022, "Way Of Life");
            string bookBibliographyCitation = really.BuildBibliographyCitation();
            string bookTextReference = really.BuildInTextCitation("Work hard.");

            Console.WriteLine(bibliographyCitation);
            Console.WriteLine(textReference);
            Console.WriteLine("");
            Console.WriteLine(bookBibliographyCitation);
            Console.WriteLine(bookTextReference);
        }
    }
}
