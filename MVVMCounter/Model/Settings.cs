using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCounter.Model
{
    static class Settings
    {
        public static Model Read()
        {
            Properties.Settings settings = Properties.Settings.Default;
            return new Model(settings.CounterValue, settings.CounterSize, settings.R, settings.G, settings.B);
        }
    }
}
