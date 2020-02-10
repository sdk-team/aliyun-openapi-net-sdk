/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EcsDemo.Model.V20190626;

namespace Aliyun.Acs.EcsDemo.Transform.V20190626
{
    public class CancelInstanceResponseUnmarshaller
    {
        public static CancelInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			CancelInstanceResponse cancelInstanceResponse = new CancelInstanceResponse();

			cancelInstanceResponse.HttpResponse = context.HttpResponse;
			cancelInstanceResponse.RequestId = context.StringValue("CancelInstance.RequestId");

			CancelInstanceResponse.CancelInstance_Instance instance = new CancelInstanceResponse.CancelInstance_Instance();
			instance.Id = context.StringValue("CancelInstance.Instance.Id");
			instance.Name = context.StringValue("CancelInstance.Instance.Name");
			instance.Host = context.StringValue("CancelInstance.Instance.Host");
			cancelInstanceResponse.Instance = instance;
        
			return cancelInstanceResponse;
        }
    }
}
