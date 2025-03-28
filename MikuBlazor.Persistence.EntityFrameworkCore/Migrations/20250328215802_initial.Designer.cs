﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MikuBlazor.Persistence.EntityFrameworkCore.Context;

#nullable disable

namespace MikuBlazor.Persistence.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250328215802_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimeCharacter", b =>
                {
                    b.Property<Guid>("AnimesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharactersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnimesId", "CharactersId");

                    b.HasIndex("CharactersId");

                    b.ToTable("AnimeCharacter");
                });

            modelBuilder.Entity("AnimeEpisode", b =>
                {
                    b.Property<Guid>("AnimesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EpisodesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnimesId", "EpisodesId");

                    b.HasIndex("EpisodesId");

                    b.ToTable("AnimeEpisode");
                });

            modelBuilder.Entity("AnimeGenre", b =>
                {
                    b.Property<Guid>("AnimesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenresId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnimesId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("AnimeGenre");
                });

            modelBuilder.Entity("AnimeProducer", b =>
                {
                    b.Property<Guid>("AnimesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProducersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnimesId", "ProducersId");

                    b.HasIndex("ProducersId");

                    b.ToTable("AnimeProducer");
                });

            modelBuilder.Entity("AnimeStudio", b =>
                {
                    b.Property<Guid>("AnimesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudiosId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnimesId", "StudiosId");

                    b.HasIndex("StudiosId");

                    b.ToTable("AnimeStudio");
                });

            modelBuilder.Entity("AnimeTag", b =>
                {
                    b.Property<Guid>("AnimesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AnimesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("AnimeTag");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Anime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JapaneseTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProducerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("SeasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ViewerRatingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.HasIndex("ViewerRatingId");

                    b.ToTable("Anime");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.AnimeStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AnimeStatus");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.AnimeType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AnimeType");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("JapaneseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Episode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Episode");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Producer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Season", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Studio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Studio");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.ViewerRating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ViewerRating");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.JoinEntity.UserAnimeFavourites", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAnimeFavourites");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.JoinEntity.UserAnimeRatings", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAnimeRatings");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.JoinEntity.UserCharacterFavourites", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AnimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCharacterFavourites");
                });

            modelBuilder.Entity("AnimeCharacter", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnimeEpisode", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Episode", null)
                        .WithMany()
                        .HasForeignKey("EpisodesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnimeGenre", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnimeProducer", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Producer", null)
                        .WithMany()
                        .HasForeignKey("ProducersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnimeStudio", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Studio", null)
                        .WithMany()
                        .HasForeignKey("StudiosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AnimeTag", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", null)
                        .WithMany()
                        .HasForeignKey("AnimesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Anime", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Season", "Season")
                        .WithMany("Animes")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.AnimeStatus", "Status")
                        .WithMany("Animes")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.AnimeType", "Type")
                        .WithMany("Animes")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.ViewerRating", "ViewerRating")
                        .WithMany("Animes")
                        .HasForeignKey("ViewerRatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Season");

                    b.Navigation("Status");

                    b.Navigation("Type");

                    b.Navigation("ViewerRating");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Character", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Gender", "Gender")
                        .WithMany("Characters")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.JoinEntity.UserAnimeFavourites", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", "Anime")
                        .WithMany("UserAnimeFavourites")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.User", "User")
                        .WithMany("AnimeFavourites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.JoinEntity.UserAnimeRatings", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", "Anime")
                        .WithMany("UserAnimeRatings")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.User", "User")
                        .WithMany("AnimeRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.JoinEntity.UserCharacterFavourites", b =>
                {
                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Anime", null)
                        .WithMany("UserCharacterFavouritesList")
                        .HasForeignKey("AnimeId");

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MikuBlazor.Domain.Anime.Entity.User", "User")
                        .WithMany("CharacterFavourites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Anime", b =>
                {
                    b.Navigation("UserAnimeFavourites");

                    b.Navigation("UserAnimeRatings");

                    b.Navigation("UserCharacterFavouritesList");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.AnimeStatus", b =>
                {
                    b.Navigation("Animes");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.AnimeType", b =>
                {
                    b.Navigation("Animes");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Gender", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.Season", b =>
                {
                    b.Navigation("Animes");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.User", b =>
                {
                    b.Navigation("AnimeFavourites");

                    b.Navigation("AnimeRatings");

                    b.Navigation("CharacterFavourites");
                });

            modelBuilder.Entity("MikuBlazor.Domain.Anime.Entity.ViewerRating", b =>
                {
                    b.Navigation("Animes");
                });
#pragma warning restore 612, 618
        }
    }
}
