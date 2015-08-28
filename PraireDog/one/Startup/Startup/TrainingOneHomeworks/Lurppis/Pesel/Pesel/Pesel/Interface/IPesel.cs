namespace Pesel.Interface
{
    public interface IPesel
    {
        //string PeselNumber { get; set; }
        bool CheckLength();
        bool IsCorrect();
    }
}