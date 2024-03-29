﻿using System;
using NUnit.Framework;

namespace _001_Mocks
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public static void FileManagerTest1()
        {
            MockLogService mockService = new MockLogService();

            FileManager mgr = new FileManager(mockService);

            mgr.Analize("SomeFile.log");

            Assert.AreEqual("FileExtension error: SomeFile.log", mockService.lastError);
        }
    }
}
