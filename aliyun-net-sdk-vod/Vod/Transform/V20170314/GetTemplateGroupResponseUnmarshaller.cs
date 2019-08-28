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
    public class GetTemplateGroupResponseUnmarshaller
    {
        public static GetTemplateGroupResponse Unmarshall(UnmarshallerContext context)
        {
			GetTemplateGroupResponse getTemplateGroupResponse = new GetTemplateGroupResponse();

			getTemplateGroupResponse.HttpResponse = context.HttpResponse;
			getTemplateGroupResponse.RequestId = context.StringValue("GetTemplateGroup.RequestId");

			GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup templateGroup = new GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup();
			templateGroup.GroupId = context.StringValue("GetTemplateGroup.TemplateGroup.GroupId");
			templateGroup.DefaultGroup = context.StringValue("GetTemplateGroup.TemplateGroup.DefaultGroup");
			templateGroup.Status = context.StringValue("GetTemplateGroup.TemplateGroup.Status");
			templateGroup.GroupType = context.StringValue("GetTemplateGroup.TemplateGroup.GroupType");
			templateGroup.Name = context.StringValue("GetTemplateGroup.TemplateGroup.Name");
			templateGroup.TranscodeMode = context.StringValue("GetTemplateGroup.TemplateGroup.TranscodeMode");
			templateGroup.GroupSymbol = context.StringValue("GetTemplateGroup.TemplateGroup.GroupSymbol");
			templateGroup.IsLocked = context.StringValue("GetTemplateGroup.TemplateGroup.IsLocked");

			List<GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template> templateGroup_templates = new List<GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template>();
			for (int i = 0; i < context.Length("GetTemplateGroup.TemplateGroup.Templates.Length"); i++) {
				GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template template = new GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template();
				template.Definition = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Definition");
				template.MediaDefinition = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].MediaDefinition");
				template.Condition = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Condition");
				template.TemplateId = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].TemplateId");
				template.Status = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Status");
				template.UserWaterMark = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].UserWaterMark");
				template.UseWaterMark = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].UseWaterMark");
				template.NarrowBand = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].NarrowBand");
				template.Encrypt = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Encrypt");
				template.IsLocked = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].IsLocked");
				template.Name = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Name");

				GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_Video video = new GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_Video();
				video.Codec = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Codec");
				video.Profile = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Profile");
				video.Bitrate = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Bitrate");
				video.Crf = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Crf");
				video.Width = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Width");
				video.Height = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Height");
				video.Fps = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Fps");
				video.Gop = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Gop");
				video.Preset = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Preset");
				video.ScanMode = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.ScanMode");
				video.PixFmt = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.PixFmt");
				video._Remove = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video._Remove");
				video.Crop = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Crop");
				video.Pad = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.Pad");
				video.LongShortMode = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Video.LongShortMode");
				template.Video = video;

				GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_Audio audio = new GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_Audio();
				audio.Codec = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Audio.Profile");
				audio.Bitrate = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Audio.Bitrate");
				audio.Samplerate = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Audio.Samplerate");
				audio.Channels = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Audio.Channels");
				audio._Remove = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Audio._Remove");
				template.Audio = audio;

				GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_Container container = new GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_Container();
				container.Format = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].Container.Format");
				template.Container = container;

				GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_TransConfig transConfig = new GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_TransConfig();
				transConfig.TransMode = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].TransConfig.TransMode");
				transConfig.IsCheckReso = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].TransConfig.IsCheckReso");
				transConfig.IsCheckResoFail = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].TransConfig.IsCheckResoFail");
				transConfig.IsCheckVideoBitrate = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].TransConfig.IsCheckVideoBitrate");
				transConfig.IsCheckAudioBitrate = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].TransConfig.IsCheckAudioBitrate");
				transConfig.IsCheckAudioBitrateFail = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].TransConfig.IsCheckAudioBitrateFail");
				transConfig.IsCheckVideoBitrateFail = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].TransConfig.IsCheckVideoBitrateFail");
				template.TransConfig = transConfig;

				GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_MuxConfig muxConfig = new GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_MuxConfig();

				GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_MuxConfig.GetTemplateGroup_Segment segment = new GetTemplateGroupResponse.GetTemplateGroup_TemplateGroup.GetTemplateGroup_Template.GetTemplateGroup_MuxConfig.GetTemplateGroup_Segment();
				segment.Duration = context.StringValue("GetTemplateGroup.TemplateGroup.Templates["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;
				template.MuxConfig = muxConfig;

				templateGroup_templates.Add(template);
			}
			templateGroup.Templates = templateGroup_templates;
			getTemplateGroupResponse.TemplateGroup = templateGroup;
        
			return getTemplateGroupResponse;
        }
    }
}
