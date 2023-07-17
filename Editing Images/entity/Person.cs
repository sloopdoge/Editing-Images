using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editing_Images.entity
{
    /* Class to contain info about every person in crew */
    public class Person
    {
        /* Editing rate (1 image) / (minutes spend to edit 1 image) */
        public double Rate;

        /* Constructor */
        public Person(double rate)
        {
            Rate = rate;
        }
    }
}
