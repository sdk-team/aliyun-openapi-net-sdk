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
    public class ListCustomTemplateResponseUnmarshaller
    {
        public static ListCustomTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			ListCustomTemplateResponse listCustomTemplateResponse = new ListCustomTemplateResponse();

			listCustomTemplateResponse.HttpResponse = context.HttpResponse;
			listCustomTemplateResponse.RequestId = context.StringValue("ListCustomTemplate.RequestId");

			List<ListCustomTemplateResponse.ListCustomTemplate_Template> listCustomTemplateResponse_templates = new List<ListCustomTemplateResponse.ListCustomTemplate_Template>();
			for (int i = 0; i < context.Length("ListCustomTemplate.Templates.Length"); i++) {
				ListCustomTemplateResponse.ListCustomTemplate_Template template = new ListCustomTemplateResponse.ListCustomTemplate_Template();
				template.Definition = context.StringValue("ListCustomTemplate.Templates["+ i +"].Definition");
				template.Condition = context.StringValue("ListCustomTemplate.Templates["+ i +"].Condition");
				template.TemplateId = context.StringValue("ListCustomTemplate.Templates["+ i +"].TemplateId");
				template.Status = context.StringValue("ListCustomTemplate.Templates["+ i +"].Status");
				template.UserWaterMark = context.StringValue("ListCustomTemplate.Templates["+ i +"].UserWaterMark");
				template.NarrowBand = context.StringValue("ListCustomTemplate.Templates["+ i +"].NarrowBand");
				template.Encrypt = context.StringValue("ListCustomTemplate.Templates["+ i +"].Encrypt");

				ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_Video video = new ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_Video();
				video.Codec = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Codec");
				video.Profile = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Profile");
				video.Bitrate = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Bitrate");
				video.Crf = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Crf");
				video.Width = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Width");
				video.Height = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Height");
				video.Fps = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Fps");
				video.Gop = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Gop");
				video.Preset = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Preset");
				video.ScanMode = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.ScanMode");
				video.PixFmt = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.PixFmt");
				video._Remove = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video._Remove");
				video.Crop = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Crop");
				video.Pad = context.StringValue("ListCustomTemplate.Templates["+ i +"].Video.Pad");
				template.Video = video;

				ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_Audio audio = new ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_Audio();
				audio.Codec = context.StringValue("ListCustomTemplate.Templates["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("ListCustomTemplate.Templates["+ i +"].Audio.Profile");
				audio.Bitrate = context.StringValue("ListCustomTemplate.Templates["+ i +"].Audio.Bitrate");
				audio.Samplerate = context.StringValue("ListCustomTemplate.Templates["+ i +"].Audio.Samplerate");
				audio.Channels = context.StringValue("ListCustomTemplate.Templates["+ i +"].Audio.Channels");
				audio._Remove = context.StringValue("ListCustomTemplate.Templates["+ i +"].Audio._Remove");
				template.Audio = audio;

				ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_Container container = new ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_Container();
				container.Format = context.StringValue("ListCustomTemplate.Templates["+ i +"].Container.Format");
				template.Container = container;

				ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_TransConfig transConfig = new ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_TransConfig();
				transConfig.TransMode = context.StringValue("ListCustomTemplate.Templates["+ i +"].TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("ListCustomTemplate.Templates["+ i +"].TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("ListCustomTemplate.Templates["+ i +"].TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("ListCustomTemplate.Templates["+ i +"].TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("ListCustomTemplate.Templates["+ i +"].TransConfig.IsCheckAudioBitrate");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("ListCustomTemplate.Templates["+ i +"].TransConfig.IsCheckAudioBitrateFail");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("ListCustomTemplate.Templates["+ i +"].TransConfig.IsCheckVideoBitrateFail");
				template.TransConfig = transConfig;

				ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_MuxConfig muxConfig = new ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_MuxConfig();

				ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_MuxConfig.ListCustomTemplate_Segment segment = new ListCustomTemplateResponse.ListCustomTemplate_Template.ListCustomTemplate_MuxConfig.ListCustomTemplate_Segment();
				segment.Duration = context.StringValue("ListCustomTemplate.Templates["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;
				template.MuxConfig = muxConfig;

				listCustomTemplateResponse_templates.Add(template);
			}
			listCustomTemplateResponse.Templates = listCustomTemplateResponse_templates;
        
			return listCustomTemplateResponse;
        }
    }
}
