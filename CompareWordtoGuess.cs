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
    public bool CompareLetter(string Answer, string Guess)
    {

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
                    GuessIsTrue = true;

                }
            }

        }

        return (GuessIsTrue);
    }

    public List<string> SwapLetter(string Answer, string Guess, List<string> BlankList)
    {
        int AnswerLength = Answer.Length;

        for (int i = 0; i < AnswerLength; i++)
        {
            if (Answer[i].ToString() == Guess)
            {
                // Remove Element. 
                BlankList[i] = Guess;

            }


        }
        return (BlankList);

    }

    public bool CheckBlankList(List<string> BlankList)
    {
        bool ListisUnfinished = false;
        
        foreach (var item in BlankList)
        {
            if (item == "_")
            {
                ListisUnfinished = true;
            }
            
        }
        return ListisUnfinished;
    }
}