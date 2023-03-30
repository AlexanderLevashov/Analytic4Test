using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Analytic4Tests.JsonHandler
{
    class EnvironmentConstantWriter
    {
        public void WriteDown()
        {
            var environmentConstants = new EnvironmentConstants();

            string objectSerialized = JsonSerializer.Serialize(environmentConstants);
            File.WriteAllText("EnvironmentConstants.json", objectSerialized);
            
        }
    }
}
