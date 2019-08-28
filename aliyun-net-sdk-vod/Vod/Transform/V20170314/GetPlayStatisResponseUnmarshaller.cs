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
    public class GetPlayStatisResponseUnmarshaller
    {
        public static GetPlayStatisResponse Unmarshall(UnmarshallerContext context)
        {
			GetPlayStatisResponse getPlayStatisResponse = new GetPlayStatisResponse();

			getPlayStatisResponse.HttpResponse = context.HttpResponse;
			getPlayStatisResponse.RequestId = context.StringValue("GetPlayStatis.RequestId");

			List<GetPlayStatisResponse.GetPlayStatis_PlayStatisByPlatform> getPlayStatisResponse_playStatisByPlatformDOs = new List<GetPlayStatisResponse.GetPlayStatis_PlayStatisByPlatform>();
			for (int i = 0; i < context.Length("GetPlayStatis.PlayStatisByPlatformDOs.Length"); i++) {
				GetPlayStatisResponse.GetPlayStatis_PlayStatisByPlatform playStatisByPlatform = new GetPlayStatisResponse.GetPlayStatis_PlayStatisByPlatform();
				playStatisByPlatform.Platform = context.StringValue("GetPlayStatis.PlayStatisByPlatformDOs["+ i +"].Platform");

				List<GetPlayStatisResponse.GetPlayStatis_PlayStatisByPlatform.GetPlayStatis_PlayStatisDO> playStatisByPlatform_playStatisDOs = new List<GetPlayStatisResponse.GetPlayStatis_PlayStatisByPlatform.GetPlayStatis_PlayStatisDO>();
				for (int j = 0; j < context.Length("GetPlayStatis.PlayStatisByPlatformDOs["+ i +"].PlayStatisDOs.Length"); j++) {
					GetPlayStatisResponse.GetPlayStatis_PlayStatisByPlatform.GetPlayStatis_PlayStatisDO playStatisDO = new GetPlayStatisResponse.GetPlayStatis_PlayStatisByPlatform.GetPlayStatis_PlayStatisDO();
					playStatisDO.UserId = context.StringValue("GetPlayStatis.PlayStatisByPlatformDOs["+ i +"].PlayStatisDOs["+ j +"].UserId");
					playStatisDO.Platform = context.StringValue("GetPlayStatis.PlayStatisByPlatformDOs["+ i +"].PlayStatisDOs["+ j +"].Platform");
					playStatisDO.VisitView = context.LongValue("GetPlayStatis.PlayStatisByPlatformDOs["+ i +"].PlayStatisDOs["+ j +"].VisitView");
					playStatisDO.ViewTime = context.LongValue("GetPlayStatis.PlayStatisByPlatformDOs["+ i +"].PlayStatisDOs["+ j +"].ViewTime");
					playStatisDO.StatTime = context.StringValue("GetPlayStatis.PlayStatisByPlatformDOs["+ i +"].PlayStatisDOs["+ j +"].StatTime");

					playStatisByPlatform_playStatisDOs.Add(playStatisDO);
				}
				playStatisByPlatform.PlayStatisDOs = playStatisByPlatform_playStatisDOs;

				getPlayStatisResponse_playStatisByPlatformDOs.Add(playStatisByPlatform);
			}
			getPlayStatisResponse.PlayStatisByPlatformDOs = getPlayStatisResponse_playStatisByPlatformDOs;
        
			return getPlayStatisResponse;
        }
    }
}
