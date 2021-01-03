using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportFeedBack.Data
{
    public class DbSeed
    {
        private readonly FeedBackDbContext _context;

        public DbSeed(FeedBackDbContext context)
        {
            _context = context;
        }
        public void Init()
        {
            if (!_context.User.Any())
            {
                _context.User.Add(new Entity.User
                {
                    UserName = "User",
                    RoleName = "Admin",


                });
                _context.User.Add(new Entity.User
                {
                    UserName = "User1",
                    RoleName = "Admin",
                }); ;
                _context.SaveChanges();
            }
            if (!_context.Post.Any())
            {
                _context.Post.Add(new Entity.Post
                {
                    UserId = 1,
                    Title = "PostOne",
                    Description = "Post One Description",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> {
                        new Entity.Comment { Desc = "Post One Comments1", Like = 10, Dislike = 0, UserId = 1,EntryDate=DateTime.Now },
                        new Entity.Comment { Desc = "Post One Comments2", Like = 20, Dislike = 5, UserId = 2, EntryDate = DateTime.Now}
                    }

                });
                _context.Post.Add(new Entity.Post
                {
                    UserId = 2,
                    Title = "PostTwo",
                    Description = "Post Two Description",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> { 
                        new Entity.Comment { Desc = "Post Two Comments1", Like = 500, Dislike = 15, UserId = 1, EntryDate = DateTime.Now },
                        new Entity.Comment { Desc = "Post Two Comments2", Like = 400, Dislike = 10, UserId = 2, EntryDate = DateTime.Now },
                        new Entity.Comment { Desc = "Post Two Comments3", Like = 200, Dislike = 8, UserId = 2, EntryDate = DateTime.Now }
                    }

                });
                _context.Post.Add(new Entity.Post
                {
                    UserId = 2,
                    Title = "PostThree",
                    Description = "Post Three Description",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> { 
                        new Entity.Comment { Desc = "Post Three Comments", Like = 200, Dislike = 2, UserId = 2, EntryDate = DateTime.Now } 
                    }

                });
                _context.Post.Add(new Entity.Post
                {
                    UserId = 1,
                    Title = "PostFour",
                    Description = "Post Four Description",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> { new Entity.Comment {
                        Desc = "Post Four Comments", Like = 150, Dislike = 11, UserId = 1, EntryDate = DateTime.Now }
                    }

                });
                _context.Post.Add(new Entity.Post
                {
                    UserId = 1,
                    Title = "PostFive",
                    Description = "Post Five Description",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> {
                        new Entity.Comment { Desc = "Post Five Comments", Like = 270, Dislike = 20, UserId = 1, EntryDate = DateTime.Now } 
                    }

                });
                _context.Post.Add(new Entity.Post
                {
                    UserId = 1,
                    Title = "PostSix",
                    Description = "Post Six Description",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> {
                        new Entity.Comment { Desc = "Post Six Comments", Like = 5000, Dislike = 30, UserId = 1, EntryDate = DateTime.Now }
                    }

                });
                _context.Post.Add(new Entity.Post
                {
                    UserId = 1,
                    Title = "PostSeven",
                    Description = "Post Seven Description",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> {
                        new Entity.Comment { Desc = "Post Seven Comments", Like = 3000, Dislike = 40, UserId = 1, EntryDate = DateTime.Now } 
                    }

                });
                _context.Post.Add(new Entity.Post
                {
                    UserId = 1,
                    Title = "PostEight",
                    Description = "Post Eight Description",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> {
                        new Entity.Comment { Desc = "Post Eight Comments", Like = 700, Dislike = 10, UserId = 1, EntryDate = DateTime.Now }
                    }

                });
                _context.Post.Add(new Entity.Post
                {
                    UserId = 1,
                    Title = "PostNine",
                    Description = "Test 6",
                    EntryDate = DateTime.Now,
                    Comments = new List<Entity.Comment> {
                        new Entity.Comment { Desc = "N/A", Like = 600, Dislike = 20, UserId = 1, EntryDate = DateTime.Now }
                    }

                });
                _context.SaveChanges();
            }
        }
    }
}
