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
    public class InnerGroupQueryResponseUnmarshaller
    {
        public static InnerGroupQueryResponse Unmarshall(UnmarshallerContext context)
        {
			InnerGroupQueryResponse innerGroupQueryResponse = new InnerGroupQueryResponse();

			innerGroupQueryResponse.HttpResponse = context.HttpResponse;
			innerGroupQueryResponse.RequestId = context.StringValue("InnerGroupQuery.RequestId");

			InnerGroupQueryResponse.InnerGroupQuery_ErrorCode errorCode = new InnerGroupQueryResponse.InnerGroupQuery_ErrorCode();
			errorCode.Code = context.StringValue("InnerGroupQuery.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerGroupQuery.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerGroupQuery.ErrorCode.isSuccess");
			innerGroupQueryResponse.ErrorCode = errorCode;

			InnerGroupQueryResponse.InnerGroupQuery_Data data = new InnerGroupQueryResponse.InnerGroupQuery_Data();
			data.Total = context.IntegerValue("InnerGroupQuery.Data.total");
			data.VpcInstanceId = context.StringValue("InnerGroupQuery.Data.vpcInstanceId");
			data.PageNo = context.IntegerValue("InnerGroupQuery.Data.pageNo");
			data.PageSize = context.IntegerValue("InnerGroupQuery.Data.pageSize");
			data.RegionNo = context.StringValue("InnerGroupQuery.Data.regionNo");

			List<InnerGroupQueryResponse.InnerGroupQuery_Data.InnerGroupQuery_Group> data_groups = new List<InnerGroupQueryResponse.InnerGroupQuery_Data.InnerGroupQuery_Group>();
			for (int i = 0; i < context.Length("InnerGroupQuery.Data.Groups.Length"); i++) {
				InnerGroupQueryResponse.InnerGroupQuery_Data.InnerGroupQuery_Group group = new InnerGroupQueryResponse.InnerGroupQuery_Data.InnerGroupQuery_Group();
				group.EcsCount = context.IntegerValue("InnerGroupQuery.Data.Groups["+ i +"].ecsCount");
				group.VpcInstanceId = context.StringValue("InnerGroupQuery.Data.Groups["+ i +"].vpcInstanceId");
				group.GroupDesc = context.StringValue("InnerGroupQuery.Data.Groups["+ i +"].groupDesc");
				group.GmtCreated = context.StringValue("InnerGroupQuery.Data.Groups["+ i +"].gmtCreated");
				group.GroupName = context.StringValue("InnerGroupQuery.Data.Groups["+ i +"].groupName");
				group.GmtModified = context.StringValue("InnerGroupQuery.Data.Groups["+ i +"].gmtModified");
				group.GroupNo = context.StringValue("InnerGroupQuery.Data.Groups["+ i +"].groupNo");

				List<InnerGroupQueryResponse.InnerGroupQuery_Data.InnerGroupQuery_Group.InnerGroupQuery_Tag> group_tags = new List<InnerGroupQueryResponse.InnerGroupQuery_Data.InnerGroupQuery_Group.InnerGroupQuery_Tag>();
				for (int j = 0; j < context.Length("InnerGroupQuery.Data.Groups["+ i +"].Tags.Length"); j++) {
					InnerGroupQueryResponse.InnerGroupQuery_Data.InnerGroupQuery_Group.InnerGroupQuery_Tag tag = new InnerGroupQueryResponse.InnerGroupQuery_Data.InnerGroupQuery_Group.InnerGroupQuery_Tag();
					tag.Key = context.StringValue("InnerGroupQuery.Data.Groups["+ i +"].Tags["+ j +"].key");
					tag._Value = context.StringValue("InnerGroupQuery.Data.Groups["+ i +"].Tags["+ j +"].value");

					group_tags.Add(tag);
				}
				group.Tags = group_tags;

				data_groups.Add(group);
			}
			data.Groups = data_groups;
			innerGroupQueryResponse.Data = data;
        
			return innerGroupQueryResponse;
        }
    }
}
