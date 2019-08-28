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
    public class UpdateEditingProjectResponseUnmarshaller
    {
        public static UpdateEditingProjectResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateEditingProjectResponse updateEditingProjectResponse = new UpdateEditingProjectResponse();

			updateEditingProjectResponse.HttpResponse = context.HttpResponse;
			updateEditingProjectResponse.RequestId = context.StringValue("UpdateEditingProject.RequestId");

			UpdateEditingProjectResponse.UpdateEditingProject_Project project = new UpdateEditingProjectResponse.UpdateEditingProject_Project();
			project.ProjectId = context.StringValue("UpdateEditingProject.Project.ProjectId");
			project.CreateTime = context.StringValue("UpdateEditingProject.Project.CreateTime");
			project.ModifyTime = context.StringValue("UpdateEditingProject.Project.ModifyTime");
			project.CustomerId = context.StringValue("UpdateEditingProject.Project.CustomerId");
			project.Status = context.StringValue("UpdateEditingProject.Project.Status");
			project.Description = context.StringValue("UpdateEditingProject.Project.Description");
			project.Title = context.StringValue("UpdateEditingProject.Project.Title");
			project.Timeline = context.StringValue("UpdateEditingProject.Project.Timeline");
			project.ProducedMediaId = context.StringValue("UpdateEditingProject.Project.ProducedMediaId");
			project.Duration = context.FloatValue("UpdateEditingProject.Project.Duration");
			project.CoverUrl = context.StringValue("UpdateEditingProject.Project.CoverUrl");
			updateEditingProjectResponse.Project = project;
        
			return updateEditingProjectResponse;
        }
    }
}
