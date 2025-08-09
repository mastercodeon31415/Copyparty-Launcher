using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Copyparty_Launcher_GUI.Logic
{
    public static class SettingsManager
    {
        private const string SettingsFileName = "copyparty-gui-settings.json";

        // Gets the full path to the settings file, located next to the app's .exe
        private static string FilePath
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SettingsFileName);
            }
        }

        /// <summary>
        /// Loads the AppSettings object from the JSON file.
        /// If the file doesn't exist (first run), it returns a new, default AppSettings object.
        /// </summary>
        public static AppSettings Load()
        {
            if (!File.Exists(FilePath))
            {
                // First time run, return a fresh settings object
                return new AppSettings();
            }

            try
            {
                string json = File.ReadAllText(FilePath);
                // If the file is empty or corrupt, DeserializeObject can return null
                return JsonConvert.DeserializeObject<AppSettings>(json) ?? new AppSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load settings file. A new one will be created.\n\nError: {ex.Message}", "Settings Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Return a fresh object on error
                return new AppSettings();
            }
        }

        /// <summary>
        /// Saves the provided AppSettings object to the JSON file.
        /// </summary>
        public static void Save(AppSettings settings)
        {
            try
            {
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save settings to file.\n\nError: {ex.Message}", "Settings Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
