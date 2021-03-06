﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BooksAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PracticeEntities : DbContext
    {
        public PracticeEntities()
            : base("name=PracticeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AuthorInfo> AuthorInfoes { get; set; }
        public virtual DbSet<BookInfo> BookInfoes { get; set; }
    
        public virtual ObjectResult<AuthorBook_Result> AuthorBook(string authorname)
        {
            var authornameParameter = authorname != null ?
                new ObjectParameter("Authorname", authorname) :
                new ObjectParameter("Authorname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AuthorBook_Result>("AuthorBook", authornameParameter);
        }
    }
}
