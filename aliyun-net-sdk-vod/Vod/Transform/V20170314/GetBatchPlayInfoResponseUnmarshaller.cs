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
    public class GetBatchPlayInfoResponseUnmarshaller
    {
        public static GetBatchPlayInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetBatchPlayInfoResponse getBatchPlayInfoResponse = new GetBatchPlayInfoResponse();

			getBatchPlayInfoResponse.HttpResponse = context.HttpResponse;
			getBatchPlayInfoResponse.RequestId = context.StringValue("GetBatchPlayInfo.RequestId");

			List<GetBatchPlayInfoResponse.GetBatchPlayInfo_BatchPlayInfo> getBatchPlayInfoResponse_batchPlayInfoList = new List<GetBatchPlayInfoResponse.GetBatchPlayInfo_BatchPlayInfo>();
			for (int i = 0; i < context.Length("GetBatchPlayInfo.BatchPlayInfoList.Length"); i++) {
				GetBatchPlayInfoResponse.GetBatchPlayInfo_BatchPlayInfo batchPlayInfo = new GetBatchPlayInfoResponse.GetBatchPlayInfo_BatchPlayInfo();
				batchPlayInfo.VideoId = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].VideoId");
				batchPlayInfo.ErrorCode = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].ErrorCode");
				batchPlayInfo.ErrorMessage = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].ErrorMessage");
				batchPlayInfo.HttpStatusCode = context.LongValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].HttpStatusCode");

				List<GetBatchPlayInfoResponse.GetBatchPlayInfo_BatchPlayInfo.GetBatchPlayInfo_PlayInfo> batchPlayInfo_playInfoList = new List<GetBatchPlayInfoResponse.GetBatchPlayInfo_BatchPlayInfo.GetBatchPlayInfo_PlayInfo>();
				for (int j = 0; j < context.Length("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList.Length"); j++) {
					GetBatchPlayInfoResponse.GetBatchPlayInfo_BatchPlayInfo.GetBatchPlayInfo_PlayInfo playInfo = new GetBatchPlayInfoResponse.GetBatchPlayInfo_BatchPlayInfo.GetBatchPlayInfo_PlayInfo();
					playInfo.Width = context.LongValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Width");
					playInfo.Height = context.LongValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Height");
					playInfo.Size = context.LongValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Size");
					playInfo.PlayURL = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].PlayURL");
					playInfo.Bitrate = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Bitrate");
					playInfo.Definition = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Definition");
					playInfo.Duration = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Duration");
					playInfo.Format = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Format");
					playInfo.Fps = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Fps");
					playInfo.Encrypt = context.LongValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Encrypt");
					playInfo.Plaintext = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Plaintext");
					playInfo.Complexity = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Complexity");
					playInfo.StreamType = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].StreamType");
					playInfo.Rand = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].Rand");
					playInfo.JobId = context.StringValue("GetBatchPlayInfo.BatchPlayInfoList["+ i +"].PlayInfoList["+ j +"].JobId");

					batchPlayInfo_playInfoList.Add(playInfo);
				}
				batchPlayInfo.PlayInfoList = batchPlayInfo_playInfoList;

				getBatchPlayInfoResponse_batchPlayInfoList.Add(batchPlayInfo);
			}
			getBatchPlayInfoResponse.BatchPlayInfoList = getBatchPlayInfoResponse_batchPlayInfoList;
        
			return getBatchPlayInfoResponse;
        }
    }
}
