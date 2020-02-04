using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (averageGrade < 5)
            {
                throw new InvalidOperationException("Ranked Grading requires more than 5 grades to caclulate an average ");
            }

                //Will fe
                var theshold = (int)Math.Ceiling(Students.Count * 0.2);

                var grades = Students.OrderByDescending(e => e.AverageGrade)
                    .Select(e => e.AverageGrade)
                    .ToList();

                if (grades[theshold - 1] <= averageGrade)
                {
                    return 'A';
                }
                else if (grades[theshold * 2 - 1] <= averageGrade)
                {
                    return 'B';
                }
                else if (grades[theshold * 3 - 1] <= averageGrade)
                {
                    return 'C';
                }
                else if (grades[theshold * 4 - 1] <= averageGrade)
                {
                    return 'D';
                }
                else
                {
                    return 'F';
                }
            
                
            
        }
    }
