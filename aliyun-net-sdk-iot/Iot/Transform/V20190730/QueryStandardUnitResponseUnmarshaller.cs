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
    public class QueryStandardUnitResponseUnmarshaller
    {
        public static QueryStandardUnitResponse Unmarshall(UnmarshallerContext context)
        {
			QueryStandardUnitResponse queryStandardUnitResponse = new QueryStandardUnitResponse();

			queryStandardUnitResponse.HttpResponse = context.HttpResponse;
			queryStandardUnitResponse.RequestId = context.StringValue("QueryStandardUnit.RequestId");
			queryStandardUnitResponse.Success = context.BooleanValue("QueryStandardUnit.Success");
			queryStandardUnitResponse.ErrorMessage = context.StringValue("QueryStandardUnit.ErrorMessage");
			queryStandardUnitResponse.Code = context.StringValue("QueryStandardUnit.Code");

			List<QueryStandardUnitResponse.QueryStandardUnit_UnifyUnitSpecsDTO> queryStandardUnitResponse_models = new List<QueryStandardUnitResponse.QueryStandardUnit_UnifyUnitSpecsDTO>();
			for (int i = 0; i < context.Length("QueryStandardUnit.Models.Length"); i++) {
				QueryStandardUnitResponse.QueryStandardUnit_UnifyUnitSpecsDTO unifyUnitSpecsDTO = new QueryStandardUnitResponse.QueryStandardUnit_UnifyUnitSpecsDTO();
				unifyUnitSpecsDTO.Name = context.StringValue("QueryStandardUnit.Models["+ i +"].Name");
				unifyUnitSpecsDTO.Symbol = context.StringValue("QueryStandardUnit.Models["+ i +"].Symbol");

				queryStandardUnitResponse_models.Add(unifyUnitSpecsDTO);
			}
			queryStandardUnitResponse.Models = queryStandardUnitResponse_models;
        
			return queryStandardUnitResponse;
        }
    }
}
