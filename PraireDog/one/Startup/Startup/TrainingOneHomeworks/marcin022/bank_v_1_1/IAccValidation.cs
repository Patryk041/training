namespace Startup.TrainingOneHomeworks.marcin022.bank_1_2
{
    public interface IAccValidation
    {
        string AccNumber { get; set; }
        string BankId { get; set; }

        string CheckNumberFormat(string accNumber);
        string CutToId(string fixedNumber);
    }
}