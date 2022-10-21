class Program
{

    static void Main(string[] args)
    {
        /// Test for display blank list. Works!
        Display display = new Display();

        Library library = new Library();
        string Word = "frog";


        CompareWord compare = new CompareWord();

        List<string> BlankList = compare.CreateBlankList(Word);

        Tuple<bool, List<string>> tuple;
        bool Guess = false;

        
        tuple = compare.CompareLetter(Word, "o");

        Guess = tuple.Item1;
        List <string> WordList = tuple.Item2;

        foreach(string Item in WordList){
            Console.Write(Item);
        }



    }

}