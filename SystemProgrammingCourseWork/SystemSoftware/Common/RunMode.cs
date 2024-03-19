using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSoftware.Common
{
    /// <summary>
	/// Состояние программы в текущий момент.
	/// </summary>
	public enum RunMode
    {
        /// <summary>
        /// Первый проход.
        /// </summary>
        FirstRun = 0,

        /// <summary>
        /// Второй проход.
        /// </summary>
        SecondRun = 1
    }
}
