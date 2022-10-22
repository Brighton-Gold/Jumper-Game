class Display
{

    List<string> Jumper = new List<string>

    {@" ---", @"/___\", @"\   /", @" \ /"};

    public void DisplayJumper(bool IsGuessTrue, List <string> BlankList)
    {
        foreach (var i in BlankList)
        {
            Console.Write(i);
            Console.Write("  ");

        }

        Console.WriteLine("\n");


        if (IsGuessTrue == false) //If THe user guess is false, then the first element is removed from the list. 
        {
            Jumper.RemoveAt(0);
        }

        int JumperLength = Jumper.Count;
        if(JumperLength != 0)
        {
            foreach (var i in Jumper)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("  O");

        }

        else
        {
            Console.WriteLine("  X");
        }

        Console.WriteLine(@" /|\");
        Console.WriteLine(@" / \");


    }
    public bool CheckJumper()
    {
        bool ListisUnfinished = false;
        
        if(Jumper.Count != 1){
            ListisUnfinished = true;
        }
        return ListisUnfinished;
    }



}