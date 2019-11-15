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
using Aliyun.Acs.Ecs.Model.V20160314;

namespace Aliyun.Acs.Ecs.Transform.V20160314
{
    public class CreateOrderResponseUnmarshaller
    {
        public static CreateOrderResponse Unmarshall(UnmarshallerContext context)
        {
			CreateOrderResponse createOrderResponse = new CreateOrderResponse();

			createOrderResponse.HttpResponse = context.HttpResponse;
			createOrderResponse.RequestId = context.StringValue("CreateOrder.RequestId");
			createOrderResponse.OrderId = context.StringValue("CreateOrder.OrderId");

			List<string> createOrderResponse_orderParams = new List<string>();
			for (int i = 0; i < context.Length("CreateOrder.OrderParams.Length"); i++) {
				createOrderResponse_orderParams.Add(context.StringValue("CreateOrder.OrderParams["+ i +"]"));
			}
			createOrderResponse.OrderParams = createOrderResponse_orderParams;

			List<CreateOrderResponse.CreateOrder_RelatedOrderItemSet> createOrderResponse_relatedOrderItemSets = new List<CreateOrderResponse.CreateOrder_RelatedOrderItemSet>();
			for (int i = 0; i < context.Length("CreateOrder.RelatedOrderItemSets.Length"); i++) {
				CreateOrderResponse.CreateOrder_RelatedOrderItemSet relatedOrderItemSet = new CreateOrderResponse.CreateOrder_RelatedOrderItemSet();

				List<string> relatedOrderItemSet_instanceIdSet = new List<string>();
				for (int j = 0; j < context.Length("CreateOrder.RelatedOrderItemSets["+ i +"].InstanceIdSet.Length"); j++) {
					relatedOrderItemSet_instanceIdSet.Add(context.StringValue("CreateOrder.RelatedOrderItemSets["+ i +"].InstanceIdSet["+ j +"]"));
				}
				relatedOrderItemSet.InstanceIdSet = relatedOrderItemSet_instanceIdSet;

				List<string> relatedOrderItemSet_relatedOrderIds = new List<string>();
				for (int j = 0; j < context.Length("CreateOrder.RelatedOrderItemSets["+ i +"].RelatedOrderIds.Length"); j++) {
					relatedOrderItemSet_relatedOrderIds.Add(context.StringValue("CreateOrder.RelatedOrderItemSets["+ i +"].RelatedOrderIds["+ j +"]"));
				}
				relatedOrderItemSet.RelatedOrderIds = relatedOrderItemSet_relatedOrderIds;

				createOrderResponse_relatedOrderItemSets.Add(relatedOrderItemSet);
			}
			createOrderResponse.RelatedOrderItemSets = createOrderResponse_relatedOrderItemSets;
        
			return createOrderResponse;
        }
    }
}
