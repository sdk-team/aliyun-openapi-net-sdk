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
    public class GetCategoryListResponseUnmarshaller
    {
        public static GetCategoryListResponse Unmarshall(UnmarshallerContext context)
        {
			GetCategoryListResponse getCategoryListResponse = new GetCategoryListResponse();

			getCategoryListResponse.HttpResponse = context.HttpResponse;
			getCategoryListResponse.RequestId = context.StringValue("GetCategoryList.RequestId");

			List<GetCategoryListResponse.GetCategoryList_Category> getCategoryListResponse_categoryList = new List<GetCategoryListResponse.GetCategoryList_Category>();
			for (int i = 0; i < context.Length("GetCategoryList.CategoryList.Length"); i++) {
				GetCategoryListResponse.GetCategoryList_Category category = new GetCategoryListResponse.GetCategoryList_Category();
				category.CateId = context.StringValue("GetCategoryList.CategoryList["+ i +"].CateId");
				category.CateName = context.StringValue("GetCategoryList.CategoryList["+ i +"].CateName");
				category.ParentId = context.StringValue("GetCategoryList.CategoryList["+ i +"].ParentId");
				category.Level = context.StringValue("GetCategoryList.CategoryList["+ i +"].Level");

				getCategoryListResponse_categoryList.Add(category);
			}
			getCategoryListResponse.CategoryList = getCategoryListResponse_categoryList;
        
			return getCategoryListResponse;
        }
    }
}
