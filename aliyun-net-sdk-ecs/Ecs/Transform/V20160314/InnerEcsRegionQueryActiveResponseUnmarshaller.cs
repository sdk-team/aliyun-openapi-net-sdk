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
    public class InnerEcsRegionQueryActiveResponseUnmarshaller
    {
        public static InnerEcsRegionQueryActiveResponse Unmarshall(UnmarshallerContext context)
        {
			InnerEcsRegionQueryActiveResponse innerEcsRegionQueryActiveResponse = new InnerEcsRegionQueryActiveResponse();

			innerEcsRegionQueryActiveResponse.HttpResponse = context.HttpResponse;
			innerEcsRegionQueryActiveResponse.RequestId = context.StringValue("InnerEcsRegionQueryActive.RequestId");
			innerEcsRegionQueryActiveResponse.Count = context.IntegerValue("InnerEcsRegionQueryActive.count");

			InnerEcsRegionQueryActiveResponse.InnerEcsRegionQueryActive_ErrorCode errorCode = new InnerEcsRegionQueryActiveResponse.InnerEcsRegionQueryActive_ErrorCode();
			errorCode.Code = context.StringValue("InnerEcsRegionQueryActive.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerEcsRegionQueryActive.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerEcsRegionQueryActive.ErrorCode.isSuccess");
			innerEcsRegionQueryActiveResponse.ErrorCode = errorCode;

			List<InnerEcsRegionQueryActiveResponse.InnerEcsRegionQueryActive_Item> innerEcsRegionQueryActiveResponse_data = new List<InnerEcsRegionQueryActiveResponse.InnerEcsRegionQueryActive_Item>();
			for (int i = 0; i < context.Length("InnerEcsRegionQueryActive.Data.Length"); i++) {
				InnerEcsRegionQueryActiveResponse.InnerEcsRegionQueryActive_Item item = new InnerEcsRegionQueryActiveResponse.InnerEcsRegionQueryActive_Item();
				item.RegionNoAlias = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].regionNoAlias");
				item.RegionMemo = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].regionMemo");
				item.RegionName = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].regionName");
				item.RegionNo = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].regionNo");
				item.RegionEnName = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].regionEnName");
				item.IsActive = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].isActive");
				item.Id = context.LongValue("InnerEcsRegionQueryActive.Data["+ i +"].id");

				InnerEcsRegionQueryActiveResponse.InnerEcsRegionQueryActive_Item.InnerEcsRegionQueryActive_Attributes attributes = new InnerEcsRegionQueryActiveResponse.InnerEcsRegionQueryActive_Item.InnerEcsRegionQueryActive_Attributes();
				attributes.Support_image_copy = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].Attributes.support_image_copy");
				attributes.Internal_use = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].Attributes.internal_use");
				attributes.Ak_name = context.StringValue("InnerEcsRegionQueryActive.Data["+ i +"].Attributes.ak_name");
				item.Attributes = attributes;

				innerEcsRegionQueryActiveResponse_data.Add(item);
			}
			innerEcsRegionQueryActiveResponse.Data = innerEcsRegionQueryActiveResponse_data;
        
			return innerEcsRegionQueryActiveResponse;
        }
    }
}
