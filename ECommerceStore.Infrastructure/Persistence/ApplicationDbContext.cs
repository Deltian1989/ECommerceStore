﻿using ECommerceStore.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceStore.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Smamsung TV Set 4K 50'",
                Amount = 20,
                Description = "Good old Samsung TV Set 50'",
                UnitPrice = 1400,
                ImagePath = "/productImages/tvset.jpg"
            },
            new Product
            {
                Id = 2,
                Name = "Mario Kart 8 Deluxe",
                Amount = 50,
                Description = "Very good kart racing game with our favorite characters like Mario, Luigi etc.",
                UnitPrice = 289,
                ImagePath = "/productImages/marioswitch.jpg"
            },
            new Product
            {
                Id = 3,
                Name = "Playstation 5",
                Amount = 40,
                Description = "The latest generation of the Playstation consoles available in marketplace",
                UnitPrice = 1700,
                ImagePath = "/productImages/playstation5.jpg"
            },
            new Product
            {
                Id = 4,
                Name = "Minecraft Java Edition (2011)",
                Amount = 200,
                Description = "Classic Minecraft Java Edition (PC only)",
                UnitPrice = 110,
                ImagePath = "/productImages/minecraft.jpg"
            },
            new Product
            {
                Id = 5,
                Name = "Pirates of the Caribbean: Dead Men Tell No Tales (DVD/Blu-ray)",
                Description = "Captain Jack Sparrow (Johnny Depp) sets sail for a fifth effects-filled swashbuckler, now on a quest for the Trident of Poseidon and the ultimate power it can bestow. However, he'll have to outrace young Henry Turner (Brenton Thwaites), who's looking to free father Will (Orlando Bloom) from the Flying Dutchman's curse... and outpace the vengeance hunt of the undead Captain Salazar (Javier Bardem). Geoffrey Rush, Kaya Scodelario, and Keira Knightley co-star.",
                ImagePath = "https://m.media-amazon.com/images/I/81aLSDXBZqL._AC_SY606_.jpg",
                UnitPrice = 39.99m,
            },
                new Product
                {
                    Id = 6,
                    Name = "Heroes of Might & Magic III Complete (PC CD-ROM)",
                    Description = "This is a must have for every Might and Magic series fan! Includes Heroes of Might & Magic III and its expansions: Armageddon's Blade and The Shadow of Death. Insanely addictive gameplay that will make you want to play “just one more turn” over and over again great multiplayer, especially when playing in hot seat mode on one PC",
                    ImagePath = "https://i.ebayimg.com/images/g/0pcAAOSw3~diWWLL/s-l1600.jpg",
                    UnitPrice = 35m,
                },
                new Product
                {
                    Id = 7,
                    Name = "ORIGINAL Nintendo Entertainment System Video Game Bundle Set Kit NES Console OG",
                    Description = "This is the original vintage gaming system from the 1980's. It comes with brand new accessories, which makes you feel like you are playing it for the first time again! Please note that this is NOT the \"Classic\" edition that has pre-loaded games, you will have to use old school game cartridges in this system (not included) like its 1989.",
                    ImagePath = "https://i.ebayimg.com/images/g/AD4AAOSw3YphYRwA/s-l1600.jpg",
                    UnitPrice = 170m,
                },
                new Product
                {
                    Id = 8,
                    Name = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                    ImagePath = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    UnitPrice = 80m,
                },
                    new Product
                    {
                        Id = 9,
                        Name = "Ready Player One",
                        Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                        UnitPrice = 80m,
                    },
                    new Product
                    {
                        Id = 10,
                        Name = "Nineteen Eighty-Four",
                        Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                        UnitPrice = 69m,
                    },
                    new Product
                    {
                        Id = 11,
                        Name = "The Matrix",
                        Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                        UnitPrice = 60m,
                    },
                    new Product
                    {
                        Id = 12,
                        Name = "Back to the Future",
                        Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                        UnitPrice = 59m,
                    },
                    new Product
                    {
                        Id = 13,
                        Name = "Toy Story",
                        Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                        UnitPrice = 50m,

                    },
                    new Product
                    {
                        Id = 14,
                        Name = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                        UnitPrice = 64m,

                    },
                    new Product
                    {
                        Id = 15,
                        Name = "Diablo II",
                        Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                        UnitPrice = 45m,
                    },
                    new Product
                    {
                        Id = 16,
                        Name = "Day of the Tentacle",
                        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                        UnitPrice = 75m,
                    },
                    new Product
                    {
                        Id = 17,
                        Name = "Xbox",
                        Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                        UnitPrice = 1500m,
                    },
                    new Product
                    {
                        Id = 18,
                        Name = "Super Nintendo Entertainment System",
                        Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                        ImagePath = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                        UnitPrice=600m
                    });
        }
    }
}
