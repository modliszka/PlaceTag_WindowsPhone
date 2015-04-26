using PlaceTagv0._1.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases
{
    class DatabaseDelete
    {
        public void DeleteAllPlaces() 
        {
            using (PlaceDataContext context = new PlaceDataContext(PlaceDataContext.DBConnectionString))
            {
                IQueryable<Place_details> entityQuery = from c in context.Places select c;
                IList<Place_details> entityToDelete = entityQuery.ToList();
                context.Places.DeleteAllOnSubmit(entityToDelete);
                context.SubmitChanges();
            }
        }
        public void DeletePlace(String id) //delete place by id
        {
            using (PlaceDataContext context = new PlaceDataContext(PlaceDataContext.DBConnectionString))
            {
                IQueryable<Place_details> entityQuery = from c in context.Places where c.ID.Equals(id) select c;
                Place_details entityToDelete = entityQuery.FirstOrDefault();
                context.Places.DeleteOnSubmit(entityToDelete);
                context.SubmitChanges();
            }
        }
    }
}
