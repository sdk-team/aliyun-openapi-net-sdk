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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class InnerVpcDescribeCrossBorderRouterInterfaceResponseUnmarshaller
    {
        public static InnerVpcDescribeCrossBorderRouterInterfaceResponse Unmarshall(UnmarshallerContext context)
        {
			InnerVpcDescribeCrossBorderRouterInterfaceResponse innerVpcDescribeCrossBorderRouterInterfaceResponse = new InnerVpcDescribeCrossBorderRouterInterfaceResponse();

			innerVpcDescribeCrossBorderRouterInterfaceResponse.HttpResponse = context.HttpResponse;
			innerVpcDescribeCrossBorderRouterInterfaceResponse.RequestId = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.RequestId");

			List<InnerVpcDescribeCrossBorderRouterInterfaceResponse.InnerVpcDescribeCrossBorderRouterInterface_AlreadyOpenedId> innerVpcDescribeCrossBorderRouterInterfaceResponse_alreadyOpenedIds = new List<InnerVpcDescribeCrossBorderRouterInterfaceResponse.InnerVpcDescribeCrossBorderRouterInterface_AlreadyOpenedId>();
			for (int i = 0; i < context.Length("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds.Length"); i++) {
				InnerVpcDescribeCrossBorderRouterInterfaceResponse.InnerVpcDescribeCrossBorderRouterInterface_AlreadyOpenedId alreadyOpenedId = new InnerVpcDescribeCrossBorderRouterInterfaceResponse.InnerVpcDescribeCrossBorderRouterInterface_AlreadyOpenedId();
				alreadyOpenedId.AliUid = context.LongValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].AliUid");
				alreadyOpenedId.OppositeInterfaceOwnerId = context.LongValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].OppositeInterfaceOwnerId");
				alreadyOpenedId.InstanceId = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].InstanceId");
				alreadyOpenedId.OppositeInterfaceId = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].OppositeInterfaceId");
				alreadyOpenedId.RegionNo = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].RegionNo");
				alreadyOpenedId.OppositeRegionNo = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].OppositeRegionNo");
				alreadyOpenedId.Spec = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].Spec");
				alreadyOpenedId.OppositeInterfaceSpec = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].OppositeInterfaceSpec");
				alreadyOpenedId.ConnectedTime = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].ConnectedTime");
				alreadyOpenedId.Description = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.AlreadyOpenedIds["+ i +"].Description");

				innerVpcDescribeCrossBorderRouterInterfaceResponse_alreadyOpenedIds.Add(alreadyOpenedId);
			}
			innerVpcDescribeCrossBorderRouterInterfaceResponse.AlreadyOpenedIds = innerVpcDescribeCrossBorderRouterInterfaceResponse_alreadyOpenedIds;

			List<InnerVpcDescribeCrossBorderRouterInterfaceResponse.InnerVpcDescribeCrossBorderRouterInterface_NotOpenedId> innerVpcDescribeCrossBorderRouterInterfaceResponse_notOpenedIds = new List<InnerVpcDescribeCrossBorderRouterInterfaceResponse.InnerVpcDescribeCrossBorderRouterInterface_NotOpenedId>();
			for (int i = 0; i < context.Length("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds.Length"); i++) {
				InnerVpcDescribeCrossBorderRouterInterfaceResponse.InnerVpcDescribeCrossBorderRouterInterface_NotOpenedId notOpenedId = new InnerVpcDescribeCrossBorderRouterInterfaceResponse.InnerVpcDescribeCrossBorderRouterInterface_NotOpenedId();
				notOpenedId.AliUid = context.LongValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].AliUid");
				notOpenedId.OppositeInterfaceOwnerId = context.LongValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].OppositeInterfaceOwnerId");
				notOpenedId.InstanceId = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].InstanceId");
				notOpenedId.OppositeInterfaceId = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].OppositeInterfaceId");
				notOpenedId.RegionNo = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].RegionNo");
				notOpenedId.OppositeRegionNo = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].OppositeRegionNo");
				notOpenedId.Spec = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].Spec");
				notOpenedId.OppositeInterfaceSpec = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].OppositeInterfaceSpec");
				notOpenedId.ConnectedTime = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].ConnectedTime");
				notOpenedId.Description = context.StringValue("InnerVpcDescribeCrossBorderRouterInterface.NotOpenedIds["+ i +"].Description");

				innerVpcDescribeCrossBorderRouterInterfaceResponse_notOpenedIds.Add(notOpenedId);
			}
			innerVpcDescribeCrossBorderRouterInterfaceResponse.NotOpenedIds = innerVpcDescribeCrossBorderRouterInterfaceResponse_notOpenedIds;
        
			return innerVpcDescribeCrossBorderRouterInterfaceResponse;
        }
    }
}
