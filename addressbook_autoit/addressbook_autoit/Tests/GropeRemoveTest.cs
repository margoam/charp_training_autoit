using System;
namespace addressbook_autoit.Tests
{
    [TestFixture]
    public class GroupRemoveTest : TestBase
    {
        [Test]
        public void TestGroupRemove()
        {
            GroupData newGroup = new GroupData()
            {
                Name = "testforRemove"

            };
            List<GroupData> oldGroups = app.Groups.IfGroupNotExists(0, newGroup);
            int countOldGroups = app.Groups.GetGroupList().Count();

            app.Groups.Remove(0);
            int newGroupsCount = app.Groups.GetGroupList().Count();
            oldGroups.RemoveAt(0);
          

            Assert.AreEqual(countOldGroups - 1, newGroupsCount);
        }
    }
}

