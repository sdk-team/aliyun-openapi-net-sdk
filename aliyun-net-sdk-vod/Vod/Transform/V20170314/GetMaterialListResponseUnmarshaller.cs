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
    public class GetMaterialListResponseUnmarshaller
    {
        public static GetMaterialListResponse Unmarshall(UnmarshallerContext context)
        {
			GetMaterialListResponse getMaterialListResponse = new GetMaterialListResponse();

			getMaterialListResponse.HttpResponse = context.HttpResponse;
			getMaterialListResponse.RequestId = context.StringValue("GetMaterialList.RequestId");

			List<GetMaterialListResponse.GetMaterialList_Material> getMaterialListResponse_materialList = new List<GetMaterialListResponse.GetMaterialList_Material>();
			for (int i = 0; i < context.Length("GetMaterialList.MaterialList.Length"); i++) {
				GetMaterialListResponse.GetMaterialList_Material material = new GetMaterialListResponse.GetMaterialList_Material();
				material.MaterialId = context.StringValue("GetMaterialList.MaterialList["+ i +"].MaterialId");
				material.Title = context.StringValue("GetMaterialList.MaterialList["+ i +"].Title");
				material.Tags = context.StringValue("GetMaterialList.MaterialList["+ i +"].Tags");
				material.Status = context.StringValue("GetMaterialList.MaterialList["+ i +"].Status");
				material.Size = context.LongValue("GetMaterialList.MaterialList["+ i +"].Size");
				material.Duration = context.FloatValue("GetMaterialList.MaterialList["+ i +"].Duration");
				material.Description = context.StringValue("GetMaterialList.MaterialList["+ i +"].Description");
				material.CustomerId = context.LongValue("GetMaterialList.MaterialList["+ i +"].CustomerId");
				material.CreateTime = context.StringValue("GetMaterialList.MaterialList["+ i +"].CreateTime");
				material.ModifyTime = context.StringValue("GetMaterialList.MaterialList["+ i +"].ModifyTime");
				material.CoverURL = context.StringValue("GetMaterialList.MaterialList["+ i +"].CoverURL");
				material.CateId = context.IntegerValue("GetMaterialList.MaterialList["+ i +"].CateId");
				material.CateName = context.StringValue("GetMaterialList.MaterialList["+ i +"].CateName");
				material.Source = context.StringValue("GetMaterialList.MaterialList["+ i +"].Source");

				List<string> material_snapshots = new List<string>();
				for (int j = 0; j < context.Length("GetMaterialList.MaterialList["+ i +"].Snapshots.Length"); j++) {
					material_snapshots.Add(context.StringValue("GetMaterialList.MaterialList["+ i +"].Snapshots["+ j +"]"));
				}
				material.Snapshots = material_snapshots;

				List<string> material_tiles = new List<string>();
				for (int j = 0; j < context.Length("GetMaterialList.MaterialList["+ i +"].Tiles.Length"); j++) {
					material_tiles.Add(context.StringValue("GetMaterialList.MaterialList["+ i +"].Tiles["+ j +"]"));
				}
				material.Tiles = material_tiles;

				getMaterialListResponse_materialList.Add(material);
			}
			getMaterialListResponse.MaterialList = getMaterialListResponse_materialList;
        
			return getMaterialListResponse;
        }
    }
}
