using Moldovan_Andrei.Models;

namespace Moldovan_Andrei.ViewModels
{
    public class CategoryIndexData
    {

        public IEnumerable<Category>? Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}