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
using Aliyun.Acs.Ft.Model.V20180713;

namespace Aliyun.Acs.Ft.Transform.V20180713
{
    public class GetMigrateStrategyResultResponseUnmarshaller
    {
        public static GetMigrateStrategyResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMigrateStrategyResultResponse getMigrateStrategyResultResponse = new GetMigrateStrategyResultResponse();

			getMigrateStrategyResultResponse.HttpResponse = _ctx.HttpResponse;
			getMigrateStrategyResultResponse.Success = _ctx.BooleanValue("GetMigrateStrategyResult.Success");
			getMigrateStrategyResultResponse.Code = _ctx.StringValue("GetMigrateStrategyResult.Code");
			getMigrateStrategyResultResponse.Message = _ctx.StringValue("GetMigrateStrategyResult.Message");
			getMigrateStrategyResultResponse.MessageCN = _ctx.StringValue("GetMigrateStrategyResult.MessageCN");
			getMigrateStrategyResultResponse.RequestId = _ctx.StringValue("GetMigrateStrategyResult.RequestId");
			getMigrateStrategyResultResponse.NullValue = _ctx.StringValue("GetMigrateStrategyResult.NullValue");

			GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data data = new GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data();
			data.PageSize = _ctx.IntegerValue("GetMigrateStrategyResult.Data.PageSize");
			data.CurrentPage = _ctx.IntegerValue("GetMigrateStrategyResult.Data.CurrentPage");
			data.TotalItem = _ctx.IntegerValue("GetMigrateStrategyResult.Data.TotalItem");
			data.TestNull = _ctx.StringValue("GetMigrateStrategyResult.Data.TestNull");

			List<GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem> data_dataList = new List<GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem>();
			for (int i = 0; i < _ctx.Length("GetMigrateStrategyResult.Data.DataList.Length"); i++) {
				GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem dataListItem = new GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem();
				dataListItem.Id = _ctx.LongValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Id");
				dataListItem.CreateTime = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].CreateTime");
				dataListItem.ModifiedTime = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].ModifiedTime");
				dataListItem.RecordVersion = _ctx.IntegerValue("GetMigrateStrategyResult.Data.DataList["+ i +"].RecordVersion");
				dataListItem.Env = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Env");
				dataListItem.Product = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Product");
				dataListItem.Version = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Version");
				dataListItem.Api = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Api");
				dataListItem.StrategyName = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].StrategyName");
				dataListItem.ParentName = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].ParentName");
				dataListItem.Type = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Type");
				dataListItem.FlowSpecial = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].FlowSpecial");
				dataListItem.DataItem = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].DataItem");
				dataListItem.Status = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Status");

				GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem.GetMigrateStrategyResult_Modifier modifier = new GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem.GetMigrateStrategyResult_Modifier();
				modifier.Id = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Modifier.Id");
				modifier.Name = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Modifier.Name");
				modifier.BucId = _ctx.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Modifier.BucId");
				dataListItem.Modifier = modifier;

				data_dataList.Add(dataListItem);
			}
			data.DataList = data_dataList;
			getMigrateStrategyResultResponse.Data = data;
        
			return getMigrateStrategyResultResponse;
        }
    }
}
