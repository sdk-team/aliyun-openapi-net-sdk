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
    public class InnerDetailResponseUnmarshaller
    {
        public static InnerDetailResponse Unmarshall(UnmarshallerContext context)
        {
			InnerDetailResponse innerDetailResponse = new InnerDetailResponse();

			innerDetailResponse.HttpResponse = context.HttpResponse;
			innerDetailResponse.RequestId = context.StringValue("InnerDetail.RequestId");

			InnerDetailResponse.InnerDetail_InstanceModel instanceModel = new InnerDetailResponse.InnerDetail_InstanceModel();
			instanceModel.SystemDeviceCategory = context.StringValue("InnerDetail.InstanceModel.SystemDeviceCategory");
			instanceModel.VncHost = context.StringValue("InnerDetail.InstanceModel.VncHost");
			instanceModel.IntensiveNet = context.IntegerValue("InnerDetail.InstanceModel.IntensiveNet");
			instanceModel.SafetyQuota = context.StringValue("InnerDetail.InstanceModel.SafetyQuota");
			instanceModel.VncPort = context.IntegerValue("InnerDetail.InstanceModel.VncPort");
			instanceModel.ZoneNo = context.StringValue("InnerDetail.InstanceModel.ZoneNo");
			instanceModel.InstanceName = context.StringValue("InnerDetail.InstanceModel.InstanceName");
			instanceModel.RegionNo = context.StringValue("InnerDetail.InstanceModel.RegionNo");
			instanceModel.Hostname = context.StringValue("InnerDetail.InstanceModel.Hostname");
			instanceModel.NetworkValidation = context.BooleanValue("InnerDetail.InstanceModel.NetworkValidation");
			instanceModel.InternetTx = context.IntegerValue("InnerDetail.InstanceModel.InternetTx");
			instanceModel.InternetRx = context.IntegerValue("InnerDetail.InstanceModel.InternetRx");
			instanceModel.Platform = context.StringValue("InnerDetail.InstanceModel.Platform");
			instanceModel.VlanNo = context.StringValue("InnerDetail.InstanceModel.VlanNo");
			instanceModel.Status = context.StringValue("InnerDetail.InstanceModel.Status");
			instanceModel.CreationTime = context.StringValue("InnerDetail.InstanceModel.CreationTime");
			instanceModel.Mem = context.IntegerValue("InnerDetail.InstanceModel.Mem");
			instanceModel.IntensiveIo = context.IntegerValue("InnerDetail.InstanceModel.IntensiveIo");
			instanceModel.NcId = context.StringValue("InnerDetail.InstanceModel.NcId");
			instanceModel.Bps = context.IntegerValue("InnerDetail.InstanceModel.Bps");
			instanceModel.VncPassword = context.StringValue("InnerDetail.InstanceModel.VncPassword");
			instanceModel.EcsName = context.StringValue("InnerDetail.InstanceModel.EcsName");
			instanceModel.InnerIp = context.StringValue("InnerDetail.InstanceModel.InnerIp");
			instanceModel.RealZoneNo = context.StringValue("InnerDetail.InstanceModel.RealZoneNo");
			instanceModel.SerialNumber = context.StringValue("InnerDetail.InstanceModel.SerialNumber");
			instanceModel.IzNo = context.StringValue("InnerDetail.InstanceModel.IzNo");
			instanceModel.Cores = context.IntegerValue("InnerDetail.InstanceModel.Cores");
			instanceModel.IntranetTx = context.IntegerValue("InnerDetail.InstanceModel.IntranetTx");
			instanceModel.IntensiveCpu = context.IntegerValue("InnerDetail.InstanceModel.IntensiveCpu");
			instanceModel.ImageProductCode = context.StringValue("InnerDetail.InstanceModel.ImageProductCode");
			instanceModel.IntranetRx = context.IntegerValue("InnerDetail.InstanceModel.IntranetRx");
			instanceModel.SecurityControl = context.StringValue("InnerDetail.InstanceModel.SecurityControl");
			instanceModel.RackId = context.StringValue("InnerDetail.InstanceModel.RackId");
			instanceModel.Disk = context.IntegerValue("InnerDetail.InstanceModel.Disk");

			InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_PublicIp publicIp = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_PublicIp();
			publicIp.BindIp = context.StringValue("InnerDetail.InstanceModel.PublicIp.BindIp");
			publicIp.AssignNatIp = context.StringValue("InnerDetail.InstanceModel.PublicIp.AssignNatIp");
			publicIp.AssignIp = context.StringValue("InnerDetail.InstanceModel.PublicIp.AssignIp");
			instanceModel.PublicIp = publicIp;

			InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img img = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img();
			img.Name = context.StringValue("InnerDetail.InstanceModel.Img.Name");
			img.ImageId = context.StringValue("InnerDetail.InstanceModel.Img.ImageId");
			img.SrcImageId = context.LongValue("InnerDetail.InstanceModel.Img.SrcImageId");
			img.GmtCreated = context.StringValue("InnerDetail.InstanceModel.Img.GmtCreated");
			img.Id = context.LongValue("InnerDetail.InstanceModel.Img.Id");
			img.Bid = context.StringValue("InnerDetail.InstanceModel.Img.Bid");
			img.Visibility = context.StringValue("InnerDetail.InstanceModel.Img.Visibility");
			img.Remark = context.StringValue("InnerDetail.InstanceModel.Img.Remark");
			img.SupportIoOptimizedInstance = context.BooleanValue("InnerDetail.InstanceModel.Img.SupportIoOptimizedInstance");
			img.ImportOSSObject = context.StringValue("InnerDetail.InstanceModel.Img.ImportOSSObject");
			img.GmtModified = context.StringValue("InnerDetail.InstanceModel.Img.GmtModified");
			img.Progress = context.StringValue("InnerDetail.InstanceModel.Img.Progress");
			img.Version = context.StringValue("InnerDetail.InstanceModel.Img.Version");
			img.ImageProductCode = context.StringValue("InnerDetail.InstanceModel.Img.ImageProductCode");
			img.AliUid = context.LongValue("InnerDetail.InstanceModel.Img.AliUid");
			img.GmtRelease = context.StringValue("InnerDetail.InstanceModel.Img.GmtRelease");
			img.ImageCategory = context.StringValue("InnerDetail.InstanceModel.Img.ImageCategory");
			img.DisplayName = context.StringValue("InnerDetail.InstanceModel.Img.DisplayName");
			img.Owner = context.StringValue("InnerDetail.InstanceModel.Img.Owner");
			img.Status = context.StringValue("InnerDetail.InstanceModel.Img.Status");
			img.ImportOSSBucket = context.StringValue("InnerDetail.InstanceModel.Img.ImportOSSBucket");
			img.Format = context.StringValue("InnerDetail.InstanceModel.Img.Format");
			img.RegionNo = context.StringValue("InnerDetail.InstanceModel.Img.RegionNo");
			img.ImageSize = context.IntegerValue("InnerDetail.InstanceModel.Img.ImageSize");
			img.SnapshotNo = context.StringValue("InnerDetail.InstanceModel.Img.SnapshotNo");

			InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_OsTypeModel osTypeModel = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_OsTypeModel();
			osTypeModel.Platform = context.StringValue("InnerDetail.InstanceModel.Img.OsTypeModel.Platform");
			osTypeModel.Id = context.LongValue("InnerDetail.InstanceModel.Img.OsTypeModel.Id");
			osTypeModel.OsBit = context.IntegerValue("InnerDetail.InstanceModel.Img.OsTypeModel.OsBit");
			osTypeModel.MinCpu = context.IntegerValue("InnerDetail.InstanceModel.Img.OsTypeModel.MinCpu");
			osTypeModel.MinMemory = context.IntegerValue("InnerDetail.InstanceModel.Img.OsTypeModel.MinMemory");
			osTypeModel.MaxCpu = context.IntegerValue("InnerDetail.InstanceModel.Img.OsTypeModel.MaxCpu");
			osTypeModel.MaxMemory = context.IntegerValue("InnerDetail.InstanceModel.Img.OsTypeModel.MaxMemory");
			osTypeModel.OsName = context.StringValue("InnerDetail.InstanceModel.Img.OsTypeModel.OsName");
			osTypeModel.OsMemo = context.StringValue("InnerDetail.InstanceModel.Img.OsTypeModel.OsMemo");
			osTypeModel.Type = context.StringValue("InnerDetail.InstanceModel.Img.OsTypeModel.Type");

			InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_OsTypeModel.InnerDetail_Kind kind = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_OsTypeModel.InnerDetail_Kind();
			kind.Kind = context.StringValue("InnerDetail.InstanceModel.Img.OsTypeModel.Kind.Kind");
			osTypeModel.Kind = kind;
			img.OsTypeModel = osTypeModel;

			InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_QuoteType quoteType = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_QuoteType();
			quoteType.QuoteType = context.StringValue("InnerDetail.InstanceModel.Img.QuoteType.QuoteType");
			img.QuoteType = quoteType;

			List<InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_Tag2> img_tags1 = new List<InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_Tag2>();
			for (int i = 0; i < context.Length("InnerDetail.InstanceModel.Img.Tags.Length"); i++) {
				InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_Tag2 tag2 = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Img.InnerDetail_Tag2();
				tag2.Key = context.StringValue("InnerDetail.InstanceModel.Img.Tags["+ i +"].Key");
				tag2._Value = context.StringValue("InnerDetail.InstanceModel.Img.Tags["+ i +"].Value");

				img_tags1.Add(tag2);
			}
			img.Tags1 = img_tags1;
			instanceModel.Img = img;

			InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_StatusNote statusNote = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_StatusNote();
			statusNote.NoteCode = context.StringValue("InnerDetail.InstanceModel.StatusNote.NoteCode");
			statusNote.NoteInfo = context.StringValue("InnerDetail.InstanceModel.StatusNote.NoteInfo");
			instanceModel.StatusNote = statusNote;

			List<InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Group> instanceModel_groups = new List<InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Group>();
			for (int i = 0; i < context.Length("InnerDetail.InstanceModel.Groups.Length"); i++) {
				InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Group group = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Group();
				group.GroupNo = context.StringValue("InnerDetail.InstanceModel.Groups["+ i +"].GroupNo");
				group.GroupName = context.StringValue("InnerDetail.InstanceModel.Groups["+ i +"].GroupName");
				group.GroupDesc = context.StringValue("InnerDetail.InstanceModel.Groups["+ i +"].GroupDesc");
				group.EcsCount = context.IntegerValue("InnerDetail.InstanceModel.Groups["+ i +"].EcsCount");
				group.VpcInstanceId = context.StringValue("InnerDetail.InstanceModel.Groups["+ i +"].VpcInstanceId");
				group.GmtCreated = context.StringValue("InnerDetail.InstanceModel.Groups["+ i +"].GmtCreated");
				group.GmtModified = context.StringValue("InnerDetail.InstanceModel.Groups["+ i +"].GmtModified");

				List<InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Group.InnerDetail_Tag> group_tags = new List<InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Group.InnerDetail_Tag>();
				for (int j = 0; j < context.Length("InnerDetail.InstanceModel.Groups["+ i +"].Tags.Length"); j++) {
					InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Group.InnerDetail_Tag tag = new InnerDetailResponse.InnerDetail_InstanceModel.InnerDetail_Group.InnerDetail_Tag();
					tag.Key = context.StringValue("InnerDetail.InstanceModel.Groups["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("InnerDetail.InstanceModel.Groups["+ i +"].Tags["+ j +"].Value");

					group_tags.Add(tag);
				}
				group.Tags = group_tags;

				instanceModel_groups.Add(group);
			}
			instanceModel.Groups = instanceModel_groups;
			innerDetailResponse.InstanceModel = instanceModel;
        
			return innerDetailResponse;
        }
    }
}
