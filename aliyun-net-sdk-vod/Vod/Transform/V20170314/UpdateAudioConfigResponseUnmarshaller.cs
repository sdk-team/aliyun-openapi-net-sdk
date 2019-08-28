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
    public class UpdateAudioConfigResponseUnmarshaller
    {
        public static UpdateAudioConfigResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateAudioConfigResponse updateAudioConfigResponse = new UpdateAudioConfigResponse();

			updateAudioConfigResponse.HttpResponse = context.HttpResponse;
			updateAudioConfigResponse.RequestId = context.StringValue("UpdateAudioConfig.RequestId");

			List<UpdateAudioConfigResponse.UpdateAudioConfig_Config> updateAudioConfigResponse_configs = new List<UpdateAudioConfigResponse.UpdateAudioConfig_Config>();
			for (int i = 0; i < context.Length("UpdateAudioConfig.Configs.Length"); i++) {
				UpdateAudioConfigResponse.UpdateAudioConfig_Config config = new UpdateAudioConfigResponse.UpdateAudioConfig_Config();
				config.TemplateId = context.StringValue("UpdateAudioConfig.Configs["+ i +"].TemplateId");
				config.Status = context.StringValue("UpdateAudioConfig.Configs["+ i +"].Status");

				updateAudioConfigResponse_configs.Add(config);
			}
			updateAudioConfigResponse.Configs = updateAudioConfigResponse_configs;
        
			return updateAudioConfigResponse;
        }
    }
}
