public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //CONSTRUCTOR
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        //Se crea un arreglo "words" de strings y se divide el texto por los espacios en blanco
        string[] words = text.Split(' ');
        //Crea una nueva instancia vacía 
        _words = new List<Word>();
        //Se utiliza un loop para iterar cada elemento en "words"
        foreach (string word in words)
        {
            //Se añade cada elemento de "words" en _word, ya no como string sino como Word
            _words.Add(new Word(word));
        }

    }

    //METHODS
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int countHidden = 0;

        while (countHidden < numberToHide)
        {
            int number = random.Next(0, _words.Count);
            Word randomWord = _words[number];

            if(!randomWord.IsHidden())
            {
                randomWord.Hide();
                countHidden++;
            }
        }
    }
    public string GetDisplayText()
    {
        string phraseAgain = "";
        foreach (Word word in _words)
        {
            phraseAgain += word.GetDisplayWord() + " ";
        }
        return $"{_reference.GetDisplayReference()}  {phraseAgain}";
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}