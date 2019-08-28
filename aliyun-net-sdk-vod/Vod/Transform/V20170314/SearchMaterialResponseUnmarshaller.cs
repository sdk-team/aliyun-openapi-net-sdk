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
    public class SearchMaterialResponseUnmarshaller
    {
        public static SearchMaterialResponse Unmarshall(UnmarshallerContext context)
        {
			SearchMaterialResponse searchMaterialResponse = new SearchMaterialResponse();

			searchMaterialResponse.HttpResponse = context.HttpResponse;
			searchMaterialResponse.RequestId = context.StringValue("SearchMaterial.RequestId");
			searchMaterialResponse.Total = context.IntegerValue("SearchMaterial.Total");

			List<SearchMaterialResponse.SearchMaterial_Material> searchMaterialResponse_materialList = new List<SearchMaterialResponse.SearchMaterial_Material>();
			for (int i = 0; i < context.Length("SearchMaterial.MaterialList.Length"); i++) {
				SearchMaterialResponse.SearchMaterial_Material material = new SearchMaterialResponse.SearchMaterial_Material();
				material.MaterialId = context.StringValue("SearchMaterial.MaterialList["+ i +"].MaterialId");
				material.Title = context.StringValue("SearchMaterial.MaterialList["+ i +"].Title");
				material.Tags = context.StringValue("SearchMaterial.MaterialList["+ i +"].Tags");
				material.Status = context.StringValue("SearchMaterial.MaterialList["+ i +"].Status");
				material.Size = context.LongValue("SearchMaterial.MaterialList["+ i +"].Size");
				material.Duration = context.FloatValue("SearchMaterial.MaterialList["+ i +"].Duration");
				material.Description = context.StringValue("SearchMaterial.MaterialList["+ i +"].Description");
				material.CustomerId = context.LongValue("SearchMaterial.MaterialList["+ i +"].CustomerId");
				material.CreateTime = context.StringValue("SearchMaterial.MaterialList["+ i +"].CreateTime");
				material.ModifyTime = context.StringValue("SearchMaterial.MaterialList["+ i +"].ModifyTime");
				material.CoverURL = context.StringValue("SearchMaterial.MaterialList["+ i +"].CoverURL");
				material.CateId = context.IntegerValue("SearchMaterial.MaterialList["+ i +"].CateId");
				material.CateName = context.StringValue("SearchMaterial.MaterialList["+ i +"].CateName");
				material.Source = context.StringValue("SearchMaterial.MaterialList["+ i +"].Source");

				List<string> material_snapshots = new List<string>();
				for (int j = 0; j < context.Length("SearchMaterial.MaterialList["+ i +"].Snapshots.Length"); j++) {
					material_snapshots.Add(context.StringValue("SearchMaterial.MaterialList["+ i +"].Snapshots["+ j +"]"));
				}
				material.Snapshots = material_snapshots;

				List<string> material_tiles = new List<string>();
				for (int j = 0; j < context.Length("SearchMaterial.MaterialList["+ i +"].Tiles.Length"); j++) {
					material_tiles.Add(context.StringValue("SearchMaterial.MaterialList["+ i +"].Tiles["+ j +"]"));
				}
				material.Tiles = material_tiles;

				searchMaterialResponse_materialList.Add(material);
			}
			searchMaterialResponse.MaterialList = searchMaterialResponse_materialList;
        
			return searchMaterialResponse;
        }
    }
}
