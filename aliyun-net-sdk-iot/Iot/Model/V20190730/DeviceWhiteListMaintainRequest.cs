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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20190730;

namespace Aliyun.Acs.Iot.Model.V20190730
{
    public class DeviceWhiteListMaintainRequest : RpcAcsRequest<DeviceWhiteListMaintainResponse>
    {
        public DeviceWhiteListMaintainRequest()
            : base("Iot", "2019-07-30", "DeviceWhiteListMaintain", "Iot", "openAPI")
        {
        }

		private string actionType;

		private string manufacture;

		private string iotInstanceId;

		private List<Device> devices;

		public string ActionType
		{
			get
			{
				return actionType;
			}
			set	
			{
				actionType = value;
				DictionaryUtil.Add(QueryParameters, "ActionType", value);
			}
		}

		public string Manufacture
		{
			get
			{
				return manufacture;
			}
			set	
			{
				manufacture = value;
				DictionaryUtil.Add(QueryParameters, "Manufacture", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public List<Device> Devices
		{
			get
			{
				return devices;
			}

			set
			{
				devices = value;
				for (int i = 0; i < devices.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Device." + (i + 1) + ".Secret", devices[i].Secret);
					DictionaryUtil.Add(BodyParameters,"Device." + (i + 1) + ".Mac", devices[i].Mac);
				}
			}
		}

		public class Device
		{

			private string secret;

			private string mac;

			public string Secret
			{
				get
				{
					return secret;
				}
				set	
				{
					secret = value;
				}
			}

			public string Mac
			{
				get
				{
					return mac;
				}
				set	
				{
					mac = value;
				}
			}
		}

        public override DeviceWhiteListMaintainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeviceWhiteListMaintainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
