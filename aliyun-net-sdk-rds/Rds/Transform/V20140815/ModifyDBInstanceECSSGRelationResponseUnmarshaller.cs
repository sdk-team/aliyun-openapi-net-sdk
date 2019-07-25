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
    public class ModifyDBInstanceECSSGRelationResponseUnmarshaller
    {
        public static ModifyDBInstanceECSSGRelationResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyDBInstanceECSSGRelationResponse modifyDBInstanceECSSGRelationResponse = new ModifyDBInstanceECSSGRelationResponse();

			modifyDBInstanceECSSGRelationResponse.HttpResponse = context.HttpResponse;
			modifyDBInstanceECSSGRelationResponse.RequestId = context.StringValue("ModifyDBInstanceECSSGRelation.RequestId");
			modifyDBInstanceECSSGRelationResponse.DBInstanceName = context.StringValue("ModifyDBInstanceECSSGRelation.DBInstanceName");

			List<ModifyDBInstanceECSSGRelationResponse.ModifyDBInstanceECSSGRelation_EcsSecurityGroupRelation> modifyDBInstanceECSSGRelationResponse_items = new List<ModifyDBInstanceECSSGRelationResponse.ModifyDBInstanceECSSGRelation_EcsSecurityGroupRelation>();
			for (int i = 0; i < context.Length("ModifyDBInstanceECSSGRelation.Items.Length"); i++) {
				ModifyDBInstanceECSSGRelationResponse.ModifyDBInstanceECSSGRelation_EcsSecurityGroupRelation ecsSecurityGroupRelation = new ModifyDBInstanceECSSGRelationResponse.ModifyDBInstanceECSSGRelation_EcsSecurityGroupRelation();
				ecsSecurityGroupRelation.RegionId = context.StringValue("ModifyDBInstanceECSSGRelation.Items["+ i +"].RegionId");
				ecsSecurityGroupRelation.SecurityGroupId = context.StringValue("ModifyDBInstanceECSSGRelation.Items["+ i +"].SecurityGroupId");
				ecsSecurityGroupRelation.NetworkType = context.StringValue("ModifyDBInstanceECSSGRelation.Items["+ i +"].NetworkType");

				modifyDBInstanceECSSGRelationResponse_items.Add(ecsSecurityGroupRelation);
			}
			modifyDBInstanceECSSGRelationResponse.Items = modifyDBInstanceECSSGRelationResponse_items;
        
			return modifyDBInstanceECSSGRelationResponse;
        }
    }
}
