

namespace BlazorEcommerce.Server.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData

                       (new Product
                        {
                            Id = 1,
                            Title = "The Hitchhiker's Guide to the Galaxy2112",
                            Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Price = 9.99m
                        },
                        new Product
                        {
                            Id = 2,
                            Title = "Breakfast of Champions",
                            Description = "Breakfast of Champions, or Goodbye Blue Monday is a 1973 novel by the American author Kurt Vonnegut. His seventh novel, it is set predominantly in the fictional town of Midland City, Ohio, and focuses on two characters: Dwayne Hoover, a Midland resident, Pontiac dealer and affluent figure in the city, and Kilgore Trout, a widely published but mostly unknown science fiction author. Breakfast of Champions deals with themes of free will, suicide, and race relations, among others. The novel is full of drawings by the author, substituting descriptive language with depictions requiring no translation.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/46/BreakfastOfChampions%28Vonnegut%29.jpg",
                            Price = 11.99m
                        },
                        new Product
                        {
                            Id = 3,
                            Title = "The Brothers Karamazov",
                            Description = "The Brothers Karamazov (Russian: Братья Карамазовы, Brat'ya Karamazovy, pronounced [ˈbratʲjə kərɐˈmazəvɨ]), also translated as The Karamazov Brothers, is the last novel by Russian author Fyodor Dostoevsky. Dostoevsky spent nearly two years writing The Brothers Karamazov, which was published as a serial in The Russian Messenger from January 1879 to November 1880. Dostoevsky died less than four months after its publication. It has been acclaimed as one of the supreme achievements in world literature.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2d/Dostoevsky-Brothers_Karamazov.jpg",
                            Price = 5.99m
                        });


        }


        public DbSet<Product> Products { get; set; }
    }
}
