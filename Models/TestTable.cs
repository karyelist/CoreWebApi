using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Api.Models
{
    public class TestTable
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string Il_ad { get; set; }
        public string Hava_Durumu { get; set; }
        [Display(Name="Tarih")]
        public DateTime create_date { get; set; }

    }
}
