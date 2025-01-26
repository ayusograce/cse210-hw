public class Word
{
    private string _text;
    private bool _isHidden;

    //CONSTRUCTOR
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //METHODS
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayWord()
    {
        if (_isHidden == true)
        {
            
            return new string('_', _text.Length);
        }
        return _text;
    }
}