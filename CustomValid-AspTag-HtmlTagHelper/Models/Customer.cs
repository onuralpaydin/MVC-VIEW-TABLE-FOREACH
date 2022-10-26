using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CustomValid_AspTag_HtmlTagHelper.Models
{
    public class Customer : IValidatableObject
    {
        [Required(ErrorMessage = "Customer Id zorunlu.")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "CompanyName zorunlu.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Yaş Zorunlu.")]
        [Range(18, 41, ErrorMessage = "Yaşınız 18-100 arasında olmalı")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email Zorunlu.")]
        [DataType(DataType.EmailAddress)]
        //[EmailAddress]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Katılım Tarihi zorunlu.")]
        public DateTime JoinDate { get; set; }

        [Required(ErrorMessage = "Müşteri Türü Zorunlu.")]
        [EnumDataType(typeof(CustomerType), ErrorMessage = "Geçersiz Müşteri Türü")]
        public CustomerType CustomerTipi { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new List<ValidationResult>();

            if (this.Age <= 18 || this.Age > 40)
            {
                result.Add(new ValidationResult("Kullanıcı Yaşı 18-40 arasında olmalıdır."));
            }
            if (this.CompanyName.Length < 3 || this.CompanyName.Length > 30)
            {
                result.Add(new ValidationResult("Company Name can not be less than 3 letters"));
            }


            //Hocam Burda enum kontrolü yapmaya çalıştım ama kontrolü gerçekleştirmiyor.


            //if(Enum.IsDefined(typeof(CustomerType), this.CustomerTipi))
            //{
            //    result.Add(new ValidationResult("Müşteri Tipi Geçersiz"));
            //}
            //if (this.CustomerTipi != CustomerType.New || this.CustomerTipi != CustomerType.Elite || this.CustomerTipi != CustomerType.Regular)
            //{
            //    result.Add(new ValidationResult("Müşteri Tipi Geçersiz"));
            //}
            if (this.JoinDate.Year < 2000 || this.JoinDate > DateTime.Now)
            {
                result.Add(new ValidationResult("JoinDate is not valid."));
            }

            return result;
        }
    }
    public enum CustomerType
    {
        New = 0, Regular, Elite
    }
}
