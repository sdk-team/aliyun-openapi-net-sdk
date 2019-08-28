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
    public class SubmitPreprocessJobsResponseUnmarshaller
    {
        public static SubmitPreprocessJobsResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitPreprocessJobsResponse submitPreprocessJobsResponse = new SubmitPreprocessJobsResponse();

			submitPreprocessJobsResponse.HttpResponse = context.HttpResponse;
			submitPreprocessJobsResponse.RequestId = context.StringValue("SubmitPreprocessJobs.RequestId");

			List<SubmitPreprocessJobsResponse.SubmitPreprocessJobs_TranscodeJob> submitPreprocessJobsResponse_transcodeJobs = new List<SubmitPreprocessJobsResponse.SubmitPreprocessJobs_TranscodeJob>();
			for (int i = 0; i < context.Length("SubmitPreprocessJobs.TranscodeJobs.Length"); i++) {
				SubmitPreprocessJobsResponse.SubmitPreprocessJobs_TranscodeJob transcodeJob = new SubmitPreprocessJobsResponse.SubmitPreprocessJobs_TranscodeJob();
				transcodeJob.JobId = context.StringValue("SubmitPreprocessJobs.TranscodeJobs["+ i +"].JobId");

				submitPreprocessJobsResponse_transcodeJobs.Add(transcodeJob);
			}
			submitPreprocessJobsResponse.TranscodeJobs = submitPreprocessJobsResponse_transcodeJobs;
        
			return submitPreprocessJobsResponse;
        }
    }
}
