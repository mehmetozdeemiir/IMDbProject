using IMDbProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbProject.EntityLayer.Entites.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract int Id { get; set; }

    }
}
