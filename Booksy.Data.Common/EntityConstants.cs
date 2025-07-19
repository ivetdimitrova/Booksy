namespace Booksy.Data.Common
{
    public static class EntityConstants
    {
        public static class Author
        {
            public const int NameMaxLength = 40;
        }

        public static class Book
        {
            public const int TitleMaxLength = 610;
            public const int ISBNMaxLength = 17;
     
        }

        public static class Ganre
        {
            public const int NameMaxLength = 85;
        }
       
        public static class ApplicationUser
        {
            public const int FirstNameMaxLength = 50;

            public const int LastNameMaxLength = 50;
        }
    }
}
