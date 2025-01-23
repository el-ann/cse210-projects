public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void HideWord()
    {
        isHidden = true;
    }

    public void ShowWord()
    {
        isHidden = false;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string GetText()
    {
        return text;
    }
}
