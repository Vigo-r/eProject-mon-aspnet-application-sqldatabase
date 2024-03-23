using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Libraries.Any())
                {
                    context.Libraries.AddRange(new List<Library>()
                    {

                        new Library()
                        {
                            Name = "Library 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first library"
                        },
                        new Library()
                        {
                            Name = "Library 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first library"
                        },
                        new Library()
                        {
                            Name = "Library 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first library"
                        },
                        new Library()
                        {
                            Name = "Library 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first library"
                        },
                        new Library()
                        {
                            Name = "Library 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first library"
                        },
                    });
                    context.SaveChanges();

                }
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "Author 1",
                            Bio = "This is the Bio of the first author",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Author()
                        {
                            FullName = "Author 2",
                            Bio = "This is the Bio of the second author",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Author()
                        {
                            FullName = "Author 3",
                            Bio = "This is the Bio of the second author",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Author()
                        {
                            FullName = "Author 4",
                            Bio = "This is the Bio of the second author",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Author()
                        {
                            FullName = "Author 5",
                            Bio = "This is the Bio of the second author",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            PublisherName = "Publisher 1",
                            PublisherDescription = "This is the Bio of the first author",
                            PublisherPictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Publisher()
                        {
                            PublisherName = "Publisher 2",
                            PublisherDescription = "This is the Bio of the second author",
                            PublisherPictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Publisher()
                        {
                            PublisherName = "Publisher 3",
                            PublisherDescription = "This is the Bio of the second author",
                            PublisherPictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Publisher()
                        {
                            PublisherName = "Publisher 4",
                            PublisherDescription = "This is the Bio of the second author",
                            PublisherPictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Publisher()
                        {
                            PublisherName = "Publisher 5",
                            PublisherDescription = "This is the Bio of the second author",
                            PublisherPictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            CoverURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            LibraryId = 3,
                            PublisherId = 3,
                            BookGenre = BookGenre.Thriller
                        },
                        new Book()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            CoverURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            LibraryId = 1,
                            PublisherId = 1,
                            BookGenre = BookGenre.Fiction
                        },
                        new Book()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            CoverURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            LibraryId = 4,
                            PublisherId = 4,
                            BookGenre = BookGenre.Fantasy
                        },
                        new Book()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            CoverURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            LibraryId = 1,
                            PublisherId = 2,
                            BookGenre = BookGenre.Thriller
                        },
                        new Book()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            CoverURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            LibraryId = 1,
                            PublisherId = 3,
                            BookGenre = BookGenre.Fiction
                        },
                        new Book()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            CoverURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            LibraryId = 1,
                            PublisherId = 5,
                            BookGenre = BookGenre.History
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Authors_Books.Any())
                {
                    context.Authors_Books.AddRange(new List<Author_Book>()
                    {
                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 1
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 1
                        },

                         new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 2
                        },
                         new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 2
                        },

                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 3
                        },
                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 3
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 3
                        },


                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 4
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 4
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 4
                        },


                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 5
                        },


                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 6
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 6
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }           
        }
    }
}
