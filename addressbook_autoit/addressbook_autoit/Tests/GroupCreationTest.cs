using System;
namespace addressbook_autoit
{
	[TestFixture]
	public class GroupCreationTest : TestBase
	{
		[Test]
		public void TestGroupCreation()
		{
			List<GroupData> oldGroups = app.Groups.GetGroupList();

			int countOldGroups = app.Groups.GetGroupList().Count();

            GroupData newGroup = new GroupData()
			{
				Name = "test"

			};

			app.Groups.Add(newGroup);
            int newGroups = app.Groups.GetGroupList().Count();
            oldGroups.Add(newGroup);
		

			Assert.AreEqual(countOldGroups + 1, newGroups);
        }
	}
}

