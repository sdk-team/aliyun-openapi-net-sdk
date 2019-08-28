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
    public class AddAudioTemplateResponseUnmarshaller
    {
        public static AddAudioTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			AddAudioTemplateResponse addAudioTemplateResponse = new AddAudioTemplateResponse();

			addAudioTemplateResponse.HttpResponse = context.HttpResponse;
			addAudioTemplateResponse.RequestId = context.StringValue("AddAudioTemplate.RequestId");

			AddAudioTemplateResponse.AddAudioTemplate_Audio audio = new AddAudioTemplateResponse.AddAudioTemplate_Audio();
			audio.TemplateId = context.StringValue("AddAudioTemplate.Audio.TemplateId");
			audio.Codec = context.StringValue("AddAudioTemplate.Audio.Codec");
			audio.Bitrate = context.StringValue("AddAudioTemplate.Audio.Bitrate");
			audio.Channeles = context.StringValue("AddAudioTemplate.Audio.Channeles");
			audio._Remove = context.StringValue("AddAudioTemplate.Audio._Remove");
			audio.Name = context.StringValue("AddAudioTemplate.Audio.Name");
			audio.Format = context.StringValue("AddAudioTemplate.Audio.Format");
			audio.Status = context.StringValue("AddAudioTemplate.Audio.Status");
			audio.Type = context.StringValue("AddAudioTemplate.Audio.Type");
			audio.IsDefault = context.StringValue("AddAudioTemplate.Audio.IsDefault");
			addAudioTemplateResponse.Audio = audio;
        
			return addAudioTemplateResponse;
        }
    }
}
