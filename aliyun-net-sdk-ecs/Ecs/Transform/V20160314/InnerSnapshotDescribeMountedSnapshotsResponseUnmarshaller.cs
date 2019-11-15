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
    public class InnerSnapshotDescribeMountedSnapshotsResponseUnmarshaller
    {
        public static InnerSnapshotDescribeMountedSnapshotsResponse Unmarshall(UnmarshallerContext context)
        {
			InnerSnapshotDescribeMountedSnapshotsResponse innerSnapshotDescribeMountedSnapshotsResponse = new InnerSnapshotDescribeMountedSnapshotsResponse();

			innerSnapshotDescribeMountedSnapshotsResponse.HttpResponse = context.HttpResponse;
			innerSnapshotDescribeMountedSnapshotsResponse.RequestId = context.StringValue("InnerSnapshotDescribeMountedSnapshots.RequestId");
			innerSnapshotDescribeMountedSnapshotsResponse.Count = context.IntegerValue("InnerSnapshotDescribeMountedSnapshots.count");
			innerSnapshotDescribeMountedSnapshotsResponse.PageNo = context.IntegerValue("InnerSnapshotDescribeMountedSnapshots.pageNo");
			innerSnapshotDescribeMountedSnapshotsResponse.PageSize = context.IntegerValue("InnerSnapshotDescribeMountedSnapshots.pageSize");
			innerSnapshotDescribeMountedSnapshotsResponse.TotalCount = context.IntegerValue("InnerSnapshotDescribeMountedSnapshots.totalCount");

			InnerSnapshotDescribeMountedSnapshotsResponse.InnerSnapshotDescribeMountedSnapshots_ErrorCode errorCode = new InnerSnapshotDescribeMountedSnapshotsResponse.InnerSnapshotDescribeMountedSnapshots_ErrorCode();
			errorCode.Code = context.StringValue("InnerSnapshotDescribeMountedSnapshots.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerSnapshotDescribeMountedSnapshots.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerSnapshotDescribeMountedSnapshots.ErrorCode.isSuccess");
			innerSnapshotDescribeMountedSnapshotsResponse.ErrorCode = errorCode;

			List<InnerSnapshotDescribeMountedSnapshotsResponse.InnerSnapshotDescribeMountedSnapshots_Item> innerSnapshotDescribeMountedSnapshotsResponse_data = new List<InnerSnapshotDescribeMountedSnapshotsResponse.InnerSnapshotDescribeMountedSnapshots_Item>();
			for (int i = 0; i < context.Length("InnerSnapshotDescribeMountedSnapshots.Data.Length"); i++) {
				InnerSnapshotDescribeMountedSnapshotsResponse.InnerSnapshotDescribeMountedSnapshots_Item item = new InnerSnapshotDescribeMountedSnapshotsResponse.InnerSnapshotDescribeMountedSnapshots_Item();
				item.Device = context.StringValue("InnerSnapshotDescribeMountedSnapshots.Data["+ i +"].device");
				item.EcsOwnerAliUid = context.LongValue("InnerSnapshotDescribeMountedSnapshots.Data["+ i +"].ecsOwnerAliUid");
				item.EcsInstanceId = context.StringValue("InnerSnapshotDescribeMountedSnapshots.Data["+ i +"].ecsInstanceId");
				item.SnapshotId = context.LongValue("InnerSnapshotDescribeMountedSnapshots.Data["+ i +"].snapshotId");
				item.EcsRegionNo = context.StringValue("InnerSnapshotDescribeMountedSnapshots.Data["+ i +"].ecsRegionNo");
				item.SnapshotOwnerAliUid = context.LongValue("InnerSnapshotDescribeMountedSnapshots.Data["+ i +"].snapshotOwnerAliUid");
				item.Status = context.StringValue("InnerSnapshotDescribeMountedSnapshots.Data["+ i +"].status");
				item.MountedTime = context.StringValue("InnerSnapshotDescribeMountedSnapshots.Data["+ i +"].mountedTime");

				innerSnapshotDescribeMountedSnapshotsResponse_data.Add(item);
			}
			innerSnapshotDescribeMountedSnapshotsResponse.Data = innerSnapshotDescribeMountedSnapshotsResponse_data;
        
			return innerSnapshotDescribeMountedSnapshotsResponse;
        }
    }
}
