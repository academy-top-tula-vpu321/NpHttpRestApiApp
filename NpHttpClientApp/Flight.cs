using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpHttpClientApp
{
    internal class Flight
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ToCity { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    }
}
