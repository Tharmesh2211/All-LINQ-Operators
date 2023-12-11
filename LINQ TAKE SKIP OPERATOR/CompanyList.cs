using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_and_Skip_Operators
{
    public class CompanyList
    {
        List<Company> companies = new List<Company>
        {
            new Company { Company_Id = 1, Company_Name = "TCS" },
            new Company { Company_Id = 2, Company_Name = "Wipro", },
            new Company { Company_Id = 3, Company_Name = "Infosys" },
            new Company { Company_Id = 4, Company_Name = "Accenture",},
            new Company { Company_Id = 5, Company_Name = "Cognizant", },
            new Company { Company_Id = 6, Company_Name = "SAP" },
            new Company { Company_Id = 7, Company_Name = "Capgemini" },
            new Company { Company_Id = 8, Company_Name = "IBM" },
            new Company { Company_Id = 9, Company_Name = "Oracle" },
            new Company { Company_Id = 10, Company_Name = "Deloitte" }
        };

        public IEnumerable<Company> Take()
        {
            //It'll Return first 5 element
            Console.WriteLine("========== TAKE ==========\n");
            var takeRes = companies.Take(5);
            return takeRes;
        }

        public IEnumerable<Company> Skip()
        {
            // It skip first 3 element
            Console.WriteLine("========== SKIP ==========\n");
            var skipRes = companies.Skip(3);
            return skipRes;
        }

        public void Print(IEnumerable<Company> companies)
        {
            foreach (var company in companies)
            {
                Console.WriteLine(company.Company_Id+"       "+company.Company_Name);
            }
            Console.WriteLine("======================================");
        }
    }
}
