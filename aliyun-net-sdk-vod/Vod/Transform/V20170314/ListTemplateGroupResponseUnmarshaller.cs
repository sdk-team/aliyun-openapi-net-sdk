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
    public class ListTemplateGroupResponseUnmarshaller
    {
        public static ListTemplateGroupResponse Unmarshall(UnmarshallerContext context)
        {
			ListTemplateGroupResponse listTemplateGroupResponse = new ListTemplateGroupResponse();

			listTemplateGroupResponse.HttpResponse = context.HttpResponse;
			listTemplateGroupResponse.RequestId = context.StringValue("ListTemplateGroup.RequestId");

			List<ListTemplateGroupResponse.ListTemplateGroup_TemplateGroup> listTemplateGroupResponse_templateGroups = new List<ListTemplateGroupResponse.ListTemplateGroup_TemplateGroup>();
			for (int i = 0; i < context.Length("ListTemplateGroup.TemplateGroups.Length"); i++) {
				ListTemplateGroupResponse.ListTemplateGroup_TemplateGroup templateGroup = new ListTemplateGroupResponse.ListTemplateGroup_TemplateGroup();
				templateGroup.GroupId = context.StringValue("ListTemplateGroup.TemplateGroups["+ i +"].GroupId");
				templateGroup.DefaultGroup = context.StringValue("ListTemplateGroup.TemplateGroups["+ i +"].DefaultGroup");
				templateGroup.Status = context.StringValue("ListTemplateGroup.TemplateGroups["+ i +"].Status");
				templateGroup.GroupSymbol = context.StringValue("ListTemplateGroup.TemplateGroups["+ i +"].GroupSymbol");
				templateGroup.GroupType = context.StringValue("ListTemplateGroup.TemplateGroups["+ i +"].GroupType");
				templateGroup.Name = context.StringValue("ListTemplateGroup.TemplateGroups["+ i +"].Name");
				templateGroup.TranscodeMode = context.StringValue("ListTemplateGroup.TemplateGroups["+ i +"].TranscodeMode");
				templateGroup.IsLocked = context.StringValue("ListTemplateGroup.TemplateGroups["+ i +"].IsLocked");

				listTemplateGroupResponse_templateGroups.Add(templateGroup);
			}
			listTemplateGroupResponse.TemplateGroups = listTemplateGroupResponse_templateGroups;
        
			return listTemplateGroupResponse;
        }
    }
}
