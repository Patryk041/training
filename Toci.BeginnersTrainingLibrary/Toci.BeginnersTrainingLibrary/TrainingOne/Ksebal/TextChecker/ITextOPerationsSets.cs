
namespace Toci.BeginnersTrainingLibrary.TrainingOne.Ksebal.TextChecker
{
    public interface ITextOPerationsSets
    {
        string GetNick();
        string[] GetPalindromSet();
        string[] GetAnagramSet(string anagram);
        string[] GetWildCardSet(string wildcard);
    }
}