using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms.VisualStyles;

namespace Tempus
{
    class TempusConfig
    {
        public int Time { get; set; }
        public int TimeToBlink { get; set; }
        public string? Type { get; set; }
        public int FontSize { get; set; }
        public string? BackGround { get; set; }
        public string? FinalTime { get; set; }
        public string? FinalBackGround { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public bool Debug { get; set; }

        private static string GetPathArchive()
        {
            string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appPath = Path.Combine(roamingPath, "Tempus");

            if(!Directory.Exists(appPath))
                Directory.CreateDirectory(appPath);

            return Path.Combine(appPath, "config.json");

        }

        public void SaveConfig()
        {
            string configPath = GetPathArchive();
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(configPath, json);
        }

        public TempusConfig loadConfig()
        {
            string configPath = GetPathArchive();
            if(File.Exists(configPath))
            {
                string json = File.ReadAllText(configPath);
                return JsonSerializer.Deserialize<TempusConfig>(json);
            }

            return new TempusConfig
            {
                Time = 10,
                TimeToBlink = 3,
                Type = @"hh\:mm\:ss",
                FontSize = 150,
                BackGround = "Light",
                FinalTime = "Stop",
                FinalBackGround = "Alter"
            };
        }
    }
}
