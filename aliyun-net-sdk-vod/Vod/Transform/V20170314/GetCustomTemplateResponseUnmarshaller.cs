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
    public class GetCustomTemplateResponseUnmarshaller
    {
        public static GetCustomTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			GetCustomTemplateResponse getCustomTemplateResponse = new GetCustomTemplateResponse();

			getCustomTemplateResponse.HttpResponse = context.HttpResponse;
			getCustomTemplateResponse.RequestId = context.StringValue("GetCustomTemplate.RequestId");

			GetCustomTemplateResponse.GetCustomTemplate_Template template = new GetCustomTemplateResponse.GetCustomTemplate_Template();
			template.Definition = context.StringValue("GetCustomTemplate.Template.Definition");
			template.Condition = context.StringValue("GetCustomTemplate.Template.Condition");
			template.TemplateId = context.StringValue("GetCustomTemplate.Template.TemplateId");
			template.Status = context.StringValue("GetCustomTemplate.Template.Status");
			template.UserWaterMark = context.StringValue("GetCustomTemplate.Template.UserWaterMark");
			template.NarrowBand = context.StringValue("GetCustomTemplate.Template.NarrowBand");
			template.Encrypt = context.StringValue("GetCustomTemplate.Template.Encrypt");

			GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_Video video = new GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_Video();
			video.Codec = context.StringValue("GetCustomTemplate.Template.Video.Codec");
			video.Profile = context.StringValue("GetCustomTemplate.Template.Video.Profile");
			video.Bitrate = context.StringValue("GetCustomTemplate.Template.Video.Bitrate");
			video.Crf = context.StringValue("GetCustomTemplate.Template.Video.Crf");
			video.Width = context.StringValue("GetCustomTemplate.Template.Video.Width");
			video.Height = context.StringValue("GetCustomTemplate.Template.Video.Height");
			video.Fps = context.StringValue("GetCustomTemplate.Template.Video.Fps");
			video.Gop = context.StringValue("GetCustomTemplate.Template.Video.Gop");
			video.Preset = context.StringValue("GetCustomTemplate.Template.Video.Preset");
			video.ScanMode = context.StringValue("GetCustomTemplate.Template.Video.ScanMode");
			video.PixFmt = context.StringValue("GetCustomTemplate.Template.Video.PixFmt");
			video._Remove = context.StringValue("GetCustomTemplate.Template.Video._Remove");
			video.Crop = context.StringValue("GetCustomTemplate.Template.Video.Crop");
			video.Pad = context.StringValue("GetCustomTemplate.Template.Video.Pad");
			template.Video = video;

			GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_Audio audio = new GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_Audio();
			audio.Codec = context.StringValue("GetCustomTemplate.Template.Audio.Codec");
			audio.Profile = context.StringValue("GetCustomTemplate.Template.Audio.Profile");
			audio.Bitrate = context.StringValue("GetCustomTemplate.Template.Audio.Bitrate");
			audio.Samplerate = context.StringValue("GetCustomTemplate.Template.Audio.Samplerate");
			audio.Channels = context.StringValue("GetCustomTemplate.Template.Audio.Channels");
			audio._Remove = context.StringValue("GetCustomTemplate.Template.Audio._Remove");
			template.Audio = audio;

			GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_Container container = new GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_Container();
			container.Format = context.StringValue("GetCustomTemplate.Template.Container.Format");
			template.Container = container;

			GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_TransConfig transConfig = new GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_TransConfig();
			transConfig.TransMode = context.StringValue("GetCustomTemplate.Template.TransConfig.TransMode");
			transConfig.IsCheckReso = context.StringValue("GetCustomTemplate.Template.TransConfig.IsCheckReso");
			transConfig.IsCheckResoFail = context.StringValue("GetCustomTemplate.Template.TransConfig.IsCheckResoFail");
			transConfig.IsCheckVideoBitrate = context.StringValue("GetCustomTemplate.Template.TransConfig.IsCheckVideoBitrate");
			transConfig.IsCheckAudioBitrate = context.StringValue("GetCustomTemplate.Template.TransConfig.IsCheckAudioBitrate");
			transConfig.IsCheckAudioBitrateFail = context.StringValue("GetCustomTemplate.Template.TransConfig.IsCheckAudioBitrateFail");
			transConfig.IsCheckVideoBitrateFail = context.StringValue("GetCustomTemplate.Template.TransConfig.IsCheckVideoBitrateFail");
			template.TransConfig = transConfig;

			GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_MuxConfig muxConfig = new GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_MuxConfig();

			GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_MuxConfig.GetCustomTemplate_Segment segment = new GetCustomTemplateResponse.GetCustomTemplate_Template.GetCustomTemplate_MuxConfig.GetCustomTemplate_Segment();
			segment.Duration = context.StringValue("GetCustomTemplate.Template.MuxConfig.Segment.Duration");
			muxConfig.Segment = segment;
			template.MuxConfig = muxConfig;
			getCustomTemplateResponse.Template = template;
        
			return getCustomTemplateResponse;
        }
    }
}
