﻿// <auto-generated />
using System;
using DataAccessLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240816121734_urlmig")]
    partial class urlmig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Collection", b =>
                {
                    b.Property<int>("CollectionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CollectionID"));

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<bool?>("Watched")
                        .HasColumnType("bit");

                    b.Property<bool?>("Wishlist")
                        .HasColumnType("bit");

                    b.HasKey("CollectionID");

                    b.HasIndex("MovieID");

                    b.HasIndex("UserID");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"));

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentTittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int?>("Position")
                        .HasColumnType("int");

                    b.Property<bool>("Spoiler")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("MovieID");

                    b.HasIndex("UserID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("EntityLayer.Concrete.GenreCon", b =>
                {
                    b.Property<int>("GenreConID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreConID"));

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("GenreConID");

                    b.HasIndex("GenreID");

                    b.HasIndex("MovieID");

                    b.ToTable("GenreCons");
                });

            modelBuilder.Entity("EntityLayer.Concrete.HelpMessage", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageID"));

                    b.Property<string>("MessageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageTittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("MessageID");

                    b.HasIndex("UserID");

                    b.ToTable("HelpMessages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ListC", b =>
                {
                    b.Property<int>("ListID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ListID"));

                    b.Property<string>("ListName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ListID");

                    b.ToTable("ListCs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ListConnect", b =>
                {
                    b.Property<int>("LConnectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LConnectID"));

                    b.Property<int>("ListID")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("LConnectID");

                    b.HasIndex("ListID");

                    b.HasIndex("MovieID");

                    b.ToTable("ListConnects");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"));

                    b.Property<float>("AvgRating")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<float?>("RunningTime")
                        .HasColumnType("real");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Rating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingID"));

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("RatingValue")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("RatingID");

                    b.HasIndex("MovieID");

                    b.HasIndex("UserID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Subscription", b =>
                {
                    b.Property<int>("SubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionID"));

                    b.Property<float>("Money")
                        .HasColumnType("real");

                    b.Property<string>("SubName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubscriptionID");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Thumb", b =>
                {
                    b.Property<int>("ThumbID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThumbID"));

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ThumbID");

                    b.HasIndex("MovieID");

                    b.HasIndex("UserID");

                    b.ToTable("Thumbs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfrimPass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<bool>("Logged")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PaidUntilDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.HasIndex("SubscriptionID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Collection", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Movie", "Movie")
                        .WithMany("Collection")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("Collection")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Movie", "Movie")
                        .WithMany("Comment")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("Comment")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.GenreCon", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Genre", "Genre")
                        .WithMany("GenreCon")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Movie", "Movie")
                        .WithMany("GenreCon")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("EntityLayer.Concrete.HelpMessage", b =>
                {
                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("HelpMessage")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ListConnect", b =>
                {
                    b.HasOne("EntityLayer.Concrete.ListC", "ListC")
                        .WithMany("ListConnect")
                        .HasForeignKey("ListID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Movie", "Movie")
                        .WithMany("ListConnect")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListC");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Rating", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Movie", "movie")
                        .WithMany("Rating")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("Rating")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("movie");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Thumb", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Movie", "Movie")
                        .WithMany("thumbs")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.User", "User")
                        .WithMany("thumbs")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Subscription", "Subscription")
                        .WithMany("user")
                        .HasForeignKey("SubscriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Genre", b =>
                {
                    b.Navigation("GenreCon");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ListC", b =>
                {
                    b.Navigation("ListConnect");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Movie", b =>
                {
                    b.Navigation("Collection");

                    b.Navigation("Comment");

                    b.Navigation("GenreCon");

                    b.Navigation("ListConnect");

                    b.Navigation("Rating");

                    b.Navigation("thumbs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Subscription", b =>
                {
                    b.Navigation("user");
                });

            modelBuilder.Entity("EntityLayer.Concrete.User", b =>
                {
                    b.Navigation("Collection");

                    b.Navigation("Comment");

                    b.Navigation("HelpMessage");

                    b.Navigation("Rating");

                    b.Navigation("thumbs");
                });
#pragma warning restore 612, 618
        }
    }
}
