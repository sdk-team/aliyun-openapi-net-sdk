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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
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
			project.CreationTime = context.StringValue("GetEditingProject.Project.CreationTime");
			project.ModifiedTime = context.StringValue("GetEditingProject.Project.ModifiedTime");
			project.Status = context.StringValue("GetEditingProject.Project.Status");
			project.Description = context.StringValue("GetEditingProject.Project.Description");
			project.Title = context.StringValue("GetEditingProject.Project.Title");
			project.Timeline = context.StringValue("GetEditingProject.Project.Timeline");
			project.CoverURL = context.StringValue("GetEditingProject.Project.CoverURL");
			project.StorageLocation = context.StringValue("GetEditingProject.Project.StorageLocation");
			project.RegionId = context.StringValue("GetEditingProject.Project.RegionId");
			getEditingProjectResponse.Project = project;
        
			return getEditingProjectResponse;
        }
    }
}
