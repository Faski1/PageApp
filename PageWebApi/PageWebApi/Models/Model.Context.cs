﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PageWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PageEntities : DbContext
    {
        public PageEntities()
            : base("name=PageEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentStatus> StudentStatus { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Kurs> Kurs { get; set; }
    
        public virtual ObjectResult<Get_All_Students_Result> Get_All_Students()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_All_Students_Result>("Get_All_Students");
        }
    
        public virtual ObjectResult<getAllStudentsOnKurs_Result> getAllStudentsOnKurs(Nullable<int> kursId)
        {
            var kursIdParameter = kursId.HasValue ?
                new ObjectParameter("KursId", kursId) :
                new ObjectParameter("KursId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllStudentsOnKurs_Result>("getAllStudentsOnKurs", kursIdParameter);
        }
    
        public virtual ObjectResult<getAllKursOnStudent_Result> getAllKursOnStudent(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("StudentId", studentId) :
                new ObjectParameter("StudentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllKursOnStudent_Result>("getAllKursOnStudent", studentIdParameter);
        }
    }
}
