using System.ComponentModel.DataAnnotations;

namespace Edukate101.ViewModel.CourseViewModel
{
    public class CourseUpdateVM
    {
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Title { get; set; }
        public IFormFile? Image { get; set; }
        [Range(0, 6)]
        public double Rating { get; set; }
    }
}
