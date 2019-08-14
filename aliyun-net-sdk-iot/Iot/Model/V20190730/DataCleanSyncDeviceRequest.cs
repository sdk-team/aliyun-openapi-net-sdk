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
    public class DataCleanSyncDeviceRequest : RpcAcsRequest<DataCleanSyncDeviceResponse>
    {
        public DataCleanSyncDeviceRequest()
            : base("Iot", "2019-07-30", "DataCleanSyncDevice", "Iot", "openAPI")
        {
        }

		private string resourceGroupId;

		private string iotInstanceId;

		private List<SyncDeviceInfos> syncDeviceInfoss;

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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

		public List<SyncDeviceInfos> SyncDeviceInfoss
		{
			get
			{
				return syncDeviceInfoss;
			}

			set
			{
				syncDeviceInfoss = value;
				for (int i = 0; i < syncDeviceInfoss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SyncDeviceInfos." + (i + 1) + ".ActiveTime", syncDeviceInfoss[i].ActiveTime);
					DictionaryUtil.Add(QueryParameters,"SyncDeviceInfos." + (i + 1) + ".FirmVersion", syncDeviceInfoss[i].FirmVersion);
					DictionaryUtil.Add(QueryParameters,"SyncDeviceInfos." + (i + 1) + ".Name", syncDeviceInfoss[i].Name);
					DictionaryUtil.Add(QueryParameters,"SyncDeviceInfos." + (i + 1) + ".DeviceSecret", syncDeviceInfoss[i].DeviceSecret);
					DictionaryUtil.Add(QueryParameters,"SyncDeviceInfos." + (i + 1) + ".ActionStr", syncDeviceInfoss[i].ActionStr);
					DictionaryUtil.Add(QueryParameters,"SyncDeviceInfos." + (i + 1) + ".ProductKey", syncDeviceInfoss[i].ProductKey);
					DictionaryUtil.Add(QueryParameters,"SyncDeviceInfos." + (i + 1) + ".DeviceType", syncDeviceInfoss[i].DeviceType);
				}
			}
		}

		public class SyncDeviceInfos
		{

			private long? activeTime;

			private string firmVersion;

			private string name;

			private string deviceSecret;

			private string actionStr;

			private string productKey;

			private int? deviceType;

			public long? ActiveTime
			{
				get
				{
					return activeTime;
				}
				set	
				{
					activeTime = value;
				}
			}

			public string FirmVersion
			{
				get
				{
					return firmVersion;
				}
				set	
				{
					firmVersion = value;
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

			public string DeviceSecret
			{
				get
				{
					return deviceSecret;
				}
				set	
				{
					deviceSecret = value;
				}
			}

			public string ActionStr
			{
				get
				{
					return actionStr;
				}
				set	
				{
					actionStr = value;
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

			public int? DeviceType
			{
				get
				{
					return deviceType;
				}
				set	
				{
					deviceType = value;
				}
			}
		}

        public override DataCleanSyncDeviceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DataCleanSyncDeviceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
