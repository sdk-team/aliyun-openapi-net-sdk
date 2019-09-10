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
    public class DataCleanSyncDeviceUnbindRequest : RpcAcsRequest<DataCleanSyncDeviceUnbindResponse>
    {
        public DataCleanSyncDeviceUnbindRequest()
            : base("Iot", "2019-07-30", "DataCleanSyncDeviceUnbind", "Iot", "openAPI")
        {
        }

		private string taobaoId;

		private string productKey;

		private string iotId;

		private string appkey;

		private string deviceName;

		private string from;

		public string TaobaoId
		{
			get
			{
				return taobaoId;
			}
			set	
			{
				taobaoId = value;
				DictionaryUtil.Add(QueryParameters, "TaobaoId", value);
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
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(QueryParameters, "IotId", value);
			}
		}

		public string Appkey
		{
			get
			{
				return appkey;
			}
			set	
			{
				appkey = value;
				DictionaryUtil.Add(QueryParameters, "Appkey", value);
			}
		}

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(QueryParameters, "DeviceName", value);
			}
		}

		public string From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value);
			}
		}

        public override DataCleanSyncDeviceUnbindResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DataCleanSyncDeviceUnbindResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
