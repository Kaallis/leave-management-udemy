using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using leave_management_udemy.Models;

namespace leave_management_udemy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Employee>Employees { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<LeaveHistory> LeaveHistories { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<leave_management_udemy.Models.LeaveTypeVM> LeaveTypeVM { get; set; }
        public DbSet<leave_management_udemy.Models.EmployeeVM> EmployeeVM { get; set; }
        public DbSet<leave_management_udemy.Models.LeaveAllocationVM> LeaveAllocationVM { get; set; }
        public DbSet<leave_management_udemy.Models.EditLeaveAllocationVM> EditLeaveAllocationVM { get; set; }
    }
}
