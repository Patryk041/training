namespace Anathema.Terry.Examples.Interfaces
{
    public interface IUser
    {
        string Name { get; set; } 
        string Surname { get; set; } 
        string Password { get; set; } 
        int Age { get; set; } 
    }
}