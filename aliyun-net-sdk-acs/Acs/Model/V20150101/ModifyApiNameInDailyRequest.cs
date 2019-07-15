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
    public class ModifyApiNameInDailyRequest : RoaAcsRequest<ModifyApiNameInDailyResponse>
    {
        public ModifyApiNameInDailyRequest()
            : base("Acs", "2015-01-01", "ModifyApiNameInDaily", "12334", "openAPI")
        {
			UriPattern = "/modifyApiNameInDaily";
			Method = MethodType.POST;
        }

		private string modifyName;

		private string name;

		private string productName;

		private string changeId;

		private string versionName;

		public string ModifyName
		{
			get
			{
				return modifyName;
			}
			set	
			{
				modifyName = value;
				DictionaryUtil.Add(QueryParameters, "ModifyName", value);
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
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
				DictionaryUtil.Add(QueryParameters, "ProductName", value);
			}
		}

		public string ChangeId
		{
			get
			{
				return changeId;
			}
			set	
			{
				changeId = value;
				DictionaryUtil.Add(QueryParameters, "ChangeId", value);
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
				DictionaryUtil.Add(QueryParameters, "VersionName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyApiNameInDailyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyApiNameInDailyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
