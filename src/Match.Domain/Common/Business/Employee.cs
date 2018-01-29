using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Match.Domain.Common.PartyBase;

namespace Match.Domain.Common.Business
{
    public class Employee : Entity<Guid>
    {
        protected Employee() : base(Guid.NewGuid())
        {
        }

        public Employee(Person person, Department department, string employeeNum = null) : base(person.Id)
        {
            Person = person;
            Department = department;
            EmployeeNum = employeeNum;
        }

        public Person Person { get; private set; }

        [StringLength(20)]
        public string EmployeeNum { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<EmploymentContract> EmploymentContracts { get; set; } = new List<EmploymentContract>();

        public void AddEmploymentContract(string num, DateTime effective, DateTime? due, string fileUrl = null)
        {
            EmploymentContracts.Add(new EmploymentContract(num, Person, effective, due, fileUrl));
        }
    }
}