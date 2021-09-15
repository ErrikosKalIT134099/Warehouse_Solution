using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Sol.Settings
{
    public sealed class SettingsAssistant
    {

        private static SettingsAssistant Instance;

        public SettingsAssistant settings {

            get{
                if(Instance !=null)
                    return Instance;
                Instance = new SettingsAssistant();
                return Instance;
            }
        }

        private SettingsAssistant()
        {

        }

    }
}
