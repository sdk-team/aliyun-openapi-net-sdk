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
using Aliyun.Acs.Iot.Model.V20190730;

namespace Aliyun.Acs.Iot.Transform.V20190730
{
    public class BulkQueryProductInfoForTmallGenieResponseUnmarshaller
    {
        public static BulkQueryProductInfoForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			BulkQueryProductInfoForTmallGenieResponse bulkQueryProductInfoForTmallGenieResponse = new BulkQueryProductInfoForTmallGenieResponse();

			bulkQueryProductInfoForTmallGenieResponse.HttpResponse = context.HttpResponse;
			bulkQueryProductInfoForTmallGenieResponse.RequestId = context.StringValue("BulkQueryProductInfoForTmallGenie.RequestId");
			bulkQueryProductInfoForTmallGenieResponse.Success = context.BooleanValue("BulkQueryProductInfoForTmallGenie.Success");
			bulkQueryProductInfoForTmallGenieResponse.ErrorMessage = context.StringValue("BulkQueryProductInfoForTmallGenie.ErrorMessage");

			BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_Data data = new BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_Data();
			data.Page = context.IntegerValue("BulkQueryProductInfoForTmallGenie.Data.Page");
			data.PageCount = context.IntegerValue("BulkQueryProductInfoForTmallGenie.Data.PageCount");
			data.PageSize = context.IntegerValue("BulkQueryProductInfoForTmallGenie.Data.PageSize");
			data.Total = context.IntegerValue("BulkQueryProductInfoForTmallGenie.Data.Total");

			List<BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_Data.BulkQueryProductInfoForTmallGenie_ProductInfo> data_list = new List<BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_Data.BulkQueryProductInfoForTmallGenie_ProductInfo>();
			for (int i = 0; i < context.Length("BulkQueryProductInfoForTmallGenie.Data.List.Length"); i++) {
				BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_Data.BulkQueryProductInfoForTmallGenie_ProductInfo productInfo = new BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_Data.BulkQueryProductInfoForTmallGenie_ProductInfo();
				productInfo.GmtCreate = context.StringValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].GmtCreate");
				productInfo.DataFormat = context.IntegerValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].DataFormat");
				productInfo.Description = context.StringValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].Description");
				productInfo.DeviceCount = context.IntegerValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].DeviceCount");
				productInfo.NodeType = context.IntegerValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].NodeType");
				productInfo.ProductKey = context.StringValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].ProductKey");
				productInfo.ProductName = context.StringValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].ProductName");
				productInfo.ScriptId = context.LongValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].ScriptId");
				productInfo.ScriptDraftCode = context.StringValue("BulkQueryProductInfoForTmallGenie.Data.List["+ i +"].ScriptDraftCode");

				data_list.Add(productInfo);
			}
			data.List = data_list;
			bulkQueryProductInfoForTmallGenieResponse.Data = data;
        
			return bulkQueryProductInfoForTmallGenieResponse;
        }
    }
}
