﻿using School.DataModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.DataModels
{
    public class Teacher : IPerson
    {
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private int age;
        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                age = value;
            }
        }

        private string location;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        private DateTime dob;
        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<IPerson> Friends { get; set; }
    }
}
