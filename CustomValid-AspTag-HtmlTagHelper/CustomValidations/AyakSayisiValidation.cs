using System.ComponentModel.DataAnnotations;

namespace CustomValid_AspTag_HtmlTagHelper.CustomValidations
{
    public class AyakSayisiValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int ayakSayisi = (int)value;
            if (ayakSayisi == 2 || ayakSayisi == 4 || ayakSayisi == 6 || ayakSayisi == 8)
                return ValidationResult.Success;
            else
                return new ValidationResult("Ayak sayısı geçersiz");
        }
    }
}
