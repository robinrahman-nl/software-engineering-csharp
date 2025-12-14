/*
Programming Languages
Do you know when C# was invented? How about your other favorite programming languages, like JavaScript, Ruby, and R?

In this project, you’ll be using lists and LINQ to search a database for answers!

The data is stored in a TSV file, which stands for tab-separated values. It’s a common way to export data from a spreadsheet or database — you might see this file type when you try to download data from apps like Microsoft Excel and Google Sheets.

Here is what the data would look like as a table (just a few random rows included):

Year	Name	Chief Developer	Predecessors
1990	AMOS BASIC	François Lionet, Constantin Sotiropoulos	STOS BASIC
1991	Visual Basic	Alan Cooper (sold to Microsoft)	QuickBASIC
1995	Ruby	Yukihiro Matsumoto	Smalltalk;Perl
2009	Go	Google	C;Oberon;Limbo;Smalltalk
In Program.cs, the data import has already been taken care of, so you can focus on the queries! The data is stored in languages, which is a list of type List<Language>. You can find the definition for the Language class in Language.cs. Here are the class’s important members:

int Year — when the language was invented
string Name — the name of the language
string ChiefDeveloper — the head developer and/or company responsible for making the language
string Predecessors — the other programming languages that this language is based on
string Prettify() — returns a nicely formatted string version of the object

*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            // 1. 
            // Let’s start by printing all of the languages: print each item in languages by calling its Prettify() method.


            foreach (var item in languages)
            {
                // Console.WriteLine(item.Prettify());
            }

            // 2. Write a query that returns a string for each language. 
            // It should include the year, name, and chief developer of each language.
            var languagesYND = languages.Select(l => $"{l.Year} {l.Name} {l.ChiefDeveloper}");

            // print
            foreach (var item in languagesYND)
            {
                // Console.WriteLine(item);
            }

            // 3. 
            // When was C# first released?
            // Find the language(s) with the name "C#". 
            var languageCSharp = languages.Where(l => l.Name.Contains("C#"));

            // Use the Prettify() method to print the results to the console.
            // languageCSharp.Prettify();
            foreach (var item in languageCSharp)
            {
                Console.WriteLine(item.Prettify());
            }

            Console.WriteLine("####################");
            var languageByMicrosoft = languages.Where(l => l.ChiefDeveloper.Contains("Microsoft"));
            foreach (var item in languageByMicrosoft)
            {
                Console.WriteLine(item.Prettify());
            }

            Console.WriteLine("####################");
            var languagesFromLisp = languages.Where(l => l.Predecessors.Contains("Lisp"));
            foreach (var item in languagesFromLisp)
            {
                Console.WriteLine(item.Prettify());
            }


            // 7. 
            // How many languages are included in the languages list?
            Console.WriteLine(languages.Count);


            // 8. 
            // How many languages were launched between 1995 and 2005?
            Console.WriteLine("####################");
            var language1995To2005 = languages.Where(l => (l.Year >= 1995 && l.Year <= 2005));
            Console.WriteLine(language1995To2005.Count());

            // 9. 
            // Print a string for each of those near-millennium languages.
            // In your query add a Select operation that returns a string of this format for each element:
            var printLanguage1995To2005 = language1995To2005.Select(l => $"{l.Name} was invented in {l.Year}");

            foreach (var item in printLanguage1995To2005)
            {
                Console.WriteLine(item);
            }
            // 10. 
            // You might have used foreach loops to print every Language in this project. Write a method PrettyPrintAll() that handles that for us. It should:
            // return nothing
            // accept an argument of type IEnumerable<Language>
            // pretty print every language in the argument
            void PrettyPrintAll(IEnumerable<Language> languages)
            {

                foreach (var item in languages)
                {
                    Console.WriteLine(item.Prettify());
                }
            }

            PrettyPrintAll(languages);  // print all languages with simplified method. 

            // ##########################################################################################################################################
            // ##########################################################################################################################################

            // ✅ Important Note: 
            // 1. Why does the exercise suddenly want IEnumerable<Object>?
            // Because at this point in the project, your LINQ queries return different types:
            // 	•	Some queries return Language objects
            // → e.g. Where(...)
            // 	•	Some queries return strings
            // → e.g. Select(l => $"{l.Name} was invented…")
            // 	•	Some could return anonymous types
            // → e.g. Select(l => new { l.Year, l.Name })



            // ✅ 
            // 2. Test Query that returns an anonymous type 
            var queryReturnsAnonymType = languages.Select(l => new {l.Year, l.Name});



            // ##########################################################################################################################################
            // ##########################################################################################################################################



            // 11. 
            // You might have also used foreach loops to print every query result in this project. 
            // Write a method PrintAll() that handles that for us. It should:
            // return nothing
            // accept an argument of type IEnumerable<Object>
            // prints every object in the argument
            Console.WriteLine("###########################################################################################################################################################################################################################################################################################################################");
            void PrintAll(IEnumerable<Object> items)
            {
                foreach (var item in items)
                {
                    Console.WriteLine();
                }
            }

            PrintAll(queryReturnsAnonymType); 



        }
    }
}
