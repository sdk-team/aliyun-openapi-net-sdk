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
	public class QueryProductInfoForTmallGenieResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private string dslString;

		private List<QueryProductInfoForTmallGenie_Property> properties;

		private List<QueryProductInfoForTmallGenie__Event> events;

		private List<QueryProductInfoForTmallGenie_Service> services;

		private QueryProductInfoForTmallGenie_ProductInfo productInfo;

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

		public string DslString
		{
			get
			{
				return dslString;
			}
			set	
			{
				dslString = value;
			}
		}

		public List<QueryProductInfoForTmallGenie_Property> Properties
		{
			get
			{
				return properties;
			}
			set	
			{
				properties = value;
			}
		}

		public List<QueryProductInfoForTmallGenie__Event> Events
		{
			get
			{
				return events;
			}
			set	
			{
				events = value;
			}
		}

		public List<QueryProductInfoForTmallGenie_Service> Services
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

		public QueryProductInfoForTmallGenie_ProductInfo ProductInfo
		{
			get
			{
				return productInfo;
			}
			set	
			{
				productInfo = value;
			}
		}

		public class QueryProductInfoForTmallGenie_Property
		{

			private long? tmallFunctionId;

			private string thingTemplateKey;

			private string dataType;

			private string rwType;

			private string name;

			private string dataSpecs;

			private string identifier;

			private string description;

			private string dataSpecsList;

			private List<QueryProductInfoForTmallGenie_Tag> tags;

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

			public List<QueryProductInfoForTmallGenie_Tag> Tags
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

			public class QueryProductInfoForTmallGenie_Tag
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

		public class QueryProductInfoForTmallGenie__Event
		{

			private long? tmallFunctionId;

			private string thingTemplateKey;

			private string eventType;

			private string name;

			private string identifier;

			private string description;

			private List<QueryProductInfoForTmallGenie_Argument> outputData;

			private List<QueryProductInfoForTmallGenie_Tag2> tags1;

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

			public List<QueryProductInfoForTmallGenie_Argument> OutputData
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

			public List<QueryProductInfoForTmallGenie_Tag2> Tags1
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

			public class QueryProductInfoForTmallGenie_Argument
			{

				private long? id;

				private string dataType;

				private string identifier;

				private string name;

				private int? paraOrder;

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

			public class QueryProductInfoForTmallGenie_Tag2
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

		public class QueryProductInfoForTmallGenie_Service
		{

			private long? tmallFunctionId;

			private string thingTemplateKey;

			private string callType;

			private string name;

			private string identifier;

			private string description;

			private List<QueryProductInfoForTmallGenie_Argument4> inputParams;

			private List<QueryProductInfoForTmallGenie_Argument5> outputParams;

			private List<QueryProductInfoForTmallGenie_Tag6> tags3;

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

			public List<QueryProductInfoForTmallGenie_Argument4> InputParams
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

			public List<QueryProductInfoForTmallGenie_Argument5> OutputParams
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

			public List<QueryProductInfoForTmallGenie_Tag6> Tags3
			{
				get
				{
					return tags3;
				}
				set	
				{
					tags3 = value;
				}
			}

			public class QueryProductInfoForTmallGenie_Argument4
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

			public class QueryProductInfoForTmallGenie_Argument5
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

			public class QueryProductInfoForTmallGenie_Tag6
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

		public class QueryProductInfoForTmallGenie_ProductInfo
		{

			private string gmtCreate;

			private int? dataFormat;

			private string description;

			private int? nodeType;

			private string productKey;

			private string productName;

			private string brand;

			private string productModel;

			private string productSecret;

			private string categoryName;

			private string categoryKey;

			private string aliyunCommodityCode;

			private bool? id2;

			private string protocolType;

			private string productStatus;

			private long? scriptId;

			private bool? owner;

			private int? netType;

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public int? DataFormat
			{
				get
				{
					return dataFormat;
				}
				set	
				{
					dataFormat = value;
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

			public int? NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string Brand
			{
				get
				{
					return brand;
				}
				set	
				{
					brand = value;
				}
			}

			public string ProductModel
			{
				get
				{
					return productModel;
				}
				set	
				{
					productModel = value;
				}
			}

			public string ProductSecret
			{
				get
				{
					return productSecret;
				}
				set	
				{
					productSecret = value;
				}
			}

			public string CategoryName
			{
				get
				{
					return categoryName;
				}
				set	
				{
					categoryName = value;
				}
			}

			public string CategoryKey
			{
				get
				{
					return categoryKey;
				}
				set	
				{
					categoryKey = value;
				}
			}

			public string AliyunCommodityCode
			{
				get
				{
					return aliyunCommodityCode;
				}
				set	
				{
					aliyunCommodityCode = value;
				}
			}

			public bool? Id2
			{
				get
				{
					return id2;
				}
				set	
				{
					id2 = value;
				}
			}

			public string ProtocolType
			{
				get
				{
					return protocolType;
				}
				set	
				{
					protocolType = value;
				}
			}

			public string ProductStatus
			{
				get
				{
					return productStatus;
				}
				set	
				{
					productStatus = value;
				}
			}

			public long? ScriptId
			{
				get
				{
					return scriptId;
				}
				set	
				{
					scriptId = value;
				}
			}

			public bool? Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public int? NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
				}
			}
		}
	}
}
