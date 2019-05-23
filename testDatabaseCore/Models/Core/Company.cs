

using System.Collections.Generic;

namespace testDatabaseCore.Models.Core
{
    public class Company : Entity
    {
        public string CompanyTitle { get; set; }
        public int? ParentId { get; set; }
        public Company Parent { get; set; }
        public string EconomicalNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public int? CompanyTypeId { get; set; }
        public CompanyType CompanyType { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int? BranchCode { get; set; }
        public string NationalNumber { get; set; }
        public ICollection<Company> Children { get; set; }
    }
}
