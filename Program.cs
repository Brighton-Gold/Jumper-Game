class Program
{

    static void Main(string[] args)
    {
        /// Test for display blank list. Works!
        Display display = new Display();
        string[] BlankList = {"_","_","_","_"};

        Library library = new Library();
        string Word = library.pickRandomWord();

        Console.Write(Word);

        
        

    }

}