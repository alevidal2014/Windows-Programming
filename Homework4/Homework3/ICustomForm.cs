using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public interface ICustomForm
    {
        int SideMeasure { get; }
        void Update(int sideMeasure, float ration);
        event EventHandler FocusIN;
        event EventHandler FocusOUT;
    }
}