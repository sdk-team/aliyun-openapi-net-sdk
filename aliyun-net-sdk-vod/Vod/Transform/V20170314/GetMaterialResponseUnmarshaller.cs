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
    public class GetMaterialResponseUnmarshaller
    {
        public static GetMaterialResponse Unmarshall(UnmarshallerContext context)
        {
			GetMaterialResponse getMaterialResponse = new GetMaterialResponse();

			getMaterialResponse.HttpResponse = context.HttpResponse;
			getMaterialResponse.RequestId = context.StringValue("GetMaterial.RequestId");

			GetMaterialResponse.GetMaterial_Material material = new GetMaterialResponse.GetMaterial_Material();
			material.MaterialId = context.StringValue("GetMaterial.Material.MaterialId");
			material.Title = context.StringValue("GetMaterial.Material.Title");
			material.Tags = context.StringValue("GetMaterial.Material.Tags");
			material.Status = context.StringValue("GetMaterial.Material.Status");
			material.Size = context.LongValue("GetMaterial.Material.Size");
			material.Duration = context.FloatValue("GetMaterial.Material.Duration");
			material.Description = context.StringValue("GetMaterial.Material.Description");
			material.CustomerId = context.LongValue("GetMaterial.Material.CustomerId");
			material.CreateTime = context.StringValue("GetMaterial.Material.CreateTime");
			material.ModifyTime = context.StringValue("GetMaterial.Material.ModifyTime");
			material.CoverURL = context.StringValue("GetMaterial.Material.CoverURL");
			material.CateId = context.IntegerValue("GetMaterial.Material.CateId");
			material.CateName = context.StringValue("GetMaterial.Material.CateName");
			material.Source = context.StringValue("GetMaterial.Material.Source");

			List<string> material_snapshots = new List<string>();
			for (int i = 0; i < context.Length("GetMaterial.Material.Snapshots.Length"); i++) {
				material_snapshots.Add(context.StringValue("GetMaterial.Material.Snapshots["+ i +"]"));
			}
			material.Snapshots = material_snapshots;

			List<string> material_tiles = new List<string>();
			for (int i = 0; i < context.Length("GetMaterial.Material.Tiles.Length"); i++) {
				material_tiles.Add(context.StringValue("GetMaterial.Material.Tiles["+ i +"]"));
			}
			material.Tiles = material_tiles;
			getMaterialResponse.Material = material;
        
			return getMaterialResponse;
        }
    }
}
