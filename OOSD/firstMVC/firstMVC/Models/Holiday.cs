using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace firstMVC.Models
{
    public class Holiday
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Bitmap Picture { get; set; }

        public Holiday(string name, DateTime date, string picture)
        {
            Name = name;
            Date = date;
            Picture = new Bitmap(picture);
        }
    }
}