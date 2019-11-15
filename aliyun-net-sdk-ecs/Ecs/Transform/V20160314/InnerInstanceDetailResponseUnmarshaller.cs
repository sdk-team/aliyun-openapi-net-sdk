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
    public class InnerInstanceDetailResponseUnmarshaller
    {
        public static InnerInstanceDetailResponse Unmarshall(UnmarshallerContext context)
        {
			InnerInstanceDetailResponse innerInstanceDetailResponse = new InnerInstanceDetailResponse();

			innerInstanceDetailResponse.HttpResponse = context.HttpResponse;
			innerInstanceDetailResponse.RequestId = context.StringValue("InnerInstanceDetail.RequestId");

			InnerInstanceDetailResponse.InnerInstanceDetail_ErrorCode errorCode = new InnerInstanceDetailResponse.InnerInstanceDetail_ErrorCode();
			errorCode.Code = context.StringValue("InnerInstanceDetail.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerInstanceDetail.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerInstanceDetail.ErrorCode.isSuccess");
			innerInstanceDetailResponse.ErrorCode = errorCode;

			InnerInstanceDetailResponse.InnerInstanceDetail_Data data = new InnerInstanceDetailResponse.InnerInstanceDetail_Data();
			data.SystemDeviceCategory = context.StringValue("InnerInstanceDetail.Data.systemDeviceCategory");
			data.VncHost = context.StringValue("InnerInstanceDetail.Data.vncHost");
			data.IntensiveNet = context.IntegerValue("InnerInstanceDetail.Data.intensiveNet");
			data.SafetyQuota = context.StringValue("InnerInstanceDetail.Data.safetyQuota");
			data.VncPort = context.IntegerValue("InnerInstanceDetail.Data.vncPort");
			data.ZoneNo = context.StringValue("InnerInstanceDetail.Data.zoneNo");
			data.InstanceName = context.StringValue("InnerInstanceDetail.Data.instanceName");
			data.RegionNo = context.StringValue("InnerInstanceDetail.Data.regionNo");
			data.Hostname = context.StringValue("InnerInstanceDetail.Data.hostname");
			data.NetworkValidation = context.BooleanValue("InnerInstanceDetail.Data.networkValidation");
			data.InternetTx = context.IntegerValue("InnerInstanceDetail.Data.internetTx");
			data.InternetRx = context.IntegerValue("InnerInstanceDetail.Data.internetRx");
			data.Platform = context.StringValue("InnerInstanceDetail.Data.platform");
			data.VlanNo = context.StringValue("InnerInstanceDetail.Data.vlanNo");
			data.Status = context.StringValue("InnerInstanceDetail.Data.status");
			data.CreationTime = context.StringValue("InnerInstanceDetail.Data.creationTime");
			data.Mem = context.IntegerValue("InnerInstanceDetail.Data.mem");
			data.IntensiveIo = context.IntegerValue("InnerInstanceDetail.Data.intensiveIo");
			data.NcId = context.StringValue("InnerInstanceDetail.Data.ncId");
			data.Bps = context.IntegerValue("InnerInstanceDetail.Data.bps");
			data.VncPassword = context.StringValue("InnerInstanceDetail.Data.vncPassword");
			data.EcsName = context.StringValue("InnerInstanceDetail.Data.ecsName");
			data.InnerIp = context.StringValue("InnerInstanceDetail.Data.innerIp");
			data.RealZoneNo = context.StringValue("InnerInstanceDetail.Data.realZoneNo");
			data.SerialNumber = context.StringValue("InnerInstanceDetail.Data.serialNumber");
			data.IzNo = context.StringValue("InnerInstanceDetail.Data.izNo");
			data.Cores = context.IntegerValue("InnerInstanceDetail.Data.cores");
			data.IntranetTx = context.IntegerValue("InnerInstanceDetail.Data.intranetTx");
			data.IntensiveCpu = context.IntegerValue("InnerInstanceDetail.Data.intensiveCpu");
			data.ImageProductCode = context.StringValue("InnerInstanceDetail.Data.imageProductCode");
			data.IntranetRx = context.IntegerValue("InnerInstanceDetail.Data.intranetRx");
			data.SecurityControl = context.StringValue("InnerInstanceDetail.Data.securityControl");
			data.RackId = context.StringValue("InnerInstanceDetail.Data.rackId");
			data.Disk = context.IntegerValue("InnerInstanceDetail.Data.disk");

			InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_PublicIp publicIp = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_PublicIp();
			publicIp.BindIp = context.StringValue("InnerInstanceDetail.Data.PublicIp.bindIp");
			publicIp.AssignNatIp = context.StringValue("InnerInstanceDetail.Data.PublicIp.assignNatIp");
			publicIp.AssignIp = context.StringValue("InnerInstanceDetail.Data.PublicIp.assignIp");
			data.PublicIp = publicIp;

			InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img img = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img();
			img.Name = context.StringValue("InnerInstanceDetail.Data.Img.name");
			img.ImageId = context.StringValue("InnerInstanceDetail.Data.Img.imageId");
			img.SrcImageId = context.LongValue("InnerInstanceDetail.Data.Img.srcImageId");
			img.GmtCreated = context.StringValue("InnerInstanceDetail.Data.Img.gmtCreated");
			img.Id = context.LongValue("InnerInstanceDetail.Data.Img.id");
			img.Bid = context.StringValue("InnerInstanceDetail.Data.Img.bid");
			img.Visibility = context.StringValue("InnerInstanceDetail.Data.Img.visibility");
			img.Remark = context.StringValue("InnerInstanceDetail.Data.Img.remark");
			img.SupportIoOptimizedInstance = context.BooleanValue("InnerInstanceDetail.Data.Img.supportIoOptimizedInstance");
			img.ImportOSSObject = context.StringValue("InnerInstanceDetail.Data.Img.importOSSObject");
			img.GmtModified = context.StringValue("InnerInstanceDetail.Data.Img.gmtModified");
			img.Progress = context.StringValue("InnerInstanceDetail.Data.Img.progress");
			img.Version = context.StringValue("InnerInstanceDetail.Data.Img.version");
			img.ImageProductCode = context.StringValue("InnerInstanceDetail.Data.Img.imageProductCode");
			img.AliUid = context.LongValue("InnerInstanceDetail.Data.Img.aliUid");
			img.GmtRelease = context.StringValue("InnerInstanceDetail.Data.Img.gmtRelease");
			img.ImageCategory = context.StringValue("InnerInstanceDetail.Data.Img.imageCategory");
			img.DisplayName = context.StringValue("InnerInstanceDetail.Data.Img.displayName");
			img.Owner = context.StringValue("InnerInstanceDetail.Data.Img.owner");
			img.Status = context.StringValue("InnerInstanceDetail.Data.Img.status");
			img.ImportOSSBucket = context.StringValue("InnerInstanceDetail.Data.Img.importOSSBucket");
			img.Format = context.StringValue("InnerInstanceDetail.Data.Img.format");
			img.RegionNo = context.StringValue("InnerInstanceDetail.Data.Img.regionNo");
			img.ImageSize = context.IntegerValue("InnerInstanceDetail.Data.Img.imageSize");
			img.SnapshotNo = context.StringValue("InnerInstanceDetail.Data.Img.snapshotNo");

			InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_OsTypeModel osTypeModel = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_OsTypeModel();
			osTypeModel.Platform = context.StringValue("InnerInstanceDetail.Data.Img.OsTypeModel.platform");
			osTypeModel.Id = context.LongValue("InnerInstanceDetail.Data.Img.OsTypeModel.id");
			osTypeModel.OsBit = context.IntegerValue("InnerInstanceDetail.Data.Img.OsTypeModel.osBit");
			osTypeModel.MinCpu = context.IntegerValue("InnerInstanceDetail.Data.Img.OsTypeModel.minCpu");
			osTypeModel.MinMemory = context.IntegerValue("InnerInstanceDetail.Data.Img.OsTypeModel.minMemory");
			osTypeModel.MaxCpu = context.IntegerValue("InnerInstanceDetail.Data.Img.OsTypeModel.maxCpu");
			osTypeModel.MaxMemory = context.IntegerValue("InnerInstanceDetail.Data.Img.OsTypeModel.maxMemory");
			osTypeModel.OsName = context.StringValue("InnerInstanceDetail.Data.Img.OsTypeModel.osName");
			osTypeModel.OsMemo = context.StringValue("InnerInstanceDetail.Data.Img.OsTypeModel.osMemo");
			osTypeModel.Type = context.StringValue("InnerInstanceDetail.Data.Img.OsTypeModel.type");

			InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_OsTypeModel.InnerInstanceDetail_Kind kind = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_OsTypeModel.InnerInstanceDetail_Kind();
			kind.Kind = context.StringValue("InnerInstanceDetail.Data.Img.OsTypeModel.Kind.kind");
			osTypeModel.Kind = kind;
			img.OsTypeModel = osTypeModel;

			InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_QuoteType quoteType = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_QuoteType();
			quoteType.QuoteType = context.StringValue("InnerInstanceDetail.Data.Img.QuoteType.quoteType");
			img.QuoteType = quoteType;

			List<InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_Tag2> img_tags1 = new List<InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_Tag2>();
			for (int i = 0; i < context.Length("InnerInstanceDetail.Data.Img.Tags.Length"); i++) {
				InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_Tag2 tag2 = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Img.InnerInstanceDetail_Tag2();
				tag2.Key = context.StringValue("InnerInstanceDetail.Data.Img.Tags["+ i +"].key");
				tag2._Value = context.StringValue("InnerInstanceDetail.Data.Img.Tags["+ i +"].value");

				img_tags1.Add(tag2);
			}
			img.Tags1 = img_tags1;
			data.Img = img;

			InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_StatusNote statusNote = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_StatusNote();
			statusNote.NoteCode = context.StringValue("InnerInstanceDetail.Data.StatusNote.noteCode");
			statusNote.NoteInfo = context.StringValue("InnerInstanceDetail.Data.StatusNote.noteInfo");
			data.StatusNote = statusNote;

			List<InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Group> data_groups = new List<InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Group>();
			for (int i = 0; i < context.Length("InnerInstanceDetail.Data.Groups.Length"); i++) {
				InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Group group = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Group();
				group.GroupNo = context.StringValue("InnerInstanceDetail.Data.Groups["+ i +"].groupNo");
				group.GroupName = context.StringValue("InnerInstanceDetail.Data.Groups["+ i +"].groupName");
				group.GroupDesc = context.StringValue("InnerInstanceDetail.Data.Groups["+ i +"].groupDesc");
				group.EcsCount = context.IntegerValue("InnerInstanceDetail.Data.Groups["+ i +"].ecsCount");
				group.VpcInstanceId = context.StringValue("InnerInstanceDetail.Data.Groups["+ i +"].vpcInstanceId");
				group.GmtCreated = context.StringValue("InnerInstanceDetail.Data.Groups["+ i +"].gmtCreated");
				group.GmtModified = context.StringValue("InnerInstanceDetail.Data.Groups["+ i +"].gmtModified");

				List<InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Group.InnerInstanceDetail_Tag> group_tags = new List<InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Group.InnerInstanceDetail_Tag>();
				for (int j = 0; j < context.Length("InnerInstanceDetail.Data.Groups["+ i +"].Tags.Length"); j++) {
					InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Group.InnerInstanceDetail_Tag tag = new InnerInstanceDetailResponse.InnerInstanceDetail_Data.InnerInstanceDetail_Group.InnerInstanceDetail_Tag();
					tag.Key = context.StringValue("InnerInstanceDetail.Data.Groups["+ i +"].Tags["+ j +"].key");
					tag._Value = context.StringValue("InnerInstanceDetail.Data.Groups["+ i +"].Tags["+ j +"].value");

					group_tags.Add(tag);
				}
				group.Tags = group_tags;

				data_groups.Add(group);
			}
			data.Groups = data_groups;
			innerInstanceDetailResponse.Data = data;
        
			return innerInstanceDetailResponse;
        }
    }
}
