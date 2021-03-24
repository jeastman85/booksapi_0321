using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Books.Any()) return;

            var books = new List<Book>
            {
                new Book
                {
                    Title = "Red Riding Hood",
                    Author = "Mother Goose",
                    ISBN = "1432"
                },
                new Book 
                {
                    Title = "Catcher in the Rye",
                    Author = "J.D. Salinger",
                    ISBN = "4633"
                },
                new Book 
                {
                    Title = "A Brave new World",
                    Author = "Aldous Huxlex",
                    ISBN = "7819"
                }
            };

            await context.Books.AddRangeAsync(books);
            await context.SaveChangesAsync();

            
        }
    }
}