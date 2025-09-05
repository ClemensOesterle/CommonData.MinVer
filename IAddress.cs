using System;
using System.Collections.Generic;
using System.Text;

namespace CommonData.MinVer.Spike
{
    /// <summary>
    /// Represents an address with a name associated with it.
    /// </summary>
    /// <remarks>This interface defines a contract for objects that have a name property,  typically used to
    /// represent an address or related entity.</remarks>
    public interface IAddress
    {
        /// <summary>
        /// Gets or sets the name associated with the object.
        /// </summary>
        string Name { get; set; }
    }
}
