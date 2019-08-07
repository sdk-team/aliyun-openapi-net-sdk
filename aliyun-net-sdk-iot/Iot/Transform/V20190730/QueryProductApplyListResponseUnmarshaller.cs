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
    public class QueryProductApplyListResponseUnmarshaller
    {
        public static QueryProductApplyListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryProductApplyListResponse queryProductApplyListResponse = new QueryProductApplyListResponse();

			queryProductApplyListResponse.HttpResponse = context.HttpResponse;
			queryProductApplyListResponse.RequestId = context.StringValue("QueryProductApplyList.RequestId");
			queryProductApplyListResponse.Success = context.BooleanValue("QueryProductApplyList.Success");
			queryProductApplyListResponse.ErrorMessage = context.StringValue("QueryProductApplyList.ErrorMessage");
			queryProductApplyListResponse.Code = context.StringValue("QueryProductApplyList.Code");
			queryProductApplyListResponse.Total = context.StringValue("QueryProductApplyList.Total");

			List<QueryProductApplyListResponse.QueryProductApplyList_ApplyInfoDTO> queryProductApplyListResponse_data = new List<QueryProductApplyListResponse.QueryProductApplyList_ApplyInfoDTO>();
			for (int i = 0; i < context.Length("QueryProductApplyList.Data.Length"); i++) {
				QueryProductApplyListResponse.QueryProductApplyList_ApplyInfoDTO applyInfoDTO = new QueryProductApplyListResponse.QueryProductApplyList_ApplyInfoDTO();
				applyInfoDTO.ApplyId = context.LongValue("QueryProductApplyList.Data["+ i +"].ApplyId");
				applyInfoDTO.ProductKey = context.StringValue("QueryProductApplyList.Data["+ i +"].ProductKey");
				applyInfoDTO.ApplyStatus = context.StringValue("QueryProductApplyList.Data["+ i +"].ApplyStatus");
				applyInfoDTO.ApplyCount = context.StringValue("QueryProductApplyList.Data["+ i +"].ApplyCount");
				applyInfoDTO.SuccessCount = context.StringValue("QueryProductApplyList.Data["+ i +"].SuccessCount");

				queryProductApplyListResponse_data.Add(applyInfoDTO);
			}
			queryProductApplyListResponse.Data = queryProductApplyListResponse_data;
        
			return queryProductApplyListResponse;
        }
    }
}
