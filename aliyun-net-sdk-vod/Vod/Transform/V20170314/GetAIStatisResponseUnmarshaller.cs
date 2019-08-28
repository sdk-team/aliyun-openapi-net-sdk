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
using Aliyun.Acs.vod.Model.V20170314;

namespace Aliyun.Acs.vod.Transform.V20170314
{
    public class GetAIStatisResponseUnmarshaller
    {
        public static GetAIStatisResponse Unmarshall(UnmarshallerContext context)
        {
			GetAIStatisResponse getAIStatisResponse = new GetAIStatisResponse();

			getAIStatisResponse.HttpResponse = context.HttpResponse;
			getAIStatisResponse.RequestId = context.StringValue("GetAIStatis.RequestId");

			List<GetAIStatisResponse.GetAIStatis_AIStatis> getAIStatisResponse_aIStatisList = new List<GetAIStatisResponse.GetAIStatis_AIStatis>();
			for (int i = 0; i < context.Length("GetAIStatis.AIStatisList.Length"); i++) {
				GetAIStatisResponse.GetAIStatis_AIStatis aIStatis = new GetAIStatisResponse.GetAIStatis_AIStatis();
				aIStatis.StatTime = context.StringValue("GetAIStatis.AIStatisList["+ i +"].StatTime");
				aIStatis.StatTimeUTC = context.StringValue("GetAIStatis.AIStatisList["+ i +"].StatTimeUTC");
				aIStatis.Duration = context.LongValue("GetAIStatis.AIStatisList["+ i +"].Duration");

				getAIStatisResponse_aIStatisList.Add(aIStatis);
			}
			getAIStatisResponse.AIStatisList = getAIStatisResponse_aIStatisList;
        
			return getAIStatisResponse;
        }
    }
}
