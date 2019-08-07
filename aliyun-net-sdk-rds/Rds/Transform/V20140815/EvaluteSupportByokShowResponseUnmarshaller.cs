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
    public class EvaluteSupportByokShowResponseUnmarshaller
    {
        public static EvaluteSupportByokShowResponse Unmarshall(UnmarshallerContext context)
        {
			EvaluteSupportByokShowResponse evaluteSupportByokShowResponse = new EvaluteSupportByokShowResponse();

			evaluteSupportByokShowResponse.HttpResponse = context.HttpResponse;
			evaluteSupportByokShowResponse.RequestId = context.StringValue("EvaluteSupportByokShow.RequestId");
			evaluteSupportByokShowResponse.SupportByokShow = context.IntegerValue("EvaluteSupportByokShow.SupportByokShow");

			List<string> evaluteSupportByokShowResponse_supportByokZone = new List<string>();
			for (int i = 0; i < context.Length("EvaluteSupportByokShow.SupportByokZone.Length"); i++) {
				evaluteSupportByokShowResponse_supportByokZone.Add(context.StringValue("EvaluteSupportByokShow.SupportByokZone["+ i +"]"));
			}
			evaluteSupportByokShowResponse.SupportByokZone = evaluteSupportByokShowResponse_supportByokZone;
        
			return evaluteSupportByokShowResponse;
        }
    }
}