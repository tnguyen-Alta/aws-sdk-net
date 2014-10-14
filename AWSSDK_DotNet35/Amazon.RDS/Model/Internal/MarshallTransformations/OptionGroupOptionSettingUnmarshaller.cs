/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OptionGroupOptionSetting Object
    /// </summary>  
    public class OptionGroupOptionSettingUnmarshaller : IUnmarshaller<OptionGroupOptionSetting, XmlUnmarshallerContext>, IUnmarshaller<OptionGroupOptionSetting, JsonUnmarshallerContext>
    {
        public OptionGroupOptionSetting Unmarshall(XmlUnmarshallerContext context)
        {
            OptionGroupOptionSetting unmarshalledObject = new OptionGroupOptionSetting();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowedValues", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllowedValues = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ApplyType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ApplyType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsModifiable", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.IsModifiable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SettingDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SettingDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SettingName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SettingName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public OptionGroupOptionSetting Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static OptionGroupOptionSettingUnmarshaller _instance = new OptionGroupOptionSettingUnmarshaller();        

        public static OptionGroupOptionSettingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}