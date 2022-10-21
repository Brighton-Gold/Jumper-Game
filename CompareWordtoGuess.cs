class CompareWord
{

    public List<string> CreateBlankList(string Answer)
    {

        List<string> BlankList = new List<string> { };

        int AnswerLength = Answer.Length;

        for (int i = 0; i < AnswerLength; i++)
        {
            BlankList.Add("_");
        }

        return (BlankList);

    }
    public Tuple<bool, List<string>> CompareLetter(string Answer, string Guess)
    {

        List<string> BlankList = new List<string> { };

        bool GuessIsTrue = false;
        int AnswerLength = Answer.Length;

        // Compare each letter in Answer to user's guessed letter.
        // "i" finds that specific location. 
        for (int i = 0; i < AnswerLength; i++)
        {
            foreach (char Letter in Answer)
            {

                if (Letter.ToString() == Guess)
                {
                    // Remove Element. 
                    BlankList.RemoveAt(i);
                    // Replace Element. 
                    BlankList.Insert(i, Guess);
                    // Guess was accurate, so now set to true. 
                    GuessIsTrue = true;

                }
            }

        }
        Tuple<bool, List<string>> tuple = new Tuple<bool, List<string>>(GuessIsTrue, BlankList);

        return (tuple);
    }
}