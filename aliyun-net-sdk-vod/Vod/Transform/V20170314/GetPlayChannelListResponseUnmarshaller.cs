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
    public class GetPlayChannelListResponseUnmarshaller
    {
        public static GetPlayChannelListResponse Unmarshall(UnmarshallerContext context)
        {
			GetPlayChannelListResponse getPlayChannelListResponse = new GetPlayChannelListResponse();

			getPlayChannelListResponse.HttpResponse = context.HttpResponse;
			getPlayChannelListResponse.RequestId = context.StringValue("GetPlayChannelList.RequestId");
			getPlayChannelListResponse.Total = context.IntegerValue("GetPlayChannelList.Total");

			List<GetPlayChannelListResponse.GetPlayChannelList_PlayKey> getPlayChannelListResponse_playKeyList = new List<GetPlayChannelListResponse.GetPlayChannelList_PlayKey>();
			for (int i = 0; i < context.Length("GetPlayChannelList.PlayKeyList.Length"); i++) {
				GetPlayChannelListResponse.GetPlayChannelList_PlayKey playKey = new GetPlayChannelListResponse.GetPlayChannelList_PlayKey();
				playKey.Channel = context.StringValue("GetPlayChannelList.PlayKeyList["+ i +"].Channel");
				playKey.CreateTime = context.StringValue("GetPlayChannelList.PlayKeyList["+ i +"].CreateTime");
				playKey.ModifyTime = context.StringValue("GetPlayChannelList.PlayKeyList["+ i +"].ModifyTime");
				playKey.SignVersion = context.StringValue("GetPlayChannelList.PlayKeyList["+ i +"].SignVersion");
				playKey.Description = context.StringValue("GetPlayChannelList.PlayKeyList["+ i +"].Description");
				playKey.ClientVersion = context.StringValue("GetPlayChannelList.PlayKeyList["+ i +"].ClientVersion");
				playKey.Status = context.StringValue("GetPlayChannelList.PlayKeyList["+ i +"].Status");
				playKey.Source = context.StringValue("GetPlayChannelList.PlayKeyList["+ i +"].Source");

				getPlayChannelListResponse_playKeyList.Add(playKey);
			}
			getPlayChannelListResponse.PlayKeyList = getPlayChannelListResponse_playKeyList;
        
			return getPlayChannelListResponse;
        }
    }
}
