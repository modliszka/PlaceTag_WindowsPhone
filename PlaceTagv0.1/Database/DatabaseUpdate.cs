using PlaceTagv0._1.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    class DatabaseUpdate
    {
        public void UpdatePlace(int id, String name, String description, String city, String street, String house_number)
        {
            using (PlaceDataContext context = new PlaceDataContext(PlaceDataContext.DBConnectionString))
            {
                IQueryable<Place_details> entityQuery = from c in context.Places where c.ID == id select c;
                Place_details entityToUpdate = entityQuery.FirstOrDefault();
                entityToUpdate.place_name = name;
                entityToUpdate.place_description = description;
                entityToUpdate.place_city = city;
                entityToUpdate.place_street = street;
                entityToUpdate.place_house_number = house_number;
                context.SubmitChanges();
            }
        }
    }
}
