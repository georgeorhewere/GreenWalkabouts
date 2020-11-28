using System;
using System.Collections.Generic;
using System.Text;

namespace Walkabouts.Data.Domain
{
    interface IRefEntity
    {
        Guid RefId { get; set; }
    }
}
