﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EFTestDBEntities : DbContext
    {
        public EFTestDBEntities()
            : base("name=EFTestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ClassInfo> ClassInfoes { get; set; }
        public virtual DbSet<DepartmentInfo> DepartmentInfoes { get; set; }
        public virtual DbSet<StudentInfo> StudentInfoes { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
    }
}