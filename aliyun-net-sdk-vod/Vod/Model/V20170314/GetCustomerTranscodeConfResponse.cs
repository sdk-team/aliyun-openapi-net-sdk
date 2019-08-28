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

namespace Aliyun.Acs.vod.Model.V20170314
{
	public class GetCustomerTranscodeConfResponse : AcsResponse
	{

		private string requestId;

		private List<GetCustomerTranscodeConf_Template> templates;

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

		public List<GetCustomerTranscodeConf_Template> Templates
		{
			get
			{
				return templates;
			}
			set	
			{
				templates = value;
			}
		}

		public class GetCustomerTranscodeConf_Template
		{

			private string id;

			private string customerId;

			private string templateId;

			private string mtstemplateId;

			private string status;

			private string name;

			private string encrypt;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string CustomerId
			{
				get
				{
					return customerId;
				}
				set	
				{
					customerId = value;
				}
			}

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public string MtstemplateId
			{
				get
				{
					return mtstemplateId;
				}
				set	
				{
					mtstemplateId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
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

			public string Encrypt
			{
				get
				{
					return encrypt;
				}
				set	
				{
					encrypt = value;
				}
			}
		}
	}
}
