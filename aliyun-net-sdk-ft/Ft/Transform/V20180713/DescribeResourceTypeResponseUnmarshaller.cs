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
using Aliyun.Acs.Ft.Model.V20180713;

namespace Aliyun.Acs.Ft.Transform.V20180713
{
    public class DescribeResourceTypeResponseUnmarshaller
    {
        public static DescribeResourceTypeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResourceTypeResponse describeResourceTypeResponse = new DescribeResourceTypeResponse();

			describeResourceTypeResponse.HttpResponse = context.HttpResponse;
			describeResourceTypeResponse.RequestId = context.StringValue("DescribeResourceType.RequestId");
			describeResourceTypeResponse.Product = context.StringValue("DescribeResourceType.Product");
			describeResourceTypeResponse.ResourceTypeCode = context.StringValue("DescribeResourceType.ResourceTypeCode");
			describeResourceTypeResponse.ResourceTypeVersion = context.StringValue("DescribeResourceType.ResourceTypeVersion");
			describeResourceTypeResponse.Title = context.StringValue("DescribeResourceType.Title");
			describeResourceTypeResponse.UniqueIdentifier = context.StringValue("DescribeResourceType.UniqueIdentifier");
			describeResourceTypeResponse.Description = context.StringValue("DescribeResourceType.Description");
			describeResourceTypeResponse.ResourceIdField = context.StringValue("DescribeResourceType.ResourceIdField");
			describeResourceTypeResponse.Definitions = context.StringValue("DescribeResourceType.Definitions");

			DescribeResourceTypeResponse.DescribeResourceType_Schema schema = new DescribeResourceTypeResponse.DescribeResourceType_Schema();
			schema._Ref = context.StringValue("DescribeResourceType.Schema.Ref");
			schema.Title = context.StringValue("DescribeResourceType.Schema.Title");
			schema.Type = context.StringValue("DescribeResourceType.Schema.Type");
			schema.Description = context.StringValue("DescribeResourceType.Schema.Description");
			schema.Properties = context.StringValue("DescribeResourceType.Schema.Properties");
			schema.ItemName = context.StringValue("DescribeResourceType.Schema.ItemName");
			schema.Items = context.StringValue("DescribeResourceType.Schema.Items");
			describeResourceTypeResponse.Schema = schema;

			DescribeResourceTypeResponse.DescribeResourceType_OperationAPI operationAPI = new DescribeResourceTypeResponse.DescribeResourceType_OperationAPI();

