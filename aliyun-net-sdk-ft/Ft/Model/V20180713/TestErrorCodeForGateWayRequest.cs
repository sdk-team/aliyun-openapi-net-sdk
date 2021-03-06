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
    public class TestErrorCodeForGateWayRequest : RpcAcsRequest<TestErrorCodeForGateWayResponse>
    {
        public TestErrorCodeForGateWayRequest()
            : base("Ft", "2018-07-13", "TestErrorCodeForGateWay")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointRegionalType, null);
            }
        }

		private string httpStatusCode;

		private string code;

		private string success;

		private string message;

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

        public override TestErrorCodeForGateWayResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TestErrorCodeForGateWayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
