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
    public class DescribeRecommendProductResponseUnmarshaller
    {
        public static DescribeRecommendProductResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRecommendProductResponse describeRecommendProductResponse = new DescribeRecommendProductResponse();

			describeRecommendProductResponse.HttpResponse = context.HttpResponse;
			describeRecommendProductResponse.RequestId = context.StringValue("DescribeRecommendProduct.RequestId");

			List<DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct> describeRecommendProductResponse_recommendProducts = new List<DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct>();
			for (int i = 0; i < context.Length("DescribeRecommendProduct.RecommendProducts.Length"); i++) {
				DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct recommendProduct = new DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct();
				recommendProduct.ZoneNo = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].ZoneNo");

				List<DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct.DescribeRecommendProduct_RecommendInstanceType> recommendProduct_recommendInstanceTypes = new List<DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct.DescribeRecommendProduct_RecommendInstanceType>();
				for (int j = 0; j < context.Length("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes.Length"); j++) {
					DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct.DescribeRecommendProduct_RecommendInstanceType recommendInstanceType = new DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct.DescribeRecommendProduct_RecommendInstanceType();
					recommendInstanceType.InstanceChargeType = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].InstanceChargeType");
					recommendInstanceType.SpotStrategy = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].SpotStrategy");
					recommendInstanceType.Priority = context.IntegerValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].Priority");
					recommendInstanceType.NetworkType = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].NetworkType");

					DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct.DescribeRecommendProduct_RecommendInstanceType.DescribeRecommendProduct_InstanceType instanceType = new DescribeRecommendProductResponse.DescribeRecommendProduct_RecommendProduct.DescribeRecommendProduct_RecommendInstanceType.DescribeRecommendProduct_InstanceType();
					instanceType.Generation = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].InstanceType.Generation");
					instanceType.InstanceTypeFamily = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].InstanceType.InstanceTypeFamily");
					instanceType.InstanceType = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].InstanceType.InstanceType");
					instanceType.SupportIoOptimized = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].InstanceType.SupportIoOptimized");
					instanceType.Cores = context.IntegerValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].InstanceType.Cores");
					instanceType.Memory = context.IntegerValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].InstanceType.Memory");
					instanceType.InstanceFamilyLevel = context.StringValue("DescribeRecommendProduct.RecommendProducts["+ i +"].RecommendInstanceTypes["+ j +"].InstanceType.InstanceFamilyLevel");
					recommendInstanceType.InstanceType = instanceType;

					recommendProduct_recommendInstanceTypes.Add(recommendInstanceType);
				}
				recommendProduct.RecommendInstanceTypes = recommendProduct_recommendInstanceTypes;

				describeRecommendProductResponse_recommendProducts.Add(recommendProduct);
			}
			describeRecommendProductResponse.RecommendProducts = describeRecommendProductResponse_recommendProducts;
        
			return describeRecommendProductResponse;
        }
    }
}
