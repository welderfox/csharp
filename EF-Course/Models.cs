using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF_Course
{
  public class Blogging : DbContext
  {
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Sourse=blogging.db");
  }

  public class Blog
  {
    public int BlogId { get; set; }
    public string Url { get; set; }

    public List<Post> Posts { get; } = new List<Post>();
  }

  public class Post
  {
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
  }
}

//LINK Para continuar https://docs.microsoft.com/pt-br/ef/core/get-started/?tabs=netcore-cli