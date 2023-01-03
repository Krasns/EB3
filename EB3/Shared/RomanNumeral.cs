using System;
using System.ComponentModel.DataAnnotations;

namespace EB3.Shared
{
    public class RomanNumeral
    {
        [Key]
        public int Id { get; set; }
        public string? Numeral { get; set; }
        [Required, Range(1,3999, ErrorMessage = "Enter numbers from 1 to 3999")]
        public int HinduArabicNumeral { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
