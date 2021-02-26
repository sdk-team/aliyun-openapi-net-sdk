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
    public class MigrateStrategyResponseUnmarshaller
    {
        public static MigrateStrategyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			MigrateStrategyResponse migrateStrategyResponse = new MigrateStrategyResponse();

			migrateStrategyResponse.HttpResponse = _ctx.HttpResponse;
			migrateStrategyResponse.RequestId = _ctx.StringValue("MigrateStrategy.RequestId");
			migrateStrategyResponse.Success = _ctx.BooleanValue("MigrateStrategy.Success");
			migrateStrategyResponse.Code = _ctx.StringValue("MigrateStrategy.Code");
			migrateStrategyResponse.Message = _ctx.StringValue("MigrateStrategy.Message");
			migrateStrategyResponse.MessageCN = _ctx.StringValue("MigrateStrategy.MessageCN");
			migrateStrategyResponse.Data = _ctx.BooleanValue("MigrateStrategy.Data");
        
			return migrateStrategyResponse;
        }
    }
}
