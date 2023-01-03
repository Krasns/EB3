using EB3.Shared;
using System.Net.Http.Json;

namespace EB3.Client.Services
{
    public class RomanNumeralService : IRomanNumeralService
    {
        private readonly HttpClient _http;

        public RomanNumeralService(HttpClient http)
        {
            _http = http;
        }

        public async Task<RomanNumeral> PostConvertNumber(RomanNumeral request)
        {
            var result = await _http.PostAsJsonAsync("api/RomanNumeral", request);
            return await result.Content.ReadFromJsonAsync<RomanNumeral>();
        }

        public async Task<List<RomanNumeral>> GetRomanNumerals()
        {
            return await _http.GetFromJsonAsync<List<RomanNumeral>>("api/RomanNumeral");
        }

        public string Generate(int number)
        {
            string romanNumeral = "";
            if (number >= 0 || number <= 3999)
            {
                while (number > 0)
                {
                    if (number >= 1000)
                    {
                        romanNumeral += "M";
                        number -= 1000;
                    }
                    else if (number >= 900)
                    {
                        romanNumeral += "DM";
                        number -= 900;
                    }
                    else if (number >= 500)
                    {
                        romanNumeral += "D";
                        number -= 500;
                    }
                    else if (number >= 400)
                    {
                        romanNumeral += "CD";
                        number -= 400;
                    }
                    else if (number >= 100)
                    {
                        romanNumeral += "C";
                        number -= 100;
                    }
                    else if (number >= 90)
                    {
                        romanNumeral += "XC";
                        number -= 90;
                    }
                    else if (number >= 50)
                    {
                        romanNumeral += "L";
                        number -= 50;
                    }
                    else if (number >= 50)
                    {
                        romanNumeral += "XL";
                        number -= 40;
                    }
                    else if (number >= 10)
                    {
                        romanNumeral += "X";
                        number -= 10;
                    }
                    else if (number >= 10)
                    {
                        romanNumeral += "IX";
                        number -= 9;
                    }
                    else if (number >= 5)
                    {
                        romanNumeral += "V";
                        number -= 5;
                    }
                    else if (number >= 4)
                    {
                        romanNumeral += "IV";
                        number -= 4;
                    }
                    else if (number >= 1)
                    {
                        romanNumeral += "I";
                        number -= 1;
                    }

                }
            }
            else
            {
                return "Insert value between 1 and 3999";
            }

            return romanNumeral;
        }
    }
}
