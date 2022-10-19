// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Template.LoadTesting.Tests
{
    public class LoadTestingClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("LoadTesting_ENDPOINT");

        // Add other client paramters here as above.
    }
}
