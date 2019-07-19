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
using Aliyun.Acs.Iot.Model.V20190730;

namespace Aliyun.Acs.Iot.Transform.V20190730
{
    public class ServiceMigrateToUnifyResponseUnmarshaller
    {
        public static ServiceMigrateToUnifyResponse Unmarshall(UnmarshallerContext context)
        {
			ServiceMigrateToUnifyResponse serviceMigrateToUnifyResponse = new ServiceMigrateToUnifyResponse();

			serviceMigrateToUnifyResponse.HttpResponse = context.HttpResponse;
			serviceMigrateToUnifyResponse.RequestId = context.StringValue("ServiceMigrateToUnify.RequestId");
			serviceMigrateToUnifyResponse.Success = context.BooleanValue("ServiceMigrateToUnify.Success");
			serviceMigrateToUnifyResponse.Code = context.StringValue("ServiceMigrateToUnify.Code");
			serviceMigrateToUnifyResponse.ErrorMessage = context.StringValue("ServiceMigrateToUnify.ErrorMessage");
        
			return serviceMigrateToUnifyResponse;
        }
    }
}
