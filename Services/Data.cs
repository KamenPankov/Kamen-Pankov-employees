using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Services
{
    public class Data
    {
        private string path;

        public Data(string path)
        {
            this.path = path;
        }

        private List<Employee> GetData()
        {
            List<string> data = new List<string>();
            List<Employee> employees = new List<Employee>();

            if (!File.Exists(this.path))
            {
                return employees;
            }

            using (StreamReader streamReader = File.OpenText(this.path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    data.Add(line);
                }
            }            

            foreach (string line in data)
            {
                string[] lineSplit = line.Split(", ");
                Employee employee = new Employee()
                {
                    EmpId = int.Parse(lineSplit[0]),
                    ProjectId = int.Parse(lineSplit[1]),
                    DateFrom = DateTime.Parse(lineSplit[2], CultureInfo.InvariantCulture),
                    DateTo = lineSplit[3] != "NULL" ?
                        DateTime.Parse(lineSplit[3], CultureInfo.InvariantCulture) :
                        DateTime.Now
                };

                employees.Add(employee);
            }

            return employees;
        }

        private List<Couple> GetCouples(List<Employee> employees)
        {
            List<Couple> couples = new List<Couple>();

            for (int i = 0; i < employees.Count - 1; i++)
            {
                Employee first = employees[i];

                for (int j = i + 1; j < employees.Count; j++)
                {
                    Employee second = employees[j];

                    double workingDays = DaysWorkedTogether(first, second);

                    if (workingDays > 0)
                    {
                        Couple couple = new Couple()
                        {
                            FirstId = first.EmpId,
                            SecondId = second.EmpId,
                            ProjectId = first.ProjectId,
                            DaysWorked = workingDays
                        };

                        couples.Add(couple);
                    }
                }
            }

            return couples;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<Couple> couples = this.GetCouples(this.GetData());

            var couple = couples.GroupBy(key => new { key.FirstId, key.SecondId },
                (key, group) => new
                {
                    FirstId = key.FirstId,
                    SecondId = key.SecondId,
                    Projects = group.Select(p => new
                    {
                        ProjectId = p.ProjectId,
                        DaysWorked = p.DaysWorked
                    })
                })
                .OrderByDescending(group => group.Projects.Sum(d => d.DaysWorked))
                .FirstOrDefault();

            if (couples.Any())
            {
                foreach (var item in couple.Projects)
                {
                    stringBuilder
                        .AppendLine(string.Format("{0}, {1}, {2}, {3}", couple.FirstId, couple.SecondId, item.ProjectId, item.DaysWorked));
                    
                }
            }
            else
            {
                stringBuilder.AppendLine("No result.");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        private double DaysWorkedTogether(Employee first, Employee second)
        {
            double workingDays = 0;

            if (first.ProjectId == second.ProjectId)
            {
                DateTime maxStartDate = first.DateFrom > second.DateFrom ? first.DateFrom : second.DateFrom;
                DateTime minEndDate = first.DateTo < second.DateTo ? first.DateTo.Value : second.DateTo.Value;

                workingDays = maxStartDate <= minEndDate ? (minEndDate - maxStartDate).TotalDays : 0;
            }

            return workingDays;
        }
    }
}
