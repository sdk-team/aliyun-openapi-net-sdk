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
        public static GetMigrateStrategyResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetMigrateStrategyResultResponse getMigrateStrategyResultResponse = new GetMigrateStrategyResultResponse();

			getMigrateStrategyResultResponse.HttpResponse = context.HttpResponse;
			getMigrateStrategyResultResponse.Success = context.BooleanValue("GetMigrateStrategyResult.Success");
			getMigrateStrategyResultResponse.Code = context.StringValue("GetMigrateStrategyResult.Code");
			getMigrateStrategyResultResponse.Message = context.StringValue("GetMigrateStrategyResult.Message");
			getMigrateStrategyResultResponse.MessageCN = context.StringValue("GetMigrateStrategyResult.MessageCN");
			getMigrateStrategyResultResponse.RequestId = context.StringValue("GetMigrateStrategyResult.RequestId");

			GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data data = new GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data();
			data.PageSize = context.IntegerValue("GetMigrateStrategyResult.Data.PageSize");
			data.CurrentPage = context.IntegerValue("GetMigrateStrategyResult.Data.CurrentPage");
			data.TotalItem = context.IntegerValue("GetMigrateStrategyResult.Data.TotalItem");

			List<GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem> data_dataList = new List<GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem>();
			for (int i = 0; i < context.Length("GetMigrateStrategyResult.Data.DataList.Length"); i++) {
				GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem dataListItem = new GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem();
				dataListItem.Id = context.LongValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Id");
				dataListItem.CreateTime = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].CreateTime");
				dataListItem.ModifiedTime = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].ModifiedTime");
				dataListItem.RecordVersion = context.IntegerValue("GetMigrateStrategyResult.Data.DataList["+ i +"].RecordVersion");
				dataListItem.Env = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Env");
				dataListItem.Product = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Product");
				dataListItem.Version = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Version");
				dataListItem.Api = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Api");
				dataListItem.StrategyName = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].StrategyName");
				dataListItem.ParentName = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].ParentName");
				dataListItem.Type = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Type");
				dataListItem.FlowSpecial = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].FlowSpecial");
				dataListItem.DataItem = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].DataItem");
				dataListItem.Status = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Status");

				GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem.GetMigrateStrategyResult_Modifier modifier = new GetMigrateStrategyResultResponse.GetMigrateStrategyResult_Data.GetMigrateStrategyResult_DataListItem.GetMigrateStrategyResult_Modifier();
				modifier.Id = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Modifier.Id");
				modifier.Name = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Modifier.Name");
				modifier.BucId = context.StringValue("GetMigrateStrategyResult.Data.DataList["+ i +"].Modifier.BucId");
				dataListItem.Modifier = modifier;

				data_dataList.Add(dataListItem);
			}
			data.DataList = data_dataList;
			getMigrateStrategyResultResponse.Data = data;
        
			return getMigrateStrategyResultResponse;
        }
    }
}
