class Library
{

    private List<string> library;

    public Library()
    {
        library = new List<string>();
        library.Add("four");
        library.Add("good");
        library.Add("time");
        library.Add("tops");
        library.Add("spot");
        library.Add("stop");
        library.Add("more");
        library.Add("less");
        library.Add("meat");
        library.Add("fire");
        library.Add("boar");
        library.Add("bird");
        library.Add("seem");
        library.Add("kill");
    }

    public string pickRandomWord()
    {
        Random random = new Random();
        int num = random.Next(15);
        return library[num];
    }


}