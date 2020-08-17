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
using Aliyun.Acs.SDK;
using Aliyun.Acs.SDK.Transform;
using Aliyun.Acs.SDK.Transform.V20180101;

namespace Aliyun.Acs.SDK.Model.V20180101
{
    public class DemoRequest : RoaAcsRequest<DemoResponse>
    {
        public DemoRequest()
            : base("SDK", "2018-01-01", "Demo")
        {
			UriPattern = "/helloworld";
			Method = MethodType.POST;
        }

		private string price;

		private string name;

		private List<ContentList> contentLists = new List<ContentList>(){ };

		public string Price
		{
			get
			{
				return price;
			}
			set	
			{
				price = value;
				DictionaryUtil.Add(QueryParameters, "Price", value);
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public List<ContentList> ContentLists
		{
			get
			{
				return contentLists;
			}

			set
			{
				contentLists = value;
				for (int i = 0; i < contentLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ContentList." + (i + 1) + ".Tag", contentLists[i].Tag);
					for (int j = 0; j < contentLists[i].Letterss.Count; j++)
					{
						DictionaryUtil.Add(BodyParameters,"ContentList." + (i + 1) + ".Letters." +(j + 1), contentLists[i].Letterss[j]);
					}
				}
			}
		}

		public class ContentList
		{

			private string tag;

			private List<string> letterss = new List<string>(){ };

			public string Tag
			{
				get
				{
					return tag;
				}
				set	
				{
					tag = value;
				}
			}

			public List<string> Letterss
			{
				get
				{
					return letterss;
				}
				set	
				{
					letterss = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DemoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DemoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
