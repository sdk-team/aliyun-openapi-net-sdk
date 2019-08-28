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
    public class UpdateMediaCategoryResponseUnmarshaller
    {
        public static UpdateMediaCategoryResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateMediaCategoryResponse updateMediaCategoryResponse = new UpdateMediaCategoryResponse();

			updateMediaCategoryResponse.HttpResponse = context.HttpResponse;
			updateMediaCategoryResponse.RequestId = context.StringValue("UpdateMediaCategory.RequestId");

			UpdateMediaCategoryResponse.UpdateMediaCategory_Media media = new UpdateMediaCategoryResponse.UpdateMediaCategory_Media();
			media.MediaId = context.StringValue("UpdateMediaCategory.Media.MediaId");
			media.Title = context.StringValue("UpdateMediaCategory.Media.Title");
			media.Description = context.StringValue("UpdateMediaCategory.Media.Description");
			media.CoverUrl = context.StringValue("UpdateMediaCategory.Media.CoverUrl");
			media.CateId = context.LongValue("UpdateMediaCategory.Media.CateId");
			media.Tags = context.StringValue("UpdateMediaCategory.Media.Tags");
			media.Duration = context.StringValue("UpdateMediaCategory.Media.Duration");
			media.FileSize = context.StringValue("UpdateMediaCategory.Media.FileSize");
			media.State = context.IntegerValue("UpdateMediaCategory.Media.State");
			media.MediaWorkflowRunId = context.StringValue("UpdateMediaCategory.Media.MediaWorkflowRunId");
			media.CreateTime = context.StringValue("UpdateMediaCategory.Media.CreateTime");
			media.CreateIp = context.StringValue("UpdateMediaCategory.Media.CreateIp");
			media.MediaWorkflowId = context.StringValue("UpdateMediaCategory.Media.MediaWorkflowId");
			media.PublicType = context.IntegerValue("UpdateMediaCategory.Media.PublicType");

			List<string> media_snapshots = new List<string>();
			for (int i = 0; i < context.Length("UpdateMediaCategory.Media.Snapshots.Length"); i++) {
				media_snapshots.Add(context.StringValue("UpdateMediaCategory.Media.Snapshots["+ i +"]"));
			}
			media.Snapshots = media_snapshots;
			updateMediaCategoryResponse.Media = media;
        
			return updateMediaCategoryResponse;
        }
    }
}
