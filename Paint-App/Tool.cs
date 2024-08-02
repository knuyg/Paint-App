using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_App
{
    public class Tool
    {
        public string Name {  get; set; }
        private string defaultTool = "Brush";

        public Tool()
        {
            Name = defaultTool;

        }

        public Tool(string toolName)
        {
            Name = toolName;
        }

        ~Tool()
        {
            Name = string.Empty;
        }
    }
}
