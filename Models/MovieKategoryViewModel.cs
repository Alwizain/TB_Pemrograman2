using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieKategoryViewModel
    {
        public List<Spicyo> Spicyo { get; set; }
        public SelectList Kategorys { get; set; }
        public string MovieKategory { get; set; }
        public string SearchString { get; set; }
    }
}