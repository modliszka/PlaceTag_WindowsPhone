using PlaceTagv0._1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    class DatabaseAdd
    {
        public void AddPlace(String name, String description, String city, String street, String house_number)
        {
            using (PlaceDataContext context = new PlaceDataContext(PlaceDataContext.DBConnectionString))
            {
                PlaceDetails pd = new PlaceDetails();
                pd.PlaceName = name;
                pd.place_description = description;
                pd.place_city = city;
                pd.place_street = street;
                pd.place_house_number = house_number;
                context.Places.InsertOnSubmit(pd);
                context.SubmitChanges();
            }
        }
    }
}
