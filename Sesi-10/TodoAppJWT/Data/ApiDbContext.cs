using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TodoAppJWT.Models;

namespace TodoAppJWT.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
    }
}