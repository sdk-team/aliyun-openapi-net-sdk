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
    public class GetTairDataRequest : RpcAcsRequest<GetTairDataResponse>
    {
        public GetTairDataRequest()
            : base("Ft", "2018-07-13", "GetTairData")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> keyss = new List<string>(){ };

		private string cacheName;

		public List<string> Keyss
		{
			get
			{
				return keyss;
			}

			set
			{
				keyss = value;
				for (int i = 0; i < keyss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Keys." + (i + 1) , keyss[i]);
				}
			}
		}

		public string CacheName
		{
			get
			{
				return cacheName;
			}
			set	
			{
				cacheName = value;
				DictionaryUtil.Add(QueryParameters, "CacheName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetTairDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetTairDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
