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
    public class GetVideoDNAResultResponseUnmarshaller
    {
        public static GetVideoDNAResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetVideoDNAResultResponse getVideoDNAResultResponse = new GetVideoDNAResultResponse();

			getVideoDNAResultResponse.HttpResponse = context.HttpResponse;
			getVideoDNAResultResponse.RequestId = context.StringValue("GetVideoDNAResult.RequestId");

			GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult aIVideoDNAResult = new GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult();

			List<GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem> aIVideoDNAResult_fpShots = new List<GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem>();
			for (int i = 0; i < context.Length("GetVideoDNAResult.AIVideoDNAResult.FpShots.Length"); i++) {
				GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem fpShotsItem = new GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem();
				fpShotsItem.PrimaryKey = context.StringValue("GetVideoDNAResult.AIVideoDNAResult.FpShots["+ i +"].PrimaryKey");
				fpShotsItem.Similarity = context.StringValue("GetVideoDNAResult.AIVideoDNAResult.FpShots["+ i +"].Similarity");

				List<GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem.GetVideoDNAResult_FpShotSlicesItem> fpShotsItem_fpShotSlices = new List<GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem.GetVideoDNAResult_FpShotSlicesItem>();
				for (int j = 0; j < context.Length("GetVideoDNAResult.AIVideoDNAResult.FpShots["+ i +"].FpShotSlices.Length"); j++) {
					GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem.GetVideoDNAResult_FpShotSlicesItem fpShotSlicesItem = new GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem.GetVideoDNAResult_FpShotSlicesItem();

					GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem.GetVideoDNAResult_FpShotSlicesItem.GetVideoDNAResult_Input input = new GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem.GetVideoDNAResult_FpShotSlicesItem.GetVideoDNAResult_Input();
					input.Start = context.StringValue("GetVideoDNAResult.AIVideoDNAResult.FpShots["+ i +"].FpShotSlices["+ j +"].Input.Start");
					input.Duration = context.StringValue("GetVideoDNAResult.AIVideoDNAResult.FpShots["+ i +"].FpShotSlices["+ j +"].Input.Duration");
					fpShotSlicesItem.Input = input;

					GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem.GetVideoDNAResult_FpShotSlicesItem.GetVideoDNAResult_Duplication duplication = new GetVideoDNAResultResponse.GetVideoDNAResult_AIVideoDNAResult.GetVideoDNAResult_FpShotsItem.GetVideoDNAResult_FpShotSlicesItem.GetVideoDNAResult_Duplication();
					duplication.Start = context.StringValue("GetVideoDNAResult.AIVideoDNAResult.FpShots["+ i +"].FpShotSlices["+ j +"].Duplication.Start");
					duplication.Duration = context.StringValue("GetVideoDNAResult.AIVideoDNAResult.FpShots["+ i +"].FpShotSlices["+ j +"].Duplication.Duration");
					fpShotSlicesItem.Duplication = duplication;

					fpShotsItem_fpShotSlices.Add(fpShotSlicesItem);
				}
				fpShotsItem.FpShotSlices = fpShotsItem_fpShotSlices;

				aIVideoDNAResult_fpShots.Add(fpShotsItem);
			}
			aIVideoDNAResult.FpShots = aIVideoDNAResult_fpShots;
			getVideoDNAResultResponse.AIVideoDNAResult = aIVideoDNAResult;
        
			return getVideoDNAResultResponse;
        }
    }
}
