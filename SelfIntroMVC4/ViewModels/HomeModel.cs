using System.ComponentModel.DataAnnotations;

namespace SelfIntroMVC4.ViewModels
{
    public class HomeModel
    {
        [Display(Name="關於我")]
        public string ShortAboutMe { get; set; }
        [Display(Name = "自傳")]
        public string ShortAutobiography { get; set; }
        [Display(Name = "聯絡我")]
        public string Contact { get; set; }
    }
}