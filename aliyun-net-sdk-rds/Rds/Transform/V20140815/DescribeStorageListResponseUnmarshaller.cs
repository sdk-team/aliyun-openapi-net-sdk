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
    public class DescribeStorageListResponseUnmarshaller
    {
        public static DescribeStorageListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStorageListResponse describeStorageListResponse = new DescribeStorageListResponse();

			describeStorageListResponse.HttpResponse = context.HttpResponse;
			describeStorageListResponse.RequestId = context.StringValue("DescribeStorageList.RequestId");

			List<DescribeStorageListResponse.DescribeStorageList_StorageList> describeStorageListResponse_items = new List<DescribeStorageListResponse.DescribeStorageList_StorageList>();
			for (int i = 0; i < context.Length("DescribeStorageList.Items.Length"); i++) {
				DescribeStorageListResponse.DescribeStorageList_StorageList storageList = new DescribeStorageListResponse.DescribeStorageList_StorageList();
				storageList.ClassGroup = context.StringValue("DescribeStorageList.Items["+ i +"].ClassGroup");
				storageList.ClassCode = context.StringValue("DescribeStorageList.Items["+ i +"].ClassCode");
				storageList.Cpu = context.StringValue("DescribeStorageList.Items["+ i +"].Cpu");
				storageList.MaxConnections = context.StringValue("DescribeStorageList.Items["+ i +"].MaxConnections");
				storageList.MaxIOPS = context.StringValue("DescribeStorageList.Items["+ i +"].MaxIOPS");
				storageList.MemoryClass = context.StringValue("DescribeStorageList.Items["+ i +"].MemoryClass");
				storageList.ReferencePrice = context.StringValue("DescribeStorageList.Items["+ i +"].ReferencePrice");
				storageList.ClassTypeLevel = context.StringValue("DescribeStorageList.Items["+ i +"].ClassTypeLevel");

				describeStorageListResponse_items.Add(storageList);
			}
			describeStorageListResponse.Items = describeStorageListResponse_items;
        
			return describeStorageListResponse;
        }
    }
}
