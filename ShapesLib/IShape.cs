using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    /// <summary>
    /// Интерфейс фигура
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Площадь
        /// </summary>
        double Area { get; }
    }
}
