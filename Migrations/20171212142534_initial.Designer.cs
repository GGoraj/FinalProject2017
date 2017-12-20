﻿// <auto-generated />
using dreamstarter_web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace dreamstarter_web.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20171212142534_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("dreamstarter_web.Models.Entities.Campaign", b =>
                {
                    b.Property<int>("CampaignId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AmountRaised");

                    b.Property<double>("AmountRequired");

                    b.Property<string>("DetailDescription");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsFinished");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Synopsis");

                    b.Property<string>("ThemeImageFileName");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("CampaignId");

                    b.HasIndex("UserId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("dreamstarter_web.Models.Entities.CommentCampaign", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CampaignId");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("CommentId");

                    b.HasIndex("CampaignId");

                    b.ToTable("CampaignComments");
                });

            modelBuilder.Entity("dreamstarter_web.Models.Entities.Incetiment", b =>
                {
                    b.Property<int>("IncetimentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CampaignId1");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("IncetimentId");

                    b.HasIndex("CampaignId1");

                    b.ToTable("Incetiment");
                });

            modelBuilder.Entity("dreamstarter_web.Models.Entities.LikeCampaign", b =>
                {
                    b.Property<int>("LikeCampaignId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CampaignId");

                    b.Property<int>("UserId");

                    b.HasKey("LikeCampaignId");

                    b.HasIndex("CampaignId");

                    b.ToTable("CampaignLikes");
                });

            modelBuilder.Entity("dreamstarter_web.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cpr");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("ProfilePicture");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("StreetNr")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("dreamstarter_web.Models.Entities.Campaign", b =>
                {
                    b.HasOne("dreamstarter_web.Models.Entities.User", "User")
                        .WithMany("Campaigns")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dreamstarter_web.Models.Entities.CommentCampaign", b =>
                {
                    b.HasOne("dreamstarter_web.Models.Entities.Campaign", "Campaign")
                        .WithMany("Comments")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dreamstarter_web.Models.Entities.Incetiment", b =>
                {
                    b.HasOne("dreamstarter_web.Models.Entities.Campaign")
                        .WithMany("Incetiments")
                        .HasForeignKey("CampaignId1");
                });

            modelBuilder.Entity("dreamstarter_web.Models.Entities.LikeCampaign", b =>
                {
                    b.HasOne("dreamstarter_web.Models.Entities.Campaign", "Campaign")
                        .WithMany("Likes")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
