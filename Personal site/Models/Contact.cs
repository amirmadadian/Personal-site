using System.ComponentModel.DataAnnotations;

namespace Personal_site.Models
{
	public class Contact
	{
        [Required(ErrorMessage =" این فیلد اجباری است ")]
        [MinLength(3,ErrorMessage =" نام باید حداقل سه حرف داشته باشد")]
        [MaxLength(100,ErrorMessage =" نام نمیتواند بیش از این مقدار باشد")]
        public string Name { get; set; }
		[Required(ErrorMessage = " این فیلد اجباری است ")]
		[EmailAddress(ErrorMessage ="ایمیل وارد شده صحیح نمی باشد ")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
