using Microsoft.EntityFrameworkCore;

namespace asp_net_web_api_sample.Models {
  public class TodoContext : DbContext {

    public TodoContext(DbContextOptions<TodoContext> options) : base(options) {

    }

    public DbSet<TodoItem> TodoItems {get; set;}
  }
}