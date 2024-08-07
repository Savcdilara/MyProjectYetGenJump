﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("Server=91.151.83.102;Port=5432;Database=MyProject;UserId=yunusemresenteam;Password=3*ZM44j3bglBULDrlsyjKB595;");
		}

		public DbSet<About> Abouts { get; set; }
		public DbSet<About2> About2s { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Destination> Destinations { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Feature2> Feature2s { get; set; }
		public DbSet<Guide> Guides { get; set; }
		public DbSet<NewsLetter> NewsLetters { get; set; }
		public DbSet<SubAbout> SubAbout { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<Comment> Comment { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
	}
}
