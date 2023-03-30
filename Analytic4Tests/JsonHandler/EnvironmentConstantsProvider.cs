using System;
using System.IO;
using System.Text.Json;

namespace Analytic4Tests.JsonHandler
{
    public class EnvironmentConstantsProvider
    {
        private string _nameJsonFile = "EnvironmentConstants.json";
        public void Provide(out EnvironmentConstants environmentConstantsObject)
        {
            string objectJsonFile = File.ReadAllText(_nameJsonFile);
            environmentConstantsObject = JsonSerializer.Deserialize<EnvironmentConstants>(objectJsonFile);
        }
    }
}
