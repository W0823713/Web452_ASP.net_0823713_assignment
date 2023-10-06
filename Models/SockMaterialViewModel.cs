using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AryaSock.Models
{
    public class SockMaterialViewModel
    {
        public List<Sock> Socks { get; set; }
        public SelectList Materials { get; set; } // Assuming you want to select materials
        public string SelectedMaterial { get; set; } // Change this property according to your requirements
        public string SearchString { get; set; }
    }
}