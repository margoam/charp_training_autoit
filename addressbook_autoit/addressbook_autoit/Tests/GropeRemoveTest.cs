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

            app.Groups.Remove(0);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}

