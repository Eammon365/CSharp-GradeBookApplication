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
                throw new InvalidOperationException();
            }

            else
            {



                //Will fe
                var theshold = (int)Math.Ceiling(Students.Count * 0.2);

                List<Student> grades = Students.OrderByDescending(e => e.AverageGrade)
                    .Select(e => averageGrade)
                    .ToList();

                if (grades[theshold - 1] { }=> averageGrade)
                {

                }
            }
                return 'F';
            }
        }
    }
