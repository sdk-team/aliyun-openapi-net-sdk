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
using Aliyun.Acs.Ecs.Model.V20160314;

namespace Aliyun.Acs.Ecs.Transform.V20160314
{
    public class InnerGroupLeaveResponseUnmarshaller
    {
        public static InnerGroupLeaveResponse Unmarshall(UnmarshallerContext context)
        {
			InnerGroupLeaveResponse innerGroupLeaveResponse = new InnerGroupLeaveResponse();

			innerGroupLeaveResponse.HttpResponse = context.HttpResponse;
			innerGroupLeaveResponse.RequestId = context.StringValue("InnerGroupLeave.RequestId");
			innerGroupLeaveResponse.Data = context.StringValue("InnerGroupLeave.data");

			InnerGroupLeaveResponse.InnerGroupLeave_ErrorCode errorCode = new InnerGroupLeaveResponse.InnerGroupLeave_ErrorCode();
			errorCode.Code = context.StringValue("InnerGroupLeave.ErrorCode.code");
			errorCode.Message = context.StringValue("InnerGroupLeave.ErrorCode.message");
			errorCode.IsSuccess = context.BooleanValue("InnerGroupLeave.ErrorCode.isSuccess");
			innerGroupLeaveResponse.ErrorCode = errorCode;
        
			return innerGroupLeaveResponse;
        }
    }
}
