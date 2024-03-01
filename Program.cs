using Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
       Wordsmean Word1 = new Wordsmean() { Word = "Pray", Meaning = " address a prayer to God or another deity" };
        Wordsmean Word2 = new Wordsmean() { Word = "Dance", Meaning = "Dance is an art form, often classified as a sport, consisting of sequences of body movements with aesthetic" };
        Wordsmean Word3 = new Wordsmean() { Word = "Deity", Meaning = " a god or goddess" };
        Wordsmean Word4 = new Wordsmean() { Word = "Oblivion", Meaning = " the state of being unaware or unconscious of what is happening around one" };
        Wordsmean Word5 = new Wordsmean() { Word = "Careless", Meaning = "not giving sufficient attention or thought to avoiding harm or errors" };
        Wordsmean Word6 = new Wordsmean() { Word = "Champion", Meaning = " a person who has surpassed all rivals in a sporting contest or other competition" };
        Wordsmean Word7 = new Wordsmean() { Word = "Awkward", Meaning = " causing difficulty; hard to do or deal with" };
        Wordsmean Word8 = new Wordsmean() { Word = "Insane", Meaning = "very foolish, irrational, or strange" };
        Wordsmean Word9 = new Wordsmean() { Word = "Independence", Meaning = "Independence is a condition of a nation, country, or state, in which residents and population, or some portion thereof, exercise self-government" };
        Wordsmean Word10 = new Wordsmean() { Word = "Patriot", Meaning = "a person who vigorously supports their country and is prepared to defend it against enemies or detractors" };
       

        Dictionary<string,Wordsmean> Dictionary = new Dictionary<string,Wordsmean>();
        Dictionary.Add(Word1.Word, Word1);
        Dictionary.Add(Word2.Word, Word2);
        Dictionary.Add(Word3.Word, Word3);
        Dictionary.Add(Word4.Word, Word4);
        Dictionary.Add(Word5.Word, Word5);
        Dictionary.Add(Word6.Word, Word6);
        Dictionary.Add(Word7.Word, Word7);
        Dictionary.Add(Word8.Word, Word8);
        Dictionary.Add(Word9.Word, Word9);
        Dictionary.Add(Word10.Word, Word10);

        foreach(var word in Dictionary)
        {
            Console.WriteLine("Key word"+" "+ word.Key);
            var words = word.Value;
            Console.WriteLine("meaning = {0}", words.Meaning);
        }






    }
}

