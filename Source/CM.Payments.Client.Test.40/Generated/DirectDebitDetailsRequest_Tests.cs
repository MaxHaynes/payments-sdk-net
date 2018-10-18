﻿using CM.Payments.Client.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

//<auto-generated>
//	IMPORTANT NOTE:
//	This code is generated by MessageUnitTestGenerator in this project.
//	Date and time: 06-04-2018 14:52:28
//
//	Changes to this file may cause incorrect behavior and will be lost on the next code generation.
//</auto-generated>
namespace CM.Payments.Client.Test
{
    [TestClass, ExcludeFromCodeCoverage]
	public partial class DirectDebitDetailsRequestTests : BaseJsonConvertTests
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void DirectDebitDetailsRequest()
		{
			var obj = new DirectDebitDetailsRequest
			{
				BankAccountNumber = "Lorum_681",
				CallbackUrl = "Lorum_514",
				CancelledUrl = "Lorum_666",
				Description = "Lorum_485",
				ExpiredUrl = "Lorum_696",
				FailedUrl = "Lorum_420",
				MandateId = "Lorum_204",
				MandateStartDate = DateTime.Now,
				Name = "Lorum_513",
				PurchaseId = "Lorum_617",
				SuccessUrl = "Lorum_221",
				TransactionDescription = "Lorum_778"
			};
			var deserialized = ConversionTest(obj);
			Assert.IsNotNull(deserialized);
			Assert.AreEqual(obj.BankAccountNumber, deserialized.BankAccountNumber);
			Assert.AreEqual(obj.CallbackUrl, deserialized.CallbackUrl);
			Assert.AreEqual(obj.CancelledUrl, deserialized.CancelledUrl);
			Assert.AreEqual(obj.Description, deserialized.Description);
			Assert.AreEqual(obj.ExpiredUrl, deserialized.ExpiredUrl);
			Assert.AreEqual(obj.FailedUrl, deserialized.FailedUrl);
			Assert.AreEqual(obj.MandateId, deserialized.MandateId);
		    if (obj.MandateStartDate.HasValue && deserialized.MandateStartDate.HasValue)
		    {
		        // Check only date and time up to seconds.. Json.NET does not save milliseconds.
		        Assert.AreEqual(
		            new DateTime(obj.MandateStartDate.Value.Year, obj.MandateStartDate.Value.Month, obj.MandateStartDate.Value.Day),
		            new DateTime(deserialized.MandateStartDate.Value.Year, deserialized.MandateStartDate.Value.Month, deserialized.MandateStartDate.Value.Day));
		    }
            Assert.AreEqual(obj.Name, deserialized.Name);
			Assert.AreEqual(obj.PurchaseId, deserialized.PurchaseId);
			Assert.AreEqual(obj.SuccessUrl, deserialized.SuccessUrl);
			Assert.AreEqual(obj.TransactionDescription, deserialized.TransactionDescription);
		}
	}
}