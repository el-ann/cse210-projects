public class Reference
{
    private string book;
    private int chapter;
    private int? verseStart;
    private int? verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    public string GetDisplayText()
    {
        if (verseEnd.HasValue)
        {
            return $"{book} {chapter}:{verseStart}-{verseEnd}";
        }
        return $"{book} {chapter}:{verseStart}";
    }
}
