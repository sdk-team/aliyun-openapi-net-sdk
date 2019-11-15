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
using Aliyun.Acs.Ecs.Model.V20160314;

namespace Aliyun.Acs.Ecs.Transform.V20160314
{
    public class InnerCountEcsInRegionResponseUnmarshaller
    {
        public static InnerCountEcsInRegionResponse Unmarshall(UnmarshallerContext context)
        {
			InnerCountEcsInRegionResponse innerCountEcsInRegionResponse = new InnerCountEcsInRegionResponse();

			innerCountEcsInRegionResponse.HttpResponse = context.HttpResponse;
			innerCountEcsInRegionResponse.RequestId = context.StringValue("InnerCountEcsInRegion.RequestId");
			innerCountEcsInRegionResponse.PageNumber = context.IntegerValue("InnerCountEcsInRegion.PageNumber");
			innerCountEcsInRegionResponse.PageSize = context.IntegerValue("InnerCountEcsInRegion.PageSize");

			List<InnerCountEcsInRegionResponse.InnerCountEcsInRegion_EcsInRegion> innerCountEcsInRegionResponse_ecsInRegions = new List<InnerCountEcsInRegionResponse.InnerCountEcsInRegion_EcsInRegion>();
			for (int i = 0; i < context.Length("InnerCountEcsInRegion.EcsInRegions.Length"); i++) {
				InnerCountEcsInRegionResponse.InnerCountEcsInRegion_EcsInRegion ecsInRegion = new InnerCountEcsInRegionResponse.InnerCountEcsInRegion_EcsInRegion();
				ecsInRegion.EcsNum = context.IntegerValue("InnerCountEcsInRegion.EcsInRegions["+ i +"].EcsNum");
				ecsInRegion.AliUid = context.LongValue("InnerCountEcsInRegion.EcsInRegions["+ i +"].AliUid");
				ecsInRegion.RegionNo = context.StringValue("InnerCountEcsInRegion.EcsInRegions["+ i +"].RegionNo");

				innerCountEcsInRegionResponse_ecsInRegions.Add(ecsInRegion);
			}
			innerCountEcsInRegionResponse.EcsInRegions = innerCountEcsInRegionResponse_ecsInRegions;
        
			return innerCountEcsInRegionResponse;
        }
    }
}
