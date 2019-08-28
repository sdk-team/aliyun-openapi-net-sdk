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
    public class GetEditingProjectResponseUnmarshaller
    {
        public static GetEditingProjectResponse Unmarshall(UnmarshallerContext context)
        {
			GetEditingProjectResponse getEditingProjectResponse = new GetEditingProjectResponse();

			getEditingProjectResponse.HttpResponse = context.HttpResponse;
			getEditingProjectResponse.RequestId = context.StringValue("GetEditingProject.RequestId");

			GetEditingProjectResponse.GetEditingProject_Project project = new GetEditingProjectResponse.GetEditingProject_Project();
			project.ProjectId = context.StringValue("GetEditingProject.Project.ProjectId");
			project.CreateTime = context.StringValue("GetEditingProject.Project.CreateTime");
			project.ModifyTime = context.StringValue("GetEditingProject.Project.ModifyTime");
			project.CustomerId = context.StringValue("GetEditingProject.Project.CustomerId");
			project.Status = context.StringValue("GetEditingProject.Project.Status");
			project.Description = context.StringValue("GetEditingProject.Project.Description");
			project.Title = context.StringValue("GetEditingProject.Project.Title");
			project.Timeline = context.StringValue("GetEditingProject.Project.Timeline");
			project.ProducedMediaId = context.StringValue("GetEditingProject.Project.ProducedMediaId");
			project.Duration = context.FloatValue("GetEditingProject.Project.Duration");
			project.CoverUrl = context.StringValue("GetEditingProject.Project.CoverUrl");
			getEditingProjectResponse.Project = project;
        
			return getEditingProjectResponse;
        }
    }
}
