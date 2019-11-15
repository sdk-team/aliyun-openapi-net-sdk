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
    public class InnerImageDetailResponseUnmarshaller
    {
        public static InnerImageDetailResponse Unmarshall(UnmarshallerContext context)
        {
			InnerImageDetailResponse innerImageDetailResponse = new InnerImageDetailResponse();

			innerImageDetailResponse.HttpResponse = context.HttpResponse;
			innerImageDetailResponse.RequestId = context.StringValue("InnerImageDetail.RequestId");

			InnerImageDetailResponse.InnerImageDetail_ErrorCode errorCode = new InnerImageDetailResponse.InnerImageDetail_ErrorCode();
			errorCode.Code = context.StringValue("InnerImageDetail.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerImageDetail.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerImageDetail.ErrorCode.isSuccess");
			innerImageDetailResponse.ErrorCode = errorCode;

			InnerImageDetailResponse.InnerImageDetail_Data data = new InnerImageDetailResponse.InnerImageDetail_Data();
			data.Name = context.StringValue("InnerImageDetail.Data.name");
			data.SrcImageId = context.LongValue("InnerImageDetail.Data.srcImageId");
			data.ImageId = context.StringValue("InnerImageDetail.Data.imageId");
			data.GmtCreated = context.StringValue("InnerImageDetail.Data.gmtCreated");
			data.Id = context.LongValue("InnerImageDetail.Data.id");
			data.Bid = context.StringValue("InnerImageDetail.Data.bid");
			data.SupportIoOptimizedInstance = context.BooleanValue("InnerImageDetail.Data.supportIoOptimizedInstance");
			data.Remark = context.StringValue("InnerImageDetail.Data.remark");
			data.Visibility = context.StringValue("InnerImageDetail.Data.visibility");
			data.ImportOSSObject = context.StringValue("InnerImageDetail.Data.importOSSObject");
			data.GmtModified = context.StringValue("InnerImageDetail.Data.gmtModified");
			data.Progress = context.StringValue("InnerImageDetail.Data.progress");
			data.Version = context.StringValue("InnerImageDetail.Data.version");
			data.ImageProductCode = context.StringValue("InnerImageDetail.Data.imageProductCode");
			data.AliUid = context.LongValue("InnerImageDetail.Data.aliUid");
			data.GmtRelease = context.StringValue("InnerImageDetail.Data.gmtRelease");
			data.ImageCategory = context.StringValue("InnerImageDetail.Data.imageCategory");
			data.DisplayName = context.StringValue("InnerImageDetail.Data.displayName");
			data.Owner = context.StringValue("InnerImageDetail.Data.owner");
			data.Status = context.StringValue("InnerImageDetail.Data.status");
			data.ImportOSSBucket = context.StringValue("InnerImageDetail.Data.importOSSBucket");
			data.RegionNo = context.StringValue("InnerImageDetail.Data.regionNo");
			data.Format = context.StringValue("InnerImageDetail.Data.format");
			data.ImageSize = context.IntegerValue("InnerImageDetail.Data.imageSize");
			data.SnapshotNo = context.StringValue("InnerImageDetail.Data.snapshotNo");

			InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_OsTypeModel osTypeModel = new InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_OsTypeModel();
			osTypeModel.Platform = context.StringValue("InnerImageDetail.Data.OsTypeModel.platform");
			osTypeModel.Id = context.LongValue("InnerImageDetail.Data.OsTypeModel.id");
			osTypeModel.OsBit = context.IntegerValue("InnerImageDetail.Data.OsTypeModel.osBit");
			osTypeModel.MinCpu = context.IntegerValue("InnerImageDetail.Data.OsTypeModel.minCpu");
			osTypeModel.MinMemory = context.IntegerValue("InnerImageDetail.Data.OsTypeModel.minMemory");
			osTypeModel.MaxCpu = context.IntegerValue("InnerImageDetail.Data.OsTypeModel.maxCpu");
			osTypeModel.MaxMemory = context.IntegerValue("InnerImageDetail.Data.OsTypeModel.maxMemory");
			osTypeModel.OsName = context.StringValue("InnerImageDetail.Data.OsTypeModel.osName");
			osTypeModel.OsMemo = context.StringValue("InnerImageDetail.Data.OsTypeModel.osMemo");
			osTypeModel.Type = context.StringValue("InnerImageDetail.Data.OsTypeModel.type");

			InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_OsTypeModel.InnerImageDetail_Kind kind = new InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_OsTypeModel.InnerImageDetail_Kind();
			kind.Kind = context.StringValue("InnerImageDetail.Data.OsTypeModel.Kind.kind");
			osTypeModel.Kind = kind;
			data.OsTypeModel = osTypeModel;

			InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_QuoteType quoteType = new InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_QuoteType();
			quoteType.QuoteType = context.StringValue("InnerImageDetail.Data.QuoteType.quoteType");
			data.QuoteType = quoteType;

			List<InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_Tag> data_tags = new List<InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_Tag>();
			for (int i = 0; i < context.Length("InnerImageDetail.Data.Tags.Length"); i++) {
				InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_Tag tag = new InnerImageDetailResponse.InnerImageDetail_Data.InnerImageDetail_Tag();
				tag.Key = context.StringValue("InnerImageDetail.Data.Tags["+ i +"].key");
				tag._Value = context.StringValue("InnerImageDetail.Data.Tags["+ i +"].value");

				data_tags.Add(tag);
			}
			data.Tags = data_tags;
			innerImageDetailResponse.Data = data;
        
			return innerImageDetailResponse;
        }
    }
}
