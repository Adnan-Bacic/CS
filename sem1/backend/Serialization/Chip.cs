using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Serialization
{
    [Serializable] //important
    public class Chip
    {
        private int id;

        public Chip(int id)
        {
            this.id = id;
        }


        //empty constructor for json
        public Chip()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return "id = " + id;
        }
    }
}