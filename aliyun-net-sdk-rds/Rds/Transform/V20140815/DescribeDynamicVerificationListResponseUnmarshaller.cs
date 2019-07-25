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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDynamicVerificationListResponseUnmarshaller
    {
        public static DescribeDynamicVerificationListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDynamicVerificationListResponse describeDynamicVerificationListResponse = new DescribeDynamicVerificationListResponse();

			describeDynamicVerificationListResponse.HttpResponse = context.HttpResponse;
			describeDynamicVerificationListResponse.RequestId = context.StringValue("DescribeDynamicVerificationList.RequestId");
			describeDynamicVerificationListResponse.ReplicaId = context.StringValue("DescribeDynamicVerificationList.ReplicaId");
			describeDynamicVerificationListResponse.PagNumber = context.IntegerValue("DescribeDynamicVerificationList.PagNumber");
			describeDynamicVerificationListResponse.PageRecordCount = context.IntegerValue("DescribeDynamicVerificationList.PageRecordCount");
			describeDynamicVerificationListResponse.TotalRecordCount = context.IntegerValue("DescribeDynamicVerificationList.TotalRecordCount");

			List<DescribeDynamicVerificationListResponse.DescribeDynamicVerificationList_ItemsItem> describeDynamicVerificationListResponse_items = new List<DescribeDynamicVerificationListResponse.DescribeDynamicVerificationList_ItemsItem>();
			for (int i = 0; i < context.Length("DescribeDynamicVerificationList.Items.Length"); i++) {
				DescribeDynamicVerificationListResponse.DescribeDynamicVerificationList_ItemsItem itemsItem = new DescribeDynamicVerificationListResponse.DescribeDynamicVerificationList_ItemsItem();
				itemsItem.InstanceIdA = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].InstanceIdA");
				itemsItem.InstanceIdB = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].InstanceIdB");
				itemsItem.Key = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].Key");
				itemsItem.KeyType = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].KeyType");
				itemsItem.InconsistentType = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].InconsistentType");
				itemsItem.OccurTime = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].OccurTime");
				itemsItem.Schema = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].Schema");

				List<DescribeDynamicVerificationListResponse.DescribeDynamicVerificationList_ItemsItem.DescribeDynamicVerificationList_InconsistentFiledsItem> itemsItem_inconsistentFileds = new List<DescribeDynamicVerificationListResponse.DescribeDynamicVerificationList_ItemsItem.DescribeDynamicVerificationList_InconsistentFiledsItem>();
				for (int j = 0; j < context.Length("DescribeDynamicVerificationList.Items["+ i +"].InconsistentFileds.Length"); j++) {
					DescribeDynamicVerificationListResponse.DescribeDynamicVerificationList_ItemsItem.DescribeDynamicVerificationList_InconsistentFiledsItem inconsistentFiledsItem = new DescribeDynamicVerificationListResponse.DescribeDynamicVerificationList_ItemsItem.DescribeDynamicVerificationList_InconsistentFiledsItem();
					inconsistentFiledsItem.Filed = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].InconsistentFileds["+ j +"].Filed");
					inconsistentFiledsItem.FiledInconsistentType = context.StringValue("DescribeDynamicVerificationList.Items["+ i +"].InconsistentFileds["+ j +"].FiledInconsistentType");

					itemsItem_inconsistentFileds.Add(inconsistentFiledsItem);
				}
				itemsItem.InconsistentFileds = itemsItem_inconsistentFileds;

				describeDynamicVerificationListResponse_items.Add(itemsItem);
			}
			describeDynamicVerificationListResponse.Items = describeDynamicVerificationListResponse_items;
        
			return describeDynamicVerificationListResponse;
        }
    }
}
