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
	public class DescribeResourceTypeResponse : AcsResponse
	{

		private string requestId;

		private string product;

		private string resourceTypeCode;

		private string resourceTypeVersion;

		private string title;

		private string uniqueIdentifier;

		private string description;

		private string resourceIdField;

		private string definitions;

		private List<DescribeResourceType_State> states;

		private DescribeResourceType_Schema schema;

		private DescribeResourceType_OperationAPI operationAPI;

		private DescribeResourceType_ResourceTypeAttributeMappings resourceTypeAttributeMappings;

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

		public string ResourceTypeCode
		{
			get
			{
				return resourceTypeCode;
			}
			set	
			{
				resourceTypeCode = value;
			}
		}

		public string ResourceTypeVersion
		{
			get
			{
				return resourceTypeVersion;
			}
			set	
			{
				resourceTypeVersion = value;
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

		public string UniqueIdentifier
		{
			get
			{
				return uniqueIdentifier;
			}
			set	
			{
				uniqueIdentifier = value;
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

		public string ResourceIdField
		{
			get
			{
				return resourceIdField;
			}
			set	
			{
				resourceIdField = value;
			}
		}

		public string Definitions
		{
			get
			{
				return definitions;
			}
			set	
			{
				definitions = value;
			}
		}

		public List<DescribeResourceType_State> States
		{
			get
			{
				return states;
			}
			set	
			{
				states = value;
			}
		}

		public DescribeResourceType_Schema Schema
		{
			get
			{
				return schema;
			}
			set	
			{
				schema = value;
			}
		}

		public DescribeResourceType_OperationAPI OperationAPI
		{
			get
			{
				return operationAPI;
			}
			set	
			{
				operationAPI = value;
			}
		}

		public DescribeResourceType_ResourceTypeAttributeMappings ResourceTypeAttributeMappings
		{
			get
			{
				return resourceTypeAttributeMappings;
			}
			set	
			{
				resourceTypeAttributeMappings = value;
			}
		}

		public class DescribeResourceType_State
		{

			private string code;

			private string description;

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
		}

		public class DescribeResourceType_Schema
		{

			private string _ref;

			private string title;

			private string type;

			private string description;

			private string properties;

			private string itemName;

			private string items;

			public string _Ref
			{
				get
				{
					return _ref;
				}
				set	
				{
					_ref = value;
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

			public string Properties
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

			public string ItemName
			{
				get
				{
					return itemName;
				}
				set	
				{
					itemName = value;
				}
			}

			public string Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}
		}

		public class DescribeResourceType_OperationAPI
		{

			private List<DescribeResourceType_APIIdentity> createAPIs;

			private List<DescribeResourceType_APIIdentity> getAPIs;

			private List<DescribeResourceType_APIIdentity> listAPIs;

			private List<DescribeResourceType_APIIdentity> updateAPIs;

			private List<DescribeResourceType_APIIdentity> deleteAPIs;

			private List<DescribeResourceType_APIIdentity> establishRelationAPIs;

			private List<DescribeResourceType_APIIdentity> destroyRelationAPIs;

			public List<DescribeResourceType_APIIdentity> CreateAPIs
			{
				get
				{
					return createAPIs;
				}
				set	
				{
					createAPIs = value;
				}
			}

			public List<DescribeResourceType_APIIdentity> GetAPIs
			{
				get
				{
					return getAPIs;
				}
				set	
				{
					getAPIs = value;
				}
			}

			public List<DescribeResourceType_APIIdentity> ListAPIs
			{
				get
				{
					return listAPIs;
				}
				set	
				{
					listAPIs = value;
				}
			}

			public List<DescribeResourceType_APIIdentity> UpdateAPIs
			{
				get
				{
					return updateAPIs;
				}
				set	
				{
					updateAPIs = value;
				}
			}

			public List<DescribeResourceType_APIIdentity> DeleteAPIs
			{
				get
				{
					return deleteAPIs;
				}
				set	
				{
					deleteAPIs = value;
				}
			}

			public List<DescribeResourceType_APIIdentity> EstablishRelationAPIs
			{
				get
				{
					return establishRelationAPIs;
				}
				set	
				{
					establishRelationAPIs = value;
				}
			}

			public List<DescribeResourceType_APIIdentity> DestroyRelationAPIs
			{
				get
				{
					return destroyRelationAPIs;
				}
				set	
				{
					destroyRelationAPIs = value;
				}
			}

			public class DescribeResourceType_APIIdentity
			{

				private string aPIGroup;

				private string aPIVersion;

				private string aPIName;

				public string APIGroup
				{
					get
					{
						return aPIGroup;
					}
					set	
					{
						aPIGroup = value;
					}
				}

				public string APIVersion
				{
					get
					{
						return aPIVersion;
					}
					set	
					{
						aPIVersion = value;
					}
				}

				public string APIName
				{
					get
					{
						return aPIName;
					}
					set	
					{
						aPIName = value;
					}
				}
			}
		}

		public class DescribeResourceType_ResourceTypeAttributeMappings
		{

			private string prePaidValue;

			private string enableAttributeMapping;

			private DescribeResourceType_OperationGet operationGet;

			public string PrePaidValue
			{
				get
				{
					return prePaidValue;
				}
				set	
				{
					prePaidValue = value;
				}
			}

			public string EnableAttributeMapping
			{
				get
				{
					return enableAttributeMapping;
				}
				set	
				{
					enableAttributeMapping = value;
				}
			}

			public DescribeResourceType_OperationGet OperationGet
			{
				get
				{
					return operationGet;
				}
				set	
				{
					operationGet = value;
				}
			}

			public class DescribeResourceType_OperationGet
			{

				private List<DescribeResourceType_ResourceTypeOperationDetail> apiInfos;

				public List<DescribeResourceType_ResourceTypeOperationDetail> ApiInfos
				{
					get
					{
						return apiInfos;
					}
					set	
					{
						apiInfos = value;
					}
				}

				public class DescribeResourceType_ResourceTypeOperationDetail
				{

					private string gatewaySource;

					private string gatewayProduct;

					private string gatewayVersion;

					private string apiName;

					private string attributeAsyncDetections;

					private DescribeResourceType_RequiredAttributeMappings requiredAttributeMappings;

					public string GatewaySource
					{
						get
						{
							return gatewaySource;
						}
						set	
						{
							gatewaySource = value;
						}
					}

					public string GatewayProduct
					{
						get
						{
							return gatewayProduct;
						}
						set	
						{
							gatewayProduct = value;
						}
					}

					public string GatewayVersion
					{
						get
						{
							return gatewayVersion;
						}
						set	
						{
							gatewayVersion = value;
						}
					}

					public string ApiName
					{
						get
						{
							return apiName;
						}
						set	
						{
							apiName = value;
						}
					}

					public string AttributeAsyncDetections
					{
						get
						{
							return attributeAsyncDetections;
						}
						set	
						{
							attributeAsyncDetections = value;
						}
					}

					public DescribeResourceType_RequiredAttributeMappings RequiredAttributeMappings
					{
						get
						{
							return requiredAttributeMappings;
						}
						set	
						{
							requiredAttributeMappings = value;
						}
					}

					public class DescribeResourceType_RequiredAttributeMappings
					{

						private string idMappings;

						public string IdMappings
						{
							get
							{
								return idMappings;
							}
							set	
							{
								idMappings = value;
							}
						}
					}
				}
			}
		}
	}
}
