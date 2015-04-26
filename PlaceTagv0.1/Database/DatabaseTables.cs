using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceTagv0._1.Database
{
    public class PlaceDataContext : DataContext
    {
        public static string DBConnectionString = @"isostore:/Databases.sdf";
        public PlaceDataContext(string connectionString)
            : base(connectionString)
        { }
        public Table<Place_details> Places
        {
            get
            {
                return this.GetTable<Place_details>();
            }
        }
    }
    [Table]
    public class Place_details
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column]
        public int lat { get; set; }
        [Column]
        public int lon { get; set; }
        [Column]
        public string place_name { get; set; }
        [Column]
        public string place_city { get; set; }
        [Column]
        public string place_street { get; set; }
        [Column]
        public string place_house_number { get; set; }
        [Column]
        public string place_description { get; set; }
    }
}
