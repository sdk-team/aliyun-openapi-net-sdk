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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetAnalyzeCommodityDataResponseUnmarshaller
    {
        public static GetAnalyzeCommodityDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetAnalyzeCommodityDataResponse getAnalyzeCommodityDataResponse = new GetAnalyzeCommodityDataResponse();

			getAnalyzeCommodityDataResponse.HttpResponse = context.HttpResponse;
			getAnalyzeCommodityDataResponse.PageIndex = context.IntegerValue("GetAnalyzeCommodityData.PageIndex");
			getAnalyzeCommodityDataResponse.Total = context.IntegerValue("GetAnalyzeCommodityData.Total");
			getAnalyzeCommodityDataResponse.PageSize = context.IntegerValue("GetAnalyzeCommodityData.PageSize");

			List<GetAnalyzeCommodityDataResponse.GetAnalyzeCommodityData_AnalyzeCommodityItem> getAnalyzeCommodityDataResponse_analyzeCommodityItems = new List<GetAnalyzeCommodityDataResponse.GetAnalyzeCommodityData_AnalyzeCommodityItem>();
			for (int i = 0; i < context.Length("GetAnalyzeCommodityData.AnalyzeCommodityItems.Length"); i++) {
				GetAnalyzeCommodityDataResponse.GetAnalyzeCommodityData_AnalyzeCommodityItem analyzeCommodityItem = new GetAnalyzeCommodityDataResponse.GetAnalyzeCommodityData_AnalyzeCommodityItem();
				analyzeCommodityItem.LocationNames = context.StringValue("GetAnalyzeCommodityData.AnalyzeCommodityItems["+ i +"].LocationNames");
				analyzeCommodityItem.SupportCount = context.LongValue("GetAnalyzeCommodityData.AnalyzeCommodityItems["+ i +"].SupportCount");
				analyzeCommodityItem.LocationIds = context.StringValue("GetAnalyzeCommodityData.AnalyzeCommodityItems["+ i +"].LocationIds");
				analyzeCommodityItem.ItemCount = context.LongValue("GetAnalyzeCommodityData.AnalyzeCommodityItems["+ i +"].ItemCount");

				getAnalyzeCommodityDataResponse_analyzeCommodityItems.Add(analyzeCommodityItem);
			}
			getAnalyzeCommodityDataResponse.AnalyzeCommodityItems = getAnalyzeCommodityDataResponse_analyzeCommodityItems;
        
			return getAnalyzeCommodityDataResponse;
        }
    }
}
