﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Drawing;
using WcfService1.Core;
using WcfService1.Core.Enums;
using Autofac;
using Autofac.Integration.Wcf;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IQuadrilateralTypeService
    {

        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //string GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD);

        [OperationContract]
        string GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD, int angleAB, int angleBC, int angleCD, int angleDA);
       

        [OperationContract]
        string GetQuadrilateralTypeByVertices(Point vertexA, Point vertexB, Point vertexC, Point vertexD);
        

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
