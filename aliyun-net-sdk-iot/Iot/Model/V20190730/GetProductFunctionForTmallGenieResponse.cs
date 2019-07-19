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
	public class GetProductFunctionForTmallGenieResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private GetProductFunctionForTmallGenie_PropertyInfo propertyInfo;

		private GetProductFunctionForTmallGenie_ServiceInfo serviceInfo;

		private GetProductFunctionForTmallGenie_EventInfos eventInfos;

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

		public GetProductFunctionForTmallGenie_PropertyInfo PropertyInfo
		{
			get
			{
				return propertyInfo;
			}
			set	
			{
				propertyInfo = value;
			}
		}

		public GetProductFunctionForTmallGenie_ServiceInfo ServiceInfo
		{
			get
			{
				return serviceInfo;
			}
			set	
			{
				serviceInfo = value;
			}
		}

		public GetProductFunctionForTmallGenie_EventInfos EventInfos
		{
			get
			{
				return eventInfos;
			}
			set	
			{
				eventInfos = value;
			}
		}

		public class GetProductFunctionForTmallGenie_PropertyInfo
		{

			private long? tmallFunctionId;

			private string thingTemplateKey;

			private string dataType;

			private string rwType;

			private string identifier;

			private string description;

			private string name;

			private string dataSpecs;

			private string dataSpecsList;

			private List<GetProductFunctionForTmallGenie_Tag> tags;

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

			public string RwType
			{
				get
				{
					return rwType;
				}
				set	
				{
					rwType = value;
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

			public List<GetProductFunctionForTmallGenie_Tag> Tags
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

			public class GetProductFunctionForTmallGenie_Tag
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

		public class GetProductFunctionForTmallGenie_ServiceInfo
		{

			private long? tmallFunctionId;

			private string thingTemplateKey;

			private string callType;

			private string name;

			private string identifier;

			private List<GetProductFunctionForTmallGenie_Argument> inputParams;

			private List<GetProductFunctionForTmallGenie_Argument2> outputParams;

			private List<GetProductFunctionForTmallGenie_Tag3> tags1;

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

			public List<GetProductFunctionForTmallGenie_Argument> InputParams
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

			public List<GetProductFunctionForTmallGenie_Argument2> OutputParams
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

			public List<GetProductFunctionForTmallGenie_Tag3> Tags1
			{
				get
				{
					return tags1;
				}
				set	
				{
					tags1 = value;
				}
			}

			public class GetProductFunctionForTmallGenie_Argument
			{

				private long? id;

				private string dataType;

				private string identifier;

				private string name;

				private int? paraOrder;

				private string direction;

				private string dataSpecs;

				private string dataSpecsList;

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
			}

			public class GetProductFunctionForTmallGenie_Argument2
			{

				private long? id;

				private string dataType;

				private string identifier;

				private int? paraOrder;

				private string direction;

				private string name;

				private string dataSpecs;

				private string dataSpecsList;

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
			}

			public class GetProductFunctionForTmallGenie_Tag3
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

		public class GetProductFunctionForTmallGenie_EventInfos
		{

			private long? tmallFunctionId;

			private string thingTemplateKey;

			private string eventType;

			private string name;

			private string identifier;

			private List<GetProductFunctionForTmallGenie_Argument5> outputData;

			private List<GetProductFunctionForTmallGenie_Tag6> tags4;

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

			public string EventType
			{
				get
				{
					return eventType;
				}
				set	
				{
					eventType = value;
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

			public List<GetProductFunctionForTmallGenie_Argument5> OutputData
			{
				get
				{
					return outputData;
				}
				set	
				{
					outputData = value;
				}
			}

			public List<GetProductFunctionForTmallGenie_Tag6> Tags4
			{
				get
				{
					return tags4;
				}
				set	
				{
					tags4 = value;
				}
			}

			public class GetProductFunctionForTmallGenie_Argument5
			{

				private long? id;

				private string dataType;

				private string identifier;

				private string name;

				private int? paraOrder;

				private string dataSpecs;

				private string dataSpecsList;

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
			}

			public class GetProductFunctionForTmallGenie_Tag6
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
