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
    public class UpdateMaterialResponseUnmarshaller
    {
        public static UpdateMaterialResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateMaterialResponse updateMaterialResponse = new UpdateMaterialResponse();

			updateMaterialResponse.HttpResponse = context.HttpResponse;
			updateMaterialResponse.RequestId = context.StringValue("UpdateMaterial.RequestId");

			UpdateMaterialResponse.UpdateMaterial_Material material = new UpdateMaterialResponse.UpdateMaterial_Material();
			material.MaterialId = context.StringValue("UpdateMaterial.Material.MaterialId");
			material.Title = context.StringValue("UpdateMaterial.Material.Title");
			material.Tags = context.StringValue("UpdateMaterial.Material.Tags");
			material.Status = context.StringValue("UpdateMaterial.Material.Status");
			material.Size = context.LongValue("UpdateMaterial.Material.Size");
			material.Duration = context.FloatValue("UpdateMaterial.Material.Duration");
			material.Description = context.StringValue("UpdateMaterial.Material.Description");
			material.CustomerId = context.LongValue("UpdateMaterial.Material.CustomerId");
			material.CreateTime = context.StringValue("UpdateMaterial.Material.CreateTime");
			material.ModifyTime = context.StringValue("UpdateMaterial.Material.ModifyTime");
			material.CoverURL = context.StringValue("UpdateMaterial.Material.CoverURL");
			material.CateId = context.IntegerValue("UpdateMaterial.Material.CateId");
			material.CateName = context.StringValue("UpdateMaterial.Material.CateName");
			material.Source = context.StringValue("UpdateMaterial.Material.Source");

			List<string> material_snapshots = new List<string>();
			for (int i = 0; i < context.Length("UpdateMaterial.Material.Snapshots.Length"); i++) {
				material_snapshots.Add(context.StringValue("UpdateMaterial.Material.Snapshots["+ i +"]"));
			}
			material.Snapshots = material_snapshots;

			List<string> material_tiles = new List<string>();
			for (int i = 0; i < context.Length("UpdateMaterial.Material.Tiles.Length"); i++) {
				material_tiles.Add(context.StringValue("UpdateMaterial.Material.Tiles["+ i +"]"));
			}
			material.Tiles = material_tiles;
			updateMaterialResponse.Material = material;
        
			return updateMaterialResponse;
        }
    }
}
