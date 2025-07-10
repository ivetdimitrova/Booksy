using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Booksy.ViewModels
{
    public class BookIndexViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string? ImageUrl { get; set; }

        public string Genre { get; set; } = null!;
        public int SavedCount {  get; set; }


    }
}
