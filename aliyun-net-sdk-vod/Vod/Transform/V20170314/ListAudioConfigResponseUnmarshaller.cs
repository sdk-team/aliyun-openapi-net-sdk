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
    public class ListAudioConfigResponseUnmarshaller
    {
        public static ListAudioConfigResponse Unmarshall(UnmarshallerContext context)
        {
			ListAudioConfigResponse listAudioConfigResponse = new ListAudioConfigResponse();

			listAudioConfigResponse.HttpResponse = context.HttpResponse;
			listAudioConfigResponse.RequestId = context.StringValue("ListAudioConfig.RequestId");

			List<ListAudioConfigResponse.ListAudioConfig_Config> listAudioConfigResponse_configs = new List<ListAudioConfigResponse.ListAudioConfig_Config>();
			for (int i = 0; i < context.Length("ListAudioConfig.Configs.Length"); i++) {
				ListAudioConfigResponse.ListAudioConfig_Config config = new ListAudioConfigResponse.ListAudioConfig_Config();
				config.TemplateId = context.StringValue("ListAudioConfig.Configs["+ i +"].TemplateId");
				config.Status = context.StringValue("ListAudioConfig.Configs["+ i +"].Status");

				listAudioConfigResponse_configs.Add(config);
			}
			listAudioConfigResponse.Configs = listAudioConfigResponse_configs;
        
			return listAudioConfigResponse;
        }
    }
}
