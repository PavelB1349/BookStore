using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Название книги обязательно.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Автор книги обязателен.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Цена книги обязательна.")]
        [DataType(DataType.Currency)]
        [Range(0.01, double.MaxValue, ErrorMessage = "Цена должна быть больше 0.")]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
