using InstrumentInformation.Models.Entity.Enums;
using InstrumentInformation.Models.Entity.Instrument;
using InstrumentInformation.Models.Entity.User;
using InstrumentInformation.Utils.Converter;
using Microsoft.EntityFrameworkCore;

namespace InstrumentInformation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>().ToTable("users");
            // modelBuilder.Entity<Role>().ToTable("roles");
            // modelBuilder.Entity<UserRole>().ToTable("user_roles");
            // modelBuilder.Entity<UserRole>()
            //     .HasKey(ur => new { ur.UserId, ur.RoleId });
            //
            // // Configure relationship between User and UserRole
            // modelBuilder.Entity<UserRole>()
            //     .HasOne(ur => ur.User)
            //     .WithMany()
            //     .HasForeignKey(ur => ur.UserId);
            //
            // modelBuilder.Entity<UserRole>()
            //     .HasOne(ur => ur.Role)
            //     .WithMany()
            //     .HasForeignKey(ur => ur.RoleId);


            List<InstrumentType> instrumentTypes =
                EnumToInstrumentTypeConverter.ConvertEnumToInstrumentTypeList<InstrumentTypeEnum>();
            modelBuilder.Entity<Instrument>()
                .Property(i => i.CreatedDate)
                .HasColumnType("DATE");

            modelBuilder.Entity<Instrument>()
                .Property(i => i.ExpiredDate)
                .HasColumnType("DATE");
            modelBuilder.Entity<InstrumentType>().ToTable("instrument_types").HasData(instrumentTypes);
            modelBuilder.Entity<Instrument>().ToTable("instruments").HasData(
                new Instrument
                {
                    Id = 1,
                    SerialNumber = "0002",
                    Name = "特大号持针钳490",
                    InstrumentTypeId = 68,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 2,
                    SerialNumber = "0003",
                    Name = "特大号持针钳490",
                    InstrumentTypeId = 68,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 3,
                    SerialNumber = "0004",
                    Name = "特大号持针钳490",
                    InstrumentTypeId = 68,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 4,
                    SerialNumber = "das12334ss",
                    Name = "大力抓取钳500",
                    InstrumentTypeId = 71,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 5,
                    SerialNumber = "000ds21234432adas4",
                    Name = "大力抓取钳500",
                    InstrumentTypeId = 71,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 6,
                    SerialNumber = "dsada12deas",
                    Name = "超声刀头550",
                    InstrumentTypeId = 98,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 7,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 8,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 9,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 10,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 11,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 12,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 13,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 16,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                }, 
                new Instrument
                {
                    Id = 14,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 15,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                },
                new Instrument
                {
                    Id = 25,
                    SerialNumber = "45656dadasdas",
                    Name = "超声刀头510",
                    InstrumentTypeId = 99,
                    Description = "器械1的描述"
                }
            );
        }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<InstrumentType> InstrumentTypes { get; set; }
        // public DbSet<User> Users { get; set; }
        // public DbSet<Role> Roles { get; set; }
        // public DbSet<UserRole> UserRoles { get; set; }
    }
}