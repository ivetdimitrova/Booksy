﻿namespace Booksy.Data.Models
{
    public class Ganre
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<BookGanre> Books { get; set; }
        = new HashSet<BookGanre>();
    }
}
