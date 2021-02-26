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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ft;
using Aliyun.Acs.Ft.Transform;
using Aliyun.Acs.Ft.Transform.V20180713;

namespace Aliyun.Acs.Ft.Model.V20180713
{
    public class RpcDubboServiceRouteApiRequest : RpcAcsRequest<RpcDubboServiceRouteApiResponse>
    {
        public RpcDubboServiceRouteApiRequest()
            : base("Ft", "2018-07-13", "RpcDubboServiceRouteApi")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string requiredValue;

		private string code;

		private int? intValue;

		private bool? proxy_original_security_transport;

		private string resultSwitchValue;

		private string proxy_original_source_ip;

		private string jsonObject;

		private long? sleep;

		private string switchValue;

		private string jsonObjectList;

		private string defaultValue;

		private int? numberRange;

		private string message;

		private string checkNumberValue;

		private string httpStatusCode;

		private string stringValue;

		private int? enumValue;

		private string success;

		private string otherParam;

		public string RequiredValue
		{
			get
			{
				return requiredValue;
			}
			set	
			{
				requiredValue = value;
				DictionaryUtil.Add(QueryParameters, "RequiredValue", value);
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
				DictionaryUtil.Add(QueryParameters, "Code", value);
			}
		}

		public int? IntValue
		{
			get
			{
				return intValue;
			}
			set	
			{
				intValue = value;
				DictionaryUtil.Add(QueryParameters, "IntValue", value.ToString());
			}
		}

		public bool? Proxy_original_security_transport
		{
			get
			{
				return proxy_original_security_transport;
			}
			set	
			{
				proxy_original_security_transport = value;
				DictionaryUtil.Add(QueryParameters, "proxy_original_security_transport", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ResultSwitchValue", value);
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
				DictionaryUtil.Add(QueryParameters, "proxy_original_source_ip", value);
			}
		}

		public string JsonObject
		{
			get
			{
				return jsonObject;
			}
			set	
			{
				jsonObject = value;
				DictionaryUtil.Add(QueryParameters, "JsonObject", value);
			}
		}

		public long? Sleep
		{
			get
			{
				return sleep;
			}
			set	
			{
				sleep = value;
				DictionaryUtil.Add(QueryParameters, "Sleep", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "SwitchValue", value);
			}
		}

		public string JsonObjectList
		{
			get
			{
				return jsonObjectList;
			}
			set	
			{
				jsonObjectList = value;
				DictionaryUtil.Add(QueryParameters, "JsonObjectList", value);
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
				DictionaryUtil.Add(QueryParameters, "DefaultValue", value);
			}
		}

		public int? NumberRange
		{
			get
			{
				return numberRange;
			}
			set	
			{
				numberRange = value;
				DictionaryUtil.Add(QueryParameters, "NumberRange", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Message", value);
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
				DictionaryUtil.Add(QueryParameters, "CheckNumberValue", value);
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
				DictionaryUtil.Add(QueryParameters, "HttpStatusCode", value);
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
				DictionaryUtil.Add(QueryParameters, "StringValue", value);
			}
		}

		public int? EnumValue
		{
			get
			{
				return enumValue;
			}
			set	
			{
				enumValue = value;
				DictionaryUtil.Add(QueryParameters, "EnumValue", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Success", value);
			}
		}

		public string OtherParam
		{
			get
			{
				return otherParam;
			}
			set	
			{
				otherParam = value;
				DictionaryUtil.Add(QueryParameters, "OtherParam", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RpcDubboServiceRouteApiResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RpcDubboServiceRouteApiResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
