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
    public class SearchProductForTmallGenieResponseUnmarshaller
    {
        public static SearchProductForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			SearchProductForTmallGenieResponse searchProductForTmallGenieResponse = new SearchProductForTmallGenieResponse();

			searchProductForTmallGenieResponse.HttpResponse = context.HttpResponse;
			searchProductForTmallGenieResponse.RequestId = context.StringValue("SearchProductForTmallGenie.RequestId");
			searchProductForTmallGenieResponse.Success = context.BooleanValue("SearchProductForTmallGenie.Success");
			searchProductForTmallGenieResponse.ErrorMessage = context.StringValue("SearchProductForTmallGenie.ErrorMessage");

			SearchProductForTmallGenieResponse.SearchProductForTmallGenie_Data data = new SearchProductForTmallGenieResponse.SearchProductForTmallGenie_Data();
			data.Page = context.IntegerValue("SearchProductForTmallGenie.Data.Page");
			data.PageCount = context.IntegerValue("SearchProductForTmallGenie.Data.PageCount");
			data.PageSize = context.IntegerValue("SearchProductForTmallGenie.Data.PageSize");
			data.Total = context.IntegerValue("SearchProductForTmallGenie.Data.Total");

			List<SearchProductForTmallGenieResponse.SearchProductForTmallGenie_Data.SearchProductForTmallGenie_ProductInfo> data_list = new List<SearchProductForTmallGenieResponse.SearchProductForTmallGenie_Data.SearchProductForTmallGenie_ProductInfo>();
			for (int i = 0; i < context.Length("SearchProductForTmallGenie.Data.List.Length"); i++) {
				SearchProductForTmallGenieResponse.SearchProductForTmallGenie_Data.SearchProductForTmallGenie_ProductInfo productInfo = new SearchProductForTmallGenieResponse.SearchProductForTmallGenie_Data.SearchProductForTmallGenie_ProductInfo();
				productInfo.GmtCreate = context.StringValue("SearchProductForTmallGenie.Data.List["+ i +"].GmtCreate");
				productInfo.DataFormat = context.IntegerValue("SearchProductForTmallGenie.Data.List["+ i +"].DataFormat");
				productInfo.Description = context.StringValue("SearchProductForTmallGenie.Data.List["+ i +"].Description");
				productInfo.DeviceCount = context.IntegerValue("SearchProductForTmallGenie.Data.List["+ i +"].DeviceCount");
				productInfo.NodeType = context.IntegerValue("SearchProductForTmallGenie.Data.List["+ i +"].NodeType");
				productInfo.ProductKey = context.StringValue("SearchProductForTmallGenie.Data.List["+ i +"].ProductKey");
				productInfo.ProductName = context.StringValue("SearchProductForTmallGenie.Data.List["+ i +"].ProductName");
				productInfo.ScriptId = context.LongValue("SearchProductForTmallGenie.Data.List["+ i +"].ScriptId");
				productInfo.ScriptDraftCode = context.StringValue("SearchProductForTmallGenie.Data.List["+ i +"].ScriptDraftCode");

				data_list.Add(productInfo);
			}
			data.List = data_list;
			searchProductForTmallGenieResponse.Data = data;
        
			return searchProductForTmallGenieResponse;
        }
    }
}
