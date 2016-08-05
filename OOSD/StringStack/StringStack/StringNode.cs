using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStack
{
    

    class StringNode
    {
        public string nodeString {get; set; }
        
        public StringNode Next { get; set; }

        public StringNode(string nodeString)
        {
            this.nodeString = nodeString;
        }
    }
}
