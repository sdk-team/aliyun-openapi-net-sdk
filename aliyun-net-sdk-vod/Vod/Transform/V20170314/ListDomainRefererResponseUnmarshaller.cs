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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170314;

namespace Aliyun.Acs.vod.Transform.V20170314
{
    public class ListDomainRefererResponseUnmarshaller
    {
        public static ListDomainRefererResponse Unmarshall(UnmarshallerContext context)
        {
			ListDomainRefererResponse listDomainRefererResponse = new ListDomainRefererResponse();

			listDomainRefererResponse.HttpResponse = context.HttpResponse;
			listDomainRefererResponse.RequestId = context.StringValue("ListDomainReferer.RequestId");
			listDomainRefererResponse.Total = context.IntegerValue("ListDomainReferer.Total");
			listDomainRefererResponse.AllowEmpty = context.StringValue("ListDomainReferer.AllowEmpty");

			List<ListDomainRefererResponse.ListDomainReferer_RefererItem> listDomainRefererResponse_refererList = new List<ListDomainRefererResponse.ListDomainReferer_RefererItem>();
			for (int i = 0; i < context.Length("ListDomainReferer.RefererList.Length"); i++) {
				ListDomainRefererResponse.ListDomainReferer_RefererItem refererItem = new ListDomainRefererResponse.ListDomainReferer_RefererItem();
				refererItem.RefererId = context.LongValue("ListDomainReferer.RefererList["+ i +"].RefererId");
				refererItem.Referer = context.StringValue("ListDomainReferer.RefererList["+ i +"].Referer");
				refererItem.CreateTime = context.StringValue("ListDomainReferer.RefererList["+ i +"].CreateTime");

				listDomainRefererResponse_refererList.Add(refererItem);
			}
			listDomainRefererResponse.RefererList = listDomainRefererResponse_refererList;
        
			return listDomainRefererResponse;
        }
    }
}
