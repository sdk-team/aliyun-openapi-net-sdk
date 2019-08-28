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
    public class SetEditingProjectMaterialsResponseUnmarshaller
    {
        public static SetEditingProjectMaterialsResponse Unmarshall(UnmarshallerContext context)
        {
			SetEditingProjectMaterialsResponse setEditingProjectMaterialsResponse = new SetEditingProjectMaterialsResponse();

			setEditingProjectMaterialsResponse.HttpResponse = context.HttpResponse;
			setEditingProjectMaterialsResponse.RequestId = context.StringValue("SetEditingProjectMaterials.RequestId");

			List<SetEditingProjectMaterialsResponse.SetEditingProjectMaterials_Material> setEditingProjectMaterialsResponse_materialList = new List<SetEditingProjectMaterialsResponse.SetEditingProjectMaterials_Material>();
			for (int i = 0; i < context.Length("SetEditingProjectMaterials.MaterialList.Length"); i++) {
				SetEditingProjectMaterialsResponse.SetEditingProjectMaterials_Material material = new SetEditingProjectMaterialsResponse.SetEditingProjectMaterials_Material();
				material.MaterialId = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].MaterialId");
				material.Title = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].Title");
				material.Tags = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].Tags");
				material.Status = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].Status");
				material.Size = context.LongValue("SetEditingProjectMaterials.MaterialList["+ i +"].Size");
				material.Duration = context.FloatValue("SetEditingProjectMaterials.MaterialList["+ i +"].Duration");
				material.Description = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].Description");
				material.CustomerId = context.LongValue("SetEditingProjectMaterials.MaterialList["+ i +"].CustomerId");
				material.CreateTime = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].CreateTime");
				material.ModifyTime = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].ModifyTime");
				material.CoverURL = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].CoverURL");
				material.CateId = context.IntegerValue("SetEditingProjectMaterials.MaterialList["+ i +"].CateId");
				material.CateName = context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].CateName");

				List<string> material_snapshots = new List<string>();
				for (int j = 0; j < context.Length("SetEditingProjectMaterials.MaterialList["+ i +"].Snapshots.Length"); j++) {
					material_snapshots.Add(context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].Snapshots["+ j +"]"));
				}
				material.Snapshots = material_snapshots;

				List<string> material_tiles = new List<string>();
				for (int j = 0; j < context.Length("SetEditingProjectMaterials.MaterialList["+ i +"].Tiles.Length"); j++) {
					material_tiles.Add(context.StringValue("SetEditingProjectMaterials.MaterialList["+ i +"].Tiles["+ j +"]"));
				}
				material.Tiles = material_tiles;

				setEditingProjectMaterialsResponse_materialList.Add(material);
			}
			setEditingProjectMaterialsResponse.MaterialList = setEditingProjectMaterialsResponse_materialList;
        
			return setEditingProjectMaterialsResponse;
        }
    }
}
