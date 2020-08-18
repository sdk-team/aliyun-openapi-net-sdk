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
    public class FtIpFlowControlResponseUnmarshaller
    {
        public static FtIpFlowControlResponse Unmarshall(UnmarshallerContext context)
        {
			FtIpFlowControlResponse ftIpFlowControlResponse = new FtIpFlowControlResponse();

			ftIpFlowControlResponse.HttpResponse = context.HttpResponse;
			ftIpFlowControlResponse.RequestId = context.StringValue("FtIpFlowControl.RequestId");

			List<string> ftIpFlowControlResponse_names = new List<string>();
			for (int i = 0; i < context.Length("FtIpFlowControl.Names.Length"); i++) {
				ftIpFlowControlResponse_names.Add(context.StringValue("FtIpFlowControl.Names["+ i +"]"));
			}
			ftIpFlowControlResponse.Names = ftIpFlowControlResponse_names;

			List<string> ftIpFlowControlResponse_names01 = new List<string>();
			for (int i = 0; i < context.Length("FtIpFlowControl.Names01.Length"); i++) {
				ftIpFlowControlResponse_names01.Add(context.StringValue("FtIpFlowControl.Names01["+ i +"]"));
			}
			ftIpFlowControlResponse.Names01 = ftIpFlowControlResponse_names01;

			List<string> ftIpFlowControlResponse_integerList = new List<string>();
			for (int i = 0; i < context.Length("FtIpFlowControl.IntegerList.Length"); i++) {
				ftIpFlowControlResponse_integerList.Add(context.StringValue("FtIpFlowControl.IntegerList["+ i +"]"));
			}
			ftIpFlowControlResponse.IntegerList = ftIpFlowControlResponse_integerList;

			List<string> ftIpFlowControlResponse_integerList1 = new List<string>();
			for (int i = 0; i < context.Length("FtIpFlowControl.IntegerList1.Length"); i++) {
				ftIpFlowControlResponse_integerList1.Add(context.StringValue("FtIpFlowControl.IntegerList1["+ i +"]"));
			}
			ftIpFlowControlResponse.IntegerList1 = ftIpFlowControlResponse_integerList1;
        
			return ftIpFlowControlResponse;
        }
    }
}
