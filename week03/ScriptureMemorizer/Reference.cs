public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    

    public Reference(string _book, int _chapter, int _verse, int _endVerse)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._verse = _verse;
        this._endVerse = _endVerse;
    }
   
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}" + (_endVerse > _verse ? $"-{_endVerse}" : "");
    }
}
