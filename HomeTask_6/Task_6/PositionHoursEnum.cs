using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    /// <summary>
    /// перечисление содержит константы часов, которые должен отработать сотридник определённой должности
    /// </summary>
    public enum PositionHours
    {
        /// <summary>
        /// Лаборант
        /// </summary>
        LaboratoryAssistant=660,

        /// <summary>
        /// доктор
        /// </summary>
        Doctor=880,

        /// <summary>
        /// медсестра
        /// </summary>
        Nurse=880,

        /// <summary>
        /// повар
        /// </summary>
        Cook=770,
    }
}
