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
	public class ListTemplateGroupResponse : AcsResponse
	{

		private string requestId;

		private List<ListTemplateGroup_TemplateGroup> templateGroups;

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

		public List<ListTemplateGroup_TemplateGroup> TemplateGroups
		{
			get
			{
				return templateGroups;
			}
			set	
			{
				templateGroups = value;
			}
		}

		public class ListTemplateGroup_TemplateGroup
		{

			private string groupId;

			private string defaultGroup;

			private string status;

			private string groupSymbol;

			private string groupType;

			private string name;

			private string transcodeMode;

			private string isLocked;

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string DefaultGroup
			{
				get
				{
					return defaultGroup;
				}
				set	
				{
					defaultGroup = value;
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

			public string GroupSymbol
			{
				get
				{
					return groupSymbol;
				}
				set	
				{
					groupSymbol = value;
				}
			}

			public string GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string TranscodeMode
			{
				get
				{
					return transcodeMode;
				}
				set	
				{
					transcodeMode = value;
				}
			}

			public string IsLocked
			{
				get
				{
					return isLocked;
				}
				set	
				{
					isLocked = value;
				}
			}
		}
	}
}
