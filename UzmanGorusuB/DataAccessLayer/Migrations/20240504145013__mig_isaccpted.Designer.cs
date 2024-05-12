﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240504145013__mig_isaccpted")]
    partial class _mig_isaccpted
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutID"), 1L, 1);

                    b.Property<string>("AboutDetails1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UzmanGorusuAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UzmanGorusuMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UzmanGorusuTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Applicant", b =>
                {
                    b.Property<int>("ApplicantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicantID"), 1L, 1);

                    b.Property<string>("ApplicantAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApplicantAge")
                        .HasColumnType("int");

                    b.Property<string>("ApplicantCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantGradition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ApplicantStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ApplicantSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantUniversity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantUniversityDepartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LanguageProficiency")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicantID");

                    b.ToTable("Applicants");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ApplicantExpert", b =>
                {
                    b.Property<int>("ApplicantExpertID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicantExpertID"), 1L, 1);

                    b.Property<int>("ApplicantExpertAge")
                        .HasColumnType("int");

                    b.Property<string>("ApplicantExpertCV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApplicantExpertGender")
                        .HasColumnType("int");

                    b.Property<string>("ApplicantExpertMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicantExpertName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ApplicantExpertStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ApplicantExpertSurnameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApplicantExpertTitle")
                        .HasColumnType("int");

                    b.Property<bool>("IsAccpted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MembershipDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ApplicantExpertID");

                    b.ToTable("ApplicantExperts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"), 1L, 1);

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentTittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpertID")
                        .HasColumnType("int");

                    b.Property<int>("ExpertScore")
                        .HasColumnType("int");

                    b.HasKey("CommentID");

                    b.HasIndex("ExpertID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactID"), 1L, 1);

                    b.Property<DateTime>("ContactDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContectUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Expert", b =>
                {
                    b.Property<int>("ExpertID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpertID"), 1L, 1);

                    b.Property<int>("ExpertAge")
                        .HasColumnType("int");

                    b.Property<string>("ExpertDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ExpertStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ExpertSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpertTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MembershipDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ExpertID");

                    b.ToTable("Experts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.ExpertRayting", b =>
                {
                    b.Property<int>("ExpertRaytingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpertRaytingID"), 1L, 1);

                    b.Property<int>("ExpertID")
                        .HasColumnType("int");

                    b.Property<int>("ExpertRaytingCount")
                        .HasColumnType("int");

                    b.Property<int>("ExpertTotalScore")
                        .HasColumnType("int");

                    b.HasKey("ExpertRaytingID");

                    b.ToTable("ExpertRaytings");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Link", b =>
                {
                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LinkID"), 1L, 1);

                    b.Property<int>("ApplicantID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("LinkContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LinkDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LinkStatus")
                        .HasColumnType("bit");

                    b.Property<string>("LinkTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkID");

                    b.HasIndex("ApplicantID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageID"), 1L, 1);

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MessageStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Receiver")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message2", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageID"), 1L, 1);

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MessageStatus")
                        .HasColumnType("bit");

                    b.Property<int?>("ReceiverID")
                        .HasColumnType("int");

                    b.Property<int?>("SenderID")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.HasIndex("ReceiverID");

                    b.HasIndex("SenderID");

                    b.ToTable("Message2s");
                });

            modelBuilder.Entity("EntityLayer.Concrete.NewsLetter", b =>
                {
                    b.Property<int>("MailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MailID"), 1L, 1);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MailStatus")
                        .HasColumnType("bit");

                    b.HasKey("MailID");

                    b.ToTable("NewsLetters");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Notification", b =>
                {
                    b.Property<int>("NotificationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationID"), 1L, 1);

                    b.Property<string>("NotificationColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NotificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotificationDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NotificationStatus")
                        .HasColumnType("bit");

                    b.Property<string>("NotificationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotificationTypeSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationID");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comment", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Expert", "expert")
                        .WithMany("Comments")
                        .HasForeignKey("ExpertID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("expert");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Link", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Applicant", "Applicant")
                        .WithMany("Links")
                        .HasForeignKey("ApplicantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Links")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Message2", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Applicant", "ReceiverUser")
                        .WithMany("WriterReciever")
                        .HasForeignKey("ReceiverID");

                    b.HasOne("EntityLayer.Concrete.Applicant", "SenderUser")
                        .WithMany("WriterSender")
                        .HasForeignKey("SenderID");

                    b.Navigation("ReceiverUser");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Applicant", b =>
                {
                    b.Navigation("Links");

                    b.Navigation("WriterReciever");

                    b.Navigation("WriterSender");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Links");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Expert", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
