
using System;
using System.Collections.Generic;

using NUnit.Framework;


namespace Mango.Templates.Minge.Tests {

	[TestFixture]
	public class DataTest : MingeTest {


		[SetUp]
		public void Setup ()
		{
		}

		[Test]
		public void WhiteSpace ()
		{
			Assert.AreEqual (" ", RenderString (" "), "A1");
			Assert.AreEqual ("  ", RenderString ("  "), "A2");
			Assert.AreEqual ("\t", RenderString ("\t"), "A3");
			Assert.AreEqual ("\t\t", RenderString ("\t\t"), "A4");
			Assert.AreEqual ("\n", RenderString ("\n"), "A5");
			Assert.AreEqual ("\n\n", RenderString ("\n\n"), "A6");
			Assert.AreEqual (" \t\n", RenderString (" \t\n"), "A7");
			Assert.AreEqual ("\r\n", RenderString ("\r\n"), "A8");
		}

		[Test]
		public void Chars ()
		{
			Assert.AreEqual ("ABCDEFGHIJKLMNOPQRSTUVWXYZ", RenderString ("ABCDEFGHIJKLMNOPQRSTUVWXYZ"), "A1");
		}

		[Test]
		public void QuotedStrings ()
		{
		}

		[Test]
		public void Numbers ()
		{
		}

		[Test]
		public void SpecialChars ()
		{
		}

		[Test]
		public void Multiline ()
		{
		}
	}
}
