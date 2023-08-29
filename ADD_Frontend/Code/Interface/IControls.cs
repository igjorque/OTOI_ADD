using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADD_Frontend.Code.Interface
{
    /// <summary>
    /// IControls interface
    /// </summary>
    internal interface IControls
    {
        /// <summary>
        /// Obtains the implementing object's controls.
        /// </summary>
        /// <returns>List containing the controls</returns>
        public List<Object> GetControls();
    }
}
