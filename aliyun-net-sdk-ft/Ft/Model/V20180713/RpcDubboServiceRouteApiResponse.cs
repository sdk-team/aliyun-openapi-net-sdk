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
	public class RpcDubboServiceRouteApiResponse : AcsResponse
	{

		private string age;

		private string checkNumberValue;

		private string code;

		private string defaultValue;

		private string enumValue;

		private string httpStatusCode;

		private string intValue;

		private string jsonListStrig;

		private string message;

		private string name;

		private string nullToEmptyValue;

		private string numberRange;

		private string regionId;

		private string requiredValue;

		private string resultSwitchValue;

		private string stringValue;

		private string success;

		private string switchValue;

		private string ak_mfa_present;

		private string app_ip;

		private string callerBid;

		private string callerParentId;

		private string callerType;

		private string callerUid;

		private string proxy_original_security_transport;

		private string proxy_original_source_ip;

		private string proxy_trust_transport_info;

		private string requestId;

		private string resourceOwnerId;

		private string security_transport;

		private List<RpcDubboServiceRouteApi_ArrayItem> arrayValue;

		private List<RpcDubboServiceRouteApi_L1ArrayItem> l1Array;

		private List<RpcDubboServiceRouteApi_ArrayItem> nullArrayValue;

		private RpcDubboServiceRouteApi_NullToEmptyStructValue nullToEmptyStructValue;

		private RpcDubboServiceRouteApi_StructValue structValue;

		public string Age
		{
			get
			{
				return age;
			}
			set	
			{
				age = value;
			}
		}

		public string CheckNumberValue
		{
			get
			{
				return checkNumberValue;
			}
			set	
			{
				checkNumberValue = value;
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

		public string DefaultValue
		{
			get
			{
				return defaultValue;
			}
			set	
			{
				defaultValue = value;
			}
		}

		public string EnumValue
		{
			get
			{
				return enumValue;
			}
			set	
			{
				enumValue = value;
			}
		}

		public string HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string IntValue
		{
			get
			{
				return intValue;
			}
			set	
			{
				intValue = value;
			}
		}

		public string JsonListStrig
		{
			get
			{
				return jsonListStrig;
			}
			set	
			{
				jsonListStrig = value;
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

		public string NullToEmptyValue
		{
			get
			{
				return nullToEmptyValue;
			}
			set	
			{
				nullToEmptyValue = value;
			}
		}

		public string NumberRange
		{
			get
			{
				return numberRange;
			}
			set	
			{
				numberRange = value;
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		public string RequiredValue
		{
			get
			{
				return requiredValue;
			}
			set	
			{
				requiredValue = value;
			}
		}

		public string ResultSwitchValue
		{
			get
			{
				return resultSwitchValue;
			}
			set	
			{
				resultSwitchValue = value;
			}
		}

		public string StringValue
		{
			get
			{
				return stringValue;
			}
			set	
			{
				stringValue = value;
			}
		}

		public string Success
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

		public string SwitchValue
		{
			get
			{
				return switchValue;
			}
			set	
			{
				switchValue = value;
			}
		}

		public string Ak_mfa_present
		{
			get
			{
				return ak_mfa_present;
			}
			set	
			{
				ak_mfa_present = value;
			}
		}

		public string App_ip
		{
			get
			{
				return app_ip;
			}
			set	
			{
				app_ip = value;
			}
		}

		public string CallerBid
		{
			get
			{
				return callerBid;
			}
			set	
			{
				callerBid = value;
			}
		}

		public string CallerParentId
		{
			get
			{
				return callerParentId;
			}
			set	
			{
				callerParentId = value;
			}
		}

		public string CallerType
		{
			get
			{
				return callerType;
			}
			set	
			{
				callerType = value;
			}
		}

		public string CallerUid
		{
			get
			{
				return callerUid;
			}
			set	
			{
				callerUid = value;
			}
		}

		public string Proxy_original_security_transport
		{
			get
			{
				return proxy_original_security_transport;
			}
			set	
			{
				proxy_original_security_transport = value;
			}
		}

		public string Proxy_original_source_ip
		{
			get
			{
				return proxy_original_source_ip;
			}
			set	
			{
				proxy_original_source_ip = value;
			}
		}

		public string Proxy_trust_transport_info
		{
			get
			{
				return proxy_trust_transport_info;
			}
			set	
			{
				proxy_trust_transport_info = value;
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

		public string ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
			}
		}

		public string Security_transport
		{
			get
			{
				return security_transport;
			}
			set	
			{
				security_transport = value;
			}
		}

		public List<RpcDubboServiceRouteApi_ArrayItem> ArrayValue
		{
			get
			{
				return arrayValue;
			}
			set	
			{
				arrayValue = value;
			}
		}

		public List<RpcDubboServiceRouteApi_L1ArrayItem> L1Array
		{
			get
			{
				return l1Array;
			}
			set	
			{
				l1Array = value;
			}
		}

		public List<RpcDubboServiceRouteApi_ArrayItem> NullArrayValue
		{
			get
			{
				return nullArrayValue;
			}
			set	
			{
				nullArrayValue = value;
			}
		}

		public RpcDubboServiceRouteApi_NullToEmptyStructValue NullToEmptyStructValue
		{
			get
			{
				return nullToEmptyStructValue;
			}
			set	
			{
				nullToEmptyStructValue = value;
			}
		}

		public RpcDubboServiceRouteApi_StructValue StructValue
		{
			get
			{
				return structValue;
			}
			set	
			{
				structValue = value;
			}
		}

		public class RpcDubboServiceRouteApi_ArrayItem
		{

			private string arrayChildValue;

			public string ArrayChildValue
			{
				get
				{
					return arrayChildValue;
				}
				set	
				{
					arrayChildValue = value;
				}
			}
		}

		public class RpcDubboServiceRouteApi_L1ArrayItem
		{

			private string l1Member1;

			private List<RpcDubboServiceRouteApi_L2ArrayItem> l2Array;

			private RpcDubboServiceRouteApi_L1Struct l1Struct;

			public string L1Member1
			{
				get
				{
					return l1Member1;
				}
				set	
				{
					l1Member1 = value;
				}
			}

			public List<RpcDubboServiceRouteApi_L2ArrayItem> L2Array
			{
				get
				{
					return l2Array;
				}
				set	
				{
					l2Array = value;
				}
			}

			public RpcDubboServiceRouteApi_L1Struct L1Struct
			{
				get
				{
					return l1Struct;
				}
				set	
				{
					l1Struct = value;
				}
			}

			public class RpcDubboServiceRouteApi_L2ArrayItem
			{

				private string l2Member1;

				private List<RpcDubboServiceRouteApi_L3ArrayItem> l3Array;

				public string L2Member1
				{
					get
					{
						return l2Member1;
					}
					set	
					{
						l2Member1 = value;
					}
				}

				public List<RpcDubboServiceRouteApi_L3ArrayItem> L3Array
				{
					get
					{
						return l3Array;
					}
					set	
					{
						l3Array = value;
					}
				}

				public class RpcDubboServiceRouteApi_L3ArrayItem
				{

					private string l3Member1;

					public string L3Member1
					{
						get
						{
							return l3Member1;
						}
						set	
						{
							l3Member1 = value;
						}
					}
				}
			}

			public class RpcDubboServiceRouteApi_L1Struct
			{

				private string l1StructMember;

				public string L1StructMember
				{
					get
					{
						return l1StructMember;
					}
					set	
					{
						l1StructMember = value;
					}
				}
			}
		}

		public class RpcDubboServiceRouteApi_NullToEmptyStructValue
		{

			private string nullToEmptyStructChildValue;

			public string NullToEmptyStructChildValue
			{
				get
				{
					return nullToEmptyStructChildValue;
				}
				set	
				{
					nullToEmptyStructChildValue = value;
				}
			}
		}

		public class RpcDubboServiceRouteApi_StructValue
		{

			private string structChildValue;

			public string StructChildValue
			{
				get
				{
					return structChildValue;
				}
				set	
				{
					structChildValue = value;
				}
			}
		}
	}
}
