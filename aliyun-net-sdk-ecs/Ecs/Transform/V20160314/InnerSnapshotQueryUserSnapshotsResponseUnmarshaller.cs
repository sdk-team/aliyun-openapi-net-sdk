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
    public class InnerSnapshotQueryUserSnapshotsResponseUnmarshaller
    {
        public static InnerSnapshotQueryUserSnapshotsResponse Unmarshall(UnmarshallerContext context)
        {
			InnerSnapshotQueryUserSnapshotsResponse innerSnapshotQueryUserSnapshotsResponse = new InnerSnapshotQueryUserSnapshotsResponse();

			innerSnapshotQueryUserSnapshotsResponse.HttpResponse = context.HttpResponse;
			innerSnapshotQueryUserSnapshotsResponse.RequestId = context.StringValue("InnerSnapshotQueryUserSnapshots.RequestId");
			innerSnapshotQueryUserSnapshotsResponse.Count = context.IntegerValue("InnerSnapshotQueryUserSnapshots.count");
			innerSnapshotQueryUserSnapshotsResponse.PageNo = context.IntegerValue("InnerSnapshotQueryUserSnapshots.pageNo");
			innerSnapshotQueryUserSnapshotsResponse.PageSize = context.IntegerValue("InnerSnapshotQueryUserSnapshots.pageSize");

			InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_ErrorCode errorCode = new InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_ErrorCode();
			errorCode.Code = context.StringValue("InnerSnapshotQueryUserSnapshots.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerSnapshotQueryUserSnapshots.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerSnapshotQueryUserSnapshots.ErrorCode.isSuccess");
			innerSnapshotQueryUserSnapshotsResponse.ErrorCode = errorCode;

			List<InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_Item> innerSnapshotQueryUserSnapshotsResponse_data = new List<InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_Item>();
			for (int i = 0; i < context.Length("InnerSnapshotQueryUserSnapshots.Data.Length"); i++) {
				InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_Item item = new InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_Item();
				item.SnapshotType = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].snapshotType");
				item.GmtModified = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].gmtModified");
				item.SnapshotId = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].snapshotId");
				item.AliUid = context.LongValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].aliUid");
				item.ImgPc = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].imgPc");
				item.DiskType = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].diskType");
				item.SnapshotNickname = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].snapshotNickname");
				item.DeviceType = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].deviceType");
				item.SnapshotName = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].snapshotName");
				item.Description = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].description");
				item.Id = context.LongValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].id");
				item.EcsSnapshotStatus = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].ecsSnapshotStatus");
				item.GmtCreated = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].gmtCreated");
				item.Bid = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].bid");
				item.EcsId = context.LongValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].ecsId");
				item.DiskId = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].diskId");
				item.SnapshotProcess = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].snapshotProcess");
				item.Status = context.IntegerValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].status");
				item.SnapshotSize = context.IntegerValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].snapshotSize");
				item.SnapshotNo = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].snapshotNo");
				item.QuoteType = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].quoteType");
				item.ImgId = context.LongValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].imgId");
				item.DeviceNo = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].deviceNo");
				item.DiskSize = context.IntegerValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].diskSize");

				List<InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_Item.InnerSnapshotQueryUserSnapshots_Tag> item_tags = new List<InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_Item.InnerSnapshotQueryUserSnapshots_Tag>();
				for (int j = 0; j < context.Length("InnerSnapshotQueryUserSnapshots.Data["+ i +"].Tags.Length"); j++) {
					InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_Item.InnerSnapshotQueryUserSnapshots_Tag tag = new InnerSnapshotQueryUserSnapshotsResponse.InnerSnapshotQueryUserSnapshots_Item.InnerSnapshotQueryUserSnapshots_Tag();
					tag.Key = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].Tags["+ j +"].key");
					tag._Value = context.StringValue("InnerSnapshotQueryUserSnapshots.Data["+ i +"].Tags["+ j +"].value");

					item_tags.Add(tag);
				}
				item.Tags = item_tags;

				innerSnapshotQueryUserSnapshotsResponse_data.Add(item);
			}
			innerSnapshotQueryUserSnapshotsResponse.Data = innerSnapshotQueryUserSnapshotsResponse_data;
        
			return innerSnapshotQueryUserSnapshotsResponse;
        }
    }
}
