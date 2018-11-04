using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Tank_Benchmark
{
    /// <summary>
    /// Possible states of the computations
    /// </summary>
    enum Computing_States
    {
        /// <summary>
        /// Initial condition
        /// </summary>
        Initial,
        /// <summary>
        /// Running loop
        /// </summary>
        Running,
        /// <summary>
        /// Stopped for saving graphs
        /// </summary>
        Stopped,
        /// <summary>
        /// Exited from the program
        /// </summary>
        Exited
    }
}
