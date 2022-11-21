using System;
namespace addressbook_autoit
{
	public class GroupCreationTest : TestBase
	{
		[Test]
		public void TestGroupCreation()
		{
			List<GroupData> oldGroups = app.Groups.GetGroupList();

			GroupData newGroup = new GroupData()
			{
				Name = "test"

			};

			app.Groups.Add(newGroup);
            List<GroupData> newGroups = app.Groups.GetGroupList();
			oldGroups.Add(newGroup;
			oldGroups.Sort();
			newGroups.Sort();

			Assert.AreEqual(oldGroups, newGroups);
        }
	}
}

