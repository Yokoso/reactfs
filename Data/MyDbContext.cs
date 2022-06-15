using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using reactfs.Models;

namespace reactfs.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {

    }

    public DbSet<Note> Notes { get; set; }
}
