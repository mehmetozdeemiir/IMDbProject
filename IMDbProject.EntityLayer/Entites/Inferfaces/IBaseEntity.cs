using IMDbProject.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbProject.EntityLayer.Entites.Inferfaces
{
   public interface IBaseEntity
    {
        //assigned tabloların sadece BaseEntitty kalıtım aldıkları "Id" parametresinin  
        DateTime? CreateDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? PassivedDate { get; set; }

        Status Status { get ; set; }

    }
}
