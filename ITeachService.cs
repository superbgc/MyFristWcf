using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFristWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITeachService" in both code and config file together.
    //表示这个接口遵循wcf协定
    [ServiceContract]
    public interface ITeachService
    {
        //表示协议的一部分
        [OperationContract]


        String getCourseName(int courseId);
    }
}
