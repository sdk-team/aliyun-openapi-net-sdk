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
using Aliyun.Acs.cr.Transform;
using Aliyun.Acs.cr.Transform.V20150506;

namespace Aliyun.Acs.cr.Model.V20150506
{
    public class DoPhysicalDeleteResourceRequest : RpcAcsRequest<DoPhysicalDeleteResourceResponse>
    {
        public DoPhysicalDeleteResourceRequest()
            : base("cr", "2015-05-06", "DoPhysicalDeleteResource", "cr", "openAPI")
        {
        }

		private string country;

		private long? hid;

		private bool? success;

		private bool? interrupt;

		private string gmtWakeup;

		private string pk;

		private string invoker;

		private string bid;

		private string message;

		private string taskExtraData;

		private string taskIdentifier;

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

		public long? Hid
		{
			get
			{
				return hid;
			}
			set	
			{
				hid = value;
				DictionaryUtil.Add(QueryParameters, "Hid", value.ToString());
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
				DictionaryUtil.Add(QueryParameters, "Success", value.ToString());
			}
		}

		public bool? Interrupt
		{
			get
			{
				return interrupt;
			}
			set	
			{
				interrupt = value;
				DictionaryUtil.Add(QueryParameters, "Interrupt", value.ToString());
			}
		}

		public string GmtWakeup
		{
			get
			{
				return gmtWakeup;
			}
			set	
			{
				gmtWakeup = value;
				DictionaryUtil.Add(QueryParameters, "GmtWakeup", value);
			}
		}

		public string Pk
		{
			get
			{
				return pk;
			}
			set	
			{
				pk = value;
				DictionaryUtil.Add(QueryParameters, "Pk", value);
			}
		}

		public string Invoker
		{
			get
			{
				return invoker;
			}
			set	
			{
				invoker = value;
				DictionaryUtil.Add(QueryParameters, "Invoker", value);
			}
		}

		public string Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "Bid", value);
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

		public string TaskExtraData
		{
			get
			{
				return taskExtraData;
			}
			set	
			{
				taskExtraData = value;
				DictionaryUtil.Add(QueryParameters, "TaskExtraData", value);
			}
		}

		public string TaskIdentifier
		{
			get
			{
				return taskIdentifier;
			}
			set	
			{
				taskIdentifier = value;
				DictionaryUtil.Add(QueryParameters, "TaskIdentifier", value);
			}
		}

        public override DoPhysicalDeleteResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DoPhysicalDeleteResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
