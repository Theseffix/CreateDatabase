﻿using System;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using CreateDatabase.Models;

namespace CreateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateStudent();
            //CreateCompany();
            //AddContactInfo();
            //AddLiaWork();
            DropStudent();
        }

        public static void CreateStudent()
        {
            using (var context = new EFContext())
            {
                User user = new User();
                user.UserType = UserTypeEnum.Student;

                Student toAdd = new Student();
                toAdd.FirstName = "Dennis";
                toAdd.LastName = "Nyberg";
                toAdd.Birthdate = new DateTime(1995, 2, 16);
                toAdd.User = user;
                context.Add(toAdd);

                User user1 = new User();
                user1.UserType = UserTypeEnum.Student;

                Student toAdd1 = new Student();
                toAdd1.FirstName = "Erik";
                toAdd1.LastName = "Häregård";
                toAdd1.Birthdate = new DateTime(1997, 2, 9);
                toAdd1.User = user1;
                context.Add(toAdd1);

                context.SaveChanges();
            }
        }

        public static void CreateCompany()
        {
            using (var context = new EFContext())
            {
                Company toAdd = new Company();
                toAdd.Name = "Google";
                toAdd.OrganisationNumber = "9999-1";
                context.Add(toAdd);

                context.SaveChanges();
            }
        }

        public static void AddContactInfo()
        {
            using (var context = new EFContext())
            {

                ContactInfo toAdd = new ContactInfo();
                toAdd.UserId = 1;
                toAdd.ContactType = ContactTypeEnum.Email;
                toAdd.Contact = "TestDennis@google.bing";
                context.ContactInfo.Add(toAdd);

                context.SaveChanges();

            }
        }
        public static void AddLiaWork()
        {
            using (var context = new EFContext())
            {

                LIAWork AddLia = new LIAWork();
                AddLia.StudentId = 1;
                AddLia.CompanyId = 1;
                AddLia.StartDate = DateTime.Now;
                AddLia.EndDate = DateTime.Now.AddDays(1);
                context.Add(AddLia);

                LIAWork AddLia1 = new LIAWork();
                AddLia1.StudentId = 2;
                AddLia1.CompanyId = 1;
                AddLia1.StartDate = DateTime.Now;
                AddLia1.EndDate = DateTime.Now.AddDays(1);
                context.Add(AddLia1);

                context.SaveChanges();

            }
        }
        public static void DropStudent()
        {
            using (var context = new EFContext())
            {
                User u = context.User.Find(1);
                context.Remove(u);
                context.SaveChanges();
            }
        }
    }
}
