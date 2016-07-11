using SelfIntroMVC4.Types;
using System;
using System.ComponentModel.DataAnnotations;

namespace SelfIntroMVC4.ViewModels
{
    public class AboutMeModel
    {
        [Display(Name="姓名")]
        public string Name { get; set; }
        [Display(Name="綽號")]
        public string NickName { get; set; }
        [Display(Name="英文名字")]
        public string EnglishName { get; set; }
        [Display(Name="性別")]
        public SexType Sex { get; set; }
        [Display(Name="生日")]
        public DateTime BirthDay { get; set; }
    }
}