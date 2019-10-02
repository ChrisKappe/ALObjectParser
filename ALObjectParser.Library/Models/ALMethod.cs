using System.Collections.Generic;

namespace ALObjectParser.Library
{
    public class ALMethod
    {
        public ALMethod()
        {
            Parameters = new List<ALParameter>();
        }

        public string Name { get; set; }
        public string MethodKind { get; set; }
        public bool TestMethod { get; set; }
        public bool IsLocal { get; set; }
        public List<ALParameter> Parameters { get; set; }
        public string ReturnType { get; set; }
        public ITestScenario Scenario { get; set; }
        public string Content { get; set; }
    }
}