﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;
using Microsoft.EntityFrameworkCore;

namespace UnitTest_Mock.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Property
        private readonly ApiDbContext _apiDbContext;
        #endregion

        #region Constructor
        public EmployeeService(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }
        #endregion

        public async Task<string> GetEmployeeById(int empID)
        {
            var name = await _apiDbContext.Employees.Where(c => c.Id == empID).Select(d => d.Name).FirstOrDefaultAsync();
            return name;
        }

        public async Task<Employee> GetEmployeeDetails(int empID)
        {
            var emp = await _apiDbContext.Employees.FirstOrDefaultAsync(c => c.Id == empID);
            return emp;
        }
    }
}
