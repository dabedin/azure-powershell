﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.WindowsAzure.ServiceManagemenet.Common.Models;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.WindowsAzure.Commands.ScenarioTest
{
    public partial class ServiceManagementTests
    {
        public ServiceManagementTests(ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestGetAzureVM()
        {
            this.RunPowerShellTest("Test-GetAzureVM");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestGetAzureLocation()
        {
            this.RunPowerShellTest("Test-GetAzureLocation");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunServiceManagementCloudExceptionTests()
        {
            this.RunPowerShellTest("Run-ServiceManagementCloudExceptionTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunStartAndStopMultipleVirtualMachinesTest()
        {
            this.RunPowerShellTest("Run-StartAndStopMultipleVirtualMachinesTest");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunAutoGeneratedHostedServiceCmdletTests()
        {
            this.RunPowerShellTest("Run-AutoGeneratedHostedServiceCmdletTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunAutoGeneratedVirtualMachineCmdletTests()
        {
            this.RunPowerShellTest("Run-AutoGeneratedVirtualMachineCmdletTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunNewAzureComputeArgumentListTests()
        {
            this.RunPowerShellTest("Run-NewAzureComputeArgumentListTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunNewAzureComputeParameterObjectTests()
        {
            this.RunPowerShellTest("Run-NewAzureComputeParameterObjectTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunAzurePlatformVMImageNegativeTest()
        {
            this.RunPowerShellTest("Run-AzurePlatformVMImageNegativeTest");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunAutoGeneratedServiceExtensionCmdletTests()
        {
            this.RunPowerShellTest("Run-AutoGeneratedServiceExtensionCmdletTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunServiceExtensionSetCmdletTests()
        {
            this.RunPowerShellTest("Run-ServiceExtensionSetCmdletTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunServiceDeploymentExtensionCmdletTests()
        {
            this.RunPowerShellTest("Run-ServiceDeploymentExtensionCmdletTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunEnableAndDisableDataCollectionTests()
        {
            this.RunPowerShellTest("Run-EnableAndDisableDataCollectionTests");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrateAzureDeployment()
        {
            this.RunPowerShellTest("Test-MigrateAzureDeployment");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrationAbortAzureDeployment()
        {
            this.RunPowerShellTest("Test-MigrationAbortAzureDeployment");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrationValidateAzureDeployment()
        {
            this.RunPowerShellTest("Test-MigrationValidateAzureDeployment");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrateAzureVNet()
        {
            this.RunPowerShellTest("Test-MigrateAzureVNet");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrationNetworkSecurityGroup()
        {
            this.RunPowerShellTest("Test-MigrationNetworkSecurityGroup");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrationAzureReservedIP()
        {
            this.RunPowerShellTest("Test-MigrationAzureReservedIP");
        }

        [Fact]        
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAzureReservedIPWithIPTags()
        {
            this.RunPowerShellTest("Test-AzureReservedIPWithIPTags");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrationRouteTable()
        {
            this.RunPowerShellTest("Test-MigrationRouteTable");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrationAbortAzureVNet()
        {
            this.RunPowerShellTest("Test-MigrationAbortAzureVNet");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrateAzureStorageAccount()
        {
            this.RunPowerShellTest("Test-MigrateAzureStorageAccount");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestMigrationAbortAzureStorageAccount()
        {
            this.RunPowerShellTest("Test-MigrationAbortAzureStorageAccount");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void TestNewAzureVMWithBYOL()
        {
            this.RunPowerShellTest("Test-NewAzureVMWithBYOL");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunRedeployVirtualMachineTest()
        {
            this.RunPowerShellTest("Run-RedeployVirtualMachineTest");
        }

        [Fact]
        [Trait(Category.Service, Category.ServiceManagement)]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.AcceptanceType, Category.BVT)]
        public void RunInitiateMaintenanceTest()
        {
            this.RunPowerShellTest("Run-InitiateMaintenanceTest");
        }
    }
}
