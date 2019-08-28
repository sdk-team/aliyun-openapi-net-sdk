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
	public class GetWatermarkGroupResponse : AcsResponse
	{

		private string requestId;

		private string total;

		private List<GetWatermarkGroup_WatermarkGroup> watermarkGroupList;

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

		public string Total
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

		public List<GetWatermarkGroup_WatermarkGroup> WatermarkGroupList
		{
			get
			{
				return watermarkGroupList;
			}
			set	
			{
				watermarkGroupList = value;
			}
		}

		public class GetWatermarkGroup_WatermarkGroup
		{

			private string watermarkId;

			private string watermarkGroupId;

			private string watermarkFileURL;

			private string watermarkType;

			private string watermarkConfig;

			public string WatermarkId
			{
				get
				{
					return watermarkId;
				}
				set	
				{
					watermarkId = value;
				}
			}

			public string WatermarkGroupId
			{
				get
				{
					return watermarkGroupId;
				}
				set	
				{
					watermarkGroupId = value;
				}
			}

			public string WatermarkFileURL
			{
				get
				{
					return watermarkFileURL;
				}
				set	
				{
					watermarkFileURL = value;
				}
			}

			public string WatermarkType
			{
				get
				{
					return watermarkType;
				}
				set	
				{
					watermarkType = value;
				}
			}

			public string WatermarkConfig
			{
				get
				{
					return watermarkConfig;
				}
				set	
				{
					watermarkConfig = value;
				}
			}
		}
	}
}
