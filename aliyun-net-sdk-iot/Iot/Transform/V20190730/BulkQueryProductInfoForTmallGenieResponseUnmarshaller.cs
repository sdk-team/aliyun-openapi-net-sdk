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

			List<BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_ProductInfo> bulkQueryProductInfoForTmallGenieResponse_list = new List<BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_ProductInfo>();
			for (int i = 0; i < context.Length("BulkQueryProductInfoForTmallGenie.List.Length"); i++) {
				BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_ProductInfo productInfo = new BulkQueryProductInfoForTmallGenieResponse.BulkQueryProductInfoForTmallGenie_ProductInfo();
				productInfo.GmtCreate = context.StringValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].GmtCreate");
				productInfo.DataFormat = context.IntegerValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].DataFormat");
				productInfo.Description = context.StringValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].Description");
				productInfo.DeviceCount = context.IntegerValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].DeviceCount");
				productInfo.NetType = context.IntegerValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].NetType");
				productInfo.NodeType = context.IntegerValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].NodeType");
				productInfo.ProductKey = context.StringValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].ProductKey");
				productInfo.ProductName = context.StringValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].ProductName");
				productInfo.ProductModel = context.StringValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].ProductModel");
				productInfo.ProductSecret = context.StringValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].ProductSecret");
				productInfo.ProductStatus = context.StringValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].ProductStatus");
				productInfo.ScriptId = context.LongValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].ScriptId");
				productInfo.ScriptDraftCode = context.StringValue("BulkQueryProductInfoForTmallGenie.List["+ i +"].ScriptDraftCode");

				bulkQueryProductInfoForTmallGenieResponse_list.Add(productInfo);
			}
			bulkQueryProductInfoForTmallGenieResponse.List = bulkQueryProductInfoForTmallGenieResponse_list;
        
			return bulkQueryProductInfoForTmallGenieResponse;
        }
    }
}
