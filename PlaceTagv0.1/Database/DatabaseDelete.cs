using PlaceTagv0._1.Model;
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
                IQueryable<PlaceDetails> entityQuery = from c in context.Places select c;
                IList<PlaceDetails> entityToDelete = entityQuery.ToList();
                context.Places.DeleteAllOnSubmit(entityToDelete);
                context.SubmitChanges();
            }
        }
        public void DeletePlace(String id) //delete place by id
        {
            using (PlaceDataContext context = new PlaceDataContext(PlaceDataContext.DBConnectionString))
            {
                IQueryable<PlaceDetails> entityQuery = from c in context.Places where c.PlaceId.Equals(id) select c;
                PlaceDetails entityToDelete = entityQuery.FirstOrDefault();
                context.Places.DeleteOnSubmit(entityToDelete);
                context.SubmitChanges();
            }
        }
    }
}
