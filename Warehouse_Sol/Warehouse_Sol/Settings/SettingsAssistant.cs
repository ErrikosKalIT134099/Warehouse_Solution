using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Sol.Settings
{
    public sealed class SettingsAssistant
    {
        private const string SETTINGS = "SETTINGS";

        private static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private string settingsPath = Path.Combine(baseDirectory, "config.ini");

        private FileIniDataParser parser = new FileIniDataParser();
        private IniData data;

        private static SettingsAssistant instance;

        public static  SettingsAssistant settings {

            get{
                if(instance !=null)
                    return instance;
                instance = new SettingsAssistant();
                return instance;
            }
        }
        public SettingsModel current { get; } = new SettingsModel();

        private void defaultSettings()
        {
            ///
            current.dieft = "";
            current.melos = "";
            current.melos2 = "";
            current.polh = "Κομοτηνή";
            File.Create(settingsPath).Close();


            writeSettings();

        }

        public void writeSettings()
        {
            data = parser.ReadFile(settingsPath);
            ///
            data[SETTINGS][nameof(current.dieft)] = current.dieft;
            data[SETTINGS][nameof(current.melos)] = current.melos;
            data[SETTINGS][nameof(current.melos2)] = current.melos2;
            data[SETTINGS][nameof(current.polh)] = current.polh;

            parser.WriteFile(settingsPath, data);
        }

        private void readSettings()
        {
            data = parser.ReadFile(settingsPath);
            ///
            current.dieft = data[SETTINGS][nameof(current.dieft)];
            current.melos = data[SETTINGS][nameof(current.melos)];
            current.melos2 = data[SETTINGS][nameof(current.melos2)];
            current.polh = data[SETTINGS][nameof(current.polh)];
        }


        private SettingsAssistant()
        {
            if (!File.Exists(settingsPath))
            {
                defaultSettings();
            }
            else
            {
                readSettings();
            }
        }

    }
}
