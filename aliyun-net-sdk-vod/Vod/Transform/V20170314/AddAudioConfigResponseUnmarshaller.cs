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
    public class AddAudioConfigResponseUnmarshaller
    {
        public static AddAudioConfigResponse Unmarshall(UnmarshallerContext context)
        {
			AddAudioConfigResponse addAudioConfigResponse = new AddAudioConfigResponse();

			addAudioConfigResponse.HttpResponse = context.HttpResponse;
			addAudioConfigResponse.RequestId = context.StringValue("AddAudioConfig.RequestId");

			List<AddAudioConfigResponse.AddAudioConfig_Config> addAudioConfigResponse_configs = new List<AddAudioConfigResponse.AddAudioConfig_Config>();
			for (int i = 0; i < context.Length("AddAudioConfig.Configs.Length"); i++) {
				AddAudioConfigResponse.AddAudioConfig_Config config = new AddAudioConfigResponse.AddAudioConfig_Config();
				config.TemplateId = context.StringValue("AddAudioConfig.Configs["+ i +"].TemplateId");
				config.Status = context.StringValue("AddAudioConfig.Configs["+ i +"].Status");

				addAudioConfigResponse_configs.Add(config);
			}
			addAudioConfigResponse.Configs = addAudioConfigResponse_configs;
        
			return addAudioConfigResponse;
        }
    }
}
