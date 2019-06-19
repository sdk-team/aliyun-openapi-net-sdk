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
using Aliyun.Acs.Aas.Model.V20150701;

namespace Aliyun.Acs.Aas.Transform.V20150701
{
    public class ListAliyunAccountResponseUnmarshaller
    {
        public static ListAliyunAccountResponse Unmarshall(UnmarshallerContext context)
        {
			ListAliyunAccountResponse listAliyunAccountResponse = new ListAliyunAccountResponse();

			listAliyunAccountResponse.HttpResponse = context.HttpResponse;
			listAliyunAccountResponse.RequestId = context.StringValue("ListAliyunAccount.RequestId");
			listAliyunAccountResponse.IsTruncated = context.BooleanValue("ListAliyunAccount.IsTruncated");
			listAliyunAccountResponse.Marker = context.StringValue("ListAliyunAccount.Marker");
			listAliyunAccountResponse.TotalAccount = context.IntegerValue("ListAliyunAccount.TotalAccount");
			listAliyunAccountResponse.HasNext = context.BooleanValue("ListAliyunAccount.HasNext");

			List<ListAliyunAccountResponse.ListAliyunAccount_Account> listAliyunAccountResponse_accounts = new List<ListAliyunAccountResponse.ListAliyunAccount_Account>();
			for (int i = 0; i < context.Length("ListAliyunAccount.Accounts.Length"); i++) {
				ListAliyunAccountResponse.ListAliyunAccount_Account account = new ListAliyunAccountResponse.ListAliyunAccount_Account();
				account.PK = context.StringValue("ListAliyunAccount.Accounts["+ i +"].PK");
				account.LastLoginDate = context.StringValue("ListAliyunAccount.Accounts["+ i +"].LastLoginDate");
				account.AccountStatus = context.StringValue("ListAliyunAccount.Accounts["+ i +"].AccountStatus");
				account.AliyunId = context.StringValue("ListAliyunAccount.Accounts["+ i +"].AliyunId");

				listAliyunAccountResponse_accounts.Add(account);
			}
			listAliyunAccountResponse.Accounts = listAliyunAccountResponse_accounts;
        
			return listAliyunAccountResponse;
        }
    }
}
