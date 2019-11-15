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
    public class InnerEcsRegionQueryAllResponseUnmarshaller
    {
        public static InnerEcsRegionQueryAllResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsRegionQueryAllResponse innerEcsRegionQueryAllResponse = new InnerEcsRegionQueryAllResponse();

			innerEcsRegionQueryAllResponse.HttpResponse = context.HttpResponse;
			innerEcsRegionQueryAllResponse.RequestId = context.StringValue("InnerEcsRegionQueryAll.RequestId");
			innerEcsRegionQueryAllResponse.Count = context.IntegerValue("InnerEcsRegionQueryAll.count");

			InnerEcsRegionQueryAllResponse.InnerEcsRegionQueryAll_ErrorCode errorCode = new InnerEcsRegionQueryAllResponse.InnerEcsRegionQueryAll_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsRegionQueryAll.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsRegionQueryAll.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsRegionQueryAll.ErrorCode.isSuccess");
			innerEcsRegionQueryAllResponse.ErrorCode = errorCode;

			List<InnerEcsRegionQueryAllResponse.InnerEcsRegionQueryAll_Item> innerEcsRegionQueryAllResponse_data = new List<InnerEcsRegionQueryAllResponse.InnerEcsRegionQueryAll_Item>();
			for (int i = 0; i < context.Length("InnerEcsRegionQueryAll.Data.Length"); i++) {
				InnerEcsRegionQueryAllResponse.InnerEcsRegionQueryAll_Item item = new InnerEcsRegionQueryAllResponse.InnerEcsRegionQueryAll_Item();
				item.RegionNoAlias = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].regionNoAlias");
				item.RegionMemo = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].regionMemo");
				item.RegionName = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].regionName");
				item.RegionNo = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].regionNo");
				item.RegionEnName = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].regionEnName");
				item.IsActive = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].isActive");
				item.Id = context.LongValue("InnerEcsRegionQueryAll.Data["+ i +"].id");

				InnerEcsRegionQueryAllResponse.InnerEcsRegionQueryAll_Item.InnerEcsRegionQueryAll_Attributes attributes = new InnerEcsRegionQueryAllResponse.InnerEcsRegionQueryAll_Item.InnerEcsRegionQueryAll_Attributes();
				attributes.Support_image_copy = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].Attributes.support_image_copy");
				attributes.Internal_use = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].Attributes.internal_use");
				attributes.Ak_name = context.StringValue("InnerEcsRegionQueryAll.Data["+ i +"].Attributes.ak_name");
				item.Attributes = attributes;

				innerEcsRegionQueryAllResponse_data.Add(item);
			}
			innerEcsRegionQueryAllResponse.Data = innerEcsRegionQueryAllResponse_data;
        
			return innerEcsRegionQueryAllResponse;
        }
    }
}
