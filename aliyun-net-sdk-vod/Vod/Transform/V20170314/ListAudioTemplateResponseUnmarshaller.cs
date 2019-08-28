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
    public class ListAudioTemplateResponseUnmarshaller
    {
        public static ListAudioTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			ListAudioTemplateResponse listAudioTemplateResponse = new ListAudioTemplateResponse();

			listAudioTemplateResponse.HttpResponse = context.HttpResponse;
			listAudioTemplateResponse.RequestId = context.StringValue("ListAudioTemplate.RequestId");

			List<ListAudioTemplateResponse.ListAudioTemplate_Audio> listAudioTemplateResponse_audios = new List<ListAudioTemplateResponse.ListAudioTemplate_Audio>();
			for (int i = 0; i < context.Length("ListAudioTemplate.Audios.Length"); i++) {
				ListAudioTemplateResponse.ListAudioTemplate_Audio audio = new ListAudioTemplateResponse.ListAudioTemplate_Audio();
				audio.TemplateId = context.StringValue("ListAudioTemplate.Audios["+ i +"].TemplateId");
				audio.Codec = context.StringValue("ListAudioTemplate.Audios["+ i +"].Codec");
				audio.Bitrate = context.StringValue("ListAudioTemplate.Audios["+ i +"].Bitrate");
				audio.Channeles = context.StringValue("ListAudioTemplate.Audios["+ i +"].Channeles");
				audio._Remove = context.StringValue("ListAudioTemplate.Audios["+ i +"]._Remove");
				audio.Name = context.StringValue("ListAudioTemplate.Audios["+ i +"].Name");
				audio.Format = context.StringValue("ListAudioTemplate.Audios["+ i +"].Format");
				audio.Status = context.StringValue("ListAudioTemplate.Audios["+ i +"].Status");
				audio.Type = context.StringValue("ListAudioTemplate.Audios["+ i +"].Type");
				audio.IsDefault = context.StringValue("ListAudioTemplate.Audios["+ i +"].IsDefault");

				listAudioTemplateResponse_audios.Add(audio);
			}
			listAudioTemplateResponse.Audios = listAudioTemplateResponse_audios;
        
			return listAudioTemplateResponse;
        }
    }
}
