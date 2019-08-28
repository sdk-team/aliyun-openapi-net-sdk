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
    public class UpdateAudioTemplateResponseUnmarshaller
    {
        public static UpdateAudioTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateAudioTemplateResponse updateAudioTemplateResponse = new UpdateAudioTemplateResponse();

			updateAudioTemplateResponse.HttpResponse = context.HttpResponse;
			updateAudioTemplateResponse.RequestId = context.StringValue("UpdateAudioTemplate.RequestId");

			UpdateAudioTemplateResponse.UpdateAudioTemplate_Audio audio = new UpdateAudioTemplateResponse.UpdateAudioTemplate_Audio();
			audio.TemplateId = context.StringValue("UpdateAudioTemplate.Audio.TemplateId");
			audio.Codec = context.StringValue("UpdateAudioTemplate.Audio.Codec");
			audio.Bitrate = context.StringValue("UpdateAudioTemplate.Audio.Bitrate");
			audio.Channeles = context.StringValue("UpdateAudioTemplate.Audio.Channeles");
			audio._Remove = context.StringValue("UpdateAudioTemplate.Audio._Remove");
			audio.Name = context.StringValue("UpdateAudioTemplate.Audio.Name");
			audio.Format = context.StringValue("UpdateAudioTemplate.Audio.Format");
			audio.Status = context.StringValue("UpdateAudioTemplate.Audio.Status");
			audio.Type = context.StringValue("UpdateAudioTemplate.Audio.Type");
			audio.IsDefault = context.StringValue("UpdateAudioTemplate.Audio.IsDefault");
			updateAudioTemplateResponse.Audio = audio;
        
			return updateAudioTemplateResponse;
        }
    }
}
