using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBList
{
    public class Movie
    {
        public double ImdbPuan { get; set; }
        public string Name { get; set; }

        public Movie(double imdbPuan, string name)
        {
            ImdbPuan = imdbPuan;
            Name = name;
        }
    }
}
