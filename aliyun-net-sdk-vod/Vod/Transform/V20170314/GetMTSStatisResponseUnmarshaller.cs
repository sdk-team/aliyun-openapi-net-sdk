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
    public class GetMTSStatisResponseUnmarshaller
    {
        public static GetMTSStatisResponse Unmarshall(UnmarshallerContext context)
        {
			GetMTSStatisResponse getMTSStatisResponse = new GetMTSStatisResponse();

			getMTSStatisResponse.HttpResponse = context.HttpResponse;
			getMTSStatisResponse.RequestId = context.StringValue("GetMTSStatis.RequestId");

			List<GetMTSStatisResponse.GetMTSStatis_MTSStatisBySpec> getMTSStatisResponse_mTSStatisBySpecList = new List<GetMTSStatisResponse.GetMTSStatis_MTSStatisBySpec>();
			for (int i = 0; i < context.Length("GetMTSStatis.MTSStatisBySpecList.Length"); i++) {
				GetMTSStatisResponse.GetMTSStatis_MTSStatisBySpec mTSStatisBySpec = new GetMTSStatisResponse.GetMTSStatis_MTSStatisBySpec();
				mTSStatisBySpec.Specification = context.StringValue("GetMTSStatis.MTSStatisBySpecList["+ i +"].Specification");

				List<GetMTSStatisResponse.GetMTSStatis_MTSStatisBySpec.GetMTSStatis_MTSStatisDO> mTSStatisBySpec_mTSStatisDOList = new List<GetMTSStatisResponse.GetMTSStatis_MTSStatisBySpec.GetMTSStatis_MTSStatisDO>();
				for (int j = 0; j < context.Length("GetMTSStatis.MTSStatisBySpecList["+ i +"].MTSStatisDOList.Length"); j++) {
					GetMTSStatisResponse.GetMTSStatis_MTSStatisBySpec.GetMTSStatis_MTSStatisDO mTSStatisDO = new GetMTSStatisResponse.GetMTSStatis_MTSStatisBySpec.GetMTSStatis_MTSStatisDO();
					mTSStatisDO.UserId = context.StringValue("GetMTSStatis.MTSStatisBySpecList["+ i +"].MTSStatisDOList["+ j +"].UserId");
					mTSStatisDO.Specification = context.StringValue("GetMTSStatis.MTSStatisBySpecList["+ i +"].MTSStatisDOList["+ j +"].Specification");
					mTSStatisDO.Duration = context.LongValue("GetMTSStatis.MTSStatisBySpecList["+ i +"].MTSStatisDOList["+ j +"].Duration");
					mTSStatisDO.StatTime = context.StringValue("GetMTSStatis.MTSStatisBySpecList["+ i +"].MTSStatisDOList["+ j +"].StatTime");
					mTSStatisDO.StatTimeUTC = context.StringValue("GetMTSStatis.MTSStatisBySpecList["+ i +"].MTSStatisDOList["+ j +"].StatTimeUTC");

					mTSStatisBySpec_mTSStatisDOList.Add(mTSStatisDO);
				}
				mTSStatisBySpec.MTSStatisDOList = mTSStatisBySpec_mTSStatisDOList;

				getMTSStatisResponse_mTSStatisBySpecList.Add(mTSStatisBySpec);
			}
			getMTSStatisResponse.MTSStatisBySpecList = getMTSStatisResponse_mTSStatisBySpecList;
        
			return getMTSStatisResponse;
        }
    }
}
