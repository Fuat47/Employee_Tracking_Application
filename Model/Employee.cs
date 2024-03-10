using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip.Model
{
    public class Employee
    {
        private int numOfChildren;

        public int Id { get;private set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public int DepartmentId { get; set; }

        public DateTime StartDate { get; set; }

        public int NumOfChildren
        {
            get { return numOfChildren; }
            set
            {
                if (value < 0)
                    throw new Exception("Number of children not valid!");
            }
        }

        public bool isMilitartServiceDone { get; set; }

        public bool isForeingLanguage { get; set; }

        public bool ohsStatus { get; set; }

        public bool masteryStatus { get; set; }

        public Employee(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} {Surname}";
        }

    }
}
