using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module11
{
    struct Employee
    {
        string name;
        Positions position;// должность
        int salary;
        public int[] date;
        string gender;
        public string Name        
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public Positions Position
        {
            get
            {
                return position;
            }
            set
            {
                this.position = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                this.salary = value;
            }
        }
        public int Day
        {
            get
            {
                return date[0];
            }
            set
            {
                this.date[0] = value;
            }
        }
        public int Month
        {
            get
            {
                return date[1];
            }
            set
            {
                this.date[1] = value;
            }
        }
        public int Year
        {
            get
            {
                return date[2];
            }
            set
            {
                this.date[2] = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                this.gender = value;
            }
        }
        public override string ToString() //перегрузка
        {
            return name + "  " + position + "  " + salary.ToString() + "  " + date[0].ToString() + "." + date[1].ToString() + "." + date[2].ToString();
        }
    }
}