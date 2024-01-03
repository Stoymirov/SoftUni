﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        List<string> Authors;
        public Book(string title,int year,params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }
    }
}
