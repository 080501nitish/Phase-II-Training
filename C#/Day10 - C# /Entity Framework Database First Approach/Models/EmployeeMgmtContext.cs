using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDBF.Models;

public partial class EmployeeMgmtContext : DbContext
{
    public EmployeeMgmtContext()
    {
    }

    public EmployeeMgmtContext(DbContextOptions<EmployeeMgmtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = DESKTOP-HCQDF97\\SQLEXPRESS; database = EmployeeMgmt; integrated security=SSPI; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("pk_dept");

            entity.ToTable("Dept");

            entity.Property(e => e.Deptno)
                .ValueGeneratedNever()
                .HasColumnName("deptno");
            entity.Property(e => e.Dname)
                .HasMaxLength(10)
                .HasColumnName("dname");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Empno).HasName("pk_emp");

            entity.ToTable("Emp");

            entity.Property(e => e.Empno)
                .ValueGeneratedNever()
                .HasColumnName("empno");
            entity.Property(e => e.Addr)
                .HasMaxLength(30)
                .HasColumnName("addr");
            entity.Property(e => e.Deptno).HasColumnName("deptno");
            entity.Property(e => e.Ename)
                .HasMaxLength(25)
                .HasColumnName("ename");

            entity.HasOne(d => d.DeptnoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Deptno)
                .HasConstraintName("fk_deptno");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
