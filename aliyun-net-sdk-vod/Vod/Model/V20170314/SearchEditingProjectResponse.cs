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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.vod.Model.V20170314
{
	public class SearchEditingProjectResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private List<SearchEditingProject_Project> projectList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<SearchEditingProject_Project> ProjectList
		{
			get
			{
				return projectList;
			}
			set	
			{
				projectList = value;
			}
		}

		public class SearchEditingProject_Project
		{

			private string projectId;

			private string createTime;

			private string modifyTime;

			private string customerId;

			private string status;

			private string description;

			private string title;

			private string producedMediaId;

			private float? duration;

			private string coverUrl;

			public string ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string CustomerId
			{
				get
				{
					return customerId;
				}
				set	
				{
					customerId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string ProducedMediaId
			{
				get
				{
					return producedMediaId;
				}
				set	
				{
					producedMediaId = value;
				}
			}

			public float? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string CoverUrl
			{
				get
				{
					return coverUrl;
				}
				set	
				{
					coverUrl = value;
				}
			}
		}
	}
}
