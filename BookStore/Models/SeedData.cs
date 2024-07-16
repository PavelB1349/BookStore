using BookStore.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreContext>>()))
            {
                // Проверяем, есть ли уже данные
                if (context.Book.Any())
                {
                    return;   // Данные уже существуют, выходим
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "The Lord of the Rings",
                        Author = "J.R.R. Tolkien",
                        Price = 15.99m,
                        Description = "An epic fantasy novel.",
                        ImageUrl = "https://th.bing.com/th/id/OIP.KzELUrmbJ4Blygqr2_3A4gHaK0?rs=1&pid=ImgDetMain"
                    },
                    new Book
                    {
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Author = "Douglas Adams",
                        Price = 9.99m,
                        Description = "A humorous science fiction novel.",
                        ImageUrl = "https://th.bing.com/th/id/R.77c4f5d95b7bf5dcc5615d363da47596?rik=KRCh3digZNOWCA&riu=http%3a%2f%2f4.bp.blogspot.com%2f_KFxmlXHAk1A%2fTT3xWKVzB9I%2fAAAAAAAACTE%2fNE4KyvH94ys%2fs1600%2fhitchhikers_guide_to_the_galaxy_v1.jpg&ehk=O8YYujmyoGFKxYQcPu7xCfI1PSpaA9ZZJ7oxk23bnOc%3d&risl=&pid=ImgRaw&r=0"
                    },
                    new Book
                    {
                        Title = "Pride and Prejudice",
                        Author = "Jane Austen",
                        Price = 7.99m,
                        Description = "A classic romantic novel.",
                        ImageUrl = "https://th.bing.com/th/id/OIP.9yfd27lCEs9mncqTV_25WwHaLH?w=2000&h=3000&rs=1&pid=ImgDetMain"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
