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
    public class DescribeSQLDiagnosisListResponseUnmarshaller
    {
        public static DescribeSQLDiagnosisListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSQLDiagnosisListResponse describeSQLDiagnosisListResponse = new DescribeSQLDiagnosisListResponse();

			describeSQLDiagnosisListResponse.HttpResponse = context.HttpResponse;
			describeSQLDiagnosisListResponse.RequestId = context.StringValue("DescribeSQLDiagnosisList.RequestId");

			List<DescribeSQLDiagnosisListResponse.DescribeSQLDiagnosisList_SQLDiag> describeSQLDiagnosisListResponse_sQLDiagList = new List<DescribeSQLDiagnosisListResponse.DescribeSQLDiagnosisList_SQLDiag>();
			for (int i = 0; i < context.Length("DescribeSQLDiagnosisList.SQLDiagList.Length"); i++) {
				DescribeSQLDiagnosisListResponse.DescribeSQLDiagnosisList_SQLDiag sQLDiag = new DescribeSQLDiagnosisListResponse.DescribeSQLDiagnosisList_SQLDiag();
				sQLDiag.SQLDiagId = context.StringValue("DescribeSQLDiagnosisList.SQLDiagList["+ i +"].SQLDiagId");
				sQLDiag.StartTime = context.StringValue("DescribeSQLDiagnosisList.SQLDiagList["+ i +"].StartTime");
				sQLDiag.EndTime = context.StringValue("DescribeSQLDiagnosisList.SQLDiagList["+ i +"].EndTime");
				sQLDiag.Status = context.IntegerValue("DescribeSQLDiagnosisList.SQLDiagList["+ i +"].Status");
				sQLDiag.Progress = context.IntegerValue("DescribeSQLDiagnosisList.SQLDiagList["+ i +"].Progress");

				describeSQLDiagnosisListResponse_sQLDiagList.Add(sQLDiag);
			}
			describeSQLDiagnosisListResponse.SQLDiagList = describeSQLDiagnosisListResponse_sQLDiagList;
        
			return describeSQLDiagnosisListResponse;
        }
    }
}
