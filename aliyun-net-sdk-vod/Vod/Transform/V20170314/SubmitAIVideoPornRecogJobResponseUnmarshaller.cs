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
    public class SubmitAIVideoPornRecogJobResponseUnmarshaller
    {
        public static SubmitAIVideoPornRecogJobResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitAIVideoPornRecogJobResponse submitAIVideoPornRecogJobResponse = new SubmitAIVideoPornRecogJobResponse();

			submitAIVideoPornRecogJobResponse.HttpResponse = context.HttpResponse;
			submitAIVideoPornRecogJobResponse.RequestId = context.StringValue("SubmitAIVideoPornRecogJob.RequestId");

			SubmitAIVideoPornRecogJobResponse.SubmitAIVideoPornRecogJob_AIVideoPornRecogJob aIVideoPornRecogJob = new SubmitAIVideoPornRecogJobResponse.SubmitAIVideoPornRecogJob_AIVideoPornRecogJob();
			aIVideoPornRecogJob.JobId = context.StringValue("SubmitAIVideoPornRecogJob.AIVideoPornRecogJob.JobId");
			aIVideoPornRecogJob.MediaId = context.StringValue("SubmitAIVideoPornRecogJob.AIVideoPornRecogJob.MediaId");
			aIVideoPornRecogJob.Status = context.StringValue("SubmitAIVideoPornRecogJob.AIVideoPornRecogJob.Status");
			aIVideoPornRecogJob.Code = context.StringValue("SubmitAIVideoPornRecogJob.AIVideoPornRecogJob.Code");
			aIVideoPornRecogJob.Message = context.StringValue("SubmitAIVideoPornRecogJob.AIVideoPornRecogJob.Message");
			aIVideoPornRecogJob.CreationTime = context.StringValue("SubmitAIVideoPornRecogJob.AIVideoPornRecogJob.CreationTime");
			aIVideoPornRecogJob.Data = context.StringValue("SubmitAIVideoPornRecogJob.AIVideoPornRecogJob.Data");
			submitAIVideoPornRecogJobResponse.AIVideoPornRecogJob = aIVideoPornRecogJob;
        
			return submitAIVideoPornRecogJobResponse;
        }
    }
}
