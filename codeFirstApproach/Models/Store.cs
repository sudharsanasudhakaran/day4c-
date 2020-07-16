using System;
using System.Collections.Generic;
using System.Text;

namespace codeFirstApproach.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int Level { get; set; }
        public Performance Performance { get; set; }
    }



    public class Performance
    {
        public int Id { get; set; }
        public string Gradename { get; set; }
        public string Section { get; set; }

        public List<Store> Stores { get; set; }
    }
}
