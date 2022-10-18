class Display
{
    string[] Jumper = { " ---", @"/___\", @"\   /", @" \ /" };

    public void DisplayJumper(bool IsGuessTrue, string[] BlankList)
    {
        foreach (var i in BlankList)
        {
            Console.Write(i);
            Console.Write("  ");

        }


        if (IsGuessTrue == false)
        {
            Jumper.RemoveAt(0); //need to fix
        }

        foreach (var i in Jumper)
        {
            Console.WriteLine(i);

        }





    }


}