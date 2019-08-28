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
    public class AddMidYKVidResponseUnmarshaller
    {
        public static AddMidYKVidResponse Unmarshall(UnmarshallerContext context)
        {
			AddMidYKVidResponse addMidYKVidResponse = new AddMidYKVidResponse();

			addMidYKVidResponse.HttpResponse = context.HttpResponse;
			addMidYKVidResponse.RequestId = context.StringValue("AddMidYKVid.RequestId");

			AddMidYKVidResponse.AddMidYKVid_MidYKVidDO midYKVidDO = new AddMidYKVidResponse.AddMidYKVid_MidYKVidDO();
			midYKVidDO.MediaId = context.StringValue("AddMidYKVid.MidYKVidDO.MediaId");
			midYKVidDO.YKCloudVid = context.StringValue("AddMidYKVid.MidYKVidDO.YKCloudVid");
			midYKVidDO.YKVideoId = context.StringValue("AddMidYKVid.MidYKVidDO.YKVideoId");
			addMidYKVidResponse.MidYKVidDO = midYKVidDO;
        
			return addMidYKVidResponse;
        }
    }
}
