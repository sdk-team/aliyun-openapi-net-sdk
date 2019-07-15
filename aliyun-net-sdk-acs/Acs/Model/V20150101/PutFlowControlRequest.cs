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
using Aliyun.Acs.Acs.Transform;
using Aliyun.Acs.Acs.Transform.V20150101;

namespace Aliyun.Acs.Acs.Model.V20150101
{
    public class PutFlowControlRequest : RoaAcsRequest<PutFlowControlResponse>
    {
        public PutFlowControlRequest()
            : base("Acs", "2015-01-01", "PutFlowControl", "12334", "openAPI")
        {
			UriPattern = "/FlowControl/[ProductName]/[VersionName]/[ApiName]";
			Method = MethodType.PUT;
        }

		private string bodyContent;

		private string apiName;

		private string productName;

		private string versionName;

		private string accept;

		public string BodyContent
		{
			get
			{
				return bodyContent;
			}
			set	
			{
				bodyContent = value;
				DictionaryUtil.Add(BodyParameters, "BodyContent", value);
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
				DictionaryUtil.Add(PathParameters, "ApiName", value);
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
				DictionaryUtil.Add(PathParameters, "ProductName", value);
			}
		}

		public string VersionName
		{
			get
			{
				return versionName;
			}
			set	
			{
				versionName = value;
				DictionaryUtil.Add(PathParameters, "VersionName", value);
			}
		}

		public string Accept
		{
			get
			{
				return accept;
			}
			set	
			{
				accept = value;
				DictionaryUtil.Add(Headers, "Accept", value);
			}
		}

        public override PutFlowControlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PutFlowControlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
