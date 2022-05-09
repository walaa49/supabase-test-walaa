using Postgrest.Attributes;
using System;
using Supabase;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace supabase_walaa.Models
{
   
        [Table("Livre")]
        public class Livre : SupabaseModel
        {
           
            [PrimaryKey("id", false)]
            public int Id { get; set; }

            [Column("titre")]
            public string titre { get; set; }

            [Column("auteur")]
            public string auteur { get; set; }
        }
    
}
