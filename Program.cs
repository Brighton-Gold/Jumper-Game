class Program
{

    static void Main(string[] args)
    {
        /// Test for display blank list. Works!
        Display display = new Display();
        CompareWord compare = new CompareWord();
        Library library = new Library();

        string Word = library.pickRandomWord();
        List<string> BlankList = compare.CreateBlankList(Word);
        bool DefaultGuess = true;
        bool Listisfinished = true;
        bool DoesJumperHaveParachute = true;

        display.DisplayJumper(DefaultGuess, BlankList);



        while ((Listisfinished = true) || (DoesJumperHaveParachute = true)) // Check if list still is blank, or out of parachute.
        {

            Console.WriteLine("Please guess a random letter");
            string UserGuess = Console.ReadLine();

            if (UserGuess == "cheat")    // Cheatcode!!!
            {
                Console.WriteLine(Word);
                Console.WriteLine("Please guess a random letter");
                UserGuess = Console.ReadLine();
            }

            UserGuess = UserGuess.ToLower();

            bool GuessIsTrue = compare.CompareLetter(Word, UserGuess);

            if (GuessIsTrue == true)
            {
                List<string> UpdatedList = compare.SwapLetter(Word, UserGuess, BlankList);
                display.DisplayJumper(GuessIsTrue, UpdatedList);

            }

            else
            {
                display.DisplayJumper(GuessIsTrue, BlankList);

            }
            
            DoesJumperHaveParachute = display.CheckJumper();

            Listisfinished = compare.CheckBlankList(BlankList);


        }
        Console.Write("Game Over!");





    }

}