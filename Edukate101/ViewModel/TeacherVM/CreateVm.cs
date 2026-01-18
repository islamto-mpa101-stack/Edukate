using System.ComponentModel.DataAnnotations;

namespace Edukate101.ViewModel.TeacherViewModel
{
    public class CreateVm
    {
        [Required, MaxLength(255)]
        public string FullName { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public int CourseId { get; set; }

    }
}
