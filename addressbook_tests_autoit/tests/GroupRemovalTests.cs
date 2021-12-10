﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            List<GroupData> Groups = app.Groups.GetGroupList();
            if (Groups.Count == 1)
            {
                app.Groups.Add(new GroupData()
                {
                    Name = "TestName"
                });
            }

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(0);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
