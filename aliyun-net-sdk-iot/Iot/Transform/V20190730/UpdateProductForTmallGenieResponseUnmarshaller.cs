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
    public class UpdateProductForTmallGenieResponseUnmarshaller
    {
        public static UpdateProductForTmallGenieResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateProductForTmallGenieResponse updateProductForTmallGenieResponse = new UpdateProductForTmallGenieResponse();

			updateProductForTmallGenieResponse.HttpResponse = context.HttpResponse;
			updateProductForTmallGenieResponse.RequestId = context.StringValue("UpdateProductForTmallGenie.RequestId");
			updateProductForTmallGenieResponse.Success = context.BooleanValue("UpdateProductForTmallGenie.Success");
			updateProductForTmallGenieResponse.Code = context.StringValue("UpdateProductForTmallGenie.Code");
			updateProductForTmallGenieResponse.ErrorMessage = context.StringValue("UpdateProductForTmallGenie.ErrorMessage");
        
			return updateProductForTmallGenieResponse;
        }
    }
}
