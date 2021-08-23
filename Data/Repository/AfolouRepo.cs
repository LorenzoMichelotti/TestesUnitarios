using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class AfolouRepo
    {
        public void Create(Afolou model)
        {
            using(var context = new AfolouContext())
            {
                context.Afolous.Add(model);
                context.SaveChanges();
            }
        }
        //public List<Afolou> Read()
        //{
        //    List<Afolou> list = new List<Afolou>();
        //    using (var context = new AfolouContext())
        //    {
        //        list = context.Afolous.ToList();
        //    }
        //    return list;
        //}
    }
}
