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

namespace Aliyun.Acs.Ecs.Model.V20160314
{
	public class InnerEcsRegionQueryAllResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private List<InnerEcsRegionQueryAll_Item> data;

		private InnerEcsRegionQueryAll_ErrorCode errorCode;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<InnerEcsRegionQueryAll_Item> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public InnerEcsRegionQueryAll_ErrorCode ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public class InnerEcsRegionQueryAll_Item
		{

			private string regionNoAlias;

			private string regionMemo;

			private string regionName;

			private string regionNo;

			private string regionEnName;

			private string isActive;

			private long? id;

			private InnerEcsRegionQueryAll_Attributes attributes;

			public string RegionNoAlias
			{
				get
				{
					return regionNoAlias;
				}
				set	
				{
					regionNoAlias = value;
				}
			}

			public string RegionMemo
			{
				get
				{
					return regionMemo;
				}
				set	
				{
					regionMemo = value;
				}
			}

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public string RegionNo
			{
				get
				{
					return regionNo;
				}
				set	
				{
					regionNo = value;
				}
			}

			public string RegionEnName
			{
				get
				{
					return regionEnName;
				}
				set	
				{
					regionEnName = value;
				}
			}

			public string IsActive
			{
				get
				{
					return isActive;
				}
				set	
				{
					isActive = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public InnerEcsRegionQueryAll_Attributes Attributes
			{
				get
				{
					return attributes;
				}
				set	
				{
					attributes = value;
				}
			}

			public class InnerEcsRegionQueryAll_Attributes
			{

				private string support_image_copy;

				private string internal_use;

				private string ak_name;

				public string Support_image_copy
				{
					get
					{
						return support_image_copy;
					}
					set	
					{
						support_image_copy = value;
					}
				}

				public string Internal_use
				{
					get
					{
						return internal_use;
					}
					set	
					{
						internal_use = value;
					}
				}

				public string Ak_name
				{
					get
					{
						return ak_name;
					}
					set	
					{
						ak_name = value;
					}
				}
			}
		}

		public class InnerEcsRegionQueryAll_ErrorCode
		{

			private string code;

			private string message;

			private bool? isSuccess;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public bool? IsSuccess
			{
				get
				{
					return isSuccess;
				}
				set	
				{
					isSuccess = value;
				}
			}
		}
	}
}
