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

namespace Aliyun.Acs.Ft.Model.V20180713
{
	public class GetMigrateStrategyResultResponse : AcsResponse
	{

		private bool? success;

		private string code;

		private string message;

		private string messageCN;

		private string requestId;

		private string nullValue;

		private GetMigrateStrategyResult_Data data;

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

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

		public string MessageCN
		{
			get
			{
				return messageCN;
			}
			set	
			{
				messageCN = value;
			}
		}

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

		public string NullValue
		{
			get
			{
				return nullValue;
			}
			set	
			{
				nullValue = value;
			}
		}

		public GetMigrateStrategyResult_Data Data
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

		public class GetMigrateStrategyResult_Data
		{

			private int? pageSize;

			private int? currentPage;

			private int? totalItem;

			private string testNull;

			private List<GetMigrateStrategyResult_DataListItem> dataList;

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			public int? TotalItem
			{
				get
				{
					return totalItem;
				}
				set	
				{
					totalItem = value;
				}
			}

			public string TestNull
			{
				get
				{
					return testNull;
				}
				set	
				{
					testNull = value;
				}
			}

			public List<GetMigrateStrategyResult_DataListItem> DataList
			{
				get
				{
					return dataList;
				}
				set	
				{
					dataList = value;
				}
			}

			public class GetMigrateStrategyResult_DataListItem
			{

				private long? id;

				private string createTime;

				private string modifiedTime;

				private int? recordVersion;

				private string env;

				private string product;

				private string version;

				private string api;

				private string strategyName;

				private string parentName;

				private string type;

				private string flowSpecial;

				private string dataItem;

				private string status;

				private GetMigrateStrategyResult_Modifier modifier;

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

				public string ModifiedTime
				{
					get
					{
						return modifiedTime;
					}
					set	
					{
						modifiedTime = value;
					}
				}

				public int? RecordVersion
				{
					get
					{
						return recordVersion;
					}
					set	
					{
						recordVersion = value;
					}
				}

				public string Env
				{
					get
					{
						return env;
					}
					set	
					{
						env = value;
					}
				}

				public string Product
				{
					get
					{
						return product;
					}
					set	
					{
						product = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string Api
				{
					get
					{
						return api;
					}
					set	
					{
						api = value;
					}
				}

				public string StrategyName
				{
					get
					{
						return strategyName;
					}
					set	
					{
						strategyName = value;
					}
				}

				public string ParentName
				{
					get
					{
						return parentName;
					}
					set	
					{
						parentName = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string FlowSpecial
				{
					get
					{
						return flowSpecial;
					}
					set	
					{
						flowSpecial = value;
					}
				}

				public string DataItem
				{
					get
					{
						return dataItem;
					}
					set	
					{
						dataItem = value;
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

				public GetMigrateStrategyResult_Modifier Modifier
				{
					get
					{
						return modifier;
					}
					set	
					{
						modifier = value;
					}
				}

				public class GetMigrateStrategyResult_Modifier
				{

					private string id;

					private string name;

					private string bucId;

					public string Id
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

					public string BucId
					{
						get
						{
							return bucId;
						}
						set	
						{
							bucId = value;
						}
					}
				}
			}
		}
	}
}
