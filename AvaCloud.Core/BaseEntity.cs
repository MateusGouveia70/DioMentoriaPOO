using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaCloud.Core
{
    public abstract class BaseEntity
    {
        public int Id  { get; private set; }
        public abstract bool Validate();
        public DateTime CreateDate { get; private set; }
    }
}
