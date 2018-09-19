using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFristWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TeachService" in both code and config file together.
    public class TeachService : ITeachService
    {


        public string getCourseName(int courseId)
        {
            return "Hello C#WCF";
        }
    }
}
