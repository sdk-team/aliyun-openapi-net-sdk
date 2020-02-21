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
using Aliyun.Acs.Iot;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20190730;

namespace Aliyun.Acs.Iot.Model.V20190730
{
    public class GetDeviceApplyStatusForTmallGenieRequest : RpcAcsRequest<GetDeviceApplyStatusForTmallGenieResponse>
    {
        public GetDeviceApplyStatusForTmallGenieRequest()
            : base("Iot", "2019-07-30", "GetDeviceApplyStatusForTmallGenie")
        {
        }

		private string productKey;

		private List<string> applyIds = new List<string>(){ };

		private string apiProduct;

		private string apiRevision;

		private string fileFormat;

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

		public List<string> ApplyIds
		{
			get
			{
				return applyIds;
			}

			set
			{
				applyIds = value;
				for (int i = 0; i < applyIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ApplyId." + (i + 1) , applyIds[i]);
				}
			}
		}

		public string ApiProduct
		{
			get
			{
				return apiProduct;
			}
			set	
			{
				apiProduct = value;
				DictionaryUtil.Add(BodyParameters, "ApiProduct", value);
			}
		}

		public string ApiRevision
		{
			get
			{
				return apiRevision;
			}
			set	
			{
				apiRevision = value;
				DictionaryUtil.Add(BodyParameters, "ApiRevision", value);
			}
		}

		public string FileFormat
		{
			get
			{
				return fileFormat;
			}
			set	
			{
				fileFormat = value;
				DictionaryUtil.Add(QueryParameters, "FileFormat", value);
			}
		}

        public override GetDeviceApplyStatusForTmallGenieResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetDeviceApplyStatusForTmallGenieResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
