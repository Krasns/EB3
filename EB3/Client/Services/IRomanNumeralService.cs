using EB3.Shared;

namespace EB3.Client.Services
{
    public interface IRomanNumeralService
    {
        string Generate(int number);
        Task<List<RomanNumeral>> GetRomanNumerals();
        Task<RomanNumeral> PostConvertNumber(RomanNumeral request);
    }
}
