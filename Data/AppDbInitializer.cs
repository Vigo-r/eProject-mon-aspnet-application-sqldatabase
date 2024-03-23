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
                            Name = "Bibliotheek Breda",
                            Logo = "https://www.bibliotheekbreda.nl/iguana/img/Webbannerklein.png",
                            Description = "Bibliotheek Breda is located on Molenstraat in Breda." +
                            " The library building is a 5-minute walk from the Breda Centrum bus stop located on Karnemelkstraat." +
                            " The Bibliotheek Breda, Nieuwe Veste Centre of the Arts Breda and Cultuurwinkel Breda (Culture Centre) are now under one brand name - the \"Nieuwe Veste\"."
                        },
                        new Library()
                        {
                            Name = "Old Library of Trinity College",
                            Logo = "https://www.tcd.ie/media/tcd/site-assets/images/tcd-logo.png",
                            Description = "Appropriately named the Long Room, this space is located within the Old Library at Trinity College." +
                            " Previously, the room’s ceiling was flat and only shelved books on the lower level." +
                            " However, the college was granted a free copy of every book published in Britain and Ireland, requiring the expansion of the cavernous space."
                        },
                        new Library()
                        {
                            Name = "Cite de l’Architecture et du Patrimoine",
                            Logo = "https://www.citedelarchitecture.fr/themes/custom/portail/images/svg/logo_capa.svg",
                            Description = "The library at the Cite de l’Architecture et du Patrimoine in Paris is a must visit for any architecture lover." +
                            " Not only because of the stunning location in a Romanesque sistine, but also because its entire collection is dedicated to works about architecture, urbanism, and landscaping." +
                            " The library also houses the largest collection of preserved romanesque wall paintings in France."
                        },
                        new Library()
                        {
                            Name = "The Hachioji Library",
                            Logo = "https://libopac.tamabi.ac.jp/opac/images/cyan/logo.png",
                            Description = "Situated in Tama Art University with an open floor plan and concrete colonnades, this brutalist-inspired building exudes cool minimalism." +
                            " Designed by Pritzker Prize–winning firm Toyo Ito & Associates, the head of the univeristy, Hidemi Kondo, says the space plays an important role for students." +
                            " Not only is it a place for research and education, but also a source of inspiration for the artists."
                        },
                        new Library()
                        {
                            Name = "New York Public Library",
                            Logo = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi0.wp.com%2Fgclibrary.commons.gc.cuny.edu%2Ffiles%2F2020%2F11%2FNYPL_logo1_black_pos-scaled.jpg%3Ffit%3D2560%252C1574%26ssl%3D1&f=1&nofb=1&ipt=33ca6d259360065c3fbf6fd167a5bf47f0397e0ed420d30cb47eeed91cd1755f&ipo=images",
                            Description = "The main branch of the New York City public library system, the Stephen A. Schwarzman Building is a Beaux Arts masterpiece in midtown Manhattan." +
                            " The library is divided into nine sections, with an estimated 2.5 million volumes in its collection." +
                            " The Rose Main Reading Room, seen here, measures 24 meters by 90 meters — roughly the size of two city blocks."
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
                            FullName = "Yuval Noah Harari",
                            Bio = "Prof. Yuval Noah Harari is a historian, philosopher, and the bestselling author." +
                            " His books have sold over 45 Million copies in 65 languages, and he is considered one of the world’s most influential public intellectuals today.",
                            ProfilePictureURL = "https://media.gq.com/photos/5bac0716564016036a2bdae5/1:1/w_2000,h_2000,c_limit/Yuval-Noah-Harari-Author-interview-21-Questions-for-the-21st-Century-gq-092618-3x2.jpg"

                        },
                        new Author()
                        {
                            FullName = "J. R. R. Tolkien",
                            Bio = "John Ronald Reuel Tolkien (3 January 1892 – 2 September 1973) was an English writer and philologist." +
                            " From 1925 to 1945, Tolkien was the Rawlinson and Bosworth Professor of Anglo-Saxon and a Fellow of Pembroke College," +
                            " both at the University of Oxford. He then moved within the same university to become the Merton Professor of English Language and Literature" +
                            " and Fellow of Merton College, and held these positions from 1945 until his retirement in 1959.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/J._R._R._Tolkien%2C_ca._1925.jpg/220px-J._R._R._Tolkien%2C_ca._1925.jpg"
                        },
                        new Author()
                        {
                            FullName = "William L. Shirer",
                            Bio = "This is the Bio of the second author",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BNTg2ZmRmOTYtMzg2ZS00NjJhLTk5YjgtNzdlMmExMmNmYWEyXkEyXkFqcGdeQXVyMTk2MzI2Ng@@._V1_.jpg"
                        },
                        new Author()
                        {
                            FullName = "Agatha Christie",
                            Bio = "Dame Agatha Mary Clarissa Christie, Lady Mallowan (15 September 1890 – 12 January 1976) was an English writer. " +
                            "Christie has been called the \"Queen of Crime\"—a moniker which is now trademarked by her estate." +
                            " She was made a Dame by Queen Elizabeth II for her contributions to literature. Agatha Christie is recorded as the best-selling fiction writer of all time, her novels having sold more than two billion copies.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Agatha_Christie.png/220px-Agatha_Christie.png"
                        },
                        new Author()
                        {
                            FullName = "Harper Lee",
                            Bio = "Nelle Harper Lee (April 28, 1926 – February 19, 2016) was an American novelist. Her second and final novel, Go Set a Watchman, was an earlier draft of Mockingbird that was published in July 2015 as a sequel.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b5/Photo_portrait_of_Harper_Lee_%28To_Kill_a_Mockingbird_dust_jacket%2C_1960%29.jpg/220px-Photo_portrait_of_Harper_Lee_%28To_Kill_a_Mockingbird_dust_jacket%2C_1960%29.jpg"
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
                            PublisherName = "Harvill Secker",
                            PublisherDescription = "Secker & Warburg was formed in 1935." +
                            " The firm became renowned for its political stance, being both anti-fascist and anti-communist, a position that put them at loggerheads with the ethos of many intellectuals of the time.",
                            PublisherPictureURL = "https://upload.wikimedia.org/wikipedia/en/1/1f/Harvil_Secker_logo.jpg"

                        },
                        new Publisher()
                        {
                            PublisherName = "Penguin Random House",
                            PublisherDescription = "Random House was founded in 1927 by Bennett Cerf and Donald Klopfer." +
                            " The house has grown from $10 million in revenue in 1976, to more than $200 million by 1993 and without increasing their title output. In 2003, Random House reentered the distribution business.",
                            PublisherPictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/b/bc/Random_House_logo.svg/220px-Random_House_logo.svg.png"
                        },
                        new Publisher()
                        {
                            PublisherName = "Allen & Unwin",
                            PublisherDescription = "George Allen & Sons was established in 1871 by George Allen." +
                            " Allen & Unwin Australia Pty Ltd became independent in July 1990." +
                            " Now known simply as \"Allen & Unwin\", the company went on to become the most successful independent publisher in Australia.",
                            PublisherPictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/7/75/Allen_%26_Unwin_logo.svg/220px-Allen_%26_Unwin_logo.svg.png"
                        },
                        new Publisher()
                        {
                            PublisherName = "Simon & Schuster",
                            PublisherDescription = "In 1924 Simon and Max Schuster decided to launch the company. They pooled US$8,000, equivalent to $137,000 today. " +
                            "October 30, 2023, it was announced that Simon & Schuster was sold to Kohlberg Kravis Roberts for $1.62 billion.",
                            PublisherPictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/d/db/Simon_and_Schuster.svg/140px-Simon_and_Schuster.svg.png"
                        },
                        new Publisher()
                        {
                            PublisherName = "Collins Crime Club",
                            PublisherDescription = "Collins Crime Club was an imprint of British book publishers William Collins, Sons and ran from 6 May 1930 to April 1994." +
                            " Throughout its 64 years the club issued a total of 2,012 first editions of crime novels and reached a high standard of quality throughout." +
                            " In the field of crime book collecting, Collins Crime Club is eagerly sought, particularly pre-war first editions in dust wrappers with their vivid and imaginative images. " +
                            "Now Defunct.",
                            PublisherPictureURL = "https://upload.wikimedia.org/wikipedia/en/d/d7/Collins_Crime_Club_logo.jpg"
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
                            Name = "Sapiens A Brief History of Humankind",
                            Description = "A book with a historical overview of human evolution and civilization, addressing how humans became the dominant species and shaped their societies, economies, and cultures.",
                            Price = 39.50,
                            CoverURL = "https://m.media-amazon.com/images/I/716E6dQ4BXL._AC_UF1000,1000_QL80_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            LibraryId = 3,
                            PublisherId = 2,
                            BookGenre = BookGenre.Nonfiction
                        },
                        new Book()
                        {
                            Name = "Homo Deus",
                            Description = "The book sets out to examine possibilities of the future of Homo sapiens." +
                            " The premise outlines that during the 21st century, humanity is likely to make a significant attempt to gain happiness, immortality, and God-like powers." +
                            " Throughout the book, Harari openly speculates various ways that this ambition might be realised in the future based on the past and present.",
                            Price = 29.50,
                            CoverURL = "https://media.shortform.com/covers/png/homo-deus-cover@8x.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            LibraryId = 1,
                            PublisherId = 1,
                            BookGenre = BookGenre.Fiction
                        },
                        new Book()
                        {
                            Name = "The Lord of the Rings",
                            Description = "The Lord of the Rings is an epic high fantasy novel. Set in Middle-earth, " +
                            "the story began as a sequel to The Hobbit, but eventually developed into a much larger work." +
                            " Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.",
                            Price = 39.50,
                            CoverURL = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1566425108l/33.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            LibraryId = 4,
                            PublisherId = 3,
                            BookGenre = BookGenre.Fantasy
                        },
                        new Book()
                        {
                            Name = "The Rise and Fall of the Third Reich: A History of Nazi Germany",
                            Description = "Hitler boasted that The Third Reich would last a thousand years. It lasted only 12." +
                            " But those 12 years contained some of the most catastrophic events Western civilization has ever known." +
                            " No other powerful empire ever bequeathed such mountains of evidence about its birth and destruction as the Third Reich." +
                            "The famed foreign correspondent and historian William L. Shirer, who had watched and reported on the Nazis since 1925," +
                            " spent five and a half years sifting through documentation. The result is a monumental study that has been widely acclaimed as the definitive record of one of the most frightening chapters in the history of mankind.",
                            Price = 39.50,
                            CoverURL = "https://m.media-amazon.com/images/I/71EkP5n-z0L._AC_UF1000,1000_QL80_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            LibraryId = 2,
                            PublisherId = 4,
                            BookGenre = BookGenre.History
                        },
                        new Book()
                        {
                            Name = "Murder on the Orient Express",
                            Description = "Work of detective fiction featuring the Belgian detective Hercule Poirot." +
                            " The elegant train of the 1930s, the Orient Express, is stopped by heavy snowfall." +
                            " A murder is discovered, and Poirot's trip home to London from the Middle East is interrupted to solve the case. The opening chapters of the novel take place primarily in Istanbul." +
                            " The rest of the novel takes place in Yugoslavia, with the train trapped between Vinkovci and Brod. ",
                            Price = 39.50,
                            CoverURL = "https://i0.wp.com/efsunland.com/wp-content/uploads/2017/01/murder-on-the-orient-express_cover.jpg?fit=969%2C1500&ssl=1",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            LibraryId = 5,
                            PublisherId = 5,
                            BookGenre = BookGenre.Mystery
                        },
                        new Book()
                        {
                            Name = "To Kill a Mockingbird ",
                            Description = "To Kill a Mockingbird is a novel published in June 1960 and became instantly successful." +
                            " To Kill a Mockingbird has become a classic of modern American literature. А year after its release, it won the Pulitzer Prize." +
                            " The plot and characters are loosely based on Lee's observations of her family, her neighbors and an event that occurred near her hometown of Monroeville, Alabama, in 1936, when she was ten. ",
                            Price = 39.50,
                            CoverURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/To_Kill_a_Mockingbird_%28first_edition_cover%29.jpg/220px-To_Kill_a_Mockingbird_%28first_edition_cover%29.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            LibraryId = 1,
                            PublisherId = 2,
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
                            AuthorId = 2,
                            BookId = 2
                        },

                         new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 3
                        },
                         new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 4
                        },

                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 5
                        },

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}