			List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity> operationAPI_createAPIs = new List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity>();
			for (int i = 0; i < context.Length("DescribeResourceType.OperationAPI.CreateAPIs.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity aPIIdentity = new DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity();
				aPIIdentity.APIGroup = context.StringValue("DescribeResourceType.OperationAPI.CreateAPIs["+ i +"].APIGroup");
				aPIIdentity.APIVersion = context.StringValue("DescribeResourceType.OperationAPI.CreateAPIs["+ i +"].APIVersion");
				aPIIdentity.APIName = context.StringValue("DescribeResourceType.OperationAPI.CreateAPIs["+ i +"].APIName");

				operationAPI_createAPIs.Add(aPIIdentity);
			}
			operationAPI.CreateAPIs = operationAPI_createAPIs;

			List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity> operationAPI_getAPIs = new List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity>();
			for (int i = 0; i < context.Length("DescribeResourceType.OperationAPI.GetAPIs.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity aPIIdentity = new DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity();
				aPIIdentity.APIGroup = context.StringValue("DescribeResourceType.OperationAPI.GetAPIs["+ i +"].APIGroup");
				aPIIdentity.APIVersion = context.StringValue("DescribeResourceType.OperationAPI.GetAPIs["+ i +"].APIVersion");
				aPIIdentity.APIName = context.StringValue("DescribeResourceType.OperationAPI.GetAPIs["+ i +"].APIName");

				operationAPI_getAPIs.Add(aPIIdentity);
			}
			operationAPI.GetAPIs = operationAPI_getAPIs;

			List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity> operationAPI_listAPIs = new List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity>();
			for (int i = 0; i < context.Length("DescribeResourceType.OperationAPI.ListAPIs.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity aPIIdentity = new DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity();
				aPIIdentity.APIGroup = context.StringValue("DescribeResourceType.OperationAPI.ListAPIs["+ i +"].APIGroup");
				aPIIdentity.APIVersion = context.StringValue("DescribeResourceType.OperationAPI.ListAPIs["+ i +"].APIVersion");
				aPIIdentity.APIName = context.StringValue("DescribeResourceType.OperationAPI.ListAPIs["+ i +"].APIName");

				operationAPI_listAPIs.Add(aPIIdentity);
			}
			operationAPI.ListAPIs = operationAPI_listAPIs;

			List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity> operationAPI_updateAPIs = new List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity>();
			for (int i = 0; i < context.Length("DescribeResourceType.OperationAPI.UpdateAPIs.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity aPIIdentity = new DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity();
				aPIIdentity.APIGroup = context.StringValue("DescribeResourceType.OperationAPI.UpdateAPIs["+ i +"].APIGroup");
				aPIIdentity.APIVersion = context.StringValue("DescribeResourceType.OperationAPI.UpdateAPIs["+ i +"].APIVersion");
				aPIIdentity.APIName = context.StringValue("DescribeResourceType.OperationAPI.UpdateAPIs["+ i +"].APIName");

				operationAPI_updateAPIs.Add(aPIIdentity);
			}
			operationAPI.UpdateAPIs = operationAPI_updateAPIs;

			List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity> operationAPI_deleteAPIs = new List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity>();
			for (int i = 0; i < context.Length("DescribeResourceType.OperationAPI.DeleteAPIs.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity aPIIdentity = new DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity();
				aPIIdentity.APIGroup = context.StringValue("DescribeResourceType.OperationAPI.DeleteAPIs["+ i +"].APIGroup");
				aPIIdentity.APIVersion = context.StringValue("DescribeResourceType.OperationAPI.DeleteAPIs["+ i +"].APIVersion");
				aPIIdentity.APIName = context.StringValue("DescribeResourceType.OperationAPI.DeleteAPIs["+ i +"].APIName");

				operationAPI_deleteAPIs.Add(aPIIdentity);
			}
			operationAPI.DeleteAPIs = operationAPI_deleteAPIs;

			List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity> operationAPI_establishRelationAPIs = new List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity>();
			for (int i = 0; i < context.Length("DescribeResourceType.OperationAPI.EstablishRelationAPIs.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity aPIIdentity = new DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity();
				aPIIdentity.APIGroup = context.StringValue("DescribeResourceType.OperationAPI.EstablishRelationAPIs["+ i +"].APIGroup");
				aPIIdentity.APIVersion = context.StringValue("DescribeResourceType.OperationAPI.EstablishRelationAPIs["+ i +"].APIVersion");
				aPIIdentity.APIName = context.StringValue("DescribeResourceType.OperationAPI.EstablishRelationAPIs["+ i +"].APIName");

				operationAPI_establishRelationAPIs.Add(aPIIdentity);
			}
			operationAPI.EstablishRelationAPIs = operationAPI_establishRelationAPIs;

			List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity> operationAPI_destroyRelationAPIs = new List<DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity>();
			for (int i = 0; i < context.Length("DescribeResourceType.OperationAPI.DestroyRelationAPIs.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity aPIIdentity = new DescribeResourceTypeResponse.DescribeResourceType_OperationAPI.DescribeResourceType_APIIdentity();
				aPIIdentity.APIGroup = context.StringValue("DescribeResourceType.OperationAPI.DestroyRelationAPIs["+ i +"].APIGroup");
				aPIIdentity.APIVersion = context.StringValue("DescribeResourceType.OperationAPI.DestroyRelationAPIs["+ i +"].APIVersion");
				aPIIdentity.APIName = context.StringValue("DescribeResourceType.OperationAPI.DestroyRelationAPIs["+ i +"].APIName");

				operationAPI_destroyRelationAPIs.Add(aPIIdentity);
			}
			operationAPI.DestroyRelationAPIs = operationAPI_destroyRelationAPIs;
			describeResourceTypeResponse.OperationAPI = operationAPI;

			DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings resourceTypeAttributeMappings = new DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings();
			resourceTypeAttributeMappings.PrePaidValue = context.StringValue("DescribeResourceType.ResourceTypeAttributeMappings.PrePaidValue");
			resourceTypeAttributeMappings.EnableAttributeMapping = context.StringValue("DescribeResourceType.ResourceTypeAttributeMappings.EnableAttributeMapping");

			DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings.DescribeResourceType_OperationGet operationGet = new DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings.DescribeResourceType_OperationGet();

			List<DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings.DescribeResourceType_OperationGet.DescribeResourceType_ResourceTypeOperationDetail> operationGet_apiInfos = new List<DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings.DescribeResourceType_OperationGet.DescribeResourceType_ResourceTypeOperationDetail>();
			for (int i = 0; i < context.Length("DescribeResourceType.ResourceTypeAttributeMappings.OperationGet.ApiInfos.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings.DescribeResourceType_OperationGet.DescribeResourceType_ResourceTypeOperationDetail resourceTypeOperationDetail = new DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings.DescribeResourceType_OperationGet.DescribeResourceType_ResourceTypeOperationDetail();
				resourceTypeOperationDetail.GatewaySource = context.StringValue("DescribeResourceType.ResourceTypeAttributeMappings.OperationGet.ApiInfos["+ i +"].GatewaySource");
				resourceTypeOperationDetail.GatewayProduct = context.StringValue("DescribeResourceType.ResourceTypeAttributeMappings.OperationGet.ApiInfos["+ i +"].GatewayProduct");
				resourceTypeOperationDetail.GatewayVersion = context.StringValue("DescribeResourceType.ResourceTypeAttributeMappings.OperationGet.ApiInfos["+ i +"].GatewayVersion");
				resourceTypeOperationDetail.ApiName = context.StringValue("DescribeResourceType.ResourceTypeAttributeMappings.OperationGet.ApiInfos["+ i +"].ApiName");
				resourceTypeOperationDetail.AttributeAsyncDetections = context.StringValue("DescribeResourceType.ResourceTypeAttributeMappings.OperationGet.ApiInfos["+ i +"].AttributeAsyncDetections");

				DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings.DescribeResourceType_OperationGet.DescribeResourceType_ResourceTypeOperationDetail.DescribeResourceType_RequiredAttributeMappings requiredAttributeMappings = new DescribeResourceTypeResponse.DescribeResourceType_ResourceTypeAttributeMappings.DescribeResourceType_OperationGet.DescribeResourceType_ResourceTypeOperationDetail.DescribeResourceType_RequiredAttributeMappings();
				requiredAttributeMappings.IdMappings = context.StringValue("DescribeResourceType.ResourceTypeAttributeMappings.OperationGet.ApiInfos["+ i +"].RequiredAttributeMappings.IdMappings");
				resourceTypeOperationDetail.RequiredAttributeMappings = requiredAttributeMappings;

				operationGet_apiInfos.Add(resourceTypeOperationDetail);
			}
			operationGet.ApiInfos = operationGet_apiInfos;
			resourceTypeAttributeMappings.OperationGet = operationGet;
			describeResourceTypeResponse.ResourceTypeAttributeMappings = resourceTypeAttributeMappings;

			List<DescribeResourceTypeResponse.DescribeResourceType_State> describeResourceTypeResponse_states = new List<DescribeResourceTypeResponse.DescribeResourceType_State>();
			for (int i = 0; i < context.Length("DescribeResourceType.States.Length"); i++) {
				DescribeResourceTypeResponse.DescribeResourceType_State state = new DescribeResourceTypeResponse.DescribeResourceType_State();
				state.Code = context.StringValue("DescribeResourceType.States["+ i +"].Code");
				state.Description = context.StringValue("DescribeResourceType.States["+ i +"].Description");

				describeResourceTypeResponse_states.Add(state);
			}
			describeResourceTypeResponse.States = describeResourceTypeResponse_states;
        
			return describeResourceTypeResponse;
        }
    }
}
