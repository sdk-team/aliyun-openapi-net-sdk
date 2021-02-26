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
    public class TestXmlServiceRoutePolicyResponseUnmarshaller
    {
        public static TestXmlServiceRoutePolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TestXmlServiceRoutePolicyResponse testXmlServiceRoutePolicyResponse = new TestXmlServiceRoutePolicyResponse();

			testXmlServiceRoutePolicyResponse.HttpResponse = _ctx.HttpResponse;

			List<string> testXmlServiceRoutePolicyResponse_ban = new List<string>();
			for (int i = 0; i < _ctx.Length("TestXmlServiceRoutePolicy.Ban.Length"); i++) {
				testXmlServiceRoutePolicyResponse_ban.Add(_ctx.StringValue("TestXmlServiceRoutePolicy.Ban["+ i +"]"));
			}
			testXmlServiceRoutePolicyResponse.Ban = testXmlServiceRoutePolicyResponse_ban;

			TestXmlServiceRoutePolicyResponse.TestXmlServiceRoutePolicy__Add _add = new TestXmlServiceRoutePolicyResponse.TestXmlServiceRoutePolicy__Add();
			_add.O = _ctx.StringValue("TestXmlServiceRoutePolicy.Add.O");
			testXmlServiceRoutePolicyResponse._Add = _add;

			List<TestXmlServiceRoutePolicyResponse.TestXmlServiceRoutePolicy_Sdw> testXmlServiceRoutePolicyResponse_db = new List<TestXmlServiceRoutePolicyResponse.TestXmlServiceRoutePolicy_Sdw>();
			for (int i = 0; i < _ctx.Length("TestXmlServiceRoutePolicy.Db.Length"); i++) {
				TestXmlServiceRoutePolicyResponse.TestXmlServiceRoutePolicy_Sdw sdw = new TestXmlServiceRoutePolicyResponse.TestXmlServiceRoutePolicy_Sdw();
				sdw.Import = _ctx.IntegerValue("TestXmlServiceRoutePolicy.Db["+ i +"].Import");

				testXmlServiceRoutePolicyResponse_db.Add(sdw);
			}
			testXmlServiceRoutePolicyResponse.Db = testXmlServiceRoutePolicyResponse_db;
        
			return testXmlServiceRoutePolicyResponse;
        }
    }
}
