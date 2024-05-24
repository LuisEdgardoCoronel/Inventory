using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOutput
    {
        public List<InputOutputEntity> inputOutputList()
        {
            using (var db = new InventaryContext())
            {
                return db.TInputs.ToList();
            }
        }


        public void CreateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.TInputs.Add(oInputOutput);
                db.SaveChanges();
            }
        }


        public void UpdateInputOutput(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.TInputs.Update(oInputOutput);
                db.SaveChanges();
            }
        }
    }
}
