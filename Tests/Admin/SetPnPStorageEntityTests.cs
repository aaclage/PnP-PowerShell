using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Management.Automation.Runspaces;

namespace PnP.PowerShell.Tests.Admin
{
    [TestClass]
    public class SetPnPStorageEntityTests
    {
        #region Test Setup/CleanUp
        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            // This runs on class level once before all tests run
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [ClassCleanup]
        public static void Cleanup(TestContext testContext)
        {
            // This runs on class level once
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [TestInitialize]
        public void Initialize()
        {
            using (var scope = new PSTestScope())
            {
                // Example
                // scope.ExecuteCommand("cmdlet", new CommandParameter("param1", prop));
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (var scope = new PSTestScope())
            {
                try
                {
                    // Do Test Setup - Note, this runs PER test
                }
                catch (Exception)
                {
                    // Describe Exception
                }
            }
        }
        #endregion

        #region Scaffolded Cmdlet Tests
        //TODO: This is a scaffold of the cmdlet - complete the unit test
        //[TestMethod]
        public void SetPnPStorageEntityTest()
        {
            using (var scope = new PSTestScope(true))
            {
                // Complete writing cmd parameters

				// This is a mandatory parameter
				// From Cmdlet Help: The key of the value to set.
				var key = "";
				// This is a mandatory parameter
				// From Cmdlet Help: The value to set.
				var value = "";
				// From Cmdlet Help: The comment to set.
				var comment = "";
				// From Cmdlet Help: The description to set.
				var description = "";
				// From Cmdlet Help: Defines the scope of the storage entity. Defaults to Tenant.
				var scopeVar = "";

                var results = scope.ExecuteCommand("Set-PnPStorageEntity",
					new CommandParameter("Key", key),
					new CommandParameter("Value", value),
					new CommandParameter("Comment", comment),
					new CommandParameter("Description", description),
					new CommandParameter("Scope", scopeVar));
                
                Assert.IsNotNull(results);
            }
        }
        #endregion
    }
}
            