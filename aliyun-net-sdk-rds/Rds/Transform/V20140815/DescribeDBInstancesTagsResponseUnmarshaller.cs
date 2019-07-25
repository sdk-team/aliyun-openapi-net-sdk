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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstancesTagsResponseUnmarshaller
    {
        public static DescribeDBInstancesTagsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstancesTagsResponse describeDBInstancesTagsResponse = new DescribeDBInstancesTagsResponse();

			describeDBInstancesTagsResponse.HttpResponse = context.HttpResponse;
			describeDBInstancesTagsResponse.RequestId = context.StringValue("DescribeDBInstancesTags.RequestId");
			describeDBInstancesTagsResponse.PageNumber = context.IntegerValue("DescribeDBInstancesTags.PageNumber");
			describeDBInstancesTagsResponse.PageRecordCount = context.IntegerValue("DescribeDBInstancesTags.PageRecordCount");
			describeDBInstancesTagsResponse.TotalRecordCount = context.IntegerValue("DescribeDBInstancesTags.TotalRecordCount");

			List<DescribeDBInstancesTagsResponse.DescribeDBInstancesTags_DBInstanceTag> describeDBInstancesTagsResponse_items = new List<DescribeDBInstancesTagsResponse.DescribeDBInstancesTags_DBInstanceTag>();
			for (int i = 0; i < context.Length("DescribeDBInstancesTags.Items.Length"); i++) {
				DescribeDBInstancesTagsResponse.DescribeDBInstancesTags_DBInstanceTag dBInstanceTag = new DescribeDBInstancesTagsResponse.DescribeDBInstancesTags_DBInstanceTag();
				dBInstanceTag.DBInstanceId = context.StringValue("DescribeDBInstancesTags.Items["+ i +"].DBInstanceId");
				dBInstanceTag.DBInstanceDescription = context.StringValue("DescribeDBInstancesTags.Items["+ i +"].DBInstanceDescription");
				dBInstanceTag.RegionId = context.StringValue("DescribeDBInstancesTags.Items["+ i +"].RegionId");

				List<DescribeDBInstancesTagsResponse.DescribeDBInstancesTags_DBInstanceTag.DescribeDBInstancesTags_Tag> dBInstanceTag_tags = new List<DescribeDBInstancesTagsResponse.DescribeDBInstancesTags_DBInstanceTag.DescribeDBInstancesTags_Tag>();
				for (int j = 0; j < context.Length("DescribeDBInstancesTags.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBInstancesTagsResponse.DescribeDBInstancesTags_DBInstanceTag.DescribeDBInstancesTags_Tag tag = new DescribeDBInstancesTagsResponse.DescribeDBInstancesTags_DBInstanceTag.DescribeDBInstancesTags_Tag();
					tag.TagKey = context.StringValue("DescribeDBInstancesTags.Items["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeDBInstancesTags.Items["+ i +"].Tags["+ j +"].TagValue");

					dBInstanceTag_tags.Add(tag);
				}
				dBInstanceTag.Tags = dBInstanceTag_tags;

				describeDBInstancesTagsResponse_items.Add(dBInstanceTag);
			}
			describeDBInstancesTagsResponse.Items = describeDBInstancesTagsResponse_items;
        
			return describeDBInstancesTagsResponse;
        }
    }
}
