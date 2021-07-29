using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
[ServiceContract]
public interface ICalculatorService
{
    [OperationContract]
    int add(int a,int b);
    [OperationContract]
    int sub(int a, int b);
    [OperationContract]
    int  mul(int a, int b);
    [OperationContract]
    int div(int a, int b);
}
