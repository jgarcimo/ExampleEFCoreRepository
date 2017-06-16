using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_6_Repository.Base
{
    public class EF6Repository
    {
        public Model.CF_Model Model { get; set; }

        public EF6Repository()
        {
            Model = new EF_6_Repository.Model.CF_Model();
        }
    }
}
