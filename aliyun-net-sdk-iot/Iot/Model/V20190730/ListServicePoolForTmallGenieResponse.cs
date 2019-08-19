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

namespace Aliyun.Acs.Iot.Model.V20190730
{
	public class ListServicePoolForTmallGenieResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private int? pageNo;

		private int? total;

		private int? pageSize;

		private List<ListServicePoolForTmallGenie_Service> services;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
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

		public List<ListServicePoolForTmallGenie_Service> Services
		{
			get
			{
				return services;
			}
			set	
			{
				services = value;
			}
		}

		public class ListServicePoolForTmallGenie_Service
		{

			private long? tmallFunctionId;

			private string thingTemplateKey;

			private string callType;

			private string name;

			private string identifier;

			private List<ListServicePoolForTmallGenie_Argument> inputParams;

			private List<ListServicePoolForTmallGenie_Argument1> outputParams;

			private List<ListServicePoolForTmallGenie_Tag> tags;

			public long? TmallFunctionId
			{
				get
				{
					return tmallFunctionId;
				}
				set	
				{
					tmallFunctionId = value;
				}
			}

			public string ThingTemplateKey
			{
				get
				{
					return thingTemplateKey;
				}
				set	
				{
					thingTemplateKey = value;
				}
			}

			public string CallType
			{
				get
				{
					return callType;
				}
				set	
				{
					callType = value;
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

			public string Identifier
			{
				get
				{
					return identifier;
				}
				set	
				{
					identifier = value;
				}
			}

			public List<ListServicePoolForTmallGenie_Argument> InputParams
			{
				get
				{
					return inputParams;
				}
				set	
				{
					inputParams = value;
				}
			}

			public List<ListServicePoolForTmallGenie_Argument1> OutputParams
			{
				get
				{
					return outputParams;
				}
				set	
				{
					outputParams = value;
				}
			}

			public List<ListServicePoolForTmallGenie_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class ListServicePoolForTmallGenie_Argument
			{

				private long? id;

				private string dataType;

				private string identifier;

				private string name;

				private int? paraOrder;

				private string direction;

				private string dataSpecs;

				private string dataSpecsList;

				private long? tmallFunctionId;

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

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

				public string Identifier
				{
					get
					{
						return identifier;
					}
					set	
					{
						identifier = value;
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

				public int? ParaOrder
				{
					get
					{
						return paraOrder;
					}
					set	
					{
						paraOrder = value;
					}
				}

				public string Direction
				{
					get
					{
						return direction;
					}
					set	
					{
						direction = value;
					}
				}

				public string DataSpecs
				{
					get
					{
						return dataSpecs;
					}
					set	
					{
						dataSpecs = value;
					}
				}

				public string DataSpecsList
				{
					get
					{
						return dataSpecsList;
					}
					set	
					{
						dataSpecsList = value;
					}
				}

				public long? TmallFunctionId
				{
					get
					{
						return tmallFunctionId;
					}
					set	
					{
						tmallFunctionId = value;
					}
				}
			}

			public class ListServicePoolForTmallGenie_Argument1
			{

				private long? id;

				private string dataType;

				private string identifier;

				private int? paraOrder;

				private string direction;

				private string name;

				private string dataSpecs;

				private string dataSpecsList;

				private long? tmallFunctionId;

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

				public string DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

				public string Identifier
				{
					get
					{
						return identifier;
					}
					set	
					{
						identifier = value;
					}
				}

				public int? ParaOrder
				{
					get
					{
						return paraOrder;
					}
					set	
					{
						paraOrder = value;
					}
				}

				public string Direction
				{
					get
					{
						return direction;
					}
					set	
					{
						direction = value;
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

				public string DataSpecs
				{
					get
					{
						return dataSpecs;
					}
					set	
					{
						dataSpecs = value;
					}
				}

				public string DataSpecsList
				{
					get
					{
						return dataSpecsList;
					}
					set	
					{
						dataSpecsList = value;
					}
				}

				public long? TmallFunctionId
				{
					get
					{
						return tmallFunctionId;
					}
					set	
					{
						tmallFunctionId = value;
					}
				}
			}

			public class ListServicePoolForTmallGenie_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}
		}
	}
}
