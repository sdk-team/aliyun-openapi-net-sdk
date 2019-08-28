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
    public class GetEditingProjectListResponseUnmarshaller
    {
        public static GetEditingProjectListResponse Unmarshall(UnmarshallerContext context)
        {
			GetEditingProjectListResponse getEditingProjectListResponse = new GetEditingProjectListResponse();

			getEditingProjectListResponse.HttpResponse = context.HttpResponse;
			getEditingProjectListResponse.RequestId = context.StringValue("GetEditingProjectList.RequestId");

			List<GetEditingProjectListResponse.GetEditingProjectList_Project> getEditingProjectListResponse_projectList = new List<GetEditingProjectListResponse.GetEditingProjectList_Project>();
			for (int i = 0; i < context.Length("GetEditingProjectList.ProjectList.Length"); i++) {
				GetEditingProjectListResponse.GetEditingProjectList_Project project = new GetEditingProjectListResponse.GetEditingProjectList_Project();
				project.ProjectId = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].ProjectId");
				project.CreateTime = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].CreateTime");
				project.ModifyTime = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].ModifyTime");
				project.CustomerId = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].CustomerId");
				project.Status = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].Status");
				project.Description = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].Description");
				project.Title = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].Title");
				project.ProducedMediaId = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].ProducedMediaId");
				project.Duration = context.FloatValue("GetEditingProjectList.ProjectList["+ i +"].Duration");
				project.CoverUrl = context.StringValue("GetEditingProjectList.ProjectList["+ i +"].CoverUrl");

				getEditingProjectListResponse_projectList.Add(project);
			}
			getEditingProjectListResponse.ProjectList = getEditingProjectListResponse_projectList;
        
			return getEditingProjectListResponse;
        }
    }
}
