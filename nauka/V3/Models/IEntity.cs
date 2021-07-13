using System;
using System.Collections.Generic;
using System.Text;

namespace nauka.V3.Models
{
    public interface IEntity<PrimaryKey>
    {
        public PrimaryKey Id {get; set;}
    }
    public interface IEntity: IEntity<Guid> { }
        
}